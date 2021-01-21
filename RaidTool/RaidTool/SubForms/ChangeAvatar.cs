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
    public partial class ChangeAvatar : Form
    {
        public ChangeAvatar()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {

            Uri uriResult;
            bool result = Uri.TryCreate(avatarPathTxt.Text, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            if (result == true)
                Utils.ChangeAvatar(avatarPathTxt.Text);
            else
                MessageBox.Show("Please enter a vaild url.");
        }
    }
}
