using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;

namespace SocketClint
{
    public enum NotifyType
    {
        Error,
        Userexists,
        Message,
        Quit,
        GetUsers,
        NewUser
    }

    public partial class Form1 : Form
    {
        WebSocket client;
        public Form1()
        {

            InitializeComponent();
            numPort.Minimum = 1;
            numPort.Maximum = short.MaxValue;
            gbMain.Enabled = false;
            btnLogin.Click += BtnLogin_Click;
            txtMsg.KeyDown += TxtMsg_KeyDown;
        }

        private void TxtMsg_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                if (client.IsAlive)
                {
                    client.Send($"{NotifyType.Message}|{ txtMsg.Text.Replace("|", "")}|{txtUsername.Text}");
                    txtMsg.Clear();
                    txtMsg.Focus();
                }
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Enter userName");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtServer.Text))
            {
                MessageBox.Show("Enter servers url or ip address");
                return;
            }
            //login
            client = new WebSocket($"ws://{txtServer.Text}:{numPort.Value}/chatApp?name={txtUsername.Text}");
            client.OnOpen += Client_OnOpen;
            client.OnMessage += Client_OnMessage;
            client.Connect();
        }

        private void Client_OnMessage(object sender, MessageEventArgs e)
        {
            var msg = e.Data.Split("|");
            NotifyType msgType = (NotifyType)Enum.Parse(typeof(NotifyType), msg[0]);
            
            if (msgType == NotifyType.Error)
            {
                MessageBox.Show(msg[1], msg[0], MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(msgType == NotifyType.Userexists)
            {
                MessageBox.Show(msg[1], msg[0], MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.SelectAll();
                txtUsername.Focus();
                return;
            }
            else if(msgType == NotifyType.GetUsers)
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(() =>
                    {
                        lstAllUsers.Items.AddRange(msg[1].Split('\n', StringSplitOptions.RemoveEmptyEntries));
                        gbLogin.Enabled = false;
                        gbMain.Enabled = true;
                    }));
                }
                else
                {
                    lstAllUsers.Items.AddRange(msg[1].Split('\n', StringSplitOptions.RemoveEmptyEntries));
                    gbLogin.Enabled = false;
                    gbMain.Enabled = true;
                }
            }
            else if(msgType == NotifyType.NewUser)
            {
                if (lstAllUsers.Items.Contains(msg[1])) return;

                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(() =>
                    {
                        lstAllUsers.Items.Add(msg[1]);
                    }));
                }
                else
                {
                    lstAllUsers.Items.Add(msg[1]);
                }
            }
            else if(msgType == NotifyType.Message)
            {
                if (this.InvokeRequired) // if cross-thread opration
                {
                    this.Invoke(new Action(() => {
                        txtAllMessages.Text += msg[1] + Environment.NewLine;
                        txtAllMessages.SelectionStart = txtAllMessages.TextLength;
                        txtAllMessages.ScrollToCaret();
                    }));
                }
                else
                {
                    txtAllMessages.Text += msg[1] + Environment.NewLine;
                    txtAllMessages.SelectionStart = txtAllMessages.TextLength;
                    txtAllMessages.ScrollToCaret();
                }
            }

        }

        private void Client_OnOpen(object sender, EventArgs e)
        {
            //MessageBox.Show("Connection successful");
            //gbLogin.Enabled = false;
            //gbMain.Enabled = true;
        }
    }
}
