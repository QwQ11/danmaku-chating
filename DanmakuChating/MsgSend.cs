using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using danmaku;
using AVOSCloud;
using AVOSCloud.RealtimeMessageV2;

namespace DanmakuChating {
    public partial class MsgSend : Form {
        private static DanmakuManager danmakuManager;
        private delegate void SendDanmaku(string msg, string sender);

        public MsgSend() {
            InitializeComponent();
            danmakuManager = new DanmakuManager();
            this.ShowInTaskbar = false;

            Program.client.OnMessageReceieved += OnMessageReceived;
            Program.client.OnConversationMembersChanged += OnMemberJoined;
        }

        void OnMessageReceived(object sender, AVIMOnMessageReceivedEventArgs e) {
            if (e.Message is AVIMTextMessage) {
                var msg = ((AVIMTextMessage)e.Message).TextContent;
                var clientId = e.Message.FromClientId;

                SendDanmaku smd = SendMoveDanmaku_Delegate;
                this.Invoke(smd, new object[] { msg, clientId });
            }
        }

        void OnMemberJoined(object sender,AVIMOnMembersChangedEventArgs e) {
            if(e.AffectedType == AVIMConversationEventType.MembersJoined) {
                IList<string> joinedMemberClientIds = e.AffectedMembers;
                var clientId = joinedMemberClientIds.FirstOrDefault();
                var msg = clientId + " joined.";

                SendDanmaku sd = SendTopDanmaku_Delegate;
                this.Invoke(sd, new object[] { msg, "System" });
            }
        }

        void SendTopDanmaku_Delegate(string msg, string sender) {
            danmakuManager.AddTopDanmaku(msg, sender);
        }

        void SendMoveDanmaku_Delegate(string msg,string sender) {
            danmakuManager.AddMoveDanmaku(msg, sender);
        }

        static async void SendMessage(string msg,string sender) {
            await Program.conversation.SendTextMessageAsync(msg);
            danmakuManager.AddMoveDanmaku(msg, sender);
        }
        
        private void sendBtn_Click(object sender, EventArgs e) {
            msgInput.Focus();
            if(msgInput.Text == @"\exit") {
                Application.Exit();
            }
            if (msgInput.Text != "") {
                SendMessage(msgInput.Text, Program.userName);
                msgInput.Text = "";
            } else {
                MessageBox.Show("Please enter message that you want to send.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MsgSend_MouseEnter(object sender, EventArgs e) {
            if (this.Left != danmakuManager.SCREEN_WIDGH - this.Width) {
                this.Left = danmakuManager.SCREEN_WIDGH - this.Width;
                msgInput.Focus();
            }
        }

        private void msgInput_TextChanged(object sender, EventArgs e) {
            var leftT = msgInput.Text.Substring(0, msgInput.SelectionStart);

            leftT = Regex.Replace(leftT, @"(?<!\\)\\left", "←");
            leftT = Regex.Replace(leftT, @"(?<!\\)\\right", "→");

            msgInput.Text = Regex.Replace(msgInput.Text, @"(?<!\\)\\left", "←");
            msgInput.Text = Regex.Replace(msgInput.Text, @"(?<!\\)\\right", "→");

            msgInput.SelectionStart = leftT.Length;
        }

        private void msgInput_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                sendBtn_Click(null, null);
            }
        }

        private void MsgSend_Load(object sender, EventArgs e) {
            this.Left = danmakuManager.SCREEN_WIDGH - this.Width;
            this.Top = Convert.ToInt16(danmakuManager.SCREEN_HEIGHT * 0.8);
            this.TopMost = true;
            this.BringToFront();
            this.BringToFront();
            msgInput.Focus();
        }

        private void MsgSend_Click(object sender, EventArgs e) {
            msgInput.Focus();
        }

        private void msgInput_Leave(object sender, EventArgs e) {
            if (sendBtn.Focused) return;
            this.Left = danmakuManager.SCREEN_WIDGH - 22;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void copyGroupIdToolStripMenuItem_Click(object sender, EventArgs e) {
            Clipboard.SetText(Program.conversation.ConversationId);
        }

        private async void notifyMenu_Opening(object sender, CancelEventArgs e) {
            var onlineUserCount = await Program.conversation.CountMembersAsync();

            groupNameToolStripMenuItem.Text = "Group name: " + Program.conversation.Name;
            onlineUserToolStripMenuItem.Text = "Online user: " + onlineUserCount;

            danmakuToolStripMenuItem.DropDownItems.Clear();
            if (danmakuManager.danmakuArr.Count == 0) {
                var menuItem = new ToolStripMenuItem("Empty");
                danmakuToolStripMenuItem.DropDownItems.Add(menuItem);
                return;
            }
            foreach(Danmaku tDanmaku in danmakuManager.danmakuArr) {
                var str = GetDanmakuTextPreview(tDanmaku);
                str += " -- " + tDanmaku.sender;
                var menuItem = new ToolStripMenuItem(str);
                danmakuToolStripMenuItem.DropDownItems.Add(menuItem);
            }
        }
        private string GetDanmakuTextPreview(Danmaku d) {
            return d.DANMAKU_TEXT.Length > 8 ? d.DANMAKU_TEXT.Substring(0, 6) + "..." : d.DANMAKU_TEXT;
        }
    }
}
