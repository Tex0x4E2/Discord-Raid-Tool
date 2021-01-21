
namespace RaidTool.SubForms
{
    partial class VoiceSpammer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.ChannelidTxt = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.YesBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.NoBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DownloadSound = new Guna.UI.WinForms.GunaGradientButton();
            this.LoadFile = new Guna.UI.WinForms.GunaGradientButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SoundDir = new Guna.UI.WinForms.GunaTextBox();
            this.ExecuteBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.CheckForFile = new System.Windows.Forms.Timer(this.components);
            this.PanelHide = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.PanelHide.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Channel id:";
            // 
            // ChannelidTxt
            // 
            this.ChannelidTxt.BackColor = System.Drawing.Color.Transparent;
            this.ChannelidTxt.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ChannelidTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ChannelidTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ChannelidTxt.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ChannelidTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ChannelidTxt.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ChannelidTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ChannelidTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ChannelidTxt.Location = new System.Drawing.Point(98, 46);
            this.ChannelidTxt.Name = "ChannelidTxt";
            this.ChannelidTxt.PasswordChar = '\0';
            this.ChannelidTxt.Radius = 5;
            this.ChannelidTxt.SelectedText = "";
            this.ChannelidTxt.Size = new System.Drawing.Size(160, 30);
            this.ChannelidTxt.TabIndex = 13;
            this.ChannelidTxt.TextChanged += new System.EventHandler(this.ChannelidTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 54);
            this.label2.TabIndex = 14;
            this.label2.Text = "To make this works,\nYou need to download another file that has the voice binaries" +
    ".\nWould you like to download it?";
            // 
            // YesBtn
            // 
            this.YesBtn.Animated = true;
            this.YesBtn.AnimationHoverSpeed = 0.07F;
            this.YesBtn.AnimationSpeed = 0.03F;
            this.YesBtn.BackColor = System.Drawing.Color.Transparent;
            this.YesBtn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.YesBtn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.YesBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.YesBtn.BorderSize = 2;
            this.YesBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.YesBtn.FocusedColor = System.Drawing.Color.Empty;
            this.YesBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.YesBtn.ForeColor = System.Drawing.Color.Lime;
            this.YesBtn.Image = null;
            this.YesBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.YesBtn.Location = new System.Drawing.Point(99, 77);
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.YesBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.YesBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.YesBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.YesBtn.OnHoverImage = null;
            this.YesBtn.OnPressedColor = System.Drawing.Color.Black;
            this.YesBtn.Radius = 9;
            this.YesBtn.Size = new System.Drawing.Size(155, 35);
            this.YesBtn.TabIndex = 18;
            this.YesBtn.Text = "Yes";
            this.YesBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.YesBtn.Click += new System.EventHandler(this.YesBtn_Click);
            // 
            // NoBtn
            // 
            this.NoBtn.Animated = true;
            this.NoBtn.AnimationHoverSpeed = 0.07F;
            this.NoBtn.AnimationSpeed = 0.03F;
            this.NoBtn.BackColor = System.Drawing.Color.Transparent;
            this.NoBtn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.NoBtn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.NoBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.NoBtn.BorderSize = 2;
            this.NoBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.NoBtn.FocusedColor = System.Drawing.Color.Empty;
            this.NoBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NoBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NoBtn.Image = null;
            this.NoBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.NoBtn.Location = new System.Drawing.Point(260, 77);
            this.NoBtn.Name = "NoBtn";
            this.NoBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.NoBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.NoBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.NoBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.NoBtn.OnHoverImage = null;
            this.NoBtn.OnPressedColor = System.Drawing.Color.Black;
            this.NoBtn.Radius = 9;
            this.NoBtn.Size = new System.Drawing.Size(155, 35);
            this.NoBtn.TabIndex = 19;
            this.NoBtn.Text = "No";
            this.NoBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NoBtn.Click += new System.EventHandler(this.NoBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NoBtn);
            this.panel1.Controls.Add(this.YesBtn);
            this.panel1.Location = new System.Drawing.Point(14, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 120);
            this.panel1.TabIndex = 20;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.panel2.Controls.Add(this.DownloadSound);
            this.panel2.Controls.Add(this.LoadFile);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.SoundDir);
            this.panel2.Location = new System.Drawing.Point(14, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 184);
            this.panel2.TabIndex = 21;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // DownloadSound
            // 
            this.DownloadSound.Animated = true;
            this.DownloadSound.AnimationHoverSpeed = 0.07F;
            this.DownloadSound.AnimationSpeed = 0.03F;
            this.DownloadSound.BackColor = System.Drawing.Color.Transparent;
            this.DownloadSound.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.DownloadSound.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.DownloadSound.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.DownloadSound.BorderSize = 2;
            this.DownloadSound.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DownloadSound.FocusedColor = System.Drawing.Color.Empty;
            this.DownloadSound.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DownloadSound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DownloadSound.Image = null;
            this.DownloadSound.ImageSize = new System.Drawing.Size(20, 20);
            this.DownloadSound.Location = new System.Drawing.Point(264, 146);
            this.DownloadSound.Name = "DownloadSound";
            this.DownloadSound.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.DownloadSound.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.DownloadSound.OnHoverBorderColor = System.Drawing.Color.Black;
            this.DownloadSound.OnHoverForeColor = System.Drawing.Color.White;
            this.DownloadSound.OnHoverImage = null;
            this.DownloadSound.OnPressedColor = System.Drawing.Color.Black;
            this.DownloadSound.Radius = 9;
            this.DownloadSound.Size = new System.Drawing.Size(155, 35);
            this.DownloadSound.TabIndex = 24;
            this.DownloadSound.Text = "Download Here";
            this.DownloadSound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DownloadSound.Click += new System.EventHandler(this.DownloadSound_Click);
            // 
            // LoadFile
            // 
            this.LoadFile.Animated = true;
            this.LoadFile.AnimationHoverSpeed = 0.07F;
            this.LoadFile.AnimationSpeed = 0.03F;
            this.LoadFile.BackColor = System.Drawing.Color.Transparent;
            this.LoadFile.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.LoadFile.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.LoadFile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.LoadFile.BorderSize = 2;
            this.LoadFile.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LoadFile.FocusedColor = System.Drawing.Color.Empty;
            this.LoadFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoadFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LoadFile.Image = null;
            this.LoadFile.ImageSize = new System.Drawing.Size(20, 20);
            this.LoadFile.Location = new System.Drawing.Point(98, 147);
            this.LoadFile.Name = "LoadFile";
            this.LoadFile.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.LoadFile.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.LoadFile.OnHoverBorderColor = System.Drawing.Color.Black;
            this.LoadFile.OnHoverForeColor = System.Drawing.Color.White;
            this.LoadFile.OnHoverImage = null;
            this.LoadFile.OnPressedColor = System.Drawing.Color.Black;
            this.LoadFile.Radius = 9;
            this.LoadFile.Size = new System.Drawing.Size(160, 35);
            this.LoadFile.TabIndex = 20;
            this.LoadFile.Text = "Load a file";
            this.LoadFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoadFile.Click += new System.EventHandler(this.LoadFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(43, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(431, 90);
            this.label4.TabIndex = 21;
            this.label4.Text = "Now,\nYou need to write the path to the music file,\nOr you can just load it by cli" +
    "cking the button below.\n\nIf you don\'t have a music file to play click on the dow" +
    "nload button";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(95, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Music Path:";
            // 
            // SoundDir
            // 
            this.SoundDir.BackColor = System.Drawing.Color.Transparent;
            this.SoundDir.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.SoundDir.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SoundDir.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SoundDir.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.SoundDir.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SoundDir.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SoundDir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SoundDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SoundDir.Location = new System.Drawing.Point(98, 111);
            this.SoundDir.Name = "SoundDir";
            this.SoundDir.PasswordChar = '\0';
            this.SoundDir.Radius = 5;
            this.SoundDir.SelectedText = "";
            this.SoundDir.Size = new System.Drawing.Size(160, 30);
            this.SoundDir.TabIndex = 15;
            this.SoundDir.TextChanged += new System.EventHandler(this.SoundDir_TextChanged);
            // 
            // ExecuteBtn
            // 
            this.ExecuteBtn.Animated = true;
            this.ExecuteBtn.AnimationHoverSpeed = 0.07F;
            this.ExecuteBtn.AnimationSpeed = 0.03F;
            this.ExecuteBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExecuteBtn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ExecuteBtn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ExecuteBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ExecuteBtn.BorderSize = 2;
            this.ExecuteBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ExecuteBtn.FocusedColor = System.Drawing.Color.Empty;
            this.ExecuteBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExecuteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ExecuteBtn.Image = null;
            this.ExecuteBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.ExecuteBtn.Location = new System.Drawing.Point(264, 46);
            this.ExecuteBtn.Name = "ExecuteBtn";
            this.ExecuteBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ExecuteBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ExecuteBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ExecuteBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.ExecuteBtn.OnHoverImage = null;
            this.ExecuteBtn.OnPressedColor = System.Drawing.Color.Black;
            this.ExecuteBtn.Radius = 9;
            this.ExecuteBtn.Size = new System.Drawing.Size(155, 30);
            this.ExecuteBtn.TabIndex = 21;
            this.ExecuteBtn.Text = "Execute";
            this.ExecuteBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ExecuteBtn.Click += new System.EventHandler(this.ExecuteBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.ExecuteBtn);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.ChannelidTxt);
            this.panel3.Location = new System.Drawing.Point(14, 319);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(514, 120);
            this.panel3.TabIndex = 21;
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(49, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(356, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Enter the id of the channel you would like to Ear rape:";
            // 
            // CheckForFile
            // 
            this.CheckForFile.Interval = 1000;
            this.CheckForFile.Tick += new System.EventHandler(this.CheckForFile_Tick);
            // 
            // PanelHide
            // 
            this.PanelHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.PanelHide.Controls.Add(this.label6);
            this.PanelHide.Location = new System.Drawing.Point(800, 3);
            this.PanelHide.Name = "PanelHide";
            this.PanelHide.Size = new System.Drawing.Size(514, 436);
            this.PanelHide.TabIndex = 22;
            this.PanelHide.MouseLeave += new System.EventHandler(this.PanelHide_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(495, 222);
            this.label6.TabIndex = 0;
            this.label6.Text = "Since you chose no,\r\nThis tab will be disabled for you\r\nBecause you can not use t" +
    "his tool\r\nWithout the voice binaries\r\n\r\n(Until you restart the program)";
            // 
            // VoiceSpammer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(543, 444);
            this.Controls.Add(this.PanelHide);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VoiceSpammer";
            this.Text = "VoiceSpammer";
            this.Load += new System.EventHandler(this.VoiceSpammer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PanelHide.ResumeLayout(false);
            this.PanelHide.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox ChannelidTxt;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaGradientButton YesBtn;
        private Guna.UI.WinForms.GunaGradientButton NoBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaGradientButton DownloadSound;
        private Guna.UI.WinForms.GunaGradientButton LoadFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox SoundDir;
        private Guna.UI.WinForms.GunaGradientButton ExecuteBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer CheckForFile;
        private System.Windows.Forms.Panel PanelHide;
        private System.Windows.Forms.Label label6;
    }
}