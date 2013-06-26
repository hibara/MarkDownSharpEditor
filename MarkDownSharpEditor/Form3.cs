using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using MarkDownSharpEditor.Properties;

namespace MarkDownSharpEditor
{

	public partial class Form3 : Form
	{
		[DllImport("user32.dll")]
		private static extern IntPtr SendMessage(HandleRef hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
		// 第2パラメータ：盾アイコンを設定するフラグ
		// Second parameter: shield icon flag
		uint BCM_SETSHIELD = 0x0000160C;

		public string[] BuitInCssFileListArray;
		public string[] HtmlHeaderList;
		public string SelectedCssFilePath;
		public ComboBox.ObjectCollection CombCol;

		//-----------------------------------
		// コンストラクタ
		// Constructor
		//-----------------------------------
		public Form3()
		{
			InitializeComponent();

			//関連付け設定に関するボタンにUAC盾アイコンの表示
			//View shiled icon button to associate with this application
			cmdAssociateFiles.FlatStyle = FlatStyle.System;
			HandleRef hwnd = new HandleRef(cmdAssociateFiles, cmdAssociateFiles.Handle);
			SendMessage(hwnd, BCM_SETSHIELD, new IntPtr(0), new IntPtr(1));

			cmdUnAssociateFiles.FlatStyle = FlatStyle.System;
			hwnd = new HandleRef(cmdUnAssociateFiles, cmdUnAssociateFiles.Handle);
			SendMessage(hwnd, BCM_SETSHIELD, new IntPtr(0), new IntPtr(1));
		}

		//-----------------------------------
		// フォームをロードする
		// Load form3
		//-----------------------------------
		private void Form3_Load(object sender, EventArgs e)
		{
			int i;
			var obj = MarkDownSharpEditor.AppSettings.Instance;

			//===================================
			//選択されたタブ番号
			//Selected tab number
			//-----------------------------------
			int TabIndex = obj.TabPageSelectedIndex;
			tabControl1.SelectedIndex = TabIndex;

			TabIndex = obj.MkColorTabPageSelectedIndex;
			tabControl2.SelectedIndex = TabIndex;

			//======================================================================
			//一般設定
			//GENERAL options
			//======================================================================

			//前に編集していたファイルを起動時に自動で開く
			//Open the file were edited before when application launch
			checkBoxOpenEditFileBefore.Checked = obj.fOpenEditFileBefore;

			//Markdown Extra Mode?
			if (obj.fMarkdownExtraMode == true)
			{
				comboBoxMarkdownType.SelectedIndex = 1;
				labelMarkdownExtraNotice.Visible = false;
				groupBoxMarkdownExtra.BackColor = Color.Transparent;
			}
			else
			{
				comboBoxMarkdownType.SelectedIndex = 0;
				labelMarkdownExtraNotice.Visible = true;
				groupBoxMarkdownExtra.BackColor = Color.WhiteSmoke;
			}

			//HTMLファイル出力のとき保存ダイアログを表示する(&H)
			//View save dialog in outputing to HTML file
			checkBoxShowHtmlSaveDialog.Checked = obj.fShowHtmlSaveDialog;
			//HTMLソースをクリップボードコピーしたときに確認メッセージを表示する(&M)
			//View message of confirming after HTML source copy to clipbord 
			checkBoxShowHtmlToClipboardMessage.Checked = obj.fShowHtmlToClipboardMessage;

			//編集部分をハイライトカラー表示する
			//Vew with syntax highlight color
			checkBoxEditingHighlightColor.Checked = obj.fHtmlHighLightColor;
			//編集部分のハイライトカラー
			//Syntax highlight color
			labelHighLightColor.BackColor = Color.FromArgb(obj.HtmlHighLightColor);
			labelHtmlColorName.Text = ColorTranslator.ToHtml(labelHighLightColor.BackColor);

			//ブラウザープレビューまでの間隔
			//Interval time of browser preview
			switch (obj.AutoBrowserPreviewInterval)
			{
				case -1:
					comboPreviewInterval.SelectedIndex = 0;
					break;
				case 100:
					comboPreviewInterval.SelectedIndex = 1;
					break;
				case 500:
					comboPreviewInterval.SelectedIndex = 2;
					break;
				case 1000:
					comboPreviewInterval.SelectedIndex = 3;
					break;
				case 2000:
					comboPreviewInterval.SelectedIndex = 4;
					break;
				case 3000:
					comboPreviewInterval.SelectedIndex = 5;
					break;
				case 4000:
					comboPreviewInterval.SelectedIndex = 6;
					break;
				case 5000:
					comboPreviewInterval.SelectedIndex = 7;
					break;
				case 10000:
					comboPreviewInterval.SelectedIndex = 8;
					break;
				case 30000:
					comboPreviewInterval.SelectedIndex = 9;
					break;
				case 60000:
					comboPreviewInterval.SelectedIndex = 10;
					break;
				default:	// 1000ms
					comboPreviewInterval.SelectedIndex = 3;
					break;
			}

			//======================================================================
			// エディター設定 ( Editor options )
			//======================================================================

			//Markdown SyntaxHighlighter 

			//メイン ( Main )
			labelMainColor.ForeColor = labelMainForeColor.BackColor = Color.FromArgb(obj.ForeColor_MainText);
			labelMainColor.BackColor = labelMainBackColor.BackColor = Color.FromArgb(obj.BackColor_MainText);
			labelMainForeColor.Tag = labelMainColor;
			labelMainBackColor.Tag = labelMainColor;

			//強制改行 ( Line break )
			labelLineBreakColor.ForeColor = labelLineBreakForeColor.BackColor = Color.FromArgb(obj.ForeColor_LineBreak);
			labelLineBreakColor.BackColor = labelLineBreakBackColor.BackColor = Color.FromArgb(obj.BackColor_LineBreak);
			labelLineBreakForeColor.Tag = labelLineBreakColor;
			labelLineBreakBackColor.Tag = labelLineBreakColor;
			//見出し ( Header )
			labelHeadLine1Color.ForeColor = labelHeadLine1ForeColor.BackColor = Color.FromArgb(obj.ForeColor_Headlines[1]);
			labelHeadLine1Color.BackColor = labelHeadLine1BackColor.BackColor = Color.FromArgb(obj.BackColor_Headlines[1]);
			labelHeadLine1ForeColor.Tag = labelHeadLine1Color;
			labelHeadLine1BackColor.Tag = labelHeadLine1Color;
			labelHeadLine2Color.ForeColor = labelHeadLine2ForeColor.BackColor = Color.FromArgb(obj.ForeColor_Headlines[2]);
			labelHeadLine2Color.BackColor = labelHeadLine2BackColor.BackColor = Color.FromArgb(obj.BackColor_Headlines[2]);
			labelHeadLine2ForeColor.Tag = labelHeadLine2Color;
			labelHeadLine2BackColor.Tag = labelHeadLine2Color;
			labelHeadLine3Color.ForeColor = labelHeadLine3ForeColor.BackColor = Color.FromArgb(obj.ForeColor_Headlines[3]);
			labelHeadLine3Color.BackColor = labelHeadLine3BackColor.BackColor = Color.FromArgb(obj.BackColor_Headlines[3]);
			labelHeadLine3ForeColor.Tag = labelHeadLine3Color;
			labelHeadLine3BackColor.Tag = labelHeadLine3Color;
			labelHeadLine4Color.ForeColor = labelHeadLine4ForeColor.BackColor = Color.FromArgb(obj.ForeColor_Headlines[4]);
			labelHeadLine4Color.BackColor = labelHeadLine4BackColor.BackColor = Color.FromArgb(obj.BackColor_Headlines[4]);
			labelHeadLine4ForeColor.Tag = labelHeadLine4Color;
			labelHeadLine4BackColor.Tag = labelHeadLine4Color;
			labelHeadLine5Color.ForeColor = labelHeadLine5ForeColor.BackColor = Color.FromArgb(obj.ForeColor_Headlines[5]);
			labelHeadLine5Color.BackColor = labelHeadLine5BackColor.BackColor = Color.FromArgb(obj.BackColor_Headlines[5]);
			labelHeadLine5ForeColor.Tag = labelHeadLine5Color;
			labelHeadLine5BackColor.Tag = labelHeadLine5Color;
			labelHeadLine6Color.ForeColor = labelHeadLine6ForeColor.BackColor = Color.FromArgb(obj.ForeColor_Headlines[6]);
			labelHeadLine6Color.BackColor = labelHeadLine6BackColor.BackColor = Color.FromArgb(obj.BackColor_Headlines[6]);
			labelHeadLine6ForeColor.Tag = labelHeadLine6Color;
			labelHeadLine6BackColor.Tag = labelHeadLine6Color;
			//引用 ( Blockquote )
			labelBlockquotesColor.ForeColor = labelBlockquotesForeColor.BackColor = Color.FromArgb(obj.ForeColor_Blockquotes);
			labelBlockquotesColor.BackColor = labelBlockquotesBackColor.BackColor = Color.FromArgb(obj.BackColor_Blockquotes);
			labelBlockquotesForeColor.Tag = labelBlockquotesColor;
			labelBlockquotesBackColor.Tag = labelBlockquotesColor;
			//画像 ( Image )
			labelImagesColor.ForeColor = labelImagesForeColor.BackColor = Color.FromArgb(obj.ForeColor_Images);
			labelImagesColor.BackColor = labelImagesBackColor.BackColor = Color.FromArgb(obj.BackColor_Images);
			labelImagesForeColor.Tag = labelImagesColor;
			labelImagesBackColor.Tag = labelImagesColor;
			//リンク ( Links )
			labelLinksColor.ForeColor = labelLinksForeColor.BackColor = Color.FromArgb(obj.ForeColor_Links);
			labelLinksColor.BackColor = labelLinksBackColor.BackColor = Color.FromArgb(obj.BackColor_Links);
			labelLinksForeColor.Tag = labelLinksColor;
			labelLinksBackColor.Tag = labelLinksColor;
			//強調 ( Emphasis ) 
			labelEmphasisColor.ForeColor = labelEmphasisForeColor.BackColor = Color.FromArgb(obj.ForeColor_Emphasis);
			labelEmphasisColor.BackColor = labelEmphasisBackColor.BackColor = Color.FromArgb(obj.BackColor_Emphasis);
			labelEmphasisForeColor.Tag = labelEmphasisColor;
			labelEmphasisBackColor.Tag = labelEmphasisColor;
			//リスト ( Lists )
			labelListsColor.ForeColor = labelListsForeColor.BackColor = Color.FromArgb(obj.ForeColor_Lists);
			labelListsColor.BackColor = labelListsBackColor.BackColor = Color.FromArgb(obj.BackColor_Lists);
			labelListsForeColor.Tag = labelListsColor;
			labelListsBackColor.Tag = labelListsColor;
			//コード ( Source code )
			labelCodeColor.ForeColor = labelCodeForeColor.BackColor = Color.FromArgb(obj.ForeColor_Code);
			labelCodeColor.BackColor = labelCodeBackColor.BackColor = Color.FromArgb(obj.BackColor_Code);
			labelCodeForeColor.Tag = labelCodeColor;
			labelCodeBackColor.Tag = labelCodeColor;
			//コードブロック ( Code block )
			labelCodeBlockColor.ForeColor = labelCodeBlockForeColor.BackColor = Color.FromArgb(obj.ForeColor_CodeBlocks);
			labelCodeBlockColor.BackColor = labelCodeBlockBackColor.BackColor = Color.FromArgb(obj.BackColor_CodeBlocks);
			labelCodeBlockForeColor.Tag = labelCodeBlockColor;
			labelCodeBlockBackColor.Tag = labelCodeBlockColor;
			//罫線 ( Horizontal )
			labelHorizontalColor.ForeColor = labelHorizontalForeColor.BackColor = Color.FromArgb(obj.ForeColor_Horizontal);
			labelHorizontalColor.BackColor = labelHorizontalBackColor.BackColor = Color.FromArgb(obj.BackColor_Horizontal);
			labelHorizontalForeColor.Tag = labelHorizontalColor;
			labelHorizontalBackColor.Tag = labelHorizontalColor;
			//コメント ( Comment )
			labelCommentsColor.ForeColor = labelCommentsForeColor.BackColor = Color.FromArgb(obj.ForeColor_Comments);
			labelCommentsColor.BackColor = labelCommentsBackColor.BackColor = Color.FromArgb(obj.BackColor_Comments);
			labelCommentsForeColor.Tag = labelCommentsColor;
			labelCommentsBackColor.Tag = labelCommentsColor;

			//Markdown "Extra" SyntaxHighlighter 

			if (obj.fMarkdownExtraMode == true)
			{
				labelMarkdownExtraNotice.Visible = false;
				groupBoxMarkdownExtra.BackColor = Color.Transparent;
				labelMarkdownExtraNotice.Visible = false;
			}
			else
			{
				labelMarkdownExtraNotice.Visible = true;
				groupBoxMarkdownExtra.BackColor = Color.WhiteSmoke;
				labelMarkdownExtraNotice.Visible = true;
			}

			//HTMLブロック内のMarkdown ( Markdown Inside HTML Blocks )
			labelMarkdownInsideHTMLBlocksColor.ForeColor = labelMarkdownInsideHTMLBlocksForeColor.BackColor = Color.FromArgb(obj.ForeColor_MarkdownInsideHTMLBlocks);
			labelMarkdownInsideHTMLBlocksColor.BackColor = labelMarkdownInsideHTMLBlocksBackColor.BackColor = Color.FromArgb(obj.BackColor_MarkdownInsideHTMLBlocks);
			labelMarkdownInsideHTMLBlocksForeColor.Tag = labelMarkdownInsideHTMLBlocksColor;
			labelMarkdownInsideHTMLBlocksBackColor.Tag = labelMarkdownInsideHTMLBlocksColor;
			//特殊な属性 ( Special Attributes )
			labelSpecialAttributesColor.ForeColor = labelSpecialAttributesForeColor.BackColor = Color.FromArgb(obj.ForeColor_SpecialAttributes);
			labelSpecialAttributesColor.BackColor = labelMarkdownInsideHTMLBlocksBackColor.BackColor = Color.FromArgb(obj.BackColor_SpecialAttributes);
			labelSpecialAttributesForeColor.Tag = labelSpecialAttributesColor;
			labelSpecialAttributesBackColor.Tag = labelSpecialAttributesColor;
			//コードブロック ( Code blocks )
			labelFencedCodeBlocksColor.ForeColor = labelFencedCodeBlocksForeColor.BackColor = Color.FromArgb(obj.ForeColor_FencedCodeBlocks);
			labelFencedCodeBlocksColor.BackColor = labelFencedCodeBlocksBackColor.BackColor = Color.FromArgb(obj.BackColor_FencedCodeBlocks);
			labelFencedCodeBlocksForeColor.Tag = labelFencedCodeBlocksColor;
			labelFencedCodeBlocksBackColor.Tag = labelFencedCodeBlocksColor;
			//表組み ( Tables )
			labelTablesColor.ForeColor = labelTablesForeColor.BackColor = Color.FromArgb(obj.ForeColor_Tables);
			labelTablesColor.BackColor = labelTablesBackColor.BackColor = Color.FromArgb(obj.BackColor_Tables);
			labelTablesForeColor.Tag = labelTablesColor;
			labelTablesBackColor.Tag = labelTablesColor;
			//定義リスト ( Definition Lists )
			labelDefinitionListsColor.ForeColor = labelDefinitionListsForeColor.BackColor = Color.FromArgb(obj.ForeColor_DefinitionLists);
			labelDefinitionListsColor.BackColor = labelDefinitionListsBackColor.BackColor = Color.FromArgb(obj.BackColor_DefinitionLists);
			labelDefinitionListsForeColor.Tag = labelDefinitionListsColor;
			labelDefinitionListsBackColor.Tag = labelDefinitionListsColor;
			//脚注 ( Footnotes )
			labelFootnotesColor.ForeColor = labelFootnotesForeColor.BackColor = Color.FromArgb(obj.ForeColor_Footnotes);
			labelFootnotesColor.BackColor = labelFootnotesBackColor.BackColor = Color.FromArgb(obj.BackColor_Footnotes);
			labelFootnotesForeColor.Tag = labelFootnotesColor;
			labelFootnotesBackColor.Tag = labelFootnotesColor;
			//注釈 ( Abbreviations )
			labelAbbreviationsColor.ForeColor = labelAbbreviationsForeColor.BackColor = Color.FromArgb(obj.ForeColor_Abbreviations);
			labelAbbreviationsColor.BackColor = labelAbbreviationsBackColor.BackColor = Color.FromArgb(obj.BackColor_Abbreviations);
			labelAbbreviationsForeColor.Tag = labelAbbreviationsColor;
			labelAbbreviationsBackColor.Tag = labelAbbreviationsColor;
			//バックスラッシュエスケープ ( Backslash Escapes )
			labelBackslashEscapesColor.ForeColor = labelBackslashEscapesForeColor.BackColor = Color.FromArgb(obj.ForeColor_BackslashEscapes);
			labelBackslashEscapesColor.BackColor = labelBackslashEscapesBackColor.BackColor = Color.FromArgb(obj.BackColor_BackslashEscapes);
			labelBackslashEscapesForeColor.Tag = labelBackslashEscapesColor;
			labelBackslashEscapesBackColor.Tag = labelBackslashEscapesColor;

			//======================================================================
			// CSS設定 
			// CSS options
			//======================================================================

			//CSSファイルリストの更新
			//Refresh CSS file list
			RefreshCssFileList();
			listViewCssFiles.Columns[0].Width = obj.ListViewColumnHeader1Width;
			listViewCssFiles.Columns[1].Width = obj.ListViewColumnHeader2Width;

			//======================================================================
			// HTMLファイル出力の設定
			// HTML output options
			//======================================================================

			//出力するHTMLファイルにヘッダ（DOCTYPE等）を挿入する(&D)
			//Insert header data to HTML file to output
			chkInsertHtmlHeader.Checked = obj.fHtmlOutputHeader;

			//HTMLヘッダリストを表示
			//View HTML header list
			HtmlHeaderList = new HtmlHeader().GetHeaderTypeList();
			comboBoxHtmlHeader.Items.Clear();

			int HtmlDocTypeSelectedIndex = 0;
			for (i = 0; i < HtmlHeaderList.Length; i++)
			{
				if (HtmlHeaderList[i] == obj.HtmlDocType)
				{
					HtmlDocTypeSelectedIndex = i;
				}
				comboBoxHtmlHeader.Items.Add(HtmlHeaderList[i]);
			}
			comboBoxHtmlHeader.SelectedIndex = HtmlDocTypeSelectedIndex;

			if (chkInsertHtmlHeader.Checked == true)
			{
				comboBoxHtmlHeader.Enabled = true;
				comboBoxHtmlHeader.BackColor = SystemColors.Window;
			}
			else
			{
				comboBoxHtmlHeader.Enabled = false;
				comboBoxHtmlHeader.BackColor = SystemColors.ButtonFace;
			}

			//-----------------------------------
			//CSSのファイル指定
			//Selected CSS file
			//-----------------------------------
			if (obj.HtmlCssFileOption == 0)
			{
				radioButtonImportCssFile.Checked = true;
			}
			else
			{
				radioButtonInsertLinkTag.Checked = true;
			}

			//-----------------------------------
			//エンコーディング
			//Encoding
			//-----------------------------------
			DataTable dtEncoding = new DataTable();
			dtEncoding.Columns.Add("id");
			dtEncoding.Columns.Add("name");

			foreach (EncodingInfo ei in Encoding.GetEncodings())
			{
				if (ei.GetEncoding().IsBrowserDisplay == true)
				{
					dtEncoding.Rows.Add(ei.CodePage, ei.DisplayName);
				}
			}
			comboBoxSelectEncoding.DataSource = dtEncoding;
			comboBoxSelectEncoding.ValueMember = "id";
			comboBoxSelectEncoding.DisplayMember = "name";

			try
			{
				comboBoxSelectEncoding.SelectedValue = obj.CodePageNumber;
			}
			catch  //万が一、設定のコードページがなかった場合 ( If encoding is not found... )
			{
				if (comboBoxSelectEncoding.Items.Count > 0)
				{
					comboBoxSelectEncoding.SelectedIndex = 0;
				}
			}

			//-----------------------------------
			//エンコーディングの指定
			//Select encoding
			if (obj.HtmlEncodingOption == 0)
			{
				radioButtonDefaultEncoding.Checked = true;
			}
			else
			{
				radioButtonChangeEncoding.Checked = true;
			}
			cmdApply.Enabled = false;
		}

		//-----------------------------------
		// フォームにフォーカス
		// Focus to form3
		//-----------------------------------
		private void Form3_Enter(object sender, EventArgs e)
		{
			//「CSS設定」が開いているときのみ
			// If "CSS options" tab is open only
			if (tabControl1.SelectedTab == tabPageCSS)
			{
				//ビルトインCSSファイルリストの更新
				//Refresh Buit-in CSS file lists
				RefreshCssFileList();
			}
		}

		//-----------------------------------
		// CSSリストの更新
		// Refresh CSS lists
		//-----------------------------------
		private void RefreshCssFileList()
		{
			listViewCssFiles.Items.Clear();

			for (int i = 0; i < MarkDownSharpEditor.AppSettings.Instance.ArrayCssFileList.Count; i++)
			{
				string FilePath = (string)MarkDownSharpEditor.AppSettings.Instance.ArrayCssFileList[i];
				ListViewItem item = new ListViewItem(Path.GetFileName(FilePath));

				if (i == 0)
				{
					item.Text = item.Text + Resources.MsgDefaultCSS;	// "(デフォルト)" "(Default)";
					item.Font = new Font(this.Font, FontStyle.Bold);
				}
				item.Tag = FilePath;
				item.SubItems.Add(Path.GetDirectoryName(FilePath));
				listViewCssFiles.Items.Add(item);
			}
		}

		//-----------------------------------
		//「フォームを閉じる」
		// FromClosed event
		//-----------------------------------
		private void Form3_FormClosed(object sender, FormClosedEventArgs e)
		{
			//選択中のタブ番号
			//Selected tab number
			MarkDownSharpEditor.AppSettings.Instance.TabPageSelectedIndex = tabControl1.SelectedIndex;
			MarkDownSharpEditor.AppSettings.Instance.MkColorTabPageSelectedIndex = tabControl2.SelectedIndex;
		}

		//-----------------------------------
		//「適用」ボタン（設定を保存する）
		// "Apply" button click
		//-----------------------------------
		private void cmdApply_Click(object sender, EventArgs e)
		{
			var obj = MarkDownSharpEditor.AppSettings.Instance;

			//-----------------------------------
			//一般設定 ( GENERAL options )
			//-----------------------------------

			//前に編集していたファイルを起動時に自動で開く
			//Open file edited before automatically. 
			obj.fOpenEditFileBefore = checkBoxOpenEditFileBefore.Checked;
			//Markdown Extra mode
			obj.fMarkdownExtraMode = comboBoxMarkdownType.SelectedIndex == 1 ? true : false;
			//HTMLファイル出力のとき保存ダイアログを表示する(&H)
			//&Show save dialog to output HTML file
			obj.fShowHtmlSaveDialog = checkBoxShowHtmlSaveDialog.Checked;
			//HTMLソースをクリップボードコピーしたときに確認メッセージを表示する(&M)
			//Show &message dialog in outputing HTML source to clipboard
			obj.fShowHtmlToClipboardMessage = checkBoxShowHtmlToClipboardMessage.Checked;

			//編集部分をハイライトカラー表示するか
			//&View hightlight color in editing paragraph
			obj.fHtmlHighLightColor = checkBoxEditingHighlightColor.Checked;
			//編集部分のハイライトカラー
			//The hightlight color
			obj.HtmlHighLightColor = labelHighLightColor.BackColor.ToArgb();
			//ブラウザープレビューまでの間隔
			//Interval time of previwing
			switch (comboPreviewInterval.SelectedIndex)
			{
				case 0: //Manual Update
					obj.AutoBrowserPreviewInterval = -1;
					break;
				case 1:
					obj.AutoBrowserPreviewInterval = 100;
					break;
				case 2:
					obj.AutoBrowserPreviewInterval = 500;
					break;
				case 3:
					obj.AutoBrowserPreviewInterval = 1000;
					break;
				case 4:
					obj.AutoBrowserPreviewInterval = 2000;
					break;
				case 5:
					obj.AutoBrowserPreviewInterval = 3000;
					break;
				case 6:
					obj.AutoBrowserPreviewInterval = 4000;
					break;
				case 7:
					obj.AutoBrowserPreviewInterval = 5000;
					break;
				case 8:
					obj.AutoBrowserPreviewInterval = 10000;
					break;
				case 9:
					obj.AutoBrowserPreviewInterval = 30000;
					break;
				case 10:
					obj.AutoBrowserPreviewInterval = 60000;
					break;
				default:  // default = 1 sec.
					obj.AutoBrowserPreviewInterval = 1000;
					break;
			}

			//-----------------------------------
			// エディター(SyntaxHighlighter)設定
			// SyntaxHighlighter in Text Editor settings
			//-----------------------------------
			obj.ForeColor_MainText = labelMainColor.ForeColor.ToArgb();           //全般 ( Genaral )
			obj.BackColor_MainText = labelMainColor.BackColor.ToArgb();
			obj.ForeColor_LineBreak = labelLineBreakColor.ForeColor.ToArgb();     //強制改行 ( Line break )
			obj.BackColor_LineBreak = labelLineBreakColor.BackColor.ToArgb();
			obj.ForeColor_Headlines[1] = labelHeadLine1Color.ForeColor.ToArgb();  //見出し１ ( Header 1 )
			obj.BackColor_Headlines[1] = labelHeadLine1Color.BackColor.ToArgb();
			obj.ForeColor_Headlines[2] = labelHeadLine2Color.ForeColor.ToArgb();  //見出し２ ( Header 2 )
			obj.BackColor_Headlines[2] = labelHeadLine2Color.BackColor.ToArgb();
			obj.ForeColor_Headlines[3] = labelHeadLine3Color.ForeColor.ToArgb();  //見出し３ ( Header 3 )
			obj.BackColor_Headlines[3] = labelHeadLine3Color.BackColor.ToArgb();
			obj.ForeColor_Headlines[4] = labelHeadLine4Color.ForeColor.ToArgb();  //見出し４ ( Header 4 )
			obj.BackColor_Headlines[4] = labelHeadLine4Color.BackColor.ToArgb();
			obj.ForeColor_Headlines[5] = labelHeadLine5Color.ForeColor.ToArgb();  //見出し５ ( Header 5 )
			obj.BackColor_Headlines[5] = labelHeadLine5Color.BackColor.ToArgb();
			obj.ForeColor_Headlines[6] = labelHeadLine6Color.ForeColor.ToArgb();  //見出し６ ( Header 6 )
			obj.BackColor_Headlines[6] = labelHeadLine6Color.BackColor.ToArgb();
			obj.ForeColor_Blockquotes = labelBlockquotesColor.ForeColor.ToArgb(); //引用 ( Blockquote )
			obj.BackColor_Blockquotes = labelBlockquotesColor.BackColor.ToArgb();
			obj.ForeColor_Lists = labelListsColor.ForeColor.ToArgb();             //リスト ( Lists )
			obj.BackColor_Lists = labelListsColor.BackColor.ToArgb();
			obj.ForeColor_CodeBlocks = labelCodeBlockColor.ForeColor.ToArgb();    //コードブロック ( Code block )
			obj.BackColor_CodeBlocks = labelCodeBlockColor.BackColor.ToArgb();
			obj.ForeColor_Horizontal = labelHorizontalColor.ForeColor.ToArgb();   //罫線 ( Horizontal )
			obj.BackColor_Horizontal = labelHorizontalColor.BackColor.ToArgb();
			obj.ForeColor_Links = labelLinksColor.ForeColor.ToArgb();             //リンク ( Links )
			obj.BackColor_Links = labelLinksColor.BackColor.ToArgb();
			obj.ForeColor_Emphasis = labelEmphasisColor.ForeColor.ToArgb();       //強調 ( Emphasis )
			obj.BackColor_Emphasis = labelEmphasisColor.BackColor.ToArgb();
			obj.ForeColor_Code = labelCodeColor.ForeColor.ToArgb();               //ソースコード ( Source code )
			obj.BackColor_Code = labelCodeColor.BackColor.ToArgb();
			obj.ForeColor_Images = labelImagesColor.ForeColor.ToArgb();           //画像 ( Image )
			obj.BackColor_Images = labelImagesColor.BackColor.ToArgb();
			obj.ForeColor_Comments = labelCommentsColor.ForeColor.ToArgb();       //コメント ( Comment )
			obj.BackColor_Comments = labelCommentsColor.BackColor.ToArgb();
			//Extra
			obj.ForeColor_MarkdownInsideHTMLBlocks = labelMarkdownInsideHTMLBlocksColor.ForeColor.ToArgb(); //HTMLブロック内のMarkdown ( Markdown Inside HTML Blocks )
			obj.BackColor_MarkdownInsideHTMLBlocks = labelMarkdownInsideHTMLBlocksColor.BackColor.ToArgb();
			obj.ForeColor_SpecialAttributes = labelSpecialAttributesColor.ForeColor.ToArgb();               //特殊な属性 ( Special Attributes )
			obj.BackColor_SpecialAttributes = labelSpecialAttributesColor.BackColor.ToArgb();
			obj.ForeColor_FencedCodeBlocks = labelFencedCodeBlocksColor.ForeColor.ToArgb();                 //コードブロック ( Code blocks )
			obj.BackColor_FencedCodeBlocks = labelFencedCodeBlocksColor.BackColor.ToArgb();
			obj.ForeColor_Tables = labelTablesColor.ForeColor.ToArgb();                                     //表組み ( Tables )
			obj.BackColor_Tables = labelTablesColor.BackColor.ToArgb();
			obj.ForeColor_DefinitionLists = labelDefinitionListsColor.ForeColor.ToArgb();                   //定義リスト ( Definition Lists )
			obj.BackColor_DefinitionLists = labelDefinitionListsColor.BackColor.ToArgb();
			obj.ForeColor_Footnotes = labelFootnotesColor.ForeColor.ToArgb();                               //脚注 ( Footnotes )
			obj.BackColor_Footnotes = labelFootnotesColor.BackColor.ToArgb();
			obj.ForeColor_Abbreviations = labelAbbreviationsColor.ForeColor.ToArgb();                       //注釈 ( Abbreviations )
			obj.BackColor_Abbreviations = labelAbbreviationsColor.BackColor.ToArgb();
			obj.ForeColor_BackslashEscapes = labelBackslashEscapesColor.ForeColor.ToArgb();                 //バックスラッシュエスケープ ( Backslash Escapes )
			obj.BackColor_BackslashEscapes = labelBackslashEscapesColor.BackColor.ToArgb();

			//-----------------------------------
			// CSSファイル設定
			// CSS file settings
			//-----------------------------------
			obj.ArrayCssFileList.Clear();
			for (int i = 0; i < listViewCssFiles.Items.Count; i++)
			{
				string FilePath = (string)listViewCssFiles.Items[i].Tag;
				if (File.Exists(FilePath) == true)
				{
					obj.ArrayCssFileList.Add(FilePath);
				}
			}
			//カラム幅
			//List view column width
			obj.ListViewColumnHeader1Width = listViewCssFiles.Columns[0].Width;
			obj.ListViewColumnHeader2Width = listViewCssFiles.Columns[1].Width;

			//-----------------------------------
			// HTML出力
			// HTML output settings
			//-----------------------------------

			//出力するHTMLファイルにヘッダ（DOCTYPE等）を挿入する(&D)
			//Insert header data in output HTML file
			obj.fHtmlOutputHeader = chkInsertHtmlHeader.Checked;
			//DOCTYPE
			obj.HtmlDocType = comboBoxHtmlHeader.Text;

			if (radioButtonInsertLinkTag.Checked == true)
			{
				//<LINK>タグとして挿入する(&K)
				//Insert <LINK> tag instead of header data
				obj.HtmlCssFileOption = 1;
			}
			else
			{
				//CSSファイルの内容をHTMLファイルに埋め込む(&I)
				//Embeded contents of CSS file in HTML file
				obj.HtmlCssFileOption = 0;
			}

			if (radioButtonChangeEncoding.Checked == true)
			{
				//現在のエンコーディングを変更する(&C)
				//Change HTML character encoding
				obj.HtmlEncodingOption = 1;
			}
			else
			{
				//編集中のエンコーディングを使用する(&D)
				//Apply encoding of editing file
				obj.HtmlEncodingOption = 0;
			}
			//選択されたエンコーディングのコードページを保存
			//Save the code page of selected encoding 
			obj.CodePageNumber = Convert.ToInt32(comboBoxSelectEncoding.SelectedValue);
			//ファイルに設定を保存
			//Save settings to file
			obj.SaveToXMLFile();
			//obj.SaveToJsonFile();
			cmdApply.Enabled = false;
		}

		//-----------------------------------
		//「OK」ボタン
		// "OK" Button
		//-----------------------------------
		private void cmdOK_Click(object sender, EventArgs e)
		{
			cmdApply_Click(sender, e);
			this.Close();
		}

		//-----------------------------------
		//「キャンセル」ボタン
		// "Cancel" Button
		//-----------------------------------
		private void cmdCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		//-----------------------------------
		//「AppData」フォルダーを開くボタン
		// Open the "AppData" folder Button
		//-----------------------------------
		private void cmdAppDataFolder_Click(object sender, EventArgs e)
		{
			string _AppDataFolderPath = MarkDownSharpEditor.AppSettings.GetAppDataLocalPath();
			System.Diagnostics.Process.Start("EXPLORER.EXE", String.Format(@"/n, {0}", _AppDataFolderPath));
		}

		//======================================================================
		#region tabControlのアクセスキー処理 ( Process access key of TabPage )
		//===================================

		protected override bool ProcessMnemonic(char charCode)
		{
			foreach (TabPage tp in tabControl1.TabPages)
			{
				if (IsMnemonic(charCode, tp.Text))
				{
					tabControl1.SelectedTab = tp;
					return true;
				}
			}
			return base.ProcessMnemonic(charCode);
		}

		#endregion

		//======================================================================
		#region 「全般設定」タブ ( "GENERAL" setting Tab )
		//======================================================================

		//-----------------------------------------------------------
		// Markdown Extra Mode
		//-----------------------------------------------------------
		private void comboBoxMarkdownType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxMarkdownType.SelectedIndex == 1)	// Markdown Extra
			{
				labelMarkdownExtraNotice.Visible = false;
				groupBoxMarkdownExtra.BackColor = Color.Transparent;
			}
			else
			{
				labelMarkdownExtraNotice.Visible = true;
				groupBoxMarkdownExtra.BackColor = Color.WhiteSmoke;
			}
			cmdApply.Enabled = true;
		}

		//-----------------------------------------------------------
		// 権限昇格させ関連付け設定ツールを呼び出す（関連付け）
		// Association Tool executes with UAC.
		//-----------------------------------------------------------
		private void cmdAssociateFiles_Click(object sender, EventArgs e)
		{
			//Launch other tool of associating .md file
			RunElevated("-a");
		}

		//-----------------------------------------------------------
		// 権限昇格させ関連付け設定ツールを呼び出す（関連付け・解除）
		// Un-Association Tool executes with UAC.
		//-----------------------------------------------------------
		private void cmdUnAssociateFiles_Click(object sender, EventArgs e)
		{
			//Launch other tool of un-associating .md file
			RunElevated("-u");
		}

		//-----------------------------------------------------------
		// 関連付け設定ツールの呼び出し
		// Launch other tool of associating .md file
		//-----------------------------------------------------------
		public static bool RunElevated(string arguments)
		{
			string AppDirPath = Path.GetDirectoryName(Application.ExecutablePath);
			string MrkSetupAppPath = Path.Combine(AppDirPath, "MrkSetup.exe");

			if (File.Exists(MrkSetupAppPath) == false)
			{
				//"エラー"
				//"関連付けツールが見つかりません。関連付け設定に失敗しました。"
				//"Error"
				//"Association tool is not found, therefore failed to associate .md files with this application."
				MessageBox.Show(
					Resources.MsgNotFoundAssociationTool + "\n" + MrkSetupAppPath,
					Resources.DialogTitleError, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return (false);
			}

			System.Diagnostics.ProcessStartInfo psi =
				new System.Diagnostics.ProcessStartInfo();
			//実行ファイルパス
			//Executable file path
			psi.FileName = MrkSetupAppPath;
			psi.Verb = "runas";
			//コマンドライン引数
			//Arguments
			psi.Arguments = arguments;
			//UACダイアログがForm3に対して表示されるようにする
			//Show UAC dialog
			psi.ErrorDialog = true;
			psi.ErrorDialogParentHandle = Form3.ActiveForm.Handle;

			try
			{
				System.Diagnostics.Process p = System.Diagnostics.Process.Start(psi);
				//終了するまで待機する
				//Wait for exiting process
				p.WaitForExit();
			}
			catch (System.ComponentModel.Win32Exception)
			{
				return (false);
			}
			return (true);
		}

		//-----------------------------------------------------------
		//編集部分のハイライトカラーの選択
		//Select highlight color in label
		//-----------------------------------------------------------
		private void labelHighLightColor_Click(object sender, EventArgs e)
		{
			colorDialog1.Color = Color.FromArgb(MarkDownSharpEditor.AppSettings.Instance.HtmlHighLightColor);
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				labelHighLightColor.BackColor = colorDialog1.Color;
				labelHtmlColorName.Text = ColorTranslator.ToHtml(labelHighLightColor.BackColor);
				cmdApply.Enabled = true;
			}
		}

