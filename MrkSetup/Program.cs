using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;

namespace MrkSetup
{
	class Program
	{

		private static string MarkDownSharpEditorPath;
		private static string MrkSetupAppPath;

		[DllImport("shell32.dll", CharSet = CharSet.Auto)]
		static extern void SHChangeNotify(long wEventId, uint uFlags, IntPtr dwItem1, IntPtr dwItem2);
		private const int SHCNE_ASSOCCHANGED = 0x08000000;
		private const int SHCNF_IDLIST = 0x0000;

		static void Main(string[] args)
		{
			string DirPath;

			//MrkSetup.exe自身のパス ( Self path )
			MrkSetupAppPath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
			DirPath = Path.GetDirectoryName(MrkSetupAppPath);
			MarkDownSharpEditorPath = Path.Combine(DirPath, "MarkDownSharpEditor.exe");

			foreach (string arg in args)
			{
				//関連付け設定
				//Association argument
				if ( arg == "-a" )
				{
					AssociateMdFiles();
					break;
				}
				//関連付け設定解除
				//Un-associatin argument
				else if ( arg == "-u" )
				{
					UnAssociateMdFiles();
					break;
				}
			}
		}

		//-----------------------------------
		// MDファイルを関連付け設定する
		// Associate .md file with this application
		//-----------------------------------
		private static bool AssociateMdFiles()
		{

			if (File.Exists(MarkDownSharpEditorPath) == false)
			{
				return(false);
			}

			//関連付ける拡張子 ( Extension )
			string Extension = ".md";
			//実行するコマンドライン ( Command line option )
			string CommandLine = "\"" + MarkDownSharpEditorPath + "\" \"%1\"";
			//ファイルタイプ名 ( File type name )
			string FileType = "MarkDown#Editor";
			//ファイルの説明 ( File description )
			string Description = "MarkDown形式ファイル";
			string Verb = "open";
			//コンテキストメニュー ( Context menu caption )
			string VerbDescription = "MarkDown#Editorで開く(&O)";
			//ファイルアイコンの番号
			int IconIndex = 1;

			//ファイル拡張子を登録 ( Regist file extension )
			Microsoft.Win32.RegistryKey regkey =
				Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(Extension);
			regkey.SetValue("", FileType);
			regkey.Close();

			//ファイルタイプとその説明を登録 ( Regist file type and description )
			Microsoft.Win32.RegistryKey shellkey =
				Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(FileType);
			shellkey.SetValue("", Description);

			//動作とその説明を登録 ( Regist verb and description ) 
			shellkey = shellkey.CreateSubKey("shell\\" + Verb);
			shellkey.SetValue("", VerbDescription);

			//コマンドラインを登録 ( Regist command line )
			shellkey = shellkey.CreateSubKey("command");
			shellkey.SetValue("", CommandLine);
			shellkey.Close();

			//アイコンの登録 ( Regist icon file )
			Microsoft.Win32.RegistryKey iconkey =
				Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(
				FileType + "\\DefaultIcon");
			iconkey.SetValue("", MarkDownSharpEditorPath + "," + IconIndex.ToString());
			iconkey.Close();

			//システムからアイコンの表示更新
			//Refresh system to view icons
			SHChangeNotify(SHCNE_ASSOCCHANGED, SHCNF_IDLIST, IntPtr.Zero, IntPtr.Zero);

			return (true);

		}

		//-----------------------------------
		// MDファイルを関連付けを解除する
		// Un-Associate .md files with this application
		//-----------------------------------
		private static bool UnAssociateMdFiles()
		{
			string Extension = ".md";
			string FileType = "MarkDown#Editor";
			//レジストリキーを削除
			//Remove registory key
			Microsoft.Win32.Registry.ClassesRoot.DeleteSubKeyTree(Extension);
			Microsoft.Win32.Registry.ClassesRoot.DeleteSubKeyTree(FileType);

			//システムからアイコンの表示更新
			//Refresh system to view icons
			SHChangeNotify(SHCNE_ASSOCCHANGED, SHCNF_IDLIST, IntPtr.Zero, IntPtr.Zero);

			return (true);
		}

	}
}
