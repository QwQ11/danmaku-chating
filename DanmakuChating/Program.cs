using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AVOSCloud;
using AVOSCloud.RealtimeMessageV2;
using danmaku;

namespace DanmakuChating {
    static class Program {
        public static AVIMClient client;
        public static AVIMConversation conversation;
        public static string userName;

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
            if (client != null && conversation != null) {
                Application.Run(new MsgSend());
            }
        }
    }
}
