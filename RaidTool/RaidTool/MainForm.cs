using Discord;
using Discord.Gateway;
using RaidTool.SubForms;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace RaidTool
{
    public partial class MainForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     
            int nTopRect,      
            int nRightRect,    
            int nBottomRect,   
            int nWidthEllipse, 
            int nHeightEllipse 
        );

        public static string tokens;
        ChangeAvatar avatar = new ChangeAvatar();
        DMSpammer dmSpam = new DMSpammer();
        EmbedSpammer embedSpam = new EmbedSpammer();
        Friender friender = new Friender();
        JoinLeaveSpammer joinLeave = new JoinLeaveSpammer();
        MessageSpammer msgSpam = new MessageSpammer();
        TokenChecker tokenCkr = new TokenChecker();
        VoiceSpammer voiceSpam = new VoiceSpammer();

        public MainForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            this.avatar.TopLevel = false;
            this.dmSpam.TopLevel = false;
            this.embedSpam.TopLevel = false;
            this.friender.TopLevel = false;
            this.joinLeave.TopLevel = false;
            this.msgSpam.TopLevel = false;
            this.tokenCkr.TopLevel = false;
            this.voiceSpam.TopLevel = false;
            this.panelContainer.Controls.Add(avatar);
            this.panelContainer.Controls.Add(dmSpam);
            this.panelContainer.Controls.Add(embedSpam);
            this.panelContainer.Controls.Add(friender);
            this.panelContainer.Controls.Add(joinLeave);
            this.panelContainer.Controls.Add(msgSpam);
            this.panelContainer.Controls.Add(tokenCkr);
            this.panelContainer.Controls.Add(voiceSpam);
        }

        private void HideForms()
        {
            //try { Utils.t.Abort(); } catch (Exception) { };
            //try { Utils.t2.Abort(); } catch (Exception) { };
            avatar.Hide();
            dmSpam.Hide();
            embedSpam.Hide();
            friender.Hide();
            joinLeave.Hide();
            msgSpam.Hide();
            tokenCkr.Hide();
            voiceSpam.Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void TokensCheckerBtn_Click(object sender, EventArgs e)
        {
            NavPanel.Top = TokensCheckerBtn.Top;
            HideForms();
            tokenCkr.Show();
        }

        public void ShowMainFormFunc()
        {
            NavPanel.Top = TokensCheckerBtn.Top;
            HideForms();
            tokenCkr.Show();
        }

        private void VoiceSpammerBtn_Click(object sender, EventArgs e)
        {
            NavPanel.Top = VoiceSpammerBtn.Top;
            HideForms();
            voiceSpam.Show();
        }

        private void FrienderBtn_Click(object sender, EventArgs e)
        {
            NavPanel.Top = FrienderBtn.Top;
            HideForms();
            friender.Show();
        }

        private void ChangeAvatarBtn_Click(object sender, EventArgs e)
        {
            NavPanel.Top = ChangeAvatarBtn.Top;
            HideForms();
            avatar.Show();
        }

        private void DmSpammerBtn_Click(object sender, EventArgs e)
        {
            NavPanel.Top = DmSpammerBtn.Top;
            HideForms();
            dmSpam.Show();
        }

        private void JoinLeaveBtn_Click(object sender, EventArgs e)
        {
            NavPanel.Top = JoinLeaveBtn.Top;
            HideForms();
            joinLeave.Show();
        }

        private void EmbedSpammerBtn_Click(object sender, EventArgs e)
        {
            NavPanel.Top = EmbedSpammerBtn.Top;
            HideForms();
            embedSpam.Show();
        }

        private void MsgSpammerBtn_Click(object sender, EventArgs e)
        {
            NavPanel.Top = MsgSpammerBtn.Top;
            HideForms();
            msgSpam.Show();
        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(TokensTxtBox.Text) && TokensTxtBox.Text.Length > 59)
            {
                TokensCheckerBtn.Enabled = true;
                VoiceSpammerBtn.Enabled = true;
                FrienderBtn.Enabled = true;
                ChangeAvatarBtn.Enabled = true;
                DmSpammerBtn.Enabled = true;
                JoinLeaveBtn.Enabled = true;
                EmbedSpammerBtn.Enabled = true;
                MsgSpammerBtn.Enabled = true;
                NavPanel.Visible = true;
                tokens = TokensTxtBox.Text;
                TokensPanel.Visible = false;
                NavPanel.Top = TokensCheckerBtn.Top;
                HideForms();
                tokenCkr.Show();
            }
            else
            {
                MessageBox.Show("You need to put at least one token.");
            }
        }

        private void LoadFromWeb_Click(object sender, EventArgs e)
        {
            WebClient web = new WebClient();
            string value = "";
            if(Utils.InputBox("STZ RAID TOOL", "Enter a website: ", ref value) == DialogResult.OK)
            {
                System.IO.Stream stream = web.OpenRead(value);
                using (System.IO.StreamReader reader = new System.IO.StreamReader(stream))
                {
                    String text = reader.ReadToEnd();
                    TokensTxtBox.Text = text;
                }
            } 
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
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            TokensTxtBox.Text = "";
        }

        #region RGB
        private int r = 244;
        private int g = 65;
        private int b = 65;

        private void TimerR_Tick(object sender, EventArgs e)
        {
            if (b >= 244)
            {
                r -= 1;
                ExitBtn.ForeColor = Color.FromArgb(r, g, b);
                MinBtn.ForeColor = Color.FromArgb(r, g, b);
                NavPanel.BackColor = Color.FromArgb(r, g, b);
                if (r <= 65)
                {
                    TimerR.Stop();
                    TimerG.Start();
                }
            }

            if (b <= 65)
            {
                r += 1;
                ExitBtn.ForeColor = Color.FromArgb(r, g, b);
                MinBtn.ForeColor = Color.FromArgb(r, g, b);
                NavPanel.BackColor = Color.FromArgb(r, g, b);
                if (r >= 244)
                {
                    TimerR.Stop();
                    TimerG.Start();
                }
            }
        }

        private void TimerG_Tick(object sender, EventArgs e)
        {
            if (r <= 65)
            {
                g += 1;
                ExitBtn.ForeColor = Color.FromArgb(r, g, b);
                MinBtn.ForeColor = Color.FromArgb(r, g, b);
                NavPanel.BackColor = Color.FromArgb(r, g, b);
                if (g >= 244)
                {
                    TimerG.Stop();
                    TimerB.Start();
                }
            }

            if (r >= 244)
            {
                g -= 1;
                ExitBtn.ForeColor = Color.FromArgb(r, g, b);
                MinBtn.ForeColor = Color.FromArgb(r, g, b);
                NavPanel.BackColor = Color.FromArgb(r, g, b);
                if (g <= 65)
                {
                    TimerG.Stop();
                    TimerB.Start();
                }
            }
        }

        private void TimerB_Tick(object sender, EventArgs e)
        {
            if (g <= 65)
            {
                b += 1;
                ExitBtn.ForeColor = Color.FromArgb(r, g, b);
                MinBtn.ForeColor = Color.FromArgb(r, g, b);
                NavPanel.BackColor = Color.FromArgb(r, g, b);
                if (b >= 244)
                {
                    TimerB.Stop();
                    TimerR.Start();
                }
            }

            if (g >= 244)
            {
                b -= 1;
                ExitBtn.ForeColor = Color.FromArgb(r, g, b);
                MinBtn.ForeColor = Color.FromArgb(r, g, b);
                NavPanel.BackColor = Color.FromArgb(r, g, b);
                if (b <= 64)
                {
                    TimerB.Stop();
                    TimerR.Start();
                }
            }
        }
        #endregion

        #region AppMove
        private bool mouseDown;
        private Point lastLocation;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion

        private void secretLabel_Click(object sender, EventArgs e)
        {
            SecretForm secretForm = new SecretForm();
            secretForm.BringToFront();
            secretForm.Show();
            this.Hide();
            secretForm.FormClosed += delegate { this.Show(); };
        }
    }
}
