using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace danmaku {
    public class DanmakuManager {
        private readonly int SCREEN_LEVEL_COUNT;
        public readonly int SCREEN_HEIGHT;
        public readonly int SCREEN_WIDGH;
        public const int DANMAKU_HEIGHT = 25;
        public List<Danmaku> danmakuArr;

        int move_NextLevel;
        bool[] move_LevelAvaliable;
        int top_NextLevel;
        bool[] top_LevelAvaliable;

        public DanmakuManager() {
            Rectangle r = Screen.GetWorkingArea(new Point(0,0));
            SCREEN_HEIGHT = r.Height;
            SCREEN_WIDGH = r.Width;
            SCREEN_LEVEL_COUNT = SCREEN_HEIGHT / DANMAKU_HEIGHT;
            danmakuArr = new List<Danmaku>();
            move_NextLevel = 1;
            top_NextLevel = 1;
            move_LevelAvaliable = new bool[SCREEN_LEVEL_COUNT];
            top_LevelAvaliable = new bool[SCREEN_LEVEL_COUNT];
            for (int i = 0; i < SCREEN_LEVEL_COUNT; i++) {
                move_LevelAvaliable[i] = true;
                top_LevelAvaliable[i] = true;
            }
        }

        #region MoveDanmaku
        public void AddMoveDanmaku(string str, string sender) {
            int danmakuTop = (move_NextLevel - 1) * DANMAKU_HEIGHT;
            move_LevelAvaliable[move_NextLevel - 1] = false;
            var danmaku = new MoveDanmaku(str, sender, danmakuTop, this, move_NextLevel++);
            danmakuArr.Add(danmaku);
            danmaku.FormClosed += DanmakuClose;
            danmaku.Show();

            if (move_NextLevel >= SCREEN_LEVEL_COUNT) {
                move_NextLevel++;
                move_NextLevel -= SCREEN_LEVEL_COUNT;
            }
            if (GetMoveLevelAvaliable(move_NextLevel)) {
                move_NextLevel = FindMoveNextLevel(move_NextLevel);
            }
        }
        private bool GetMoveLevelAvaliable(int index) {
            return move_LevelAvaliable[index];
        }
        private int FindMoveNextLevel(int index) {
            for (int i = index; i < SCREEN_LEVEL_COUNT; i++) {
                if (move_LevelAvaliable[i]) return ++i;
            }
            return 1;
        }
        public void SetMoveLevelAvaliable(int level) {
            move_LevelAvaliable[level] = true;
            if (level < move_NextLevel) {
                move_NextLevel = level;
            }
        }
        #endregion
        #region TopDanmaku
        public void AddTopDanmaku(string str, string sender) {
            top_LevelAvaliable[top_NextLevel - 1] = false;
            int danmakuTop = (top_NextLevel - 1) * DANMAKU_HEIGHT;
            var danmaku = new TopDanmaku(str, sender, danmakuTop, top_NextLevel++, this);
            danmakuArr.Add(danmaku);
            danmaku.FormClosed += DanmakuClose;
            danmaku.Show();
            if (top_NextLevel >= SCREEN_LEVEL_COUNT) {
                top_NextLevel++;
                top_NextLevel -= SCREEN_LEVEL_COUNT;
            }
            if (GetTopLevelAvaliable(top_NextLevel)) {
                top_NextLevel = FindTopNextLevel(top_NextLevel);
            }
        }
        private bool GetTopLevelAvaliable(int index) {
            return top_LevelAvaliable[index];
        }
        private int FindTopNextLevel(int index) {
            for (int i = index; i < SCREEN_LEVEL_COUNT; i++) {
                if (top_LevelAvaliable[i]) return ++i;
            }
            return 1;
        }
        public void SetTopLevelAvaliable(int level) {
            top_LevelAvaliable[level] = true;
            if (level < top_NextLevel) {
                top_NextLevel = level;
            }
        }
        #endregion

        public void Clear() {
            danmakuArr.Clear();
            for (int i = 0; i < SCREEN_LEVEL_COUNT; i++) {
                move_LevelAvaliable[i] = true;
                top_LevelAvaliable[i] = true;
            }
        }
        private void DanmakuClose(object sender,EventArgs e) {
            danmakuArr.Remove((Danmaku)sender);
        }
    }
}
