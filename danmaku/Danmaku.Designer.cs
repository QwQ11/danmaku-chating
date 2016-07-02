namespace danmaku {
    partial class Danmaku {
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
            this.DanmakuView = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DanmakuView
            // 
            this.DanmakuView.AutoSize = true;
            this.DanmakuView.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanmakuView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.DanmakuView.Location = new System.Drawing.Point(0, 0);
            this.DanmakuView.Name = "DanmakuView";
            this.DanmakuView.Size = new System.Drawing.Size(63, 35);
            this.DanmakuView.TabIndex = 0;
            this.DanmakuView.Text = "233";
            // 
            // Danmaku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(68, 38);
            this.Controls.Add(this.DanmakuView);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Danmaku";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label DanmakuView;
    }
}