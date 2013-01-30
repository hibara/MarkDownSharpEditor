using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Collections;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MarkDownSharpEditor
{
	[Serializable()]
	[XmlInclude(typeof(AppHistory))]
  public class AppSettings
  {
		//-----------------------------------
		#region メンバ変数（設定値）
		//-----------------------------------
		private int _Version;
		private int _FormState;
		private System.Drawing.Point _FormPos;
		private System.Drawing.Size _FormSize;
		private int _richEditWidth;
		private string _FontFormat;
		private int _richEditForeColor;
		private bool _fSplitBarWidthEvenly;
		private bool _fViewToolBar;
		private bool _fViewStatusBar;
		private int _TabPageSelectedIndex;
		private bool _fOpenEditFileBefore;
		[XmlArrayItem(typeof(AppHistory))]
		private ArrayList _ArrayHistoryEditedFiles = new ArrayList();
		private bool _fShowHtmlSaveDialog;
		private bool _fShowHtmlToClipboardMessage;
		private bool _fHtmlHighLightColor;
		private int _HtmlHighLightColor;
		private bool _fAutoBrowserPreview;
		private int _AutoBrowserPreviewInterval;
		private bool _fSearchOptionIgnoreCase;

		//エディターのSyntaxHighlighter定義
		private int _ForeColor_MainText;                 //全体
		private int _BackColor_MainText;
		private int _ForeColor_LineBreak;                //強制改行
		private int _BackColor_LineBreak;
		[XmlArrayItem(typeof(int))]
		private int[] _ForeColor_Headlines = new int[7]; //見出し
		[XmlArrayItem(typeof(int))]
		private int[] _BackColor_Headlines = new int[7];
		private int _ForeColor_Blockquotes;              //引用
		private int _BackColor_Blockquotes;
		private int _ForeColor_Lists;                    //リスト
		private int _BackColor_Lists;
		private int _ForeColor_CodeBlocks;               //コードブロック
		private int _BackColor_CodeBlocks;
		private int _ForeColor_Horizontal;               //罫線
		private int _BackColor_Horizontal;
		private int _ForeColor_Links;                    //リンク
		private int _BackColor_Links;
		private int _ForeColor_Emphasis;                 //強調
		private int _BackColor_Emphasis;
		private int _ForeColor_Code;                     //コード
		private int _BackColor_Code;
		private int _ForeColor_Images;                   //画像
		private int _BackColor_Images;
		private int _ForeColor_Comments;                 //コメント
		private int _BackColor_Comments;

		[XmlArrayItem(typeof(string))]
		private ArrayList _ArrayCssFileList = new ArrayList();
		private bool _fHtmlOutputHeader;
		private string _HtmlDocType;
		private int _HtmlCssFileOption;
		private int _HtmlEncodingOption;
		private int _CodePageNumber;
		private int _HtmlDocTypeSelectedIndex;
		private bool _fViewAllEncoding;
		private string AppDataPath;

		//Form3の設定
		private int _ListViewColumnHeader1Width;
		private int _ListViewColumnHeader2Width;

		#endregion

		//-----------------------------------
		#region プロパティ
		//-----------------------------------
		public int Version
		{
			get { return _Version; }
			set { _Version = value; }
		}
		public int FormState
		{
			get { return _FormState; }
			set { _FormState = value; }
		}
		public System.Drawing.Point FormPos
		{
				get { return _FormPos; }
				set { _FormPos = value; }
		}
		public System.Drawing.Size FormSize
		{
				get { return _FormSize; }
				set { _FormSize = value; }
		}
		public string FontFormat
		{
				get { return _FontFormat; }
				set { _FontFormat = value; }
		}
		public int richEditForeColor
				{
			get { return _richEditForeColor; }
			set { _richEditForeColor = value; }
		}
		public int richEditWidth
		{
				get { return _richEditWidth; }
				set { _richEditWidth = value; }
		}
		public bool fSplitBarWidthEvenly
		{
				get { return _fSplitBarWidthEvenly; }
				set { _fSplitBarWidthEvenly = value; }
		}
		public bool fViewToolBar
		{
				get { return _fViewToolBar; }
				set { _fViewToolBar = value; }
		}
		public bool fViewStatusBar
		{
				get { return _fViewStatusBar; }
				set { _fViewStatusBar = value; }
		}
		public int TabPageSelectedIndex
		{
				get { return _TabPageSelectedIndex; }
				set { _TabPageSelectedIndex = value; }
		}
		public bool fOpenEditFileBefore
		{
			get { return _fOpenEditFileBefore; }
			set { _fOpenEditFileBefore = value; }
		}
		public ArrayList ArrayHistoryEditedFiles
		{
			get { return _ArrayHistoryEditedFiles; }
			set { _ArrayHistoryEditedFiles = value; }
		}
		public bool fShowHtmlSaveDialog
		{
			get { return _fShowHtmlSaveDialog; }
			set { _fShowHtmlSaveDialog = value; }
		}
		public bool fShowHtmlToClipboardMessage
		{
			get { return _fShowHtmlToClipboardMessage; }
			set { _fShowHtmlToClipboardMessage = value; }
		}
		public bool fHtmlHighLightColor
		{
			get { return _fHtmlHighLightColor; }
			set { _fHtmlHighLightColor = value; }
		}
		public int HtmlHighLightColor
		{
			get { return _HtmlHighLightColor; }
			set { _HtmlHighLightColor = value; }
		}
		public bool fAutoBrowserPreview
		{
			get { return _fAutoBrowserPreview; }
			set { _fAutoBrowserPreview = value; }
		}
		public int AutoBrowserPreviewInterval
		{
			get 
			{
				if (_AutoBrowserPreviewInterval > 3600000 || _AutoBrowserPreviewInterval < -1)
				{
					_AutoBrowserPreviewInterval = 1000;	//デフォルト値
				}
				return _AutoBrowserPreviewInterval; 
			}
			set 
			{
				//正当性のチェック
				if (value > 3600000)
				{
					value = 3600000;
				}
				else if (value < -1)
				{
					value = -1;
				}
				_AutoBrowserPreviewInterval = value; 
			}
		}
		public bool fSearchOptionIgnoreCase
		{
			get { return _fSearchOptionIgnoreCase; }
			set { _fSearchOptionIgnoreCase = value; }
		}

		//-----------------------------------
		// エディタのSyntaxHightlighter設定
		//-----------------------------------

		public int ForeColor_MainText
		{
			get { return _ForeColor_MainText; }
			set { _ForeColor_MainText = value; }
		}
		public int BackColor_MainText
		{
			get { return _BackColor_MainText; }
			set { _BackColor_MainText = value; }
		}
		public int ForeColor_LineBreak
		{
			get { return _ForeColor_LineBreak; }
			set { _ForeColor_LineBreak = value; }
		}
		public int BackColor_LineBreak
		{
			get { return _BackColor_LineBreak; }
			set { _BackColor_LineBreak = value; }
		}
		public int[] ForeColor_Headlines
		{
			get { return _ForeColor_Headlines; }
			set { _ForeColor_Headlines = value; }
		}
		public int[] BackColor_Headlines
		{
			get { return _BackColor_Headlines; }
			set { _BackColor_Headlines = value; }
		}
		public int ForeColor_Blockquotes
		{
			get { return _ForeColor_Blockquotes; }
			set { _ForeColor_Blockquotes = value; }
		}
		public int BackColor_Blockquotes
		{
			get { return _BackColor_Blockquotes; }
			set { _BackColor_Blockquotes = value; }
		}
		public int ForeColor_Lists
		{
			get { return _ForeColor_Lists; }
			set { _ForeColor_Lists = value; }
		}
		public int BackColor_Lists
		{
			get { return _BackColor_Lists; }
			set { _BackColor_Lists = value; }
		}
		public int ForeColor_CodeBlocks
		{
			get { return _ForeColor_CodeBlocks; }
			set { _ForeColor_CodeBlocks = value; }
		}
		public int BackColor_CodeBlocks
		{
			get { return _BackColor_CodeBlocks; }
			set { _BackColor_CodeBlocks = value; }
		}
		public int ForeColor_Horizontal
		{
			get { return _ForeColor_Horizontal; }
			set { _ForeColor_Horizontal = value; }
		}
		public int BackColor_Horizontal
		{
			get { return _BackColor_Horizontal; }
			set { _BackColor_Horizontal = value; }
		}
		public int ForeColor_Links
		{
			get { return _ForeColor_Links; }
			set { _ForeColor_Links = value; }
		}
		public int BackColor_Links
		{
			get { return _BackColor_Links; }
			set { _BackColor_Links = value; }
		}
		public int ForeColor_Emphasis
		{
			get { return _ForeColor_Emphasis; }
			set { _ForeColor_Emphasis = value; }
		}
		public int BackColor_Emphasis
		{
			get { return _BackColor_Emphasis; }
			set { _BackColor_Emphasis = value; }
		}
		public int ForeColor_Code
		{
			get { return _ForeColor_Code; }
			set { _ForeColor_Code = value; }
		}
		public int BackColor_Code
		{
			get { return _BackColor_Code; }
			set { _BackColor_Code = value; }
		}
		public int ForeColor_Images
		{
			get { return _ForeColor_Images; }
			set { _ForeColor_Images = value; }
		}
		public int BackColor_Images
		{
			get { return _BackColor_Images; }
			set { _BackColor_Images = value; }
		}
		public int ForeColor_Comments
		{
			get { return _ForeColor_Comments; }
			set { _ForeColor_Comments = value; }
		}
		public int BackColor_Comments
		{
			get { return _BackColor_Comments; }
			set { _BackColor_Comments = value; }
		}

		//-----------------------------------
		// CSS設定
		public ArrayList ArrayCssFileList
		{
			get { return _ArrayCssFileList; }
			set { _ArrayCssFileList = value; }
		}

		//-----------------------------------
		public bool fHtmlOutputHeader
		{
			get { return _fHtmlOutputHeader; }
			set { _fHtmlOutputHeader = value; }
		}
		public string HtmlDocType
		{
			get { return _HtmlDocType; }
			set { _HtmlDocType = value; }
		}
		public int HtmlCssFileOption
		{
			get { return _HtmlCssFileOption; }
			set { _HtmlCssFileOption = value; }
		}
		public int HtmlEncodingOption
		{
			get { return _HtmlEncodingOption; }
			set { _HtmlEncodingOption = value; }
		}
		public int CodePageNumber
		{
			get { return _CodePageNumber; }
			set { _CodePageNumber = value; }
		}
		public int HtmlDocTypeSelectedIndex
		{
			get { return _HtmlDocTypeSelectedIndex; }
			set { _HtmlDocTypeSelectedIndex = value; }
		}
		public bool fViewAllEncoding
		{
			get { return _fViewAllEncoding; }
			set { _fViewAllEncoding = value; }
		}
		public int ListViewColumnHeader1Width
		{
			get { return _ListViewColumnHeader1Width; }
			set { _ListViewColumnHeader1Width = value; }
		}
		public int ListViewColumnHeader2Width
		{
			get { return _ListViewColumnHeader2Width; }
			set { _ListViewColumnHeader2Width = value; }
		}


		#endregion
		//-----------------------------------

		//-----------------------------------
		//コンストラクタ
		//-----------------------------------
		public AppSettings()
		{
			//初期位置（スクリーン中央）
			int defautPosX = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2 - 420;
			int defautPosY = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 2 - 320;

			//AppData
			AppDataPath = GetAppDataLocalPath();
			//初期CSSディレクトリ
			string CssDirPath = Path.Combine(AppDataPath, "css");

			_Version = 0;	//バージョン
			_FormState = 0;	//WindowState = Normal;
			_FormPos.X = defautPosX;
			_FormPos.Y = defautPosY;
			_FormSize.Width = 840;
			_FormSize.Height = 640;

			_richEditWidth = 320;
			_FontFormat = "MS UI Gothic, 9pt";
			_richEditForeColor = 0;

			_fSplitBarWidthEvenly = true;
			_fViewToolBar = true;
			_fViewStatusBar = true;
            
			_TabPageSelectedIndex = 0;
			_fOpenEditFileBefore = true;
			_ArrayHistoryEditedFiles.Clear();
			_fShowHtmlSaveDialog = true;
			_fShowHtmlToClipboardMessage = true;
			_fHtmlHighLightColor = true;
			_HtmlHighLightColor = Color.FromArgb(255, 255, 200).ToArgb();
			_fAutoBrowserPreview = true;
			_AutoBrowserPreviewInterval = 1000;	//ブラウザープレビューまでの間隔（ミリ秒）

			_fSearchOptionIgnoreCase = true;	//検索オプションで大文字/小文字を区別しない

			//-----------------------------------
			// エディターのSyntax Highlighter 
			//-----------------------------------
			_ForeColor_MainText     = -16777216;     //メイン
			_BackColor_MainText     = -1;

			_ForeColor_LineBreak    = -16777216;
			_BackColor_LineBreak    = -19276; 　　   //強制改行
			_ForeColor_Headlines[0] = -16777216;     //見出し
			_ForeColor_Headlines[1] = -16777216;
			_ForeColor_Headlines[2] = -11513776;
			_ForeColor_Headlines[3] = -10197916;
			_ForeColor_Headlines[4] = -10197916;
			_ForeColor_Headlines[5] = -6250336;
			_ForeColor_Headlines[6] = -3618616;

			_BackColor_Headlines[0] = -1;
			_BackColor_Headlines[1] = -3294317;
			_BackColor_Headlines[2] = -2240591;
			_BackColor_Headlines[3] = -1581625;
			_BackColor_Headlines[4] = -1120296;
			_BackColor_Headlines[5] = -527382;
			_BackColor_Headlines[6] = -328976;

			_ForeColor_Blockquotes  = -4934476;       //引用
			_BackColor_Blockquotes  = -1;
			_ForeColor_Lists        = -3057141;       //リスト（オレンジ）
			_BackColor_Lists        = -1;
			_ForeColor_CodeBlocks   = -10197916;      //コードブロック
			_BackColor_CodeBlocks   = -986896;
			_ForeColor_Horizontal   = -1;             //罫線（紫色）
			_BackColor_Horizontal   = -6946666;
			_ForeColor_Links        = -16776961;      //リンク
			_BackColor_Links        = -1;
			_ForeColor_Emphasis     = -65536;         //強調
			_BackColor_Emphasis     = -1;
			_ForeColor_Code         = -10197916;      //コード
			_BackColor_Code         = -986896;
			_ForeColor_Images       = -16777216;
			_BackColor_Images       = -12787;         //画像
			_ForeColor_Comments     = -16731136;      //コメント
			_BackColor_Comments     = -1;

			_ArrayCssFileList.Clear();                //ビルトインCSSファイルリスト

			_fHtmlOutputHeader = false;
			_HtmlDocType = "strict";
			_HtmlCssFileOption = 0;
			_HtmlEncodingOption = 0;
			_CodePageNumber = 65001;                 //utf-8
			_HtmlDocTypeSelectedIndex = 0;
			_fViewAllEncoding = false;

			//-----------------------------------
			// Form3の設定
			//-----------------------------------
			_ListViewColumnHeader1Width = 128;
			_ListViewColumnHeader2Width = 512;

		}

		//----------------------------------------------------
		// 自分自身のインスタンスからのみこのクラスへアクセス 
		//----------------------------------------------------
		[NonSerialized()]
		private static AppSettings _instance;
		[System.Xml.Serialization.XmlIgnore]
		public static AppSettings Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new AppSettings();
				}
				return _instance;
			}
			set { _instance = value; }
		}

		//-----------------------------------
		// 設定をXMLからデシリアライズして読む
		//-----------------------------------
		public void ReadFromXMLFile()
		{
			string FilePath = Path.Combine(GetAppDataLocalPath(), "settings.config");

			if (System.IO.File.Exists(FilePath) == true)
			{
				object obj;

				try
				{
					using (FileStream fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
					{
						System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(typeof(AppSettings));
						obj = xs.Deserialize(fs);
						Instance = (AppSettings)obj;
					}
				}
				catch
				{
					//読み込み失敗
					MessageBox.Show("設定ファイルの読み込みに失敗しました。初期状態で起動します。",
					"エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					// ヒストリーデータの初期化
					Instance.InitHistoryData();
					// CSSファイルリストの初期化
					Instance.InitCssFileList();
				}
			}
			else
			{
				// ヒストリーデータの初期化
				Instance.InitHistoryData();
				// CSSファイルリストの初期化
				Instance.InitCssFileList();

			}

		}

		//-----------------------------------
		// 設定群をXMLにシリアライズして書き込む
		//-----------------------------------
		public void SaveToXMLFile()
		{
			string FilePath = Path.Combine(GetAppDataLocalPath(), "settings.config");

			//ヒストリーデータを整理してから
			OptimizeHistoryData();

			try
			{
				using (FileStream fs = new FileStream(FilePath, FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
				{
					System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(typeof(AppSettings));
					//シリアル化して書き込む
					xs.Serialize(fs, Instance);
				}
			}
			catch
			{
				//書き込み失敗
				MessageBox.Show("設定ファイルの保存に失敗しました。\n保存されずにそのまま終了します。",
				"エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}

		}

		//-----------------------------------
		// ヒストリーデータの初期化
		//-----------------------------------
		private void InitHistoryData()
		{
			// ヒストリーデータがない場合のみ初期値をセット
			if (Instance.ArrayHistoryEditedFiles.Count > 0)
			{
				foreach (AppHistory data in Instance.ArrayHistoryEditedFiles)
				{
					// どうやらXMLファイルを読んだときに空の要素が１つ作られてしまうため
					// 最初の１つの要素の内容を精査する。
					if (File.Exists(data.md) == true)
					{
						return;
					}
				}
			}

			//初期CSSディレクトリ
			string CssDirPath = Path.Combine(AppDataPath, "css");

			Instance.ArrayHistoryEditedFiles.Clear();
			AppHistory histroy = new AppHistory();
			histroy.md = Path.Combine(AppDataPath, "help.md");
			histroy.css = Path.Combine(CssDirPath, "hibara.org.css");
			Instance.ArrayHistoryEditedFiles.Add(histroy);

			histroy = new AppHistory();
			histroy.md = Path.Combine(AppDataPath, "sample.md");
			histroy.css = Path.Combine(CssDirPath, "github.css");
			Instance.ArrayHistoryEditedFiles.Add(histroy);

		}

		//-----------------------------------
		// CSSファイルリストの初期化
		//-----------------------------------
		private void InitCssFileList()
		{
			// CSSファイルリストがない場合のみ初期値のセット
			foreach (string data in Instance.ArrayCssFileList)
			{
				// どうやらXMLファイルを読んだときに空の要素が１つ作られてしまうため
				// 最初の１つの要素の内容を精査する。
				if (File.Exists(data) == true)
				{
					return;
				}
			}

			//初期CSSディレクトリ
			string CssDirPath = Path.Combine(AppDataPath, "css");
			Instance.ArrayCssFileList.Clear();
			Instance.ArrayCssFileList.Add(Path.Combine(CssDirPath, "github.css"));
			Instance.ArrayCssFileList.Add(Path.Combine(CssDirPath, "hibara.org.css"));
			Instance.ArrayCssFileList.Add(Path.Combine(CssDirPath, "markdown.css"));

		}	
			
		//-----------------------------------
		// ヒストリーデータの整理（重複削除）
		//-----------------------------------
		public void OptimizeHistoryData()
		{

			int ArrayHistoryFilesLimit = 20;

			//重複データがあれば削除する
			for (int i = 0; i < Instance.ArrayHistoryEditedFiles.Count; i++)
			{
				AppHistory HistoryData = (AppHistory)Instance.ArrayHistoryEditedFiles[i];
				for (int c = i + 1; c < Instance.ArrayHistoryEditedFiles.Count; c++)
				{
				AppHistory item = (AppHistory)Instance.ArrayHistoryEditedFiles[c];
					if (HistoryData.md == item.md)
					{
						Instance.ArrayHistoryEditedFiles.RemoveAt(c);
					}
				}
			}
			// 制限数を超えたペアは古いものから削除する
			if (Instance.ArrayHistoryEditedFiles.Count > ArrayHistoryFilesLimit)
			{
				Instance.ArrayHistoryEditedFiles.RemoveRange(
				ArrayHistoryFilesLimit, Instance.ArrayHistoryEditedFiles.Count - 1);
			}
		}

		//--------------------------------------------
		// AppData/Local/MarkDownSharp フォルダの取得
		//--------------------------------------------
		public static string GetAppDataLocalPath()
		{
			// 「C:\Users\[ユーザ名]\AppData\Roaming」取得する
			string DirPath = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			DirPath = Path.Combine(DirPath, "MarkDownSharpEditor");

			if (Directory.Exists(DirPath) == false)
			{
				Directory.CreateDirectory(DirPath);
			}

			return (DirPath);

			//実行ファイルのあるディレクトリ
			//return (Path.GetDirectoryName(Application.ExecutablePath));

		}


	}

}
