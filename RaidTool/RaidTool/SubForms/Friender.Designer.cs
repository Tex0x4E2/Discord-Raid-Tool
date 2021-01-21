
namespace RaidTool.SubForms
{
    partial class Friender
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
            this.executeFriender = new Guna.UI.WinForms.GunaGradientButton();
            this.label3 = new System.Windows.Forms.Label();
            this.userIDTxt = new Guna.UI.WinForms.GunaTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // executeFriender
            // 
            this.executeFriender.Animated = true;
            this.executeFriender.AnimationHoverSpeed = 0.07F;
            this.executeFriender.AnimationSpeed = 0.03F;
            this.executeFriender.BackColor = System.Drawing.Color.Transparent;
            this.executeFriender.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.executeFriender.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.executeFriender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.executeFriender.BorderSize = 2;
            this.executeFriender.DialogResult = System.Windows.Forms.DialogResult.None;
            this.executeFriender.FocusedColor = System.Drawing.Color.Empty;
            this.executeFriender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.executeFriender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.executeFriender.Image = null;
            this.executeFriender.ImageSize = new System.Drawing.Size(20, 20);
            this.executeFriender.Location = new System.Drawing.Point(181, 151);
            this.executeFriender.Name = "executeFriender";
            this.executeFriender.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.executeFriender.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.executeFriender.OnHoverBorderColor = System.Drawing.Color.Black;
            this.executeFriender.OnHoverForeColor = System.Drawing.Color.White;
            this.executeFriender.OnHoverImage = null;
            this.executeFriender.OnPressedColor = System.Drawing.Color.Black;
            this.executeFriender.Radius = 9;
            this.executeFriender.Size = new System.Drawing.Size(160, 35);
            this.executeFriender.TabIndex = 23;
            this.executeFriender.Text = "Execute";
            this.executeFriender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.executeFriender.Click += new System.EventHandler(this.LoadFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(178, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "User Id:";
            // 
            // userIDTxt
            // 
            this.userIDTxt.BackColor = System.Drawing.Color.Transparent;
            this.userIDTxt.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.userIDTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.userIDTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userIDTxt.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.userIDTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.userIDTxt.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.userIDTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userIDTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.userIDTxt.Location = new System.Drawing.Point(181, 115);
            this.userIDTxt.Name = "userIDTxt";
            this.userIDTxt.PasswordChar = '\0';
            this.userIDTxt.Radius = 5;
            this.userIDTxt.SelectedText = "";
            this.userIDTxt.Size = new System.Drawing.Size(160, 30);
            this.userIDTxt.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.userIDTxt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.executeFriender);
            this.panel2.Location = new System.Drawing.Point(12, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(519, 200);
            this.panel2.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-2, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(520, 36);
            this.label2.TabIndex = 25;
            this.label2.Text = "Friender is just making all the tokens send a friend request to the specific user" +
    ".\nEnter the id of the user you would like to spam with friend requests,\n";
            // 
            // Friender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(543, 444);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Friender";
            this.Text = "Friender";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientButton executeFriender;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox userIDTxt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}