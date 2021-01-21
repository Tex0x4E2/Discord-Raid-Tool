
namespace RaidTool
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.secretLabel = new System.Windows.Forms.Label();
            this.MinBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.TimerR = new System.Windows.Forms.Timer(this.components);
            this.TimerG = new System.Windows.Forms.Timer(this.components);
            this.TimerB = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.NavPanel = new System.Windows.Forms.Panel();
            this.MsgSpammerBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.EmbedSpammerBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.JoinLeaveBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.DmSpammerBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.ChangeAvatarBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.FrienderBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.VoiceSpammerBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.TokensCheckerBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.TokensPanel = new System.Windows.Forms.Panel();
            this.ClearBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.LoadFromWeb = new Guna.UI.WinForms.GunaGradientButton();
            this.LoadFile = new Guna.UI.WinForms.GunaGradientButton();
            this.okBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.TokensTxtBox = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.TokensPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.secretLabel);
            this.panel1.Controls.Add(this.MinBtn);
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 71);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // secretLabel
            // 
            this.secretLabel.AutoSize = true;
            this.secretLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.secretLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.secretLabel.Location = new System.Drawing.Point(174, 3);
            this.secretLabel.Name = "secretLabel";
            this.secretLabel.Size = new System.Drawing.Size(363, 65);
            this.secretLabel.TabIndex = 3;
            this.secretLabel.Text = "STZ-RAID TOOL";
            this.secretLabel.Click += new System.EventHandler(this.secretLabel_Click);
            // 
            // MinBtn
            // 
            this.MinBtn.FlatAppearance.BorderSize = 0;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.MinBtn.ForeColor = System.Drawing.Color.White;
            this.MinBtn.Location = new System.Drawing.Point(678, 38);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(20, 20);
            this.MinBtn.TabIndex = 2;
            this.MinBtn.Text = "--";
            this.MinBtn.UseVisualStyleBackColor = true;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(678, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(20, 20);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // TimerR
            // 
            this.TimerR.Interval = 5;
            this.TimerR.Tick += new System.EventHandler(this.TimerR_Tick);
            // 
            // TimerG
            // 
            this.TimerG.Interval = 5;
            this.TimerG.Tick += new System.EventHandler(this.TimerG_Tick);
            // 
            // TimerB
            // 
            this.TimerB.Enabled = true;
            this.TimerB.Interval = 5;
            this.TimerB.Tick += new System.EventHandler(this.TimerB_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel2.Controls.Add(this.NavPanel);
            this.panel2.Controls.Add(this.MsgSpammerBtn);
            this.panel2.Controls.Add(this.EmbedSpammerBtn);
            this.panel2.Controls.Add(this.JoinLeaveBtn);
            this.panel2.Controls.Add(this.DmSpammerBtn);
            this.panel2.Controls.Add(this.ChangeAvatarBtn);
            this.panel2.Controls.Add(this.FrienderBtn);
            this.panel2.Controls.Add(this.VoiceSpammerBtn);
            this.panel2.Controls.Add(this.TokensCheckerBtn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 444);
            this.panel2.TabIndex = 0;
            // 
            // NavPanel
            // 
            this.NavPanel.BackColor = System.Drawing.Color.White;
            this.NavPanel.ForeColor = System.Drawing.Color.White;
            this.NavPanel.Location = new System.Drawing.Point(0, 28);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Size = new System.Drawing.Size(3, 52);
            this.NavPanel.TabIndex = 2;
            this.NavPanel.Visible = false;
            // 
            // MsgSpammerBtn
            // 
            this.MsgSpammerBtn.Animated = true;
            this.MsgSpammerBtn.AnimationHoverSpeed = 0.07F;
            this.MsgSpammerBtn.AnimationSpeed = 0.03F;
            this.MsgSpammerBtn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.MsgSpammerBtn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.MsgSpammerBtn.BorderColor = System.Drawing.Color.Black;
            this.MsgSpammerBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.MsgSpammerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MsgSpammerBtn.Enabled = false;
            this.MsgSpammerBtn.FocusedColor = System.Drawing.Color.Empty;
            this.MsgSpammerBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MsgSpammerBtn.ForeColor = System.Drawing.Color.White;
            this.MsgSpammerBtn.Image = null;
            this.MsgSpammerBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.MsgSpammerBtn.Location = new System.Drawing.Point(0, 392);
            this.MsgSpammerBtn.Name = "MsgSpammerBtn";
            this.MsgSpammerBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.MsgSpammerBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.MsgSpammerBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.MsgSpammerBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.MsgSpammerBtn.OnHoverImage = null;
            this.MsgSpammerBtn.OnPressedColor = System.Drawing.Color.Black;
            this.MsgSpammerBtn.Size = new System.Drawing.Size(167, 52);
            this.MsgSpammerBtn.TabIndex = 9;
            this.MsgSpammerBtn.Text = "Message Spammer";
            this.MsgSpammerBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MsgSpammerBtn.Click += new System.EventHandler(this.MsgSpammerBtn_Click);
            // 
            // EmbedSpammerBtn
            // 
            this.EmbedSpammerBtn.Animated = true;
            this.EmbedSpammerBtn.AnimationHoverSpeed = 0.07F;
            this.EmbedSpammerBtn.AnimationSpeed = 0.03F;
            this.EmbedSpammerBtn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.EmbedSpammerBtn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.EmbedSpammerBtn.BorderColor = System.Drawing.Color.Black;
            this.EmbedSpammerBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EmbedSpammerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmbedSpammerBtn.Enabled = false;
            this.EmbedSpammerBtn.FocusedColor = System.Drawing.Color.Empty;
            this.EmbedSpammerBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmbedSpammerBtn.ForeColor = System.Drawing.Color.White;
            this.EmbedSpammerBtn.Image = null;
            this.EmbedSpammerBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.EmbedSpammerBtn.Location = new System.Drawing.Point(0, 340);
            this.EmbedSpammerBtn.Name = "EmbedSpammerBtn";
            this.EmbedSpammerBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.EmbedSpammerBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.EmbedSpammerBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.EmbedSpammerBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.EmbedSpammerBtn.OnHoverImage = null;
            this.EmbedSpammerBtn.OnPressedColor = System.Drawing.Color.Black;
            this.EmbedSpammerBtn.Size = new System.Drawing.Size(167, 52);
            this.EmbedSpammerBtn.TabIndex = 8;
            this.EmbedSpammerBtn.Text = "Embed Spammer";
            this.EmbedSpammerBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmbedSpammerBtn.Click += new System.EventHandler(this.EmbedSpammerBtn_Click);
            // 
            // JoinLeaveBtn
            // 
            this.JoinLeaveBtn.Animated = true;
            this.JoinLeaveBtn.AnimationHoverSpeed = 0.07F;
            this.JoinLeaveBtn.AnimationSpeed = 0.03F;
            this.JoinLeaveBtn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.JoinLeaveBtn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.JoinLeaveBtn.BorderColor = System.Drawing.Color.Black;
            this.JoinLeaveBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.JoinLeaveBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.JoinLeaveBtn.Enabled = false;
            this.JoinLeaveBtn.FocusedColor = System.Drawing.Color.Empty;
            this.JoinLeaveBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.JoinLeaveBtn.ForeColor = System.Drawing.Color.White;
            this.JoinLeaveBtn.Image = null;
            this.JoinLeaveBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.JoinLeaveBtn.Location = new System.Drawing.Point(0, 288);
            this.JoinLeaveBtn.Name = "JoinLeaveBtn";
            this.JoinLeaveBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.JoinLeaveBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.JoinLeaveBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.JoinLeaveBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.JoinLeaveBtn.OnHoverImage = null;
            this.JoinLeaveBtn.OnPressedColor = System.Drawing.Color.Black;
            this.JoinLeaveBtn.Size = new System.Drawing.Size(167, 52);
            this.JoinLeaveBtn.TabIndex = 7;
            this.JoinLeaveBtn.Text = "Join & Leave Spammer";
            this.JoinLeaveBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.JoinLeaveBtn.Click += new System.EventHandler(this.JoinLeaveBtn_Click);
            // 
            // DmSpammerBtn
            // 
            this.DmSpammerBtn.Animated = true;
            this.DmSpammerBtn.AnimationHoverSpeed = 0.07F;
            this.DmSpammerBtn.AnimationSpeed = 0.03F;
            this.DmSpammerBtn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.DmSpammerBtn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.DmSpammerBtn.BorderColor = System.Drawing.Color.Black;
            this.DmSpammerBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DmSpammerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DmSpammerBtn.Enabled = false;
            this.DmSpammerBtn.FocusedColor = System.Drawing.Color.Empty;
            this.DmSpammerBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DmSpammerBtn.ForeColor = System.Drawing.Color.White;
            this.DmSpammerBtn.Image = null;
            this.DmSpammerBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.DmSpammerBtn.Location = new System.Drawing.Point(0, 236);
            this.DmSpammerBtn.Name = "DmSpammerBtn";
            this.DmSpammerBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.DmSpammerBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.DmSpammerBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.DmSpammerBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.DmSpammerBtn.OnHoverImage = null;
            this.DmSpammerBtn.OnPressedColor = System.Drawing.Color.Black;
            this.DmSpammerBtn.Size = new System.Drawing.Size(167, 52);
            this.DmSpammerBtn.TabIndex = 6;
            this.DmSpammerBtn.Text = "DM Spammer";
            this.DmSpammerBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DmSpammerBtn.Click += new System.EventHandler(this.DmSpammerBtn_Click);
            // 
            // ChangeAvatarBtn
            // 
            this.ChangeAvatarBtn.Animated = true;
            this.ChangeAvatarBtn.AnimationHoverSpeed = 0.07F;
            this.ChangeAvatarBtn.AnimationSpeed = 0.03F;
            this.ChangeAvatarBtn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ChangeAvatarBtn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ChangeAvatarBtn.BorderColor = System.Drawing.Color.Black;
            this.ChangeAvatarBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ChangeAvatarBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChangeAvatarBtn.Enabled = false;
            this.ChangeAvatarBtn.FocusedColor = System.Drawing.Color.Empty;
            this.ChangeAvatarBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ChangeAvatarBtn.ForeColor = System.Drawing.Color.White;
            this.ChangeAvatarBtn.Image = null;
            this.ChangeAvatarBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.ChangeAvatarBtn.Location = new System.Drawing.Point(0, 184);
            this.ChangeAvatarBtn.Name = "ChangeAvatarBtn";
            this.ChangeAvatarBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ChangeAvatarBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ChangeAvatarBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ChangeAvatarBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.ChangeAvatarBtn.OnHoverImage = null;
            this.ChangeAvatarBtn.OnPressedColor = System.Drawing.Color.Black;
            this.ChangeAvatarBtn.Size = new System.Drawing.Size(167, 52);
            this.ChangeAvatarBtn.TabIndex = 5;
            this.ChangeAvatarBtn.Text = "Change Avatar [Beta]";
            this.ChangeAvatarBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChangeAvatarBtn.Click += new System.EventHandler(this.ChangeAvatarBtn_Click);
            // 
            // FrienderBtn
            // 
            this.FrienderBtn.Animated = true;
            this.FrienderBtn.AnimationHoverSpeed = 0.07F;
            this.FrienderBtn.AnimationSpeed = 0.03F;
            this.FrienderBtn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.FrienderBtn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.FrienderBtn.BorderColor = System.Drawing.Color.Black;
            this.FrienderBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.FrienderBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.FrienderBtn.Enabled = false;
            this.FrienderBtn.FocusedColor = System.Drawing.Color.Empty;
            this.FrienderBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FrienderBtn.ForeColor = System.Drawing.Color.White;
            this.FrienderBtn.Image = null;
            this.FrienderBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.FrienderBtn.Location = new System.Drawing.Point(0, 132);
            this.FrienderBtn.Name = "FrienderBtn";
            this.FrienderBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.FrienderBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.FrienderBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.FrienderBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.FrienderBtn.OnHoverImage = null;
            this.FrienderBtn.OnPressedColor = System.Drawing.Color.Black;
            this.FrienderBtn.Size = new System.Drawing.Size(167, 52);
            this.FrienderBtn.TabIndex = 4;
            this.FrienderBtn.Text = "Friender";
            this.FrienderBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FrienderBtn.Click += new System.EventHandler(this.FrienderBtn_Click);
            // 
            // VoiceSpammerBtn
            // 
            this.VoiceSpammerBtn.Animated = true;
            this.VoiceSpammerBtn.AnimationHoverSpeed = 0.07F;
            this.VoiceSpammerBtn.AnimationSpeed = 0.03F;
            this.VoiceSpammerBtn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.VoiceSpammerBtn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.VoiceSpammerBtn.BorderColor = System.Drawing.Color.Black;
            this.VoiceSpammerBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.VoiceSpammerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.VoiceSpammerBtn.Enabled = false;
            this.VoiceSpammerBtn.FocusedColor = System.Drawing.Color.Empty;
            this.VoiceSpammerBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.VoiceSpammerBtn.ForeColor = System.Drawing.Color.White;
            this.VoiceSpammerBtn.Image = null;
            this.VoiceSpammerBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.VoiceSpammerBtn.Location = new System.Drawing.Point(0, 80);
            this.VoiceSpammerBtn.Name = "VoiceSpammerBtn";
            this.VoiceSpammerBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.VoiceSpammerBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.VoiceSpammerBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.VoiceSpammerBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.VoiceSpammerBtn.OnHoverImage = null;
            this.VoiceSpammerBtn.OnPressedColor = System.Drawing.Color.Black;
            this.VoiceSpammerBtn.Size = new System.Drawing.Size(167, 52);
            this.VoiceSpammerBtn.TabIndex = 3;
            this.VoiceSpammerBtn.Text = "Voice Spammer [Beta]";
            this.VoiceSpammerBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VoiceSpammerBtn.Click += new System.EventHandler(this.VoiceSpammerBtn_Click);
            // 
            // TokensCheckerBtn
            // 
            this.TokensCheckerBtn.Animated = true;
            this.TokensCheckerBtn.AnimationHoverSpeed = 0.07F;
            this.TokensCheckerBtn.AnimationSpeed = 0.03F;
            this.TokensCheckerBtn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TokensCheckerBtn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TokensCheckerBtn.BorderColor = System.Drawing.Color.Black;
            this.TokensCheckerBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.TokensCheckerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.TokensCheckerBtn.Enabled = false;
            this.TokensCheckerBtn.FocusedColor = System.Drawing.Color.Empty;
            this.TokensCheckerBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TokensCheckerBtn.ForeColor = System.Drawing.Color.White;
            this.TokensCheckerBtn.Image = null;
            this.TokensCheckerBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.TokensCheckerBtn.Location = new System.Drawing.Point(0, 28);
            this.TokensCheckerBtn.Name = "TokensCheckerBtn";
            this.TokensCheckerBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TokensCheckerBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.TokensCheckerBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.TokensCheckerBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.TokensCheckerBtn.OnHoverImage = null;
            this.TokensCheckerBtn.OnPressedColor = System.Drawing.Color.Black;
            this.TokensCheckerBtn.Size = new System.Drawing.Size(167, 52);
            this.TokensCheckerBtn.TabIndex = 2;
            this.TokensCheckerBtn.Text = "Tokens Checker";
            this.TokensCheckerBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TokensCheckerBtn.Click += new System.EventHandler(this.TokensCheckerBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 28);
            this.panel3.TabIndex = 0;
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.TokensPanel);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(167, 71);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(543, 444);
            this.panelContainer.TabIndex = 1;
            // 
            // TokensPanel
            // 
            this.TokensPanel.Controls.Add(this.ClearBtn);
            this.TokensPanel.Controls.Add(this.LoadFromWeb);
            this.TokensPanel.Controls.Add(this.LoadFile);
            this.TokensPanel.Controls.Add(this.okBtn);
            this.TokensPanel.Controls.Add(this.TokensTxtBox);
            this.TokensPanel.Controls.Add(this.label2);
            this.TokensPanel.Location = new System.Drawing.Point(6, 6);
            this.TokensPanel.Name = "TokensPanel";
            this.TokensPanel.Size = new System.Drawing.Size(531, 431);
            this.TokensPanel.TabIndex = 2;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Animated = true;
            this.ClearBtn.AnimationHoverSpeed = 0.07F;
            this.ClearBtn.AnimationSpeed = 0.03F;
            this.ClearBtn.BackColor = System.Drawing.Color.Transparent;
            this.ClearBtn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClearBtn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClearBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClearBtn.BorderSize = 2;
            this.ClearBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ClearBtn.FocusedColor = System.Drawing.Color.Empty;
            this.ClearBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClearBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClearBtn.Image = null;
            this.ClearBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.ClearBtn.Location = new System.Drawing.Point(186, 341);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClearBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClearBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ClearBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.ClearBtn.OnHoverImage = null;
            this.ClearBtn.OnPressedColor = System.Drawing.Color.Black;
            this.ClearBtn.Radius = 9;
            this.ClearBtn.Size = new System.Drawing.Size(155, 35);
            this.ClearBtn.TabIndex = 19;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // LoadFromWeb
            // 
            this.LoadFromWeb.Animated = true;
            this.LoadFromWeb.AnimationHoverSpeed = 0.07F;
            this.LoadFromWeb.AnimationSpeed = 0.03F;
            this.LoadFromWeb.BackColor = System.Drawing.Color.Transparent;
            this.LoadFromWeb.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.LoadFromWeb.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.LoadFromWeb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.LoadFromWeb.BorderSize = 2;
            this.LoadFromWeb.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LoadFromWeb.FocusedColor = System.Drawing.Color.Empty;
            this.LoadFromWeb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoadFromWeb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LoadFromWeb.Image = null;
            this.LoadFromWeb.ImageSize = new System.Drawing.Size(20, 20);
            this.LoadFromWeb.Location = new System.Drawing.Point(360, 341);
            this.LoadFromWeb.Name = "LoadFromWeb";
            this.LoadFromWeb.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.LoadFromWeb.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.LoadFromWeb.OnHoverBorderColor = System.Drawing.Color.Black;
            this.LoadFromWeb.OnHoverForeColor = System.Drawing.Color.White;
            this.LoadFromWeb.OnHoverImage = null;
            this.LoadFromWeb.OnPressedColor = System.Drawing.Color.Black;
            this.LoadFromWeb.Radius = 9;
            this.LoadFromWeb.Size = new System.Drawing.Size(155, 35);
            this.LoadFromWeb.TabIndex = 18;
            this.LoadFromWeb.Text = "Load from a web";
            this.LoadFromWeb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoadFromWeb.Click += new System.EventHandler(this.LoadFromWeb_Click);
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
            this.LoadFile.Location = new System.Drawing.Point(12, 341);
            this.LoadFile.Name = "LoadFile";
            this.LoadFile.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.LoadFile.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.LoadFile.OnHoverBorderColor = System.Drawing.Color.Black;
            this.LoadFile.OnHoverForeColor = System.Drawing.Color.White;
            this.LoadFile.OnHoverImage = null;
            this.LoadFile.OnPressedColor = System.Drawing.Color.Black;
            this.LoadFile.Radius = 9;
            this.LoadFile.Size = new System.Drawing.Size(155, 35);
            this.LoadFile.TabIndex = 17;
            this.LoadFile.Text = "Load from a file";
            this.LoadFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoadFile.Click += new System.EventHandler(this.LoadFile_Click);
            // 
            // okBtn
            // 
            this.okBtn.Animated = true;
            this.okBtn.AnimationHoverSpeed = 0.07F;
            this.okBtn.AnimationSpeed = 0.03F;
            this.okBtn.BackColor = System.Drawing.Color.Transparent;
            this.okBtn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.okBtn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.okBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.okBtn.BorderSize = 2;
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.okBtn.FocusedColor = System.Drawing.Color.Empty;
            this.okBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.okBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.okBtn.Image = null;
            this.okBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.okBtn.Location = new System.Drawing.Point(12, 386);
            this.okBtn.Name = "okBtn";
            this.okBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.okBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.okBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.okBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.okBtn.OnHoverImage = null;
            this.okBtn.OnPressedColor = System.Drawing.Color.Black;
            this.okBtn.Radius = 9;
            this.okBtn.Size = new System.Drawing.Size(503, 34);
            this.okBtn.TabIndex = 16;
            this.okBtn.Text = "OK";
            this.okBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.okBtn.Click += new System.EventHandler(this.gunaGradientButton3_Click);
            // 
            // TokensTxtBox
            // 
            this.TokensTxtBox.BackColor = System.Drawing.Color.Transparent;
            this.TokensTxtBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TokensTxtBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TokensTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TokensTxtBox.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TokensTxtBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TokensTxtBox.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TokensTxtBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TokensTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TokensTxtBox.Location = new System.Drawing.Point(12, 36);
            this.TokensTxtBox.Multiline = true;
            this.TokensTxtBox.Name = "TokensTxtBox";
            this.TokensTxtBox.PasswordChar = '\0';
            this.TokensTxtBox.Radius = 5;
            this.TokensTxtBox.SelectedText = "";
            this.TokensTxtBox.Size = new System.Drawing.Size(503, 299);
            this.TokensTxtBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Put your tokens here and click ok.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(710, 515);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STZ-RAID TOOL";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.TokensPanel.ResumeLayout(false);
            this.TokensPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label secretLabel;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Timer TimerR;
        private System.Windows.Forms.Timer TimerG;
        private System.Windows.Forms.Timer TimerB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaGradientButton MsgSpammerBtn;
        private Guna.UI.WinForms.GunaGradientButton EmbedSpammerBtn;
        private Guna.UI.WinForms.GunaGradientButton JoinLeaveBtn;
        private Guna.UI.WinForms.GunaGradientButton DmSpammerBtn;
        private Guna.UI.WinForms.GunaGradientButton ChangeAvatarBtn;
        private Guna.UI.WinForms.GunaGradientButton FrienderBtn;
        private Guna.UI.WinForms.GunaGradientButton VoiceSpammerBtn;
        private Guna.UI.WinForms.GunaGradientButton TokensCheckerBtn;
        private System.Windows.Forms.Panel NavPanel;
        private Guna.UI.WinForms.GunaTextBox TokensTxtBox;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaGradientButton okBtn;
        private Guna.UI.WinForms.GunaGradientButton LoadFromWeb;
        private Guna.UI.WinForms.GunaGradientButton LoadFile;
        private System.Windows.Forms.Panel TokensPanel;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI.WinForms.GunaGradientButton ClearBtn;
    }
}

