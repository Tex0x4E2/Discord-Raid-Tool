using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaidTool.SubForms
{
    public partial class Friender : Form
    {
        public Friender()
        {
            InitializeComponent();
        }

        private void LoadFile_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(userIDTxt.Text) && userIDTxt.Text.Length == 18&& Utils.IsVaildID(userIDTxt.Text) == true)
                Utils.StartFriender(userIDTxt.Text);
            else
                MessageBox.Show("You must enter a vaild user id.");
        }
    }
}
