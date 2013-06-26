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
using System.Threading;
using System.Globalization;

namespace MarkDownSharpEditor
{
	[Serializable()]
	[XmlInclude(typeof(AppHistory))]
  public class AppSettings
  {
		//-----------------------------------
		#region メンバ変数（ Member Variable ）
		//-----------------------------------
		private int _Version;
		private int _FormState;
		private System.Drawing.Point _FormPos;
		private System.Drawing.Size _FormSize;
		private int _richEditWidth;
		private string _FontFormat;
		private int _richEditForeColor;
		private string _Lang;
		private bool _fSplitBarWidthEvenly;
		private bool _fViewToolBar;
		private bool _fViewStatusBar;
		private int _TabPageSelectedIndex;
		private int _MkColorTabPageSelectedIndex;
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
    private bool _fMarkdownExtraMode;

		//Markdown SyntaxHighlighter
		private int _ForeColor_MainText;                 //全体 ( General )
		private int _BackColor_MainText;
		private int _ForeColor_LineBreak;                //強制改行 ( Line break )
		private int _BackColor_LineBreak;
		[XmlArrayItem(typeof(int))]
		private int[] _ForeColor_Headlines = new int[7]; //見出し ( Headers )
		[XmlArrayItem(typeof(int))]
		private int[] _BackColor_Headlines = new int[7];
		private int _ForeColor_Blockquotes;              //引用 ( Blockquotes )
		private int _BackColor_Blockquotes;
		private int _ForeColor_Lists;                    //リスト ( Lists )
		private int _BackColor_Lists;
		private int _ForeColor_CodeBlocks;               //コードブロック ( Code blocks )
		private int _BackColor_CodeBlocks;
		private int _ForeColor_Horizontal;               //罫線 ( Horizontal )
		private int _BackColor_Horizontal;
		private int _ForeColor_Links;                    //リンク ( Links )
		private int _BackColor_Links;
		private int _ForeColor_Emphasis;                 //強調 ( Emphasis )
		private int _BackColor_Emphasis;
		private int _ForeColor_Code;                     //コード ( Code )
		private int _BackColor_Code;
		private int _ForeColor_Images;                   //画像 ( Images )
		private int _BackColor_Images;
		private int _ForeColor_Comments;                 //コメント ( Comments )
		private int _BackColor_Comments;

		//Markdown "Extara" SyntaxHighlighter
    private int _ForeColor_MarkdownInsideHTMLBlocks; //HTMLブロック内のMarkdown ( Markdown Inside HTML Blocks )
    private int _BackColor_MarkdownInsideHTMLBlocks;
    private int _ForeColor_SpecialAttributes;        //特殊な属性 ( Special Attributes )
    private int _BackColor_SpecialAttributes;
    private int _ForeColor_FencedCodeBlocks;         //コードブロック ( Code blocks )
    private int _BackColor_FencedCodeBlocks;
    private int _ForeColor_Tables;                   //表組み ( Tables )
    private int _BackColor_Tables;
    private int _ForeColor_DefinitionLists;          //定義リスト ( Definition Lists )
    private int _BackColor_DefinitionLists;
    private int _ForeColor_Footnotes;                //脚注 ( Footnotes )
    private int _BackColor_Footnotes;
    private int _ForeColor_Abbreviations;            //注釈 ( Abbreviations )
    private int _BackColor_Abbreviations;
    private int _ForeColor_BackslashEscapes;         //バックスラッシュエスケープ ( Backslash Escapes )
    private int _BackColor_BackslashEscapes;

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
		#region プロパティ ( Property )
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
		public string Lang
		{
			get { return _Lang; }
			set { _Lang = value; }
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
		public int MkColorTabPageSelectedIndex
		{
			get { return _MkColorTabPageSelectedIndex; }
			set { _MkColorTabPageSelectedIndex = value; }
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
					_AutoBrowserPreviewInterval = 1000;	//デフォルト値 ( Default )
				}
				return _AutoBrowserPreviewInterval; 
			}
			set 
			{
				//正当性のチェック ( Validation )
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
    public bool fMarkdownExtraMode
    {
      get { return _fMarkdownExtraMode; }
      set { _fMarkdownExtraMode = value; }
    }

		//-----------------------------------
		// SyntaxHightlighter
		//-----------------------------------

    //Markdown
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

    //Markdown Extra
    public int ForeColor_MarkdownInsideHTMLBlocks
    {
      get { return _ForeColor_MarkdownInsideHTMLBlocks; }
      set { _ForeColor_MarkdownInsideHTMLBlocks = value; }
    }
    public int BackColor_MarkdownInsideHTMLBlocks
    {
      get { return _BackColor_MarkdownInsideHTMLBlocks; }
      set { _BackColor_MarkdownInsideHTMLBlocks = value; }
    }
    public int ForeColor_SpecialAttributes
    {
      get { return _ForeColor_SpecialAttributes; }
      set { _ForeColor_SpecialAttributes = value; }
    }
    public int BackColor_SpecialAttributes
    {
      get { return _BackColor_SpecialAttributes; }
      set { _BackColor_SpecialAttributes = value; }
    }
    public int ForeColor_FencedCodeBlocks
    {
      get { return _ForeColor_FencedCodeBlocks; }
      set { _ForeColor_FencedCodeBlocks = value; }
    }
    public int BackColor_FencedCodeBlocks
    {
      get { return _BackColor_FencedCodeBlocks; }
      set { _BackColor_FencedCodeBlocks = value; }
    }
    public int ForeColor_Tables
    {
      get { return _ForeColor_Tables; }
      set { _ForeColor_Tables = value; }
    }
    public int BackColor_Tables
    {
      get { return _BackColor_Tables; }
      set { _BackColor_Tables = value; }
    }
    public int ForeColor_DefinitionLists
    {
      get { return _ForeColor_DefinitionLists; }
      set { _ForeColor_DefinitionLists = value; }
    }
    public int BackColor_DefinitionLists
    {
      get { return _BackColor_DefinitionLists; }
      set { _BackColor_DefinitionLists = value; }
    }
    public int ForeColor_Footnotes
    {
      get { return _ForeColor_Footnotes; }
      set { _ForeColor_Footnotes = value; }
    }
    public int BackColor_Footnotes
    {
      get { return _BackColor_Footnotes; }
      set { _BackColor_Footnotes = value; }
    }
    public int ForeColor_Abbreviations
    {
      get { return _ForeColor_Abbreviations; }
      set { _ForeColor_Abbreviations = value; }
    }
    public int BackColor_Abbreviations
    {
      get { return _BackColor_Abbreviations; }
      set { _BackColor_Abbreviations = value; }
    }
    public int ForeColor_BackslashEscapes
    {
      get { return _ForeColor_BackslashEscapes; }
      set { _ForeColor_BackslashEscapes = value; }
    }
    public int BackColor_BackslashEscapes
    {
      get { return _BackColor_BackslashEscapes; }
      set { _BackColor_BackslashEscapes = value; }
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
		//コンストラクタ ( Constructor )
		//-----------------------------------
		public AppSettings()
		{
			//初期位置（スクリーン中央）
			//Default window position ( in screen center )
			int defautPosX = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2 - 420;
			int defautPosY = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 2 - 320;

			//AppData
			AppDataPath = GetAppDataLocalPath();
			//初期CSSディレクトリ
			//Initial directory of CSS files
			string CssDirPath = Path.Combine(AppDataPath, "css");

			_Version = 0;                        //バージョン ( Version )
			_FormState = 0;	                     //WindowState = Normal;
			_FormPos.X = defautPosX;
			_FormPos.Y = defautPosY;
			_FormSize.Width = 840;
			_FormSize.Height = 640;

			_richEditWidth = 320;
			_FontFormat = "MS UI Gothic, 9pt";
			_richEditForeColor = 0;

			// Check culture
			if (Thread.CurrentThread.CurrentCulture.Name.StartsWith("ja") == true)
			{
				_Lang = "ja";                      // Japanese
			}
			else
			{
				_Lang = "";                        // Culture lang ( default = "" )
			}

			_fSplitBarWidthEvenly = true;
			_fViewToolBar = true;
			_fViewStatusBar = true;
            
			_TabPageSelectedIndex = 0;
			_MkColorTabPageSelectedIndex = 0;
			_fOpenEditFileBefore = true;
			_ArrayHistoryEditedFiles.Clear();
			_fShowHtmlSaveDialog = true;
			_fShowHtmlToClipboardMessage = true;
			_fHtmlHighLightColor = true;
			_HtmlHighLightColor = Color.FromArgb(255, 255, 200).ToArgb();
			_fAutoBrowserPreview = true;
			_AutoBrowserPreviewInterval = 1000;	//ブラウザープレビューまでの間隔（ミリ秒）

			_fSearchOptionIgnoreCase = true;	  //検索オプションで大文字/小文字を区別しない

      _fMarkdownExtraMode = true;        //Markdown Extra Mode

			//-----------------------------------
			// Syntax Highlighter ( Markdown )
			//-----------------------------------
			_ForeColor_MainText     = -16777216; //メイン ( General )
			_BackColor_MainText     = -1;

			_ForeColor_LineBreak    = -16777216;
			_BackColor_LineBreak    = -19276;    //強制改行 ( Line break )
			_ForeColor_Headlines[0] = -16777216; //見出し ( Headers )
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

			_ForeColor_Blockquotes  = -4934476;  //引用 ( Blockquotes)
			_BackColor_Blockquotes  = -1;
			_ForeColor_Lists        = -3057141;  //リスト ( Lists )
			_BackColor_Lists        = -1;
			_ForeColor_CodeBlocks   = -10197916; //コードブロック ( Code blocks )
			_BackColor_CodeBlocks   = -986896;
			_ForeColor_Horizontal   = -1;        //罫線 ( Horizontal )
			_BackColor_Horizontal   = -6946666;
			_ForeColor_Links        = -16776961; //リンク ( Links )
			_BackColor_Links        = -1;
			_ForeColor_Emphasis     = -65536;    //強調 ( Emphasis )
			_BackColor_Emphasis     = -1;
			_ForeColor_Code         = -10197916; //コード ( Code )
			_BackColor_Code         = -986896;
			_ForeColor_Images       = -16777216;
			_BackColor_Images       = -12787;    //画像 ( Images )
			_ForeColor_Comments     = -16731136; //コメント ( Comments )
			_BackColor_Comments     = -1;

			//-----------------------------------
			// Syntax Highlighter ( Markdown Extra )
			//-----------------------------------
			_ForeColor_MarkdownInsideHTMLBlocks = -26265;    //HTMLブロック内のMarkdown ( Markdown Inside HTML Blocks )
			_BackColor_MarkdownInsideHTMLBlocks = -1;
			_ForeColor_SpecialAttributes        = -10027161; //特殊な属性 ( Special Attributes )
			_BackColor_SpecialAttributes        = -1;
			_ForeColor_FencedCodeBlocks         = -10197916; //コードブロック区切り（Fenced Code Blocks）
			_BackColor_FencedCodeBlocks         = -986896;
			_ForeColor_Tables                   = -6697779;  //表組み ( Tables )
			_BackColor_Tables                   = -1;
			_ForeColor_DefinitionLists          = -3355545;  //定義リスト ( Definition Lists )
			_BackColor_DefinitionLists          = -1;
			_ForeColor_Footnotes                = -1;        //脚注 ( Footnotes )
			_BackColor_Footnotes                = -16777164;
			_ForeColor_Abbreviations            = -3342540;  //省略表記 ( Abbreviations )
			_BackColor_Abbreviations            = -1;
			_ForeColor_BackslashEscapes         = -6710886;  //バックスラッシュエスケープ ( Backslash Escapes )
			_BackColor_BackslashEscapes         = -1;

			//ビルトインCSSファイルリスト 
			//List of buit-in CSS files
			_ArrayCssFileList.Clear();                

			_fHtmlOutputHeader = false;
			_HtmlDocType = "strict";
			_HtmlCssFileOption = 0;
			_HtmlEncodingOption = 0;
			_CodePageNumber = 65001;             //utf-8
			_HtmlDocTypeSelectedIndex = 0;
			_fViewAllEncoding = false;

			//-----------------------------------
			// Form3
			//-----------------------------------
			_ListViewColumnHeader1Width = 128;
			_ListViewColumnHeader2Width = 512;

		}

		//----------------------------------------------------
		// 自分自身のインスタンスからのみこのクラスへアクセス
 		// This instance itself is able to access this class .
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
		// Load from XML file of settings.
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
					//Fail to read
					if (Thread.CurrentThread.CurrentCulture.Name.StartsWith("ja") == true)
					{
						MessageBox.Show("設定ファイルの読み込みに失敗しました。初期状態で起動します。",
						"エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					else
					{
						MessageBox.Show("Failed to load the file of settings. Launch with default options.",
						"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					// ヒストリーデータの初期化
					// Initialize history data
					Instance.InitHistoryData();
					// CSSファイルリストの初期化
					// Initialize list of CSS files 
					Instance.InitCssFileList();
				}
			}
			else
			{
				Instance.InitHistoryData();
				Instance.InitCssFileList();
			}

		}

		//-----------------------------------
		// 設定群をXMLにシリアライズして書き込む
		// Write to XML file of settings.
		//-----------------------------------
		public void SaveToXMLFile()
		{
			string FilePath = Path.Combine(GetAppDataLocalPath(), "settings.config");

			//ヒストリーデータを整理してから
			//
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
				//Fail to write
				if (Thread.CurrentThread.CurrentCulture.Name.StartsWith("ja") == true)
				{
					MessageBox.Show("設定ファイルの保存に失敗しました。\n保存されずにそのまま終了します。",
					"エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					MessageBox.Show("Failed writing the file of settings.\nExit without saving options.",
					"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}

			}

		}

		//-----------------------------------
		// ヒストリーデータの初期化
		// Initialize history data
		//-----------------------------------
		private void InitHistoryData()
		{
			// ヒストリーデータがない場合のみ初期値をセット
			// Set default data when history data do no exists
			if (Instance.ArrayHistoryEditedFiles.Count > 0)
			{
				foreach (AppHistory data in Instance.ArrayHistoryEditedFiles)
				{
					// どうやらXMLファイルを読んだときに空の要素が１つ作られてしまうため、最初の１つの要素の内容を精査する
					// Inspect first element because blank element is created when XML file is read. 
					if (File.Exists(data.md) == true)
					{
						return;
					}
				}
			}

			//初期CSSディレクトリ
			//Initial directory of CSS files.
			string CssDirPath = Path.Combine(AppDataPath, "css");

			Instance.ArrayHistoryEditedFiles.Clear();
			AppHistory histroy = new AppHistory();

			// Check culture
			if (Thread.CurrentThread.CurrentCulture.Name.StartsWith("ja") == true)
			{	//Japanese first
				histroy = new AppHistory();
				histroy.md = Path.Combine(AppDataPath, "help-ja.md");
				histroy.css = Path.Combine(CssDirPath, "hibara.org.css");
				Instance.ArrayHistoryEditedFiles.Add(histroy);

				histroy = new AppHistory();
				histroy.md = Path.Combine(AppDataPath, "help.md");
				histroy.css = Path.Combine(CssDirPath, "hibara.org.css");
				Instance.ArrayHistoryEditedFiles.Add(histroy);
			}
			else
			{	//Default English
				histroy = new AppHistory();
				histroy.md = Path.Combine(AppDataPath, "help.md");
				histroy.css = Path.Combine(CssDirPath, "hibara.org.css");
				Instance.ArrayHistoryEditedFiles.Add(histroy);

				histroy = new AppHistory();
				histroy.md = Path.Combine(AppDataPath, "help-ja.md");
				histroy.css = Path.Combine(CssDirPath, "hibara.org.css");
				Instance.ArrayHistoryEditedFiles.Add(histroy);
			}

			histroy = new AppHistory();
			histroy.md = Path.Combine(AppDataPath, "sample.md");
			histroy.css = Path.Combine(CssDirPath, "github.css");
			Instance.ArrayHistoryEditedFiles.Add(histroy);

		}

		//-----------------------------------
		// CSSファイルリストの初期化
		// Initialize the list of CSS files. 
		//-----------------------------------
		private void InitCssFileList()
		{
			// CSSファイルリストがない場合のみ初期値のセット
			// Set default data when the list of CSS files do not exist.
			foreach (string data in Instance.ArrayCssFileList)
			{
				// どうやらXMLファイルを読んだときに空の要素が１つ作られてしまうため、最初の１つの要素の内容を精査する
				// Inspect first element because blank element is created when XML file is read. 
				if (File.Exists(data) == true)
				{
					return;
				}
			}

			//初期CSSディレクトリ
			//Initial directory of CSS files
			string CssDirPath = Path.Combine(AppDataPath, "css");
			Instance.ArrayCssFileList.Clear();
			Instance.ArrayCssFileList.Add(Path.Combine(CssDirPath, "github.css"));
			Instance.ArrayCssFileList.Add(Path.Combine(CssDirPath, "hibara.org.css"));
			Instance.ArrayCssFileList.Add(Path.Combine(CssDirPath, "markdown.css"));

		}	
			
		//-----------------------------------
		// ヒストリーデータの整理（重複削除）
		// Remove history data if there is a duplicate data.
		//-----------------------------------
		public void OptimizeHistoryData()
		{

			int ArrayHistoryFilesLimit = 20;

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
			// Remove older data when limit of history data is over.
			if (Instance.ArrayHistoryEditedFiles.Count > ArrayHistoryFilesLimit)
			{
				Instance.ArrayHistoryEditedFiles.RemoveRange(
				ArrayHistoryFilesLimit, Instance.ArrayHistoryEditedFiles.Count - ArrayHistoryFilesLimit - 1);
			}
		}

		//--------------------------------------------
		// AppData/Local/MarkDownSharp directory
		//--------------------------------------------
		public static string GetAppDataLocalPath()
		{
			//「C:\Users\[ユーザ名]\AppData\Roaming」取得する
			// Get "C:\Users\[User name]\AppData\Roaming" path.
			string DirPath = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			DirPath = Path.Combine(DirPath, "MarkDownSharpEditor");

			if (Directory.Exists(DirPath) == false)
			{
				Directory.CreateDirectory(DirPath);
			}

			return (DirPath);

			//実行ファイルのあるディレクトリ
			//Application ExecutablePath
			//return (Path.GetDirectoryName(Application.ExecutablePath));
		}

	}

}
