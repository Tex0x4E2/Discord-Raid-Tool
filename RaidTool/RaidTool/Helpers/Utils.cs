using Discord;
using Discord.Gateway;
using Discord.Media;
using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace RaidTool
{
    class Utils
    {
        public static string SoundPath;
        public static Thread t;
        public static Thread t2;
        public static bool SpamMessage;
        public static bool JoinLeave;
        public static bool EmbedMessage;
        public static bool DmSpam;
        public static string[] tokens()
        {
            string[] to_return = MainForm.tokens.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return to_return;
        }

        //works
        public static void SpamMessages(string channelID, string message)
        {
            t2 = new Thread(() =>
            {
                startPoint:
                if(SpamMessage == true)
                {
                    Thread.Sleep(500);
                    foreach (var item in tokens())
                    {
                        t = new Thread(() =>
                        {
                            try
                            {
                                DiscordClient client = new DiscordClient();
                                client.Token = item;
                                client.SendMessage(Convert.ToUInt64(channelID), message, false);
                            }
                            catch (Exception)
                            {

                            }
                        });
                        t.Start();
                    }
                    goto startPoint;
                }
                else
                {
                    MessageBox.Show("Aborted!");
                    t2.Abort();
                }
            });
            t2.Start();
        }

        public static void JoinEarrape(string channelID, string soundPath)
        {
            SoundPath = soundPath;
            foreach (var item in tokens())
            {
                if (item.Length == 59)
                {
                    Thread t2 = new Thread(() =>
                    {
                        try
                        {
                            DiscordSocketClient client = new DiscordSocketClient();
                            ulong ID = ulong.Parse(channelID);
                            var session = client.JoinVoiceChannel(new VoiceStateProperties() { ChannelId = ID });
                            session.ReceivePackets = false;
                            session.OnConnected += Session_OnConnected;
                        }
                        catch (Exception)
                        {

                        }
                    });
                    t2.Start();
                }
            }
        } //----------------------🡾

        //                                                                                             Havent test yet.
        public static void Session_OnConnected(DiscordVoiceSession session, EventArgs e)
        {
            var audio = File.ReadAllBytes(SoundPath);
            session.OnConnected += (s, a) =>
            {
                Console.WriteLine("Speaking");

                var stream = session.CreateStream(64000);
                session.SetSpeakingState(DiscordSpeakingFlags.Soundshare);

                while (true)
                    stream.CopyFrom(audio);
            };
        }//---------🡽

        public static bool IsVaildID(string text)
        {
            return double.TryParse(text, out _);
        }

        //works
        public static void DownloadFile(string link, string path)
        {
            WebClient wb = new WebClient();
            wb.Headers.Add("User-Agent", "TyarZHDSbUdJVoHhvvcw6dUa8bQkURMXAhj9pxChX4J68Lt2a98gP625uDJA");
            wb.DownloadFile(link, path);
        }

        //works
        public static void StartFriender(string UserID)
        {
            foreach (var item in tokens())
            {
                t = new Thread(() =>
                {
                    try
                    {
                        DiscordClient client = new DiscordClient();
                        client.Token = item;
                        client.SendFriendRequest(Convert.ToUInt64(UserID));
                    }
                    catch (Exception)
                    {

                    }
                });
                t.Start();
            }
        }

        //not tested
        public static void ChangeAvatar(string avatarPath)
        {
            for(int i = 0; i < tokens().Length; i++)
            {
                foreach (var item in tokens())
                {
                    t = new Thread(() =>
                    {
                        try
                        {
                            DiscordClient client = new DiscordClient();
                            client.Token = item;
                            UserProfileUpdate prof = new UserProfileUpdate();
                            prof.Avatar = Image.FromFile(avatarPath);

                            client.User.ChangeProfile(prof);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("avatar changed for " + client.User.Username);
                        }
                        catch (Exception)
                        {

                        }
                    });
                    t.Start();
                }
            }
            t.Abort();
        }

        //works
        public static void DMSpammer(string userID, string message)
        {
            t2 = new Thread(() =>
            {
                startPoint:
                if (DmSpam == true)
                {
                    Thread.Sleep(500);
                    foreach (var item in tokens())
                    {
                        t = new Thread(() =>
                        {
                            try
                            {
                                DiscordClient client = new DiscordClient();
                                client.Token = item;
                                var i = client.CreateDM(Convert.ToUInt64(userID));
                                i.SendMessage(message);
                                i.Delete();
                            }
                            catch (Exception)
                            {

                            }
                        });
                        t.Start();
                    }
                    goto startPoint;
                }
                else
                {
                    MessageBox.Show("Aborted!");
                    t2.Abort();
                }
            });
            t2.Start();
        }

        //works
        public static void JoinLeaverSpammer(string invite, string serverID)
        {
            t2 = new Thread(() =>
            {
                startPoint:
                if (JoinLeave == true)
                {
                    foreach (var item in tokens())
                    {
                        t = new Thread(() =>
                        {
                            try
                            {
                                DiscordClient client = new DiscordClient();
                                client.Token = item;
                                client.JoinGuild(invite);
                                client.LeaveGuild(ulong.Parse(serverID));
                            }
                            catch (Exception ex)
                            {
                            }
                        });
                        t.Start();
                    }
                    goto startPoint;
                }
                else
                {
                    MessageBox.Show("Aborted!");
                    t2.Abort();
                }
            });
            t2.Start();
        }

        //works
        public static void EmbedSpammer(string title, string message, string footer, string channelID)
        {
            t2 = new Thread(() =>
            {
                startPoint:
                if (EmbedMessage == true)
                {
                    Thread.Sleep(500);
                    foreach (var item in tokens())
                    {
                        t = new Thread(() =>
                        {
                            try
                            {
                                DiscordClient client = new DiscordClient();
                                client.Token = item;
                                EmbedMaker embed = new EmbedMaker();
                                embed.Title = title;
                                embed.Description = message;
                                embed.Footer.Text = footer;
                                Thread.Sleep(500);
                                client.SendMessage(Convert.ToUInt64(channelID), embed);
                            }
                            catch (Exception)
                            {

                            }
                        });
                        t.Start();
                    }
                    goto startPoint;
                }
                else
                {
                    MessageBox.Show("Aborted!");
                    t2.Abort();
                }
            });
            t2.Start();
        }

        //works
        public static void TokenChecker(string[] tokens)
        {
            if (!Directory.Exists("Results"))
                Directory.CreateDirectory("Results");

            if (File.Exists("\\Vaild Tokens.txt"))
                File.Delete("\\Vaild Tokens.txt");

            foreach (var item in tokens)
            {
                bool vaild;
                var data = GetResponse(item);
                if (data == "Error")
                {
                    vaild = false;
                }
                else
                {
                    JObject jObj = JObject.Parse(data);
                    try
                    {
                        string Username = jObj["username"].ToString() + "#" + jObj["discriminator"].ToString();
                        vaild = true;
                    }
                    catch (Exception)
                    {
                        vaild = false;
                    }
                }
                if (vaild == true)
                {
                    File.AppendAllText("Results\\Vaild Tokens.txt", item + Environment.NewLine);
                }
            }
        }

        public static void CheckTokens()
        {
            string[] result = MainForm.tokens.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            TokenChecker(result);
        }

        //works
        public static string GetResponse(string token)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://discordapp.com/api/v6/users/@me");
                request.Headers.Set("Authorization", token);
                request.ContentType = "application/json";
                request.UserAgent = "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.11 (KHTML, like Gecko) Chrome/23.0.1271.64 Safari/537.11";
                request.Method = "GET"; request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (Exception)
            {
                return "Error";
            }
        }

        //works
        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

    }
}
