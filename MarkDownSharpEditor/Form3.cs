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


namespace MarkDownSharpEditor
{
	
	public partial class Form3 : Form
	{
		[DllImport("user32.dll")]
		private static extern IntPtr SendMessage(HandleRef hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
		// 第2パラメータ：盾アイコンを設定するフラグ
		uint BCM_SETSHIELD = 0x0000160C;

		public string[] BuitInCssFileListArray;
		public string[] HtmlHeaderList;
		public string SelectedCssFilePath;
		public ComboBox.ObjectCollection CombCol;

		//-----------------------------------
		// コンストラクタ
		//-----------------------------------
		public Form3()
		{
			InitializeComponent();

			//関連付け設定に関するボタンにUAC盾アイコンの表示
			cmdAssociateFiles.FlatStyle = FlatStyle.System;
			HandleRef hwnd = new HandleRef(cmdAssociateFiles, cmdAssociateFiles.Handle);
			SendMessage(hwnd, BCM_SETSHIELD, new IntPtr(0), new IntPtr(1));

			cmdUnAssociateFiles.FlatStyle = FlatStyle.System;
			hwnd = new HandleRef(cmdUnAssociateFiles, cmdUnAssociateFiles.Handle);
			SendMessage(hwnd, BCM_SETSHIELD, new IntPtr(0), new IntPtr(1));
		}

		//-----------------------------------
		// フォームをロードする
		//-----------------------------------
		private void Form3_Load(object sender, EventArgs e)
		{
			int i;
			var obj = MarkDownSharpEditor.AppSettings.Instance;

			//===================================
			//選択されたタブ番号
			//-----------------------------------
			int TabIndex = obj.TabPageSelectedIndex;
			if (TabIndex > tabControl1.TabCount - 1)
			{
				TabIndex = 0;
			}
			tabControl1.TabPages[TabIndex].Select();

			//======================================================================
			//一般設定
			//======================================================================

			//前に編集していたファイルを起動時に自動で開く
			checkBoxOpenEditFileBefore.Checked = obj.fOpenEditFileBefore;
			//HTMLファイル出力のとき保存ダイアログを表示する(&H)
			checkBoxShowHtmlSaveDialog.Checked = obj.fShowHtmlSaveDialog;
			//HTMLソースをクリップボードコピーしたときに確認メッセージを表示する(&M)
			checkBoxShowHtmlToClipboardMessage.Checked = obj.fShowHtmlToClipboardMessage;

			//編集部分をハイライトカラー表示する
			checkBoxEditingHighlightColor.Checked = obj.fHtmlHighLightColor;
			//編集部分のハイライトカラー
			labelHighLightColor.BackColor = Color.FromArgb(obj.HtmlHighLightColor);
			labelHtmlColorName.Text = ColorTranslator.ToHtml(labelHighLightColor.BackColor);

			//ブラウザープレビューまでの間隔
			switch (obj.AutoBrowserPreviewInterval)
			{
				case -1:
					comboPreviewInterval.SelectedIndex = 0;
					numericUpDown1.Value = -1;
					break;
				case 100:
					comboPreviewInterval.SelectedIndex = 1;
					numericUpDown1.Value = 0.1m;
					break;
				case 500:
					comboPreviewInterval.SelectedIndex = 2;
					numericUpDown1.Value = 0.5m;
					break;
				case 1000:
					comboPreviewInterval.SelectedIndex = 3;
					numericUpDown1.Value = 1;
					break;
				case 2000:
					comboPreviewInterval.SelectedIndex = 4;
					numericUpDown1.Value = 2;
					break;
				case 3000:
					comboPreviewInterval.SelectedIndex = 5;
					numericUpDown1.Value = 3;
					break;
				case 4000:
					comboPreviewInterval.SelectedIndex = 6;
					numericUpDown1.Value = 4;
					break;
				case 5000:
					comboPreviewInterval.SelectedIndex = 7;
					numericUpDown1.Value = 5;
					break;
				case 10000:
					comboPreviewInterval.SelectedIndex = 8;
					numericUpDown1.Value = 10;
					break;
				case 30000:
					comboPreviewInterval.SelectedIndex = 9;
					numericUpDown1.Value = 30;
					break;
				case 60000:
					comboPreviewInterval.SelectedIndex = 10;
					numericUpDown1.Value = 60;
					break;
				default:
					//カスタム値を表示（隠し機能）
					numericUpDown1.Value = (decimal)(obj.AutoBrowserPreviewInterval / 1000);
					comboPreviewInterval.Visible = false;
					numericUpDown1.Bounds = comboPreviewInterval.Bounds;
					numericUpDown1.Visible = true;
					lblms.Visible = true;
					break;
			}

			//======================================================================
			// エディター設定
			//======================================================================

			//メイン
			labelMainColor.ForeColor = labelMainForeColor.BackColor = Color.FromArgb(obj.ForeColor_MainText);
			labelMainColor.BackColor = labelMainBackColor.BackColor = Color.FromArgb(obj.BackColor_MainText);
			labelMainForeColor.Tag = labelMainColor;
			labelMainBackColor.Tag = labelMainColor;

			//強制改行
			labelLineBreakColor.ForeColor = labelLineBreakForeColor.BackColor = Color.FromArgb(obj.ForeColor_LineBreak);
			labelLineBreakColor.BackColor = labelLineBreakBackColor.BackColor = Color.FromArgb(obj.BackColor_LineBreak);
			labelLineBreakForeColor.Tag = labelLineBreakColor;
			labelLineBreakBackColor.Tag = labelLineBreakColor;
			//見出し
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
			//引用
			labelBlockquotesColor.ForeColor = labelBlockquotesForeColor.BackColor = Color.FromArgb(obj.ForeColor_Blockquotes);
			labelBlockquotesColor.BackColor = labelBlockquotesBackColor.BackColor = Color.FromArgb(obj.BackColor_Blockquotes);
			labelBlockquotesForeColor.Tag = labelBlockquotesColor;
			labelBlockquotesBackColor.Tag = labelBlockquotesColor;
			//画像
			labelImagesColor.ForeColor = labelImagesForeColor.BackColor = Color.FromArgb(obj.ForeColor_Images);
			labelImagesColor.BackColor = labelImagesBackColor.BackColor = Color.FromArgb(obj.BackColor_Images);
			labelImagesForeColor.Tag = labelImagesColor;
			labelImagesBackColor.Tag = labelImagesColor;
			//リンク
			labelLinksColor.ForeColor = labelLinksForeColor.BackColor = Color.FromArgb(obj.ForeColor_Links);
			labelLinksColor.BackColor = labelLinksBackColor.BackColor = Color.FromArgb(obj.BackColor_Links);
			labelLinksForeColor.Tag = labelLinksColor;
			labelLinksBackColor.Tag = labelLinksColor;
			//強調
			labelEmphasisColor.ForeColor = labelEmphasisForeColor.BackColor = Color.FromArgb(obj.ForeColor_Emphasis);
			labelEmphasisColor.BackColor = labelEmphasisBackColor.BackColor = Color.FromArgb(obj.BackColor_Emphasis);
			labelEmphasisForeColor.Tag = labelEmphasisColor;
			labelEmphasisBackColor.Tag = labelEmphasisColor;
			//リスト
			labelListsColor.ForeColor = labelListsForeColor.BackColor = Color.FromArgb(obj.ForeColor_Lists);
			labelListsColor.BackColor = labelListsBackColor.BackColor = Color.FromArgb(obj.BackColor_Lists);
			labelListsForeColor.Tag = labelListsColor;
			labelListsBackColor.Tag = labelListsColor;
			//コード
			labelCodeColor.ForeColor = labelCodeForeColor.BackColor = Color.FromArgb(obj.ForeColor_Code);
			labelCodeColor.BackColor = labelCodeBackColor.BackColor = Color.FromArgb(obj.BackColor_Code);
			labelCodeForeColor.Tag = labelCodeColor;
			labelCodeBackColor.Tag = labelCodeColor;
			//コードブロック
			labelCodeBlockColor.ForeColor = labelCodeBlockForeColor.BackColor = Color.FromArgb(obj.ForeColor_CodeBlocks);
			labelCodeBlockColor.BackColor = labelCodeBlockBackColor.BackColor = Color.FromArgb(obj.BackColor_CodeBlocks);
			labelCodeBlockForeColor.Tag = labelCodeBlockColor;
			labelCodeBlockBackColor.Tag = labelCodeBlockColor;
			//罫線
			labelHorizontalColor.ForeColor = labelHorizontalForeColor.BackColor = Color.FromArgb(obj.ForeColor_Horizontal);
			labelHorizontalColor.BackColor = labelHorizontalBackColor.BackColor = Color.FromArgb(obj.BackColor_Horizontal);
			labelHorizontalForeColor.Tag = labelHorizontalColor;
			labelHorizontalBackColor.Tag = labelHorizontalColor;
			//コメント
			labelCommentsColor.ForeColor = labelCommentsForeColor.BackColor = Color.FromArgb(obj.ForeColor_Comments);
			labelCommentsColor.BackColor = labelCommentsBackColor.BackColor = Color.FromArgb(obj.BackColor_Comments);
			labelCommentsForeColor.Tag = labelCommentsColor;
			labelCommentsBackColor.Tag = labelCommentsColor;

			//======================================================================
			// CSS設定
			//======================================================================

			//CSSファイルリストの更新
			RefreshCssFileList();
			listViewCssFiles.Columns[0].Width = obj.ListViewColumnHeader1Width;
			listViewCssFiles.Columns[1].Width = obj.ListViewColumnHeader2Width;

			//======================================================================
			// HTMLファイル出力の設定
			//======================================================================

			//出力するHTMLファイルにヘッダ（DOCTYPE等）を挿入する(&D)
			chkInsertHtmlHeader.Checked = obj.fHtmlOutputHeader;

			//HTMLヘッダリストを表示
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
			catch  //万が一、設定のコードページがなかった場合
			{
				if (comboBoxSelectEncoding.Items.Count > 0)
				{
					comboBoxSelectEncoding.SelectedIndex = 0;
				}
			}

			//-----------------------------------
			//エンコーディングの指定
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
		//-----------------------------------
		private void Form3_Enter(object sender, EventArgs e)
		{
			//「CSS設定」が開いているときのみ
			if (tabControl1.SelectedTab == tabPageCSS)
			{
				//ビルトインCSSファイルリストの更新
				RefreshCssFileList();
			}
		}

		//-----------------------------------
		//　CSSリストの更新
		//-----------------------------------
		private void RefreshCssFileList()
		{
			listViewCssFiles.Items.Clear();

			for ( int i = 0; i < MarkDownSharpEditor.AppSettings.Instance.ArrayCssFileList.Count; i++ )
			{
				string FilePath = (string)MarkDownSharpEditor.AppSettings.Instance.ArrayCssFileList[i];
				ListViewItem item = new ListViewItem(Path.GetFileName(FilePath));

				if (i == 0)
				{
					item.Text = item.Text + "(デフォルト)";
					item.Font = new Font(this.Font, FontStyle.Bold);
				}
				item.Tag = FilePath;
				item.SubItems.Add(Path.GetDirectoryName(FilePath));
				listViewCssFiles.Items.Add(item);
			}

		}


		//-----------------------------------
		//「フォームを閉じる」
		//-----------------------------------
		private void Form3_FormClosed(object sender, FormClosedEventArgs e)
		{
			//選択中のタブ番号
			MarkDownSharpEditor.AppSettings.Instance.TabPageSelectedIndex = tabControl1.SelectedIndex;
		}

		//-----------------------------------
		//「適用」ボタン（設定を保存する）
		//-----------------------------------
		private void cmdApply_Click(object sender, EventArgs e)
		{

			var obj = MarkDownSharpEditor.AppSettings.Instance;

			//-----------------------------------
			//一般設定
			//-----------------------------------

			//前に編集していたファイルを起動時に自動で開く
			obj.fOpenEditFileBefore = checkBoxOpenEditFileBefore.Checked;
			//HTMLファイル出力のとき保存ダイアログを表示する(&H)
			obj.fShowHtmlSaveDialog = checkBoxShowHtmlSaveDialog.Checked;
			//HTMLソースをクリップボードコピーしたときに確認メッセージを表示する(&M)
			obj.fShowHtmlToClipboardMessage = checkBoxShowHtmlToClipboardMessage.Checked;

			//編集部分をハイライトカラー表示するか
			obj.fHtmlHighLightColor = checkBoxEditingHighlightColor.Checked; 
			//編集部分のハイライトカラー
			obj.HtmlHighLightColor = labelHighLightColor.BackColor.ToArgb();
			//ブラウザープレビューまでの間隔
			obj.AutoBrowserPreviewInterval = (int)(numericUpDown1.Value * 1000);

			//-----------------------------------
			// エディター(SyntaxHighlighter)設定
			//-----------------------------------
			obj.ForeColor_MainText = labelMainColor.ForeColor.ToArgb();           //全般
			obj.BackColor_MainText = labelMainColor.BackColor.ToArgb();
			obj.ForeColor_LineBreak = labelLineBreakColor.ForeColor.ToArgb();     //強制改行
			obj.BackColor_LineBreak = labelLineBreakColor.BackColor.ToArgb();
			obj.ForeColor_Headlines[1] = labelHeadLine1Color.ForeColor.ToArgb();  //見出し１
			obj.BackColor_Headlines[1] = labelHeadLine1Color.BackColor.ToArgb();
			obj.ForeColor_Headlines[2] = labelHeadLine2Color.ForeColor.ToArgb();  //見出し２
			obj.BackColor_Headlines[2] = labelHeadLine2Color.BackColor.ToArgb();
			obj.ForeColor_Headlines[3] = labelHeadLine3Color.ForeColor.ToArgb();  //見出し３
			obj.BackColor_Headlines[3] = labelHeadLine3Color.BackColor.ToArgb();
			obj.ForeColor_Headlines[4] = labelHeadLine4Color.ForeColor.ToArgb();  //見出し４
			obj.BackColor_Headlines[4] = labelHeadLine4Color.BackColor.ToArgb();
			obj.ForeColor_Headlines[5] = labelHeadLine5Color.ForeColor.ToArgb();  //見出し５
			obj.BackColor_Headlines[5] = labelHeadLine5Color.BackColor.ToArgb();
			obj.ForeColor_Headlines[6] = labelHeadLine6Color.ForeColor.ToArgb();  //見出し６
			obj.BackColor_Headlines[6] = labelHeadLine6Color.BackColor.ToArgb();
			obj.ForeColor_Blockquotes = labelBlockquotesColor.ForeColor.ToArgb(); //引用
			obj.BackColor_Blockquotes = labelBlockquotesColor.BackColor.ToArgb();
			obj.ForeColor_Lists = labelListsColor.ForeColor.ToArgb();             //リスト
			obj.BackColor_Lists = labelListsColor.BackColor.ToArgb();
			obj.ForeColor_CodeBlocks = labelCodeBlockColor.ForeColor.ToArgb();    //コードブロック
			obj.BackColor_CodeBlocks = labelCodeBlockColor.BackColor.ToArgb();
			obj.ForeColor_Horizontal = labelHorizontalColor.ForeColor.ToArgb();   //罫線
			obj.BackColor_Horizontal = labelHorizontalColor.BackColor.ToArgb();
			obj.ForeColor_Links = labelLinksColor.ForeColor.ToArgb();             //リンク
			obj.BackColor_Links = labelLinksColor.BackColor.ToArgb();
			obj.ForeColor_Emphasis = labelEmphasisColor.ForeColor.ToArgb();       //強調
			obj.BackColor_Emphasis = labelEmphasisColor.BackColor.ToArgb();
			obj.ForeColor_Code = labelCodeColor.ForeColor.ToArgb();               //コード
			obj.BackColor_Code = labelCodeColor.BackColor.ToArgb();
			obj.ForeColor_Images = labelImagesColor.ForeColor.ToArgb();           //画像
			obj.BackColor_Images = labelImagesColor.BackColor.ToArgb();
			obj.ForeColor_Comments = labelCommentsColor.ForeColor.ToArgb();       //コメント
			obj.BackColor_Comments = labelCommentsColor.BackColor.ToArgb();

			//-----------------------------------
			// CSSファイル設定
			//-----------------------------------
			obj.ArrayCssFileList.Clear();
			for ( int i = 0; i < listViewCssFiles.Items.Count; i++ )
			{
				string FilePath = (string)listViewCssFiles.Items[i].Tag;
				if (File.Exists(FilePath) == true)
				{
					obj.ArrayCssFileList.Add(FilePath);
				}
			}
			//カラム幅
			obj.ListViewColumnHeader1Width = listViewCssFiles.Columns[0].Width;
			obj.ListViewColumnHeader2Width = listViewCssFiles.Columns[1].Width;

			//-----------------------------------
			// HTML出力
			//-----------------------------------
			
			//出力するHTMLファイルにヘッダ（DOCTYPE等）を挿入する(&D)
			obj.fHtmlOutputHeader = chkInsertHtmlHeader.Checked;
			//HTMLのDOCTYPE
			obj.HtmlDocType = comboBoxHtmlHeader.Text;

			if (radioButtonInsertLinkTag.Checked == true)
			{
				//<LINK>タグとして挿入する(&K)
				obj.HtmlCssFileOption = 1;
			}
			else
			{
				//CSSファイルの内容をHTMLファイルに埋め込む(&I)
				obj.HtmlCssFileOption = 0;
			}

			if (radioButtonChangeEncoding.Checked == true)
			{
				//現在のエンコーディングを変更する(&C)
				obj.HtmlEncodingOption = 1;
			
			}
			else
			{
				//編集中のエンコーディングを使用する(&D)
				obj.HtmlEncodingOption = 0;
			}
			//選択されたエンコーディングのコードページを保存
			obj.CodePageNumber = Convert.ToInt32(comboBoxSelectEncoding.SelectedValue);
			// ファイルに設定を保存
			obj.SaveToXMLFile();
			//obj.SaveToJsonFile();
			cmdApply.Enabled = false;
		}

		//-----------------------------------
		//「OK」ボタン
		//-----------------------------------
		private void cmdOK_Click(object sender, EventArgs e)
		{
			cmdApply_Click(sender, e);
			this.Close();
		}

		//-----------------------------------
		//「キャンセル」ボタン
		//-----------------------------------
		private void cmdCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		//===================================
		#region tabControlのアクセスキー処理
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

		//===================================
		#region 「全般設定」タブ
		//===================================

		//-----------------------------------------------------------
		// 権限昇格させ関連付け設定ツールを呼び出す（関連付け）
		//-----------------------------------------------------------
		private void cmdAssociateFiles_Click(object sender, EventArgs e)
		{
			RunElevated("-a");
		}

		//-----------------------------------------------------------
		// 権限昇格させ関連付け設定ツールを呼び出す（関連付け・解除）
		//-----------------------------------------------------------
		private void cmdUnAssociateFiles_Click(object sender, EventArgs e)
		{
			RunElevated("-u");
		}

		//-----------------------------------------------------------
		// 関連付け設定ツールの呼び出し
		//-----------------------------------------------------------
		public static bool RunElevated(string arguments)
		{
			string AppDirPath = Path.GetDirectoryName(Application.ExecutablePath);
			string MrkSetupAppPath = Path.Combine(AppDirPath, "MrkSetup.exe");

			if (File.Exists(MrkSetupAppPath) == false)
			{
				MessageBox.Show(
					"関連付けツールが見つかりません。関連付け設定に失敗しました。\n" + MrkSetupAppPath,
					"エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return (false);
			}

			System.Diagnostics.ProcessStartInfo psi =
				new System.Diagnostics.ProcessStartInfo();
			//実行ファイルパス
			psi.FileName = MrkSetupAppPath;
			psi.Verb = "runas";
			//コマンドライン引数
			psi.Arguments = arguments;
			//UACダイアログがForm3に対して表示されるようにする
			psi.ErrorDialog = true;
			psi.ErrorDialogParentHandle = Form3.ActiveForm.Handle;

			try
			{
				System.Diagnostics.Process p = System.Diagnostics.Process.Start(psi);
				//終了するまで待機する
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
				labelHighLightColor.BackColor = Color.FromArgb(MarkDownSharpEditor.AppSettings.Instance.HtmlHighLightColor);
				labelHighLightColor.Image = null;
			}
			else
			{
				//ハイライトカラー非表示
				labelHighLightColor.BackColor = Color.White;
				labelHighLightColor.Image = Properties.Resources.strike;
			}

		}

		//-----------------------------------------------------------
		// ブラウザープレビューまでの間隔
		//-----------------------------------------------------------
		private void comboPreviewInterval_SelectionChangeCommitted(object sender, EventArgs e)
		{

			switch (comboPreviewInterval.SelectedIndex)
			{
				case 0:
					numericUpDown1.Value = -1;
					break;
				case 1:
					numericUpDown1.Value = 100;
					break;
				case 2:
					numericUpDown1.Value = 500;
					break;
				case 3:
					numericUpDown1.Value = 1000;
					break;
				case 4:
					numericUpDown1.Value = 2000;
					break;
				case 5:
					numericUpDown1.Value = 3000;
					break;
				case 6:
					numericUpDown1.Value = 4000;
					break;
				case 7:
					numericUpDown1.Value = 5000;
					break;
				case 8:
					numericUpDown1.Value = 10000;
					break;
				case 9:
					numericUpDown1.Value = 30000;
					break;
				case 10:
					numericUpDown1.Value = 60000;
					break;
				default:
					break;
			}

		}

		//-----------------------------------------------------------
		// ラベルをダブルクリックでプレビュー間隔のカスタム値入力
		//-----------------------------------------------------------
		private void lblPreviewIntervalCaption_DoubleClick(object sender, EventArgs e)
		{
			comboPreviewInterval.Visible = false;
			numericUpDown1.Bounds = comboPreviewInterval.Bounds;
			numericUpDown1.Visible = true;
			lblms.Visible = true;
		}


		#endregion

		//===================================
		#region 「エディター設定」タブ
		//===================================

		//-----------------------------------
		// 前景（文字）色の変更
		//-----------------------------------
		private void labelForeColor_Click(object sender, EventArgs e)
		{
			Label lbl = sender as Label;
			colorDialog1.Color = lbl.BackColor;
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				Label lblSample = lbl.Tag as Label;
				lblSample.ForeColor = colorDialog1.Color;
				cmdApply.Enabled = true;
			}

		}
		//-----------------------------------
		// 背景色の変更
		//-----------------------------------
		private void labelBackColor_Click(object sender, EventArgs e)
		{
			Label lbl = (Label)sender;
			colorDialog1.Color = lbl.BackColor;
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				Label lblSample = (Label)lbl.Tag;
				lblSample.BackColor = colorDialog1.Color;
				cmdApply.Enabled = true;
			}

		}

		#endregion;
		//===================================

		//===================================
		#region 「CSSファイルの指定」タブ
		//===================================

		//-----------------------------------
		// CSSファイルの追加
		//-----------------------------------
		private void cmdAddCssFile_Click(object sender, EventArgs e)
		{
			openFileDialog1.FileName = "";
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				foreach (ListViewItem item in listViewCssFiles.Items)
				{
					if (Path.Combine(item.SubItems[1].Text, item.Text) == openFileDialog1.FileName)
					{
						MessageBox.Show(
						"既に同じCSSファイルが登録されています。\n"+openFileDialog1.FileName,
						"通知",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information);
						//選択状態にする
						listViewCssFiles.Items[item.Index].Selected = true;
						return;
					}

				}
				//重複していないので登録する
				ListViewItem AddItem = new ListViewItem(Path.GetFileName(openFileDialog1.FileName));
				AddItem.SubItems.Add(Path.GetDirectoryName(openFileDialog1.FileName));
				AddItem.Tag = openFileDialog1.FileName;
				listViewCssFiles.Items.Add(AddItem);
				listViewCssFiles.Select();
				cmdApply.Enabled = true;
			}

		}

