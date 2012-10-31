using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MarkDownSharpEditor
{
    static class Program
    {

        //動作設定インスタンス（どこからでも参照できるように）
		public static AppSettings Settings = new AppSettings();

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


    }
}
