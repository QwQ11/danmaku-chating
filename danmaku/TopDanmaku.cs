using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace danmaku {
    class TopDanmaku : Danmaku {
        const int DISAPPEAR_TIME = 5000;
        int level = 0;
        Timer timer = new Timer();

        public TopDanmaku(string text, string sender, int top, int pLevel, DanmakuManager mDanmakuManager) : base(text, mDanmakuManager, sender) {
            this.Top = top;
            this.level = pLevel;
            this.Load += Danmaku_Load;
            timer.Interval = DISAPPEAR_TIME;
            timer.Tick += TimerTick;
            this.BringToFront();
            timer.Start();
        }
        void Danmaku_Load(object sender, EventArgs e) {
            DanmakuView.Text = DANMAKU_TEXT;
            this.Width = DanmakuView.Width;
            this.Left = (mDanmakuManager.SCREEN_WIDGH + this.Width) / 2;
            timer.Start();
        }
        void TimerTick(object sender,EventArgs e) {
            mDanmakuManager.SetTopLevelAvaliable(level);
            this.Close();
        }
    }
}
