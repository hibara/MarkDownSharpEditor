using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace setTimeZero
{
	class Program
	{
		static void Main(string[] args)
		{

			if (args.Length == 0)
			{
				return;
			}

			int addDays = 0;
			string argDays;
			DateTime dt = DateTime.Now;

			bool fWildcard = false;

			ArrayList fileList = new ArrayList();

			//引数をパース
			for (int i = 0; i < args.Length; i++)
			{
				//追加する日数
				if (args[i].IndexOf("/d") == 0)
				{
					argDays = args[i].Substring(2, args[i].Length - 2);

					if (int.TryParse(argDays, out addDays) == true)
					{
						addDays = int.Parse(argDays);
					}
					else
					{
						addDays = 0;
					}
				}
				//ワイルドカード
				else if (args[i].IndexOf("/w") == 0)
				{
					fWildcard = true;
				}
				//ファイルリストに追加する
				else
				{
					if (fWildcard == true)
					{
						fileList.Add(args[i]);	//ワイルドカードはそのまま追加
					}
					else
					{
						if (File.Exists(args[i]) == true)
						{
							fileList.Add(System.IO.Path.GetFullPath(args[i]));
						}
					}

				}

			}

			//日付を調整する（ = 0: 本日の日付）
			dt.AddDays(addDays);
			// カルチャ情報を設定する
			System.Globalization.CultureInfo cFormat = (
					new System.Globalization.CultureInfo("ja-JP", true)
			);
			// 文字列から DateTime の値に変換する
			dt = DateTime.Parse(string.Format("{0}/{1}/{2} 00:00:00", dt.Year, dt.Month, dt.Day), cFormat);

			//-----------------------------------
			//ファイル処理
			//-----------------------------------

			foreach (string FilePath in fileList)
			{

				if (fWildcard == true)
				{
					string[] files = Directory.GetFiles(
						Directory.GetCurrentDirectory(), FilePath, SearchOption.AllDirectories);

					for (int i = 0; i < files.Length; i++)
					{
						try
						{
							//作成日時の設定（現在の時間にする）
							Directory.SetCreationTime(files[i], dt);
							//更新日時の設定
							Directory.SetLastWriteTime(files[i], dt);
							//アクセス日時の設定
							Directory.SetLastAccessTime(files[i], dt);
							Console.WriteLine(files[i] + " のタイムスタンプを変更。");
						}
						catch
						{
							Console.WriteLine(files[i] + " のタイムスタンプの変更に失敗しました。");
							Console.WriteLine("別のプロセスが使用中の可能性があります。");
							break;
						}

					}

				}
				else
				{

					try
					{
						//作成日時の設定（現在の時間にする）
						Directory.SetCreationTime(FilePath, dt);
						//更新日時の設定
						Directory.SetLastWriteTime(FilePath, dt);
						//アクセス日時の設定
						Directory.SetLastAccessTime(FilePath, dt);
						Console.WriteLine(FilePath + " のタイムスタンプを変更。");
					}
					catch
					{
						Console.WriteLine(FilePath + " のタイムスタンプの変更に失敗しました。");
						Console.WriteLine("別のプロセスが使用中の可能性があります。");
						break;
					}

				}


			}//end foreach;

		}
	}
}
