using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace danmaku {
    public class MoveDanmaku : Danmaku {
        Timer move = new Timer();
        private const int FORM_DISPLACEMENT_VALUE = 2;
        private readonly int DANMAKU_TOP;
        private int MoveInScreensDisplacementCount;
        public int level { get; set; }

        public MoveDanmaku(string text, string sender, int top, DanmakuManager pDanmakuManager, int pLevel) : base(text, pDanmakuManager, sender) {
            DANMAKU_TOP = top;
            mDanmakuManager = pDanmakuManager;
            level = pLevel;
            this.Text = "_MoveDanmaku";
            this.Load += Danmaku_Load;
            move.Start();
        }
        private void MoveDanmakuForm(object sender, EventArgs e) {
            if (this.Left + this.Width <= 0) {
                this.Close();
            }
            this.Left -= FORM_DISPLACEMENT_VALUE;
            if (MoveInScreensDisplacementCount == -1) {
                mDanmakuManager.SetMoveLevelAvaliable(level);
                MoveInScreensDisplacementCount--;
            } else if (MoveInScreensDisplacementCount >= 0) {
                MoveInScreensDisplacementCount--;
            }
        }

        void Danmaku_Load(object sender, EventArgs e) {
            this.Left = mDanmakuManager.SCREEN_WIDGH;

            DanmakuView.Text = DANMAKU_TEXT;
            this.Top = DANMAKU_TOP;
            this.Width = DanmakuView.Width;

            move.Interval = 20;
            move.Tick += MoveDanmakuForm;

            MoveInScreensDisplacementCount = Width / FORM_DISPLACEMENT_VALUE;
        }
    }
}