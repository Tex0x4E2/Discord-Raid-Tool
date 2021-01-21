
namespace RaidTool.SubForms
{
    partial class TokenChecker
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
            this.stopBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.startBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.LoadFile = new Guna.UI.WinForms.GunaGradientButton();
            this.TokensTxtBox = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ErrosCount = new System.Windows.Forms.Label();
            this.NotVaildCount = new System.Windows.Forms.Label();
            this.VaildCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckCount = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stopBtn
            // 
            this.stopBtn.Animated = true;
            this.stopBtn.AnimationHoverSpeed = 0.07F;
            this.stopBtn.AnimationSpeed = 0.03F;
            this.stopBtn.BackColor = System.Drawing.Color.Transparent;
            this.stopBtn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.stopBtn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.stopBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.stopBtn.BorderSize = 2;
            this.stopBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.stopBtn.FocusedColor = System.Drawing.Color.Empty;
            this.stopBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stopBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.stopBtn.Image = null;
            this.stopBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.stopBtn.Location = new System.Drawing.Point(370, 338);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.stopBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.stopBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.stopBtn.OnHoverForeColor = System.Drawing.Color.Red;
            this.stopBtn.OnHoverImage = null;
            this.stopBtn.OnPressedColor = System.Drawing.Color.Black;
            this.stopBtn.Radius = 9;
            this.stopBtn.Size = new System.Drawing.Size(155, 45);
            this.stopBtn.TabIndex = 15;
            this.stopBtn.Text = "Stop";
            this.stopBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Animated = true;
            this.startBtn.AnimationHoverSpeed = 0.07F;
            this.startBtn.AnimationSpeed = 0.03F;
            this.startBtn.BackColor = System.Drawing.Color.Transparent;
            this.startBtn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.startBtn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.startBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.startBtn.BorderSize = 2;
            this.startBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.startBtn.FocusedColor = System.Drawing.Color.Empty;
            this.startBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.startBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.startBtn.Image = null;
            this.startBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.startBtn.Location = new System.Drawing.Point(196, 338);
            this.startBtn.Name = "startBtn";
            this.startBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.startBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.startBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.startBtn.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startBtn.OnHoverImage = null;
            this.startBtn.OnPressedColor = System.Drawing.Color.Black;
            this.startBtn.Radius = 9;
            this.startBtn.Size = new System.Drawing.Size(155, 45);
            this.startBtn.TabIndex = 14;
            this.startBtn.Text = "Start";
            this.startBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
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
            this.LoadFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.LoadFile.Image = null;
            this.LoadFile.ImageSize = new System.Drawing.Size(20, 20);
            this.LoadFile.Location = new System.Drawing.Point(22, 338);
            this.LoadFile.Name = "LoadFile";
            this.LoadFile.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.LoadFile.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.LoadFile.OnHoverBorderColor = System.Drawing.Color.Black;
            this.LoadFile.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.LoadFile.OnHoverImage = null;
            this.LoadFile.OnPressedColor = System.Drawing.Color.Black;
            this.LoadFile.Radius = 9;
            this.LoadFile.Size = new System.Drawing.Size(155, 45);
            this.LoadFile.TabIndex = 13;
            this.LoadFile.Text = "Load from a file";
            this.LoadFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoadFile.Click += new System.EventHandler(this.LoadFile_Click);
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
            this.TokensTxtBox.Location = new System.Drawing.Point(22, 33);
            this.TokensTxtBox.Multiline = true;
            this.TokensTxtBox.Name = "TokensTxtBox";
            this.TokensTxtBox.PasswordChar = '\0';
            this.TokensTxtBox.Radius = 5;
            this.TokensTxtBox.SelectedText = "";
            this.TokensTxtBox.Size = new System.Drawing.Size(503, 299);
            this.TokensTxtBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Put your tokens here:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.ErrosCount);
            this.panel1.Controls.Add(this.NotVaildCount);
            this.panel1.Controls.Add(this.VaildCount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 389);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 43);
            this.panel1.TabIndex = 16;
            // 
            // ErrosCount
            // 
            this.ErrosCount.AutoSize = true;
            this.ErrosCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ErrosCount.ForeColor = System.Drawing.Color.White;
            this.ErrosCount.Location = new System.Drawing.Point(437, 14);
            this.ErrosCount.Name = "ErrosCount";
            this.ErrosCount.Size = new System.Drawing.Size(15, 16);
            this.ErrosCount.TabIndex = 22;
            this.ErrosCount.Text = "0";
            // 
            // NotVaildCount
            // 
            this.NotVaildCount.AutoSize = true;
            this.NotVaildCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.NotVaildCount.ForeColor = System.Drawing.Color.White;
            this.NotVaildCount.Location = new System.Drawing.Point(288, 14);
            this.NotVaildCount.Name = "NotVaildCount";
            this.NotVaildCount.Size = new System.Drawing.Size(15, 16);
            this.NotVaildCount.TabIndex = 21;
            this.NotVaildCount.Text = "0";
            // 
            // VaildCount
            // 
            this.VaildCount.AutoSize = true;
            this.VaildCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.VaildCount.ForeColor = System.Drawing.Color.White;
            this.VaildCount.Location = new System.Drawing.Point(114, 14);
            this.VaildCount.Name = "VaildCount";
            this.VaildCount.Size = new System.Drawing.Size(15, 16);
            this.VaildCount.TabIndex = 20;
            this.VaildCount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(384, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Errors:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(210, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Unverified:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(51, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Verified:";
            // 
            // CheckCount
            // 
            this.CheckCount.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TokenChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(543, 444);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.LoadFile);
            this.Controls.Add(this.TokensTxtBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TokenChecker";
            this.Text = "TokenChecker";
            this.Load += new System.EventHandler(this.TokenChecker_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientButton stopBtn;
        private Guna.UI.WinForms.GunaGradientButton startBtn;
        private Guna.UI.WinForms.GunaGradientButton LoadFile;
        private Guna.UI.WinForms.GunaTextBox TokensTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ErrosCount;
        private System.Windows.Forms.Label VaildCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label NotVaildCount;
        private System.Windows.Forms.Timer CheckCount;
    }
}