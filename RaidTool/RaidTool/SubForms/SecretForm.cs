using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaidTool.SubForms
{
    public partial class SecretForm : Form
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
        SoundPlayer player = new SoundPlayer();

        public SecretForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            texLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
        }

        private void SecretForm_Load(object sender, EventArgs e)
        {
            try
            {
                string exePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\";
                string finalPath = exePath.Replace("file:\\", "") + "Sounds\\credits.wav";
                player.SoundLocation = finalPath ;
                player.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error playing sound");
            }
        }

        private void SecretForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            player.Stop();
        }


        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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
                RainbowLabel.ForeColor = Color.FromArgb(r, g, b);
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
                RainbowLabel.ForeColor = Color.FromArgb(r, g, b);
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
                RainbowLabel.ForeColor = Color.FromArgb(r, g, b);
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
                RainbowLabel.ForeColor = Color.FromArgb(r, g, b);
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
                RainbowLabel.ForeColor = Color.FromArgb(r, g, b);
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
                RainbowLabel.ForeColor = Color.FromArgb(r, g, b);
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

        private void panelMain_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void panelMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void panelMain_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void RainbowLabel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void RainbowLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void RainbowLabel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        #endregion

        private void ManagementLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.nuget.org/packages/System.Management/");
        }

        private void AnarchyLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.nuget.org/packages/Anarchy-wrapper/");
        }

        private void NewToSoftLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.nuget.org/packages/Newtonsoft.Json/");
        }

        private void texLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://discord.gg/tHa7JZBVtU");
        }
    }
}