		private void checkBoxEditingHighlightColor_Click(object sender, EventArgs e)
		{

			if (checkBoxEditingHighlightColor.Checked == true)
			{
				//ハイライトカラー表示
				//View highlight color
				labelHighLightColor.BackColor = Color.FromArgb(MarkDownSharpEditor.AppSettings.Instance.HtmlHighLightColor);
				labelHighLightColor.Image = null;
			}
			else
			{
				//ハイライトカラー非表示
				//View no highlight color
				labelHighLightColor.BackColor = Color.White;
				labelHighLightColor.Image = imgStrike.Image;
			}

		}

		//-----------------------------------------------------------
		// ブラウザープレビューまでの間隔
		// Interval time of browser preview
		//-----------------------------------------------------------
		private void comboPreviewInterval_SelectionChangeCommitted(object sender, EventArgs e)
		{
			cmdApply.Enabled = true;
		}

		#endregion

		//======================================================================
		#region 「エディター設定」タブ ( "Text editor" settings Tab )
		//======================================================================

		//-----------------------------------
		// 前景（文字）色の変更
		// Change foreground color
		//-----------------------------------
		private void labelForeColor_Click(object sender, EventArgs e)
		{
			Label lbl = sender as Label;
			colorDialog1.Color = lbl.BackColor;
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				Label lblSample = lbl.Tag as Label;
				lblSample.ForeColor = colorDialog1.Color;
				lbl.BackColor = colorDialog1.Color;
				cmdApply.Enabled = true;
			}
		}
		//-----------------------------------
		// 背景色の変更
		// Change background color
		//-----------------------------------
		private void labelBackColor_Click(object sender, EventArgs e)
		{
			Label lbl = (Label)sender;
			colorDialog1.Color = lbl.BackColor;
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				Label lblSample = (Label)lbl.Tag;
				lblSample.BackColor = colorDialog1.Color;
				lbl.BackColor = colorDialog1.Color;
				cmdApply.Enabled = true;
			}
		}

		#endregion;

		//======================================================================
		#region 「CSSファイルの指定」タブ ( "CSS file" setting Tab )
		//======================================================================

		//-----------------------------------
		// CSS file list Drag Enter Event
		//-----------------------------------
		private void listViewCssFiles_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop) == true)
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		//-----------------------------------
		// CSS file list Drag and Drop Event
		//-----------------------------------
		private void listViewCssFiles_DragDrop(object sender, DragEventArgs e)
		{
			string[] CssFileArray = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			if (CssFileArray.Length > 0)
			{
				foreach (string FilePath in CssFileArray)
				{
					if (Path.GetExtension(FilePath).ToLower() == ".css")
					{
						foreach (ListViewItem item in listViewCssFiles.Items)
						{
							if (Path.Combine(item.SubItems[1].Text, item.Text) == FilePath)
							{
								//"通知"
								//"既に同じCSSファイルが登録されています。"
								//"Information"
								//"Same CSS file exitsts already."
								MessageBox.Show(Resources.MsgSameCSSFileExists + "\n" + FilePath,
									Resources.DialogTitleInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
								//選択状態にする
								//The item is selected 
								listViewCssFiles.Items[item.Index].Selected = true;
								return;
							}
						}
						//重複していないので登録する
						//Regist it because the file is not list 
						ListViewItem AddItem = new ListViewItem(Path.GetFileName(FilePath));
						AddItem.SubItems.Add(Path.GetDirectoryName(FilePath));
						AddItem.Tag = FilePath;
						listViewCssFiles.Items.Add(AddItem);
						listViewCssFiles.Select();
						cmdApply.Enabled = true;
					}
				}
			}
		}

		//-----------------------------------
		// CSSファイルの追加
		// Add CSS file
		//-----------------------------------
		private void cmdAddCssFile_Click(object sender, EventArgs e)
		{
			openFileDialog1.FileName = "";
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				foreach (string FilePath in openFileDialog1.FileNames)
				{
					foreach (ListViewItem item in listViewCssFiles.Items)
					{
						if (Path.Combine(item.SubItems[1].Text, item.Text) == FilePath)
						{
							//"通知"
							//"既に同じCSSファイルが登録されています。"
							//"Information"
							//"Same CSS file exitsts already."
							MessageBox.Show(Resources.MsgSameCSSFileExists + "\n" + FilePath,
								Resources.DialogTitleInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
							//選択状態にする
							//The item is selected 
							listViewCssFiles.Items[item.Index].Selected = true;
							return;
						}
					}
					//重複していないので登録する
					//Regist it because the file is not list 
					ListViewItem AddItem = new ListViewItem(Path.GetFileName(FilePath));
					AddItem.SubItems.Add(Path.GetDirectoryName(FilePath));
					AddItem.Tag = FilePath;
					listViewCssFiles.Items.Add(AddItem);
					listViewCssFiles.Select();
					cmdApply.Enabled = true;
				}
			}

		}

		//-------------------------------------------
		// CSSファイルのあるフォルダからまとめて追加
		// Add folder all included CSS files
		//-------------------------------------------
		private void cmdAddCssFolder_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				string[] ArrayCssFiles =
					Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.css", SearchOption.AllDirectories);

				string MsgText = string.Join("\n", ArrayCssFiles);

				//"問い合わせ"
				//"以下のCSSファイルが見つかりました。すべて登録しますか？"
				//"Question"
				//"These CSS files is found. Do you add these files to list?"
				DialogResult ret = MessageBox.Show(
					Resources.MsgTheseCSSFilesFound + "\n" + MsgText,
					Resources.DialogTitleQuestion, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

				if (ret == DialogResult.Cancel)
				{
					return;
				}

				foreach (string FilePath in ArrayCssFiles)
				{
					ListViewItem item = new ListViewItem(Path.GetFileName(FilePath));
					item.SubItems.Add(Path.GetDirectoryName(FilePath));
					listViewCssFiles.Items.Add(item);
				}

				listViewCssFiles.Select();
				cmdApply.Enabled = true;
			}
		}

		//-------------------------------------------
		// CSSファイルリストから削除
		// Delete CSS file from list
		//-------------------------------------------
		private void cmdDeleteCssItem_Click(object sender, EventArgs e)
		{
			if (listViewCssFiles.SelectedItems.Count == 0)
			{
				return;
			}
			ListViewItem item = listViewCssFiles.SelectedItems[0];
			string FilePath = Path.Combine(item.SubItems[1].Text, item.Text);

			//"問い合わせ"
			//"リストからだけではなくファイル自体もごみ箱へ移動しますか？"
			//"Question"
			//"Do you remove this file in list, and move to trash?"
			DialogResult ret = MessageBox.Show(
				Resources.MsgMoveToTrash + "\n" + FilePath,
				Resources.DialogTitleQuestion, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
			if (ret == DialogResult.Cancel)
			{
				return;
			}

			//リストから削除
			//Remove the file from list
			listViewCssFiles.Items.Remove(item);
			listViewCssFiles.Select();

			cmdApply.Enabled = true;

			if (ret == DialogResult.Yes)
			{
				try
				{
					//ファイル自体をごみ箱へ移動
					//Move the file to trash
					Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(
						FilePath, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs,
						Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin);
				}
				catch
				{
					return;
				}
			}
		}

		//------------------------------------------------
		// 選択されたCSSファイルのフォルダをExplorerで開く
		// View selected CSS file in Explorer
		//------------------------------------------------
		private void cmdOpenCssDir_Click(object sender, EventArgs e)
		{
			if (listViewCssFiles.SelectedItems.Count == 0)
			{
				return;
			}
			ListViewItem item = listViewCssFiles.SelectedItems[0];
			string CssDir = item.SubItems[1].Text;

			if (Directory.Exists(CssDir) == true)
			{
				//Explorerで開く
				//Launch Explorer
				System.Diagnostics.Process.Start(
					"EXPLORER.EXE", string.Format(@"/e, {0}", CssDir));
			}
		}

		//------------------------------------------------
		// 選択されたCSSファイル項目を「上」へ
		// Up selected CSS file in the list
		//------------------------------------------------
		private void cmdUpItem_Click(object sender, EventArgs e)
		{
			if (listViewCssFiles.SelectedItems.Count == 0)
			{
				return;
			}

			int CurrentIndex = listViewCssFiles.SelectedItems[0].Index;
			if (CurrentIndex > 0)
			{
				ListViewItem item = listViewCssFiles.Items[CurrentIndex];
				listViewCssFiles.Items.RemoveAt(CurrentIndex);
				listViewCssFiles.Items.Insert(CurrentIndex - 1, item);
				listViewCssFiles.Select();
				listViewCssFiles.Items[CurrentIndex - 1].Selected = true;
			}
			cmdApply.Enabled = true;
		}

		//------------------------------------------------
		// 選択されたCSSファイル項目を「下」へ
		// Down selected CSS file in the list
		//------------------------------------------------
		private void cmdDownItem_Click(object sender, EventArgs e)
		{
			if (listViewCssFiles.SelectedItems.Count == 0)
			{
				return;
			}

			int CurrentIndex = listViewCssFiles.SelectedItems[0].Index;
			if (CurrentIndex < listViewCssFiles.Items.Count - 1)
			{
				ListViewItem item = listViewCssFiles.Items[CurrentIndex];
				listViewCssFiles.Items.RemoveAt(CurrentIndex);
				listViewCssFiles.Items.Insert(CurrentIndex + 1, item);
				listViewCssFiles.Select();
				listViewCssFiles.Items[CurrentIndex + 1].Selected = true;
			}
			cmdApply.Enabled = true;
		}

		//------------------------------------------------
		// 選択項目が変更されたとき
		// Change selection of CSS files
		//------------------------------------------------
		private void listViewCssFiles_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listViewCssFiles.Items.Count == 0 || listViewCssFiles.SelectedItems.Count == 0)
			{
				cmdUpItem.Enabled = false;
				cmdDownItem.Enabled = false;
			}
			else
			{
				int CurrentIndex = listViewCssFiles.SelectedItems[0].Index;
				if (CurrentIndex == 0)
				{
					cmdUpItem.Enabled = false;
					cmdDownItem.Enabled = true;
				}
				else if (CurrentIndex == listViewCssFiles.Items.Count - 1)
				{
					cmdUpItem.Enabled = true;
					cmdDownItem.Enabled = false;
				}
				else
				{
					cmdUpItem.Enabled = true;
					cmdDownItem.Enabled = true;
				}
			}
			//デフォルトCSSファイルの選択
			//Select default CSS file
			SelectDefaultCssFile();
		}

		//------------------------------------------------
		// デフォルトCSSファイルの選択
		// Select default CSS file
		//------------------------------------------------
		private void SelectDefaultCssFile()
		{
			for (int i = 0; i < listViewCssFiles.Items.Count; i++)
			{
				listViewCssFiles.Items[i].Text = Path.GetFileName((string)listViewCssFiles.Items[i].Tag);
				listViewCssFiles.Items[i].Font = new Font(listViewCssFiles.Items[i].Font, FontStyle.Regular);
			}
			if (listViewCssFiles.Items.Count > 0)
			{
				listViewCssFiles.Items[0].Text = Resources.MsgDefaultCSS + listViewCssFiles.Items[0].Text;
				listViewCssFiles.Items[0].Font = new Font(listViewCssFiles.Items[0].Font, FontStyle.Bold);
			}
		}

		#endregion

		//======================================================================
		#region 「HTMLファイル出力時の設定」タブ ( "HTML output" setting Tab )
		//======================================================================

		//-----------------------------------
		// 出力するHTMLファイルにヘッダを挿入する(&D)にチェック
		// Check "Insert header to output HTML file"
		//-----------------------------------
		private void chkInsertHtmlHeader_CheckedChanged(object sender, EventArgs e)
		{
			if (chkInsertHtmlHeader.Checked == true)
			{
				comboBoxHtmlHeader.Enabled = true;
				comboBoxHtmlHeader.BackColor = SystemColors.Window;
				groupBoxCssOption.Enabled = true;
			}
			else
			{
				comboBoxHtmlHeader.Enabled = false;
				comboBoxHtmlHeader.BackColor = SystemColors.ButtonFace;
				groupBoxCssOption.Enabled = false;
			}
			cmdApply.Enabled = true;
		}

		//-----------------------------------
		// HTMLヘッダの種類
		// Type of HTML header
		//-----------------------------------
		private void comboBoxHtmlHeader_SelectedIndexChanged(object sender, EventArgs e)
		{
			cmdApply.Enabled = true;
		}

		//-----------------------------------
		// CSSファイルの内容をHTMLファイルに埋め込む(&I)をチェック
		// Check "Embed contents of CSS file in HTML file"
		//-----------------------------------
		private void radioButtonImportCssFile_CheckedChanged(object sender, EventArgs e)
		{
			cmdApply.Enabled = true;
		}

		//-----------------------------------
		// <LINK>タグとして挿入する(&K)をチェック
		// Insert <LINK> tag to HTML file
		//-----------------------------------
		private void radioButtonInsertLinkTag_CheckedChanged(object sender, EventArgs e)
		{
			cmdApply.Enabled = true;
		}

		//-----------------------------------
		//「編集中のエンコーディングを使用する(&D)」チェック
		// Check "Apply encoding of editing"
		//-----------------------------------
		private void radioButtonDefaultEncoding_CheckedChanged(object sender, EventArgs e)
		{
			comboBoxSelectEncoding.Enabled = false;
			comboBoxSelectEncoding.BackColor = SystemColors.ButtonFace;
			cmdApply.Enabled = true;
		}
		//-----------------------------------
		//「現在のエンコーディングを変更する(&C)」をチェック
		// Check "Change this encoding"
		//-----------------------------------
		private void radioButtonChangeEncoding_CheckedChanged(object sender, EventArgs e)
		{
			comboBoxSelectEncoding.Enabled = true;
			comboBoxSelectEncoding.BackColor = SystemColors.Window;
			cmdApply.Enabled = true;
		}

		#endregion





	}
}
