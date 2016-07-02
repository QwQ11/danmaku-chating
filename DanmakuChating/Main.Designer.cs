namespace DanmakuChating {
    partial class Main {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupNameIdInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.creatGroupBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.defaultGroupBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cawView = new System.Windows.Forms.Label();
            this.usernameInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.connectBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.creatJoinBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.joinBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // groupNameIdInput
            // 
            this.groupNameIdInput.Depth = 0;
            this.groupNameIdInput.Hint = "Enter group name";
            this.groupNameIdInput.Location = new System.Drawing.Point(104, 129);
            this.groupNameIdInput.MaxLength = 32767;
            this.groupNameIdInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.groupNameIdInput.Name = "groupNameIdInput";
            this.groupNameIdInput.PasswordChar = '\0';
            this.groupNameIdInput.SelectedText = "";
            this.groupNameIdInput.SelectionLength = 0;
            this.groupNameIdInput.SelectionStart = 0;
            this.groupNameIdInput.Size = new System.Drawing.Size(298, 23);
            this.groupNameIdInput.TabIndex = 18;
            this.groupNameIdInput.TabStop = false;
            this.groupNameIdInput.UseSystemPasswordChar = false;
            this.groupNameIdInput.Visible = false;
            this.groupNameIdInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.groupNameIdInput_KeyPress);
            // 
            // creatGroupBtn
            // 
            this.creatGroupBtn.Depth = 0;
            this.creatGroupBtn.Location = new System.Drawing.Point(95, 210);
            this.creatGroupBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.creatGroupBtn.Name = "creatGroupBtn";
            this.creatGroupBtn.Primary = true;
            this.creatGroupBtn.Size = new System.Drawing.Size(316, 58);
            this.creatGroupBtn.TabIndex = 17;
            this.creatGroupBtn.Text = "Creat own group";
            this.creatGroupBtn.UseVisualStyleBackColor = true;
            this.creatGroupBtn.Visible = false;
            this.creatGroupBtn.Click += new System.EventHandler(this.creatGroupBtn_Click);
            // 
            // defaultGroupBtn
            // 
            this.defaultGroupBtn.Depth = 0;
            this.defaultGroupBtn.Location = new System.Drawing.Point(95, 146);
            this.defaultGroupBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.defaultGroupBtn.Name = "defaultGroupBtn";
            this.defaultGroupBtn.Primary = true;
            this.defaultGroupBtn.Size = new System.Drawing.Size(316, 58);
            this.defaultGroupBtn.TabIndex = 16;
            this.defaultGroupBtn.Text = "Join The Default Group";
            this.defaultGroupBtn.UseVisualStyleBackColor = true;
            this.defaultGroupBtn.Visible = false;
            this.defaultGroupBtn.Click += new System.EventHandler(this.defaultGroupBtn_Click);
            // 
            // cawView
            // 
            this.cawView.AutoSize = true;
            this.cawView.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cawView.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cawView.Location = new System.Drawing.Point(35, 80);
            this.cawView.Name = "cawView";
            this.cawView.Size = new System.Drawing.Size(274, 46);
            this.cawView.TabIndex = 15;
            this.cawView.Text = "Choose a way";
            this.cawView.Visible = false;
            // 
            // usernameInput
            // 
            this.usernameInput.BackColor = System.Drawing.Color.White;
            this.usernameInput.Depth = 0;
            this.usernameInput.Hint = "Username";
            this.usernameInput.Location = new System.Drawing.Point(122, 129);
            this.usernameInput.MaxLength = 32767;
            this.usernameInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.PasswordChar = '\0';
            this.usernameInput.SelectedText = "";
            this.usernameInput.SelectionLength = 0;
            this.usernameInput.SelectionStart = 0;
            this.usernameInput.Size = new System.Drawing.Size(248, 23);
            this.usernameInput.TabIndex = 13;
            this.usernameInput.TabStop = false;
            this.usernameInput.UseSystemPasswordChar = false;
            this.usernameInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameInput_KeyPress);
            // 
            // connectBtn
            // 
            this.connectBtn.Depth = 0;
            this.connectBtn.Location = new System.Drawing.Point(167, 201);
            this.connectBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Primary = true;
            this.connectBtn.Size = new System.Drawing.Size(159, 41);
            this.connectBtn.TabIndex = 14;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connect_Click);
            // 
            // creatJoinBtn
            // 
            this.creatJoinBtn.Depth = 0;
            this.creatJoinBtn.Location = new System.Drawing.Point(156, 201);
            this.creatJoinBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.creatJoinBtn.Name = "creatJoinBtn";
            this.creatJoinBtn.Primary = true;
            this.creatJoinBtn.Size = new System.Drawing.Size(179, 41);
            this.creatJoinBtn.TabIndex = 19;
            this.creatJoinBtn.Text = "Creat";
            this.creatJoinBtn.UseVisualStyleBackColor = true;
            this.creatJoinBtn.Visible = false;
            this.creatJoinBtn.Click += new System.EventHandler(this.creatJoinBtn_Click);
            // 
            // joinBtn
            // 
            this.joinBtn.Depth = 0;
            this.joinBtn.Location = new System.Drawing.Point(95, 273);
            this.joinBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.joinBtn.Name = "joinBtn";
            this.joinBtn.Primary = true;
            this.joinBtn.Size = new System.Drawing.Size(316, 58);
            this.joinBtn.TabIndex = 20;
            this.joinBtn.Text = "Join Group By ID";
            this.joinBtn.UseVisualStyleBackColor = true;
            this.joinBtn.Visible = false;
            this.joinBtn.Click += new System.EventHandler(this.joinBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(518, 356);
            this.Controls.Add(this.joinBtn);
            this.Controls.Add(this.creatJoinBtn);
            this.Controls.Add(this.groupNameIdInput);
            this.Controls.Add(this.creatGroupBtn);
            this.Controls.Add(this.defaultGroupBtn);
            this.Controls.Add(this.cawView);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.connectBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField groupNameIdInput;
        private MaterialSkin.Controls.MaterialRaisedButton creatGroupBtn;
        private MaterialSkin.Controls.MaterialRaisedButton defaultGroupBtn;
        private System.Windows.Forms.Label cawView;
        private MaterialSkin.Controls.MaterialSingleLineTextField usernameInput;
        private MaterialSkin.Controls.MaterialRaisedButton connectBtn;
        private MaterialSkin.Controls.MaterialRaisedButton creatJoinBtn;
        private MaterialSkin.Controls.MaterialRaisedButton joinBtn;
    }
}