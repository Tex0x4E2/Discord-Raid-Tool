
namespace RaidTool.SubForms
{
    partial class ChangeAvatar
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.startBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.avatarPathTxt = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.panel2.Controls.Add(this.startBtn);
            this.panel2.Controls.Add(this.avatarPathTxt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(42, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 200);
            this.panel2.TabIndex = 27;
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
            this.startBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.startBtn.Image = null;
            this.startBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.startBtn.Location = new System.Drawing.Point(153, 108);
            this.startBtn.Name = "startBtn";
            this.startBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.startBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.startBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.startBtn.OnHoverForeColor = System.Drawing.Color.Red;
            this.startBtn.OnHoverImage = null;
            this.startBtn.OnPressedColor = System.Drawing.Color.Black;
            this.startBtn.Radius = 9;
            this.startBtn.Size = new System.Drawing.Size(160, 36);
            this.startBtn.TabIndex = 25;
            this.startBtn.Text = "Execute";
            this.startBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // avatarPathTxt
            // 
            this.avatarPathTxt.BackColor = System.Drawing.Color.Transparent;
            this.avatarPathTxt.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.avatarPathTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.avatarPathTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.avatarPathTxt.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.avatarPathTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.avatarPathTxt.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.avatarPathTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.avatarPathTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.avatarPathTxt.Location = new System.Drawing.Point(20, 72);
            this.avatarPathTxt.Name = "avatarPathTxt";
            this.avatarPathTxt.PasswordChar = '\0';
            this.avatarPathTxt.Radius = 5;
            this.avatarPathTxt.SelectedText = "";
            this.avatarPathTxt.Size = new System.Drawing.Size(419, 30);
            this.avatarPathTxt.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Avatar URL:";
            // 
            // ChangeAvatar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(543, 444);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeAvatar";
            this.Text = "ChangeAvatar";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaGradientButton startBtn;
        private Guna.UI.WinForms.GunaTextBox avatarPathTxt;
        private System.Windows.Forms.Label label3;
    }
}