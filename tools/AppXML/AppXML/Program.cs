using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Xml.Serialization;

namespace AppXML
{
	public class markdownsharpeditor
	{
		public string version;
		public string date;
		public string url;
	}

	class Program
	{
		static void Main(string[] args)
		{
			int i;
			string ExeFilePath = "";
			string XmlFilePath = "";

			if (args.Length == 0)
			{
				return;
			}

			//引数をパース
			string _FilePath = "";
			for (i = 0; i < args.Length; i++)
			{
				if (File.Exists(args[i]) == true)
				{
					_FilePath = Path.GetFullPath(args[i]);
					if (Path.GetExtension(_FilePath).ToLower() == ".exe")	//実行ファイル
					{
						ExeFilePath = _FilePath;
					}
					else if (Path.GetExtension(_FilePath).ToLower() == ".xml")	//XMLファイル
					{
						XmlFilePath = _FilePath;
					}
				}
			}

			if (ExeFilePath == "")
			{
				return;
			}
			if (XmlFilePath == "")
			{
				return;
			}

			//実行ファイル情報を取得する
			FileVersionInfo vi = FileVersionInfo.GetVersionInfo(ExeFilePath);
			string VersionString = vi.FileVersion;

			//XML
			markdownsharpeditor obj = new markdownsharpeditor();
			obj.version = VersionString;
			obj.date = DateTime.Now.ToString("yyyy/MM/dd");
			obj.url = "http://hibara.org/software/jsonsharpeditor/";

			//XmlSerializer
			using (StreamWriter sw = new StreamWriter(XmlFilePath, false, Encoding.UTF8))
			{
				XmlSerializer serializer = new XmlSerializer(typeof(markdownsharpeditor));
				//"xmlns:xsi", "xmlns:xsd"の名前空間宣言を出力しない
				XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
				ns.Add("", "");
				serializer.Serialize(sw, obj, ns);
			}

		}
	}
}
