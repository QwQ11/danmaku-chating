using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using AVOSCloud;
using AVOSCloud.RealtimeMessageV2;

namespace DanmakuChating {
    public partial class Main : MaterialSkin.Controls.MaterialForm {
        private readonly MaterialSkinManager materialSkinManager;

        private const string LEANCLOUD_APPID= "oJHEadE2RuF9Ak9982lxoVX5-gzGzoHsz";
        private const string LEANCLOUD_APPKEY = "rIUVqwFOvJW757xbn7jepGbi";
        private const string LEANCLOUD_DEFAULT_GROUP_ID = "5764ee7fa341310064d243d2";

        public Main() {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.LightBlue400,
                Primary.LightBlue400,
                Primary.LightBlue400,
                Accent.Blue100,
                TextShade.WHITE);
        }

        private void Main_Load(object sender, EventArgs e) {
            AVClient.Initialize(LEANCLOUD_APPID, LEANCLOUD_APPKEY);
        }

        private async void connect_Click(object sender, EventArgs e) {
            if(usernameInput.Text == "") {
                MessageBox.Show("Please enter your username.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            usernameInput.Enabled = false;
            connectBtn.Enabled = false;
            connectBtn.Text = "Connecting";

            Program.client = new AVIMClient(usernameInput.Text);
            bool r = await Program.client.ConnectAsync();
            if (!r) {
                SetRedColor();
                usernameInput.Enabled = true;
                connectBtn.Enabled = true;
                connectBtn.Text = "Failed";
                return;
            }

            Program.userName = usernameInput.Text;
            AddClientIdToClass(usernameInput.Text);
            SetBlueColor();

            ShowCAW();
        }

        void ShowCAW() {
            usernameInput.Visible = false;
            connectBtn.Visible = false;

            cawView.Visible = true;
            defaultGroupBtn.Visible = true;
            creatGroupBtn.Visible = true;
            joinBtn.Visible = true;
        }

        void ShowCreatOwnGroup() {
            cawView.Visible = false;
            defaultGroupBtn.Visible = false;
            creatGroupBtn.Visible = false;
            joinBtn.Visible = false;

            groupNameIdInput.Visible = true;
            creatJoinBtn.Visible = true;
        }

        void ShowJoin() {
            cawView.Visible = false;
            defaultGroupBtn.Visible = false;
            creatGroupBtn.Visible = false;
            joinBtn.Visible = false;

            groupNameIdInput.Visible = true;
            creatJoinBtn.Visible = true;

            groupNameIdInput.Hint = "Enter group code";
            creatJoinBtn.Text = "Join";
        }

        private void SetRedColor() {
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red100,
                Primary.Red100,
                Primary.Red100,
                Accent.Red100,
                TextShade.WHITE);
        }
        private void SetBlueColor() {
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.LightBlue400,
                Primary.LightBlue400,
                Primary.LightBlue400,
                Accent.Blue100,
                TextShade.WHITE);
        }

        private async void LoginToDefaultGroup() {
            Program.conversation = Program.client.GetConversationById(LEANCLOUD_DEFAULT_GROUP_ID);
            await Program.conversation.JoinAsync();
        }

        async void AddClientIdToClass(string userName) {
            if (Program.client == null) return;
            AVObject userNameClass = new AVObject("UserName");

            userNameClass["clientId"] = Program.client.ClientId;
            userNameClass["userName"] = userName;

            Task saveTask = userNameClass.SaveAsync();
            await saveTask;
        }

        private void usernameInput_KeyPress(object sender, KeyPressEventArgs e) {
            if(e.KeyChar == 13) {
                connect_Click(null, null);
            }
        }

        private void defaultGroupBtn_Click(object sender, EventArgs e) {
            LoginToDefaultGroup();
            this.Close();
        }

        private void creatGroupBtn_Click(object sender, EventArgs e) {
            ShowCreatOwnGroup();
        }

        private async void creatJoinBtn_Click(object sender, EventArgs e) {
            if (creatJoinBtn.Text == "Join") {
                if (groupNameIdInput.Text != "" && groupNameIdInput.Text.Length == 24) {
                    Program.conversation = Program.client.GetConversationById(groupNameIdInput.Text);
                    if (Program.conversation != null) {
                        this.Close();
                        return;
                    }
                }
                MessageBox.Show("Invaid group id!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (groupNameIdInput.Text != "") {
                Program.conversation = await Program.client.CreateChatRoomAsync(groupNameIdInput.Text);
                DialogResult rBtn = MessageBox.Show("Creat successfully,Do you want to copy group-id?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rBtn == DialogResult.Yes) {
                    Clipboard.SetText(Program.conversation.ConversationId);
                }
                this.Close();
            } else {
                MessageBox.Show("Please enter group name", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void joinBtn_Click(object sender, EventArgs e) {
            ShowJoin();
        }

        private void groupNameIdInput_KeyPress(object sender, KeyPressEventArgs e) {
            if(e.KeyChar == 13) {
                creatJoinBtn_Click(null, null);
            }
        }
    }
}
