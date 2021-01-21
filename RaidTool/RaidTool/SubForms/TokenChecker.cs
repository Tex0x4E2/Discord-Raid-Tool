using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace RaidTool.SubForms
{
    public partial class TokenChecker : Form
    {
        Thread t;
        int unverified = 0;
        int errosCount = 0;
        int verifiedCount = 0;
        public bool Check_Enabled = false;

        public TokenChecker()
        {
            InitializeComponent();
        }

        private void LoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text Files |*.txt|All|*.*";
            dialog.InitialDirectory = @"";
            dialog.Title = "Please select a TXT file that contain the tokens.";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var path = dialog.FileName;
                TokensTxtBox.Text = File.ReadAllText(path);
            }
        }

        private void TokenChecker_Load(object sender, EventArgs e)
        {
            TokensTxtBox.Text = MainForm.tokens;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            unverified = 0;
            errosCount = 0;
            verifiedCount = 0;
            string[] result = TokensTxtBox.Text.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            Check_Enabled = true;
            CheckCount.Start();
            t = new Thread(() =>
            {
                Check(result);
            });
            t.Start();
        }

        private void Check(string[] tokens)
        {
            if (!Directory.Exists("Results"))
                Directory.CreateDirectory("Results");

            if (File.Exists("\\Verified.txt"))
                File.Delete("\\Verified.txt");

            if (File.Exists("\\Unverified.txt"))
                File.Delete("\\Unverified.txt");

            foreach (var item in tokens)
            {
                if(Check_Enabled == true)
                {
                    bool error = false;
                    bool verified = false;
                    var data = Utils.GetResponse(item);
                    if (data == "Error")
                    {
                        verified = false;
                    }
                    else
                    {
                        JObject jObj = JObject.Parse(data);
                        try
                        {
                            string Ver = jObj["verified"].ToString();
                            if (Ver == "False")
                            {
                                verified = false;
                            }
                            else
                            {
                                verified = true;
                            }
                        }
                        catch (Exception)
                        {
                            error = true;
                        }
                    }
                    if (error == true)
                    {
                        errosCount++;
                    }
                    if (verified == true)
                    {
                        verifiedCount++;
                        File.AppendAllText("Results\\Verified.txt", item + Environment.NewLine);
                    }
                    else
                    {
                        unverified++;
                        File.AppendAllText("Results\\Unverified.txt", item + Environment.NewLine);
                    }
                }
            }
            SystemSounds.Beep.Play();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            if(Check_Enabled == true)
            {
                Check_Enabled = false;
                CheckCount.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            VaildCount.Text = verifiedCount.ToString();
            NotVaildCount.Text = unverified.ToString();
            ErrosCount.Text = errosCount.ToString();
        }
    }
}
