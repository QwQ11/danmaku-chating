namespace DanmakuChating {
    partial class MsgSend {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgSend));
            this.msgInput = new System.Windows.Forms.TextBox();
            this.sendBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.输入exit然后回车可以退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.输入lef或者right可以输入箭头tToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyGroupIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danmakuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msgInput
            // 
            this.msgInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.msgInput.BackColor = System.Drawing.Color.White;
            this.msgInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msgInput.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgInput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.msgInput.Location = new System.Drawing.Point(22, 15);
            this.msgInput.Name = "msgInput";
            this.msgInput.Size = new System.Drawing.Size(316, 16);
            this.msgInput.TabIndex = 0;
            this.msgInput.TabStop = false;
            this.msgInput.TextChanged += new System.EventHandler(this.msgInput_TextChanged);
            this.msgInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.msgInput_KeyPress);
            this.msgInput.Leave += new System.EventHandler(this.msgInput_Leave);
            // 
            // sendBtn
            // 
            this.sendBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sendBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(238)))));
            this.sendBtn.Depth = 0;
            this.sendBtn.Location = new System.Drawing.Point(344, 8);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.sendBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Primary = false;
            this.sendBtn.Size = new System.Drawing.Size(62, 30);
            this.sendBtn.TabIndex = 1;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.notifyMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "DanmakuChating";
            this.notifyIcon.Visible = true;
            // 
            // notifyMenu
            // 
            this.notifyMenu.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助ToolStripMenuItem,
            this.groupToolStripMenuItem,
            this.danmakuToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.notifyMenu.Name = "notifyMenu";
            this.notifyMenu.Size = new System.Drawing.Size(182, 114);
            this.notifyMenu.Opening += new System.ComponentModel.CancelEventHandler(this.notifyMenu_Opening);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.输入exit然后回车可以退出ToolStripMenuItem,
            this.输入lef或者right可以输入箭头tToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.帮助ToolStripMenuItem.Text = "Help";
            // 
            // 输入exit然后回车可以退出ToolStripMenuItem
            // 
            this.输入exit然后回车可以退出ToolStripMenuItem.Name = "输入exit然后回车可以退出ToolStripMenuItem";
            this.输入exit然后回车可以退出ToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.输入exit然后回车可以退出ToolStripMenuItem.Text = "1.Enter \\exit can exit";
            // 
            // 输入lef或者right可以输入箭头tToolStripMenuItem
            // 
            this.输入lef或者right可以输入箭头tToolStripMenuItem.Name = "输入lef或者right可以输入箭头tToolStripMenuItem";
            this.输入lef或者right可以输入箭头tToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.输入lef或者right可以输入箭头tToolStripMenuItem.Text = "2.Enter \\left or \\right  will become arrow";
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupNameToolStripMenuItem,
            this.onlineUserToolStripMenuItem,
            this.copyGroupIdToolStripMenuItem});
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.groupToolStripMenuItem.Text = "Group";
            // 
            // groupNameToolStripMenuItem
            // 
            this.groupNameToolStripMenuItem.Name = "groupNameToolStripMenuItem";
            this.groupNameToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.groupNameToolStripMenuItem.Text = "Group name:";
            // 
            // onlineUserToolStripMenuItem
            // 
            this.onlineUserToolStripMenuItem.Name = "onlineUserToolStripMenuItem";
            this.onlineUserToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.onlineUserToolStripMenuItem.Text = "Online user:";
            // 
            // copyGroupIdToolStripMenuItem
            // 
            this.copyGroupIdToolStripMenuItem.Name = "copyGroupIdToolStripMenuItem";
            this.copyGroupIdToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.copyGroupIdToolStripMenuItem.Text = "Copy group id";
            this.copyGroupIdToolStripMenuItem.Click += new System.EventHandler(this.copyGroupIdToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // danmakuToolStripMenuItem
            // 
            this.danmakuToolStripMenuItem.Name = "danmakuToolStripMenuItem";
            this.danmakuToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.danmakuToolStripMenuItem.Text = "Danmaku senders";
            // 
            // MsgSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(423, 47);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.msgInput);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "MsgSend";
            this.Text = "MsgSend";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Deactivate += new System.EventHandler(this.msgInput_Leave);
            this.Load += new System.EventHandler(this.MsgSend_Load);
            this.Click += new System.EventHandler(this.MsgSend_Click);
            this.MouseEnter += new System.EventHandler(this.MsgSend_MouseEnter);
            this.notifyMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox msgInput;
        private MaterialSkin.Controls.MaterialRaisedButton sendBtn;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 输入exit然后回车可以退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 输入lef或者right可以输入箭头tToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyGroupIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danmakuToolStripMenuItem;
    }
}