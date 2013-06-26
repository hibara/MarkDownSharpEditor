using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;

namespace MarkDownSharpEditor
{
	static class Program
	{

		//動作設定インスタンス（どこからでも参照できるように）
		//Create settings instance ( to be able to refer from any scope. )
		public static AppSettings Settings = new AppSettings();

		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// The entry point of this application
		/// </summary>
		[STAThread]
		static void Main()
		{
			//設定を読み込む ( Read options )
			MarkDownSharpEditor.AppSettings.Instance.ReadFromXMLFile();

			// Check culture
			if (MarkDownSharpEditor.AppSettings.Instance.Lang == "ja")
			{
				Thread.CurrentThread.CurrentUICulture = new CultureInfo("ja-JP", false);
				MarkDownSharpEditor.AppSettings.Instance.Lang = "ja";
			}
			else
			{
				Thread.CurrentThread.CurrentUICulture = new CultureInfo("", false);
				MarkDownSharpEditor.AppSettings.Instance.Lang = "en";
			}
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}


	}
}
