using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace danmaku {
    public partial class Danmaku : Form {
        private const uint WS_EX_LAYERED = 0x80000;
        private const int WS_EX_TRANSPARENT = 0x20;
        private const int GWL_STYLE = (-16);
        private const int GWL_EXSTYLE = (-20);
        private const int LWA_ALPHA = 0;
        const int WS_EX_NOACTIVATE = 0x08000000;

        public readonly string DANMAKU_TEXT;
        public DanmakuManager mDanmakuManager { get; set; }
        public string sender;
        
        [DllImport("user32", EntryPoint = "SetWindowLong")]
        private static extern uint SetWindowLong(IntPtr hwnd, int nIndex, uint dwNewLong);
        [DllImport("user32", EntryPoint = "GetWindowLong")]
        private static extern uint GetWindowLong(IntPtr hwnd, int nIndex);
        [DllImport("user32", EntryPoint = "SetLayeredWindowAttributes")]
        private static extern int SetLayeredWindowAttributes(IntPtr hwnd, int crKey, int bAlpha, int dwFlags);

        public Danmaku(string text, DanmakuManager pDanmakuManager, string sender) {
            InitializeComponent();
            DANMAKU_TEXT = text;
            mDanmakuManager = pDanmakuManager;
            this.sender = sender;
            this.TopMost = true;
            this.BringToFront();
            this.ShowInTaskbar = false;
        }
        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= WS_EX_NOACTIVATE;
                return cp;
            }
        }
    }
}
