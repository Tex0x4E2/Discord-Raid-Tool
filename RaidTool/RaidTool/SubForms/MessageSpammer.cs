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
    public partial class MessageSpammer : Form
    {
        public MessageSpammer()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(channelIDTxt.Text) && Utils.IsVaildID(channelIDTxt.Text) == true)
            {
                if (!String.IsNullOrEmpty(userMessageTxt.Text))
                {
                    if (userMessageTxt.Text.Length <= 2000)
                    {
                        Utils.SpamMessage = true;
                        Utils.SpamMessages(channelIDTxt.Text, userMessageTxt.Text);
                    }
                    else
                        MessageBox.Show("By default Discord's maximum message length is 2000, You can not put more than 2000 characters in a message.");
                }
                else
                    MessageBox.Show("Cannot send an empty message,");
            }
            else
                MessageBox.Show("The channel id filed is empty, Fill him with the necessary data to continue.");
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            Utils.SpamMessage = false;
        }
    }
}