		//-------------------------------------------
		// CSSファイルのあるフォルダからまとめて追加
		//-------------------------------------------
		private void cmdAddCssFolder_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				string[] ArrayCssFiles = 
					Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.css", SearchOption.AllDirectories);


				string MsgText = string.Join("\n", ArrayCssFiles);

				DialogResult ret = MessageBox.Show(
					"以下のCSSファイルが見つかりました。すべて登録しますか？\n"+MsgText,
					"問い合わせ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

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
		//-------------------------------------------
		private void cmdDeleteCssItem_Click(object sender, EventArgs e)
		{
			if ( listViewCssFiles.SelectedItems.Count == 0 )
			{
				return;
			}

			ListViewItem item = listViewCssFiles.SelectedItems[0];
			string FilePath = Path.Combine(item.SubItems[1].Text, item.Text);
			DialogResult ret = MessageBox.Show(
				"リストからだけではなくファイル自体もごみ箱へ移動しますか？\n" + FilePath,
				"問い合わせ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

			if (ret == DialogResult.Cancel)
			{
				return;
			}

			//リストから削除
			listViewCssFiles.Items.Remove(item);
			listViewCssFiles.Select();

			cmdApply.Enabled = true;

			if (ret == DialogResult.Yes)
			{
				try
				{
					//ファイル自体をごみ箱へ移動
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
				System.Diagnostics.Process.Start(
					"EXPLORER.EXE", string.Format(@"/e, {0}", CssDir));
			}
		}

		//------------------------------------------------
		// 選択されたCSSファイル項目を「上」へ
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
		//------------------------------------------------
		private void cmdDownItem_Click(object sender, EventArgs e)
		{
			if (listViewCssFiles.SelectedItems.Count == 0)
			{
				return;
			}

			int CurrentIndex = listViewCssFiles.SelectedItems[0].Index;
			if (CurrentIndex < listViewCssFiles.Items.Count-1)
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
			SelectDefaultCssFile();

		}


		//------------------------------------------------
		// デフォルトCSSファイルの選択
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
				listViewCssFiles.Items[0].Text = "(デフォルト)" + listViewCssFiles.Items[0].Text;
				listViewCssFiles.Items[0].Font = new Font(listViewCssFiles.Items[0].Font, FontStyle.Bold);
			}
		}

		#endregion

		//===================================
		#region 「HTMLファイル出力時の設定」タブ
		//===================================

		//-----------------------------------
		// 出力するHTMLファイルにヘッダを挿入する(&D)にチェック
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
		//-----------------------------------
		private void comboBoxHtmlHeader_SelectedIndexChanged(object sender, EventArgs e)
		{
			cmdApply.Enabled = true;
		}

		//-----------------------------------
		// CSSファイルの内容をHTMLファイルに埋め込む(&I)をチェック
		//-----------------------------------
		private void radioButtonImportCssFile_CheckedChanged(object sender, EventArgs e)
		{
			cmdApply.Enabled = true;
		}
		
		//-----------------------------------
		// <LINK>タグとして挿入する(&K)をチェック
		//-----------------------------------
		private void radioButtonInsertLinkTag_CheckedChanged(object sender, EventArgs e)
		{
			cmdApply.Enabled = true;
		}

		//-----------------------------------
		//「編集中のエンコーディングを使用する(&D)」チェック
		//-----------------------------------
		private void radioButtonDefaultEncoding_CheckedChanged(object sender, EventArgs e)
		{
			comboBoxSelectEncoding.Enabled = false;
			comboBoxSelectEncoding.BackColor = SystemColors.ButtonFace;
			cmdApply.Enabled = true;
		}
		//-----------------------------------
		//「現在のエンコーディングを変更する(&C)」をチェック
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
