using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Media;
using System.Windows.Forms;

namespace RaidTool.SubForms
{
    public partial class VoiceSpammer : Form
    {
        public bool User_Requirements;
        public bool User_Selection;

        public VoiceSpammer()
        {
            InitializeComponent();
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            if (User_Requirements == false)
            {
                CheckForFile.Start();
                string path = Path.GetTempPath() + "\\STZ-RAID-TOOL\\";
                if (Directory.Exists(path))
                    Directory.Delete(path, true);

                Directory.CreateDirectory(path);
                string exePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\";
                string finalPath = exePath.Replace("file:\\", "");
                Utils.DownloadFile("https://anarchyteam.dev/voice_binaries.zip", path + "voice_binaries.zip");

                ZipArchive archive = ZipFile.Open(path + "\\voice_binaries.zip", ZipArchiveMode.Update);
                archive.ExtractToDirectory(finalPath);
                archive.Dispose();
                System.IO.File.Delete(path + "\\voice_binaries.zip");
                SystemSounds.Beep.Play();
            }
            else
                MessageBox.Show("You already have the voice binaries you can continue.");
        }

        private void VoiceSpammer_Load(object sender, EventArgs e)
        {
            string exePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\voice_binaries\\";
            string finalPath = exePath.Replace("file:\\", "");

            if (File.Exists(finalPath + "opus.dll") && File.Exists(finalPath + "libsodium.dll") && File.Exists(finalPath + "ffmpeg.exe"))
            {
                User_Requirements = true;
            }
            else
            {
                User_Requirements = false;
            }
        }

        private void HideTab()
        {
            if(User_Selection == true)
            {
                PanelHide.Location = new Point(14, 3);
            }
            else
            {
                PanelHide.Location = new Point(800, 3);
            }
        }

        private void ExecuteBtn_Click(object sender, EventArgs e)
        {
            if (User_Requirements == false)
                MessageBox.Show("First, you need to install the voice binaries.");
            else
            {
                if (!String.IsNullOrEmpty(ChannelidTxt.Text) || !String.IsNullOrEmpty(SoundDir.Text))
                {
                    Utils.JoinEarrape(ChannelidTxt.Text, SoundDir.Text);
                }
                else
                {
                    MessageBox.Show("One or more of the fields is empty, Fill them.");
                }
            }  
        }
        private void CheckForFile_Tick(object sender, EventArgs e)
        {
            string exePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\voice_binaries\\";
            string finalPath = exePath.Replace("file:\\", "");

            if (File.Exists(finalPath + "opus.dll") && File.Exists(finalPath + "libsodium.dll") && File.Exists(finalPath + "ffmpeg.exe"))
            {
                User_Requirements = true;
            }
            else
            {
                User_Requirements = false;
            }

            if (User_Requirements == true)
            {
                CheckForFile.Stop();
            }
        }
        private void DownloadSound_Click(object sender, EventArgs e)
        {
            if(User_Requirements == false)
                MessageBox.Show("First, you need to install the voice binaries.");
            else
                Process.Start("https://cdn.discordapp.com/attachments/777983942585221190/789513256481456138/Wikipedia.wav");
        }
        private void LoadFile_Click(object sender, EventArgs e)
        {
            if (User_Requirements == false)
            {
                MessageBox.Show("First, you need to install the voice binaries.");
            }
            else
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Wav Files (*.wav)|*.wav";
                dialog.InitialDirectory = @"";
                dialog.Title = "Please select a WAV file, The file will be used to spam the voice channel.";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    SoundDir.Text = dialog.FileName;
                }
            }
            
        }
        private void ChannelidTxt_TextChanged(object sender, EventArgs e)
        {
            if (ChannelidTxt.Text != "")
            {
                if (User_Requirements == false)
                {
                    MessageBox.Show("First, you need to install the voice binaries.");
                    ChannelidTxt.Text = "";
                }
            }
        }

        private void SoundDir_TextChanged(object sender, EventArgs e)
        {
            if(SoundDir.Text != "")
            {
                if (User_Requirements == false)
                {
                    MessageBox.Show("First, you need to install the voice binaries.");
                    SoundDir.Text = "";
                }
            }
        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure?\nWithout the voice binaries you cannot use the voice spammer.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                User_Selection = true;
            }
        }

        #region Hide_The_Form_If_User_Selection_Is_No
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            HideTab();
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            HideTab();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            HideTab();
        }

        private void PanelHide_MouseLeave(object sender, EventArgs e)
        {
            PanelHide.Location = new Point(800, 3);
        }
        #endregion
    }
}
