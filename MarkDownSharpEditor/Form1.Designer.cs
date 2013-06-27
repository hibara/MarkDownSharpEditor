namespace MarkDownSharpEditor
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.richTextBox1 = new RichTextBoxEx();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelTextEncoding = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelFontInfo = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelCssFileName = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelHtmlEncoding = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.menuNewFile = new System.Windows.Forms.ToolStripMenuItem();
			this.menuNewWindow = new System.Windows.Forms.ToolStripMenuItem();
			this.menuOpenFile = new System.Windows.Forms.ToolStripMenuItem();
			this.menuHistoryFiles = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuSaveFile = new System.Windows.Forms.ToolStripMenuItem();
			this.menuSaveAsFile = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
			this.menuOutputHtmlFile = new System.Windows.Forms.ToolStripMenuItem();
			this.menuOutputHtmlToClipboard = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
			this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuUndo = new System.Windows.Forms.ToolStripMenuItem();
			this.menuRedo = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.menuCut = new System.Windows.Forms.ToolStripMenuItem();
			this.menuCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.menuPaste = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.menuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
			this.menuSearch = new System.Windows.Forms.ToolStripMenuItem();
			this.menuReplace = new System.Windows.Forms.ToolStripMenuItem();
			this.menuView = new System.Windows.Forms.ToolStripMenuItem();
			this.menuViewRefresh = new System.Windows.Forms.ToolStripMenuItem();
			this.menuViewAssociateBrowser = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
			this.menuShowHeaderListMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
			this.menuViewToolBar = new System.Windows.Forms.ToolStripMenuItem();
			this.menuViewStatusBar = new System.Windows.Forms.ToolStripMenuItem();
			this.menuViewWidthEvenly = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripSeparator();
			this.menuViewLanguage = new System.Windows.Forms.ToolStripMenuItem();
			this.menuVieｗJapanese = new System.Windows.Forms.ToolStripMenuItem();
			this.menuViewEnglish = new System.Windows.Forms.ToolStripMenuItem();
			this.menuTool = new System.Windows.Forms.ToolStripMenuItem();
			this.menuOption = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
			this.menuFont = new System.Windows.Forms.ToolStripMenuItem();
			this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.menuContents = new System.Windows.Forms.ToolStripMenuItem();
			this.menuViewSample = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuCheckForUpdate = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonNewFile = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonOpenFile = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonSaveFile = new System.Windows.Forms.ToolStripButton();
			this.toolButtonOutput = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonUndo = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonCut = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonCopy = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonPaste = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonOption = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonFont = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonOutputHtmlToClipBoard = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonForward = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonBack = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonBrowserPreview = new System.Windows.Forms.ToolStripButton();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.fontDialog1 = new System.Windows.Forms.FontDialog();
			this.contextMenu1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.contextMenu2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.panelSearch = new System.Windows.Forms.Panel();
			this.cmdReplaceAll = new System.Windows.Forms.Button();
			this.labelReplace = new System.Windows.Forms.Label();
			this.textBoxReplace = new System.Windows.Forms.TextBox();
			this.imgSearchExitUnabled = new System.Windows.Forms.PictureBox();
			this.imgSearchExitEnabled = new System.Windows.Forms.PictureBox();
			this.chkOptionCase = new System.Windows.Forms.CheckBox();
			this.imgSearchExit = new System.Windows.Forms.PictureBox();
			this.cmdSearchNext = new System.Windows.Forms.Button();
			this.cmdSearchPrev = new System.Windows.Forms.Button();
			this.labelSearch = new System.Windows.Forms.Label();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.panelSearch.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgSearchExitUnabled)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgSearchExitEnabled)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgSearchExit)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
			resources.ApplyResources(this.splitContainer1, "splitContainer1");
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.richTextBox1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
			// 
			// richTextBox1
			// 
			this.richTextBox1.AcceptsTab = true;
			this.richTextBox1.DetectUrls = false;
			resources.ApplyResources(this.richTextBox1, "richTextBox1");
			this.richTextBox1.HideSelection = false;
			this.richTextBox1.HorizontalPosition = 0;
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Text = global::MarkDownSharpEditor.Properties.Resources.MsgThisWord;
			this.richTextBox1.VerticalPosition = 0;
			this.richTextBox1.VScroll += new System.EventHandler(this.richTextBox1_VScroll);
			this.richTextBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseClick);
			this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			this.richTextBox1.Enter += new System.EventHandler(this.richTextBox1_Enter);
			this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
			// 
			// webBrowser1
			// 
			this.webBrowser1.AllowWebBrowserDrop = false;
			resources.ApplyResources(this.webBrowser1, "webBrowser1");
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
			this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTextEncoding,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabelFontInfo,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabelCssFileName,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelHtmlEncoding});
			resources.ApplyResources(this.statusStrip1, "statusStrip1");
			this.statusStrip1.Name = "statusStrip1";
			// 
			// toolStripStatusLabelTextEncoding
			// 
			this.toolStripStatusLabelTextEncoding.Name = "toolStripStatusLabelTextEncoding";
			this.toolStripStatusLabelTextEncoding.Padding = new System.Windows.Forms.Padding(0, 0, 32, 0);
			resources.ApplyResources(this.toolStripStatusLabelTextEncoding, "toolStripStatusLabelTextEncoding");
			// 
			// toolStripStatusLabel2
			// 
			resources.ApplyResources(this.toolStripStatusLabel2, "toolStripStatusLabel2");
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			// 
			// toolStripStatusLabelFontInfo
			// 
			this.toolStripStatusLabelFontInfo.Name = "toolStripStatusLabelFontInfo";
			this.toolStripStatusLabelFontInfo.Padding = new System.Windows.Forms.Padding(0, 0, 32, 0);
			resources.ApplyResources(this.toolStripStatusLabelFontInfo, "toolStripStatusLabelFontInfo");
			this.toolStripStatusLabelFontInfo.Click += new System.EventHandler(this.menuFont_Click);
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			resources.ApplyResources(this.toolStripStatusLabel3, "toolStripStatusLabel3");
			this.toolStripStatusLabel3.Spring = true;
			// 
			// toolStripStatusLabelCssFileName
			// 
			this.toolStripStatusLabelCssFileName.Name = "toolStripStatusLabelCssFileName";
			this.toolStripStatusLabelCssFileName.Padding = new System.Windows.Forms.Padding(0, 0, 32, 0);
			resources.ApplyResources(this.toolStripStatusLabelCssFileName, "toolStripStatusLabelCssFileName");
			this.toolStripStatusLabelCssFileName.Click += new System.EventHandler(this.toolStripStatusLabelCssFileName_Click);
			// 
			// toolStripStatusLabel1
			// 
			resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			// 
			// toolStripStatusLabelHtmlEncoding
			// 
			this.toolStripStatusLabelHtmlEncoding.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
			this.toolStripStatusLabelHtmlEncoding.Name = "toolStripStatusLabelHtmlEncoding";
			this.toolStripStatusLabelHtmlEncoding.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
			resources.ApplyResources(this.toolStripStatusLabelHtmlEncoding, "toolStripStatusLabelHtmlEncoding");
			this.toolStripStatusLabelHtmlEncoding.Click += new System.EventHandler(this.toolStripStatusLabelEncoding_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuView,
            this.menuTool,
            this.menuHelp});
			resources.ApplyResources(this.menuStrip1, "menuStrip1");
			this.menuStrip1.Name = "menuStrip1";
			// 
			// menuFile
			// 
			this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewFile,
            this.menuNewWindow,
            this.menuOpenFile,
            this.menuHistoryFiles,
            this.toolStripMenuItem1,
            this.menuSaveFile,
            this.menuSaveAsFile,
            this.toolStripMenuItem5,
            this.menuOutputHtmlFile,
            this.menuOutputHtmlToClipboard,
            this.toolStripMenuItem7,
            this.menuExit});
			this.menuFile.Name = "menuFile";
			resources.ApplyResources(this.menuFile, "menuFile");
			this.menuFile.Click += new System.EventHandler(this.menuFile_Click);
			// 
			// menuNewFile
			// 
			resources.ApplyResources(this.menuNewFile, "menuNewFile");
			this.menuNewFile.Name = "menuNewFile";
			this.menuNewFile.Click += new System.EventHandler(this.menuNewFile_Click);
			// 
			// menuNewWindow
			// 
			this.menuNewWindow.Name = "menuNewWindow";
			resources.ApplyResources(this.menuNewWindow, "menuNewWindow");
			this.menuNewWindow.Click += new System.EventHandler(this.menuNewWindow_Click);
			// 
			// menuOpenFile
			// 
			resources.ApplyResources(this.menuOpenFile, "menuOpenFile");
			this.menuOpenFile.Name = "menuOpenFile";
			this.menuOpenFile.Click += new System.EventHandler(this.menuOpenFile_Click);
			// 
			// menuHistoryFiles
			// 
			this.menuHistoryFiles.Name = "menuHistoryFiles";
			resources.ApplyResources(this.menuHistoryFiles, "menuHistoryFiles");
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
			// 
			// menuSaveFile
			// 
			resources.ApplyResources(this.menuSaveFile, "menuSaveFile");
			this.menuSaveFile.Name = "menuSaveFile";
			this.menuSaveFile.Click += new System.EventHandler(this.menuSaveFile_Click);
			// 
			// menuSaveAsFile
			// 
			this.menuSaveAsFile.Name = "menuSaveAsFile";
			resources.ApplyResources(this.menuSaveAsFile, "menuSaveAsFile");
			this.menuSaveAsFile.Click += new System.EventHandler(this.menuSaveAsFile_Click);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
			// 
			// menuOutputHtmlFile
			// 
			resources.ApplyResources(this.menuOutputHtmlFile, "menuOutputHtmlFile");
			this.menuOutputHtmlFile.Name = "menuOutputHtmlFile";
			this.menuOutputHtmlFile.Click += new System.EventHandler(this.menuOutputHtmlFile_Click);
			// 
			// menuOutputHtmlToClipboard
			// 
			resources.ApplyResources(this.menuOutputHtmlToClipboard, "menuOutputHtmlToClipboard");
			this.menuOutputHtmlToClipboard.Name = "menuOutputHtmlToClipboard";
			this.menuOutputHtmlToClipboard.Click += new System.EventHandler(this.menuOutputHtmlToClipboard_Click);
			// 
			// toolStripMenuItem7
			// 
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			resources.ApplyResources(this.toolStripMenuItem7, "toolStripMenuItem7");
			// 
			// menuExit
			// 
			this.menuExit.Name = "menuExit";
			resources.ApplyResources(this.menuExit, "menuExit");
			this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
			// 
			// menuEdit
			// 
			this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUndo,
            this.menuRedo,
            this.toolStripMenuItem2,
            this.menuCut,
            this.menuCopy,
            this.menuPaste,
            this.toolStripMenuItem3,
            this.menuSelectAll,
            this.toolStripMenuItem10,
            this.menuSearch,
            this.menuReplace});
			this.menuEdit.Name = "menuEdit";
			resources.ApplyResources(this.menuEdit, "menuEdit");
			this.menuEdit.Click += new System.EventHandler(this.menuEdit_Click);
			// 
			// menuUndo
			// 
			resources.ApplyResources(this.menuUndo, "menuUndo");
			this.menuUndo.Name = "menuUndo";
			this.menuUndo.Click += new System.EventHandler(this.menuUndo_Click);
			// 
			// menuRedo
			// 
			this.menuRedo.Name = "menuRedo";
			resources.ApplyResources(this.menuRedo, "menuRedo");
			this.menuRedo.Click += new System.EventHandler(this.menuRedo_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
			// 
			// menuCut
			// 
			resources.ApplyResources(this.menuCut, "menuCut");
			this.menuCut.Name = "menuCut";
			this.menuCut.Click += new System.EventHandler(this.menuCut_Click);
			// 
			// menuCopy
			// 
			resources.ApplyResources(this.menuCopy, "menuCopy");
			this.menuCopy.Name = "menuCopy";
			this.menuCopy.Click += new System.EventHandler(this.menuCopy_Click);
			// 
			// menuPaste
			// 
			resources.ApplyResources(this.menuPaste, "menuPaste");
			this.menuPaste.Name = "menuPaste";
			this.menuPaste.Click += new System.EventHandler(this.menuPaste_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
			// 
			// menuSelectAll
			// 
			this.menuSelectAll.Name = "menuSelectAll";
			resources.ApplyResources(this.menuSelectAll, "menuSelectAll");
			this.menuSelectAll.Click += new System.EventHandler(this.menuSelectAll_Click);
			// 
			// toolStripMenuItem10
			// 
			this.toolStripMenuItem10.Name = "toolStripMenuItem10";
			resources.ApplyResources(this.toolStripMenuItem10, "toolStripMenuItem10");
			// 
			// menuSearch
			// 
			this.menuSearch.Name = "menuSearch";
			resources.ApplyResources(this.menuSearch, "menuSearch");
			this.menuSearch.Click += new System.EventHandler(this.menuSearch_Click);
			// 
			// menuReplace
			// 
			this.menuReplace.Name = "menuReplace";
			resources.ApplyResources(this.menuReplace, "menuReplace");
			this.menuReplace.Click += new System.EventHandler(this.menuReplace_Click);
			// 
			// menuView
			// 
			this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViewRefresh,
            this.menuViewAssociateBrowser,
            this.toolStripMenuItem9,
            this.menuShowHeaderListMenu,
            this.toolStripMenuItem8,
            this.menuViewToolBar,
            this.menuViewStatusBar,
            this.menuViewWidthEvenly,
            this.toolStripMenuItem11,
            this.menuViewLanguage});
			this.menuView.Name = "menuView";
			resources.ApplyResources(this.menuView, "menuView");
			// 
			// menuViewRefresh
			// 
			resources.ApplyResources(this.menuViewRefresh, "menuViewRefresh");
			this.menuViewRefresh.Name = "menuViewRefresh";
			this.menuViewRefresh.Click += new System.EventHandler(this.menuViewRefresh_Click);
			// 
			// menuViewAssociateBrowser
			// 
			resources.ApplyResources(this.menuViewAssociateBrowser, "menuViewAssociateBrowser");
			this.menuViewAssociateBrowser.Name = "menuViewAssociateBrowser";
			this.menuViewAssociateBrowser.Click += new System.EventHandler(this.toolStripButtonBrowserPreview_Click);
			// 
			// toolStripMenuItem9
			// 
			this.toolStripMenuItem9.Name = "toolStripMenuItem9";
			resources.ApplyResources(this.toolStripMenuItem9, "toolStripMenuItem9");
			// 
			// menuShowHeaderListMenu
			// 
			this.menuShowHeaderListMenu.Name = "menuShowHeaderListMenu";
			resources.ApplyResources(this.menuShowHeaderListMenu, "menuShowHeaderListMenu");
			this.menuShowHeaderListMenu.Click += new System.EventHandler(this.mnuShowHeaderListMenu_Click);
			// 
			// toolStripMenuItem8
			// 
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			resources.ApplyResources(this.toolStripMenuItem8, "toolStripMenuItem8");
			// 
			// menuViewToolBar
			// 
			this.menuViewToolBar.Checked = true;
			this.menuViewToolBar.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuViewToolBar.Name = "menuViewToolBar";
			resources.ApplyResources(this.menuViewToolBar, "menuViewToolBar");
			this.menuViewToolBar.Click += new System.EventHandler(this.menuViewToolBar_Click);
			// 
			// menuViewStatusBar
			// 
			this.menuViewStatusBar.Checked = true;
			this.menuViewStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuViewStatusBar.Name = "menuViewStatusBar";
			resources.ApplyResources(this.menuViewStatusBar, "menuViewStatusBar");
			this.menuViewStatusBar.Click += new System.EventHandler(this.menuViewStatusBar_Click);
			// 
			// menuViewWidthEvenly
			// 
			this.menuViewWidthEvenly.Name = "menuViewWidthEvenly";
			resources.ApplyResources(this.menuViewWidthEvenly, "menuViewWidthEvenly");
			this.menuViewWidthEvenly.Click += new System.EventHandler(this.menuViewWidthEvenly_Click);
			// 
			// toolStripMenuItem11
			// 
			this.toolStripMenuItem11.Name = "toolStripMenuItem11";
			resources.ApplyResources(this.toolStripMenuItem11, "toolStripMenuItem11");
			// 
			// menuViewLanguage
			// 
			this.menuViewLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuVieｗJapanese,
            this.menuViewEnglish});
			this.menuViewLanguage.Name = "menuViewLanguage";
			resources.ApplyResources(this.menuViewLanguage, "menuViewLanguage");
			// 
			// menuVieｗJapanese
			// 
			this.menuVieｗJapanese.Checked = true;
			this.menuVieｗJapanese.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuVieｗJapanese.Name = "menuVieｗJapanese";
			resources.ApplyResources(this.menuVieｗJapanese, "menuVieｗJapanese");
			this.menuVieｗJapanese.Click += new System.EventHandler(this.menuVieｗJapanese_Click);
			// 
			// menuViewEnglish
			// 
			this.menuViewEnglish.Name = "menuViewEnglish";
			resources.ApplyResources(this.menuViewEnglish, "menuViewEnglish");
			this.menuViewEnglish.Click += new System.EventHandler(this.menuViewEnglish_Click);
			// 
			// menuTool
			// 
			this.menuTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOption,
            this.toolStripMenuItem6,
            this.menuFont});
			this.menuTool.Name = "menuTool";
			resources.ApplyResources(this.menuTool, "menuTool");
			// 
			// menuOption
			// 
			resources.ApplyResources(this.menuOption, "menuOption");
			this.menuOption.Name = "menuOption";
			this.menuOption.Click += new System.EventHandler(this.menuOption_Click);
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			resources.ApplyResources(this.toolStripMenuItem6, "toolStripMenuItem6");
			// 
			// menuFont
			// 
			resources.ApplyResources(this.menuFont, "menuFont");
			this.menuFont.Name = "menuFont";
			this.menuFont.Click += new System.EventHandler(this.menuFont_Click);
			// 
			// menuHelp
			// 
			this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuContents,
            this.menuViewSample,
            this.toolStripMenuItem12,
            this.mnuCheckForUpdate,
            this.toolStripMenuItem4,
            this.menuAbout});
			this.menuHelp.Name = "menuHelp";
			resources.ApplyResources(this.menuHelp, "menuHelp");
			// 
			// menuContents
			// 
			resources.ApplyResources(this.menuContents, "menuContents");
			this.menuContents.Name = "menuContents";
			this.menuContents.Click += new System.EventHandler(this.menuContents_Click);
			// 
			// menuViewSample
			// 
			this.menuViewSample.Name = "menuViewSample";
			resources.ApplyResources(this.menuViewSample, "menuViewSample");
			this.menuViewSample.Click += new System.EventHandler(this.menuViewSample_Click);
			// 
			// toolStripMenuItem12
			// 
			this.toolStripMenuItem12.Name = "toolStripMenuItem12";
			resources.ApplyResources(this.toolStripMenuItem12, "toolStripMenuItem12");
			// 
			// mnuCheckForUpdate
			// 
			this.mnuCheckForUpdate.Name = "mnuCheckForUpdate";
			resources.ApplyResources(this.mnuCheckForUpdate, "mnuCheckForUpdate");
			this.mnuCheckForUpdate.Click += new System.EventHandler(this.mnuCheckForUpdate_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
			// 
			// menuAbout
			// 
			this.menuAbout.Name = "menuAbout";
			resources.ApplyResources(this.menuAbout, "menuAbout");
			this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.AllowItemReorder = true;
			this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNewFile,
            this.toolStripButtonOpenFile,
            this.toolStripButtonSaveFile,
            this.toolButtonOutput,
            this.toolStripSeparator2,
            this.toolStripButtonUndo,
            this.toolStripSeparator1,
            this.toolStripButtonCut,
            this.toolStripButtonCopy,
            this.toolStripButtonPaste,
            this.toolStripSeparator3,
            this.toolStripButtonOption,
            this.toolStripButtonFont,
            this.toolStripSeparator4,
            this.toolStripButtonOutputHtmlToClipBoard,
            this.toolStripSeparator5,
            this.toolStripButtonStop,
            this.toolStripButtonRefresh,
            this.toolStripButtonForward,
            this.toolStripButtonBack,
            this.toolStripSeparator6,
            this.toolStripButtonBrowserPreview});
			resources.ApplyResources(this.toolStrip1, "toolStrip1");
			this.toolStrip1.Name = "toolStrip1";
			// 
			// toolStripButtonNewFile
			// 
			this.toolStripButtonNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.toolStripButtonNewFile, "toolStripButtonNewFile");
			this.toolStripButtonNewFile.Name = "toolStripButtonNewFile";
			this.toolStripButtonNewFile.Click += new System.EventHandler(this.menuNewFile_Click);
			// 
			// toolStripButtonOpenFile
			// 
			this.toolStripButtonOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.toolStripButtonOpenFile, "toolStripButtonOpenFile");
			this.toolStripButtonOpenFile.Name = "toolStripButtonOpenFile";
			this.toolStripButtonOpenFile.Click += new System.EventHandler(this.menuOpenFile_Click);
			// 
			// toolStripButtonSaveFile
			// 
			this.toolStripButtonSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.toolStripButtonSaveFile, "toolStripButtonSaveFile");
			this.toolStripButtonSaveFile.Name = "toolStripButtonSaveFile";
			this.toolStripButtonSaveFile.Click += new System.EventHandler(this.menuSaveFile_Click);
			// 
			// toolButtonOutput
			// 
			this.toolButtonOutput.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolButtonOutput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.toolButtonOutput, "toolButtonOutput");
			this.toolButtonOutput.Name = "toolButtonOutput";
			this.toolButtonOutput.Click += new System.EventHandler(this.menuOutputHtmlFile_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
			// 
			// toolStripButtonUndo
			// 
			this.toolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.toolStripButtonUndo, "toolStripButtonUndo");
			this.toolStripButtonUndo.Name = "toolStripButtonUndo";
			this.toolStripButtonUndo.Click += new System.EventHandler(this.menuUndo_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
			// 
			// toolStripButtonCut
			// 
			this.toolStripButtonCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.toolStripButtonCut, "toolStripButtonCut");
			this.toolStripButtonCut.Name = "toolStripButtonCut";
			this.toolStripButtonCut.Click += new System.EventHandler(this.menuCut_Click);
			// 
			// toolStripButtonCopy
			// 
			this.toolStripButtonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.toolStripButtonCopy, "toolStripButtonCopy");
			this.toolStripButtonCopy.Name = "toolStripButtonCopy";
			this.toolStripButtonCopy.Click += new System.EventHandler(this.menuCopy_Click);
			// 
			// toolStripButtonPaste
			// 
			this.toolStripButtonPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.toolStripButtonPaste, "toolStripButtonPaste");
			this.toolStripButtonPaste.Name = "toolStripButtonPaste";
			this.toolStripButtonPaste.Click += new System.EventHandler(this.menuPaste_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
			// 
			// toolStripButtonOption
			// 
			this.toolStripButtonOption.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.toolStripButtonOption, "toolStripButtonOption");
			this.toolStripButtonOption.Name = "toolStripButtonOption";
			this.toolStripButtonOption.Click += new System.EventHandler(this.menuOption_Click);
			// 
			// toolStripButtonFont
			// 
			this.toolStripButtonFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.toolStripButtonFont, "toolStripButtonFont");
			this.toolStripButtonFont.Name = "toolStripButtonFont";
			this.toolStripButtonFont.Click += new System.EventHandler(this.menuFont_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
			// 
			// toolStripButtonOutputHtmlToClipBoard
			// 
			this.toolStripButtonOutputHtmlToClipBoard.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripButtonOutputHtmlToClipBoard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.toolStripButtonOutputHtmlToClipBoard, "toolStripButtonOutputHtmlToClipBoard");
			this.toolStripButtonOutputHtmlToClipBoard.Name = "toolStripButtonOutputHtmlToClipBoard";
			this.toolStripButtonOutputHtmlToClipBoard.Click += new System.EventHandler(this.menuOutputHtmlToClipboard_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
			// 
			// toolStripButtonStop
			// 
			this.toolStripButtonStop.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.toolStripButtonStop, "toolStripButtonStop");
			this.toolStripButtonStop.Margin = new System.Windows.Forms.Padding(0, 1, 16, 2);
			this.toolStripButtonStop.Name = "toolStripButtonStop";
			this.toolStripButtonStop.Click += new System.EventHandler(this.toolStripButtonStop_Click);
			// 
			// toolStripButtonRefresh
			// 
			this.toolStripButtonRefresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.toolStripButtonRefresh, "toolStripButtonRefresh");
			this.toolStripButtonRefresh.Margin = new System.Windows.Forms.Padding(0, 1, 4, 2);
			this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
			this.toolStripButtonRefresh.Click += new System.EventHandler(this.menuViewRefresh_Click);
			// 
			// toolStripButtonForward
			// 
			this.toolStripButtonForward.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripButtonForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.toolStripButtonForward, "toolStripButtonForward");
			this.toolStripButtonForward.Margin = new System.Windows.Forms.Padding(0, 1, 4, 2);
			this.toolStripButtonForward.Name = "toolStripButtonForward";
			this.toolStripButtonForward.Click += new System.EventHandler(this.toolStripButtonForward_Click);
			// 
			// toolStripButtonBack
			// 
			this.toolStripButtonBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripButtonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.toolStripButtonBack, "toolStripButtonBack");
			this.toolStripButtonBack.Margin = new System.Windows.Forms.Padding(0, 1, 4, 2);
			this.toolStripButtonBack.Name = "toolStripButtonBack";
			this.toolStripButtonBack.Click += new System.EventHandler(this.toolStripButtonBack_Click);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
			// 
			// toolStripButtonBrowserPreview
			// 
			this.toolStripButtonBrowserPreview.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripButtonBrowserPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.toolStripButtonBrowserPreview, "toolStripButtonBrowserPreview");
			this.toolStripButtonBrowserPreview.Margin = new System.Windows.Forms.Padding(0, 1, 16, 2);
			this.toolStripButtonBrowserPreview.Name = "toolStripButtonBrowserPreview";
			this.toolStripButtonBrowserPreview.Click += new System.EventHandler(this.toolStripButtonBrowserPreview_Click);
			// 
			// openFileDialog1
			// 
			resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "md";
			resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
			// 
			// fontDialog1
			// 
			this.fontDialog1.Color = System.Drawing.SystemColors.ControlText;
			// 
			// contextMenu1
			// 
			this.contextMenu1.Name = "contextMenuStrip1";
			resources.ApplyResources(this.contextMenu1, "contextMenu1");
			this.contextMenu1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenu1_ItemClicked);
			// 
			// saveFileDialog2
			// 
			this.saveFileDialog2.DefaultExt = "html";
			resources.ApplyResources(this.saveFileDialog2, "saveFileDialog2");
			// 
			// timer1
			// 
			this.timer1.Interval = 10;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// contextMenu2
			// 
			this.contextMenu2.Name = "contextMenu2";
			resources.ApplyResources(this.contextMenu2, "contextMenu2");
			this.contextMenu2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenu2_ItemClicked);
			// 
			// panelSearch
			// 
			this.panelSearch.Controls.Add(this.cmdReplaceAll);
			this.panelSearch.Controls.Add(this.labelReplace);
			this.panelSearch.Controls.Add(this.textBoxReplace);
			this.panelSearch.Controls.Add(this.imgSearchExitUnabled);
			this.panelSearch.Controls.Add(this.imgSearchExitEnabled);
			this.panelSearch.Controls.Add(this.chkOptionCase);
			this.panelSearch.Controls.Add(this.imgSearchExit);
			this.panelSearch.Controls.Add(this.cmdSearchNext);
			this.panelSearch.Controls.Add(this.cmdSearchPrev);
			this.panelSearch.Controls.Add(this.labelSearch);
			this.panelSearch.Controls.Add(this.textBoxSearch);
			resources.ApplyResources(this.panelSearch, "panelSearch");
			this.panelSearch.Name = "panelSearch";
			// 
			// cmdReplaceAll
			// 
			resources.ApplyResources(this.cmdReplaceAll, "cmdReplaceAll");
			this.cmdReplaceAll.Name = "cmdReplaceAll";
			this.cmdReplaceAll.UseVisualStyleBackColor = true;
			this.cmdReplaceAll.Click += new System.EventHandler(this.cmdReplaceAll_Click);
			// 
			// labelReplace
			// 
			resources.ApplyResources(this.labelReplace, "labelReplace");
			this.labelReplace.Name = "labelReplace";
			// 
			// textBoxReplace
			// 
			resources.ApplyResources(this.textBoxReplace, "textBoxReplace");
			this.textBoxReplace.Name = "textBoxReplace";
			this.textBoxReplace.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxReplace_KeyDown);
			this.textBoxReplace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxReplace_KeyPress);
			// 
			// imgSearchExitUnabled
			// 
			resources.ApplyResources(this.imgSearchExitUnabled, "imgSearchExitUnabled");
			this.imgSearchExitUnabled.Name = "imgSearchExitUnabled";
			this.imgSearchExitUnabled.TabStop = false;
			// 
			// imgSearchExitEnabled
			// 
			resources.ApplyResources(this.imgSearchExitEnabled, "imgSearchExitEnabled");
			this.imgSearchExitEnabled.Name = "imgSearchExitEnabled";
			this.imgSearchExitEnabled.TabStop = false;
			// 
			// chkOptionCase
			// 
			resources.ApplyResources(this.chkOptionCase, "chkOptionCase");
			this.chkOptionCase.Name = "chkOptionCase";
			this.chkOptionCase.UseVisualStyleBackColor = true;
			// 
			// imgSearchExit
			// 
			resources.ApplyResources(this.imgSearchExit, "imgSearchExit");
			this.imgSearchExit.Name = "imgSearchExit";
			this.imgSearchExit.TabStop = false;
			this.imgSearchExit.Click += new System.EventHandler(this.imgSearchExit_Click);
			this.imgSearchExit.MouseEnter += new System.EventHandler(this.imgSearchExit_MouseEnter);
			this.imgSearchExit.MouseLeave += new System.EventHandler(this.imgSearchExit_MouseLeave);
			// 
			// cmdSearchNext
			// 
			resources.ApplyResources(this.cmdSearchNext, "cmdSearchNext");
			this.cmdSearchNext.Name = "cmdSearchNext";
			this.cmdSearchNext.UseVisualStyleBackColor = true;
			this.cmdSearchNext.Click += new System.EventHandler(this.cmdSearchNext_Click);
			// 
			// cmdSearchPrev
			// 
			resources.ApplyResources(this.cmdSearchPrev, "cmdSearchPrev");
			this.cmdSearchPrev.Name = "cmdSearchPrev";
			this.cmdSearchPrev.UseVisualStyleBackColor = true;
			this.cmdSearchPrev.Click += new System.EventHandler(this.cmdSearchPrev_Click);
			// 
			// labelSearch
			// 
			resources.ApplyResources(this.labelSearch, "labelSearch");
			this.labelSearch.Name = "labelSearch";
			// 
			// textBoxSearch
			// 
			resources.ApplyResources(this.textBoxSearch, "textBoxSearch");
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
			this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
			this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
			this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			// 
			// backgroundWorker2
			// 
			this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
			this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
			this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
			// 
			// timer2
			// 
			this.timer2.Interval = 1000;
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// Form1
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ContextMenuStrip = this.contextMenu1;
			this.Controls.Add(this.panelSearch);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Name = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Shown += new System.EventHandler(this.Form1_Shown);
			this.ResizeBegin += new System.EventHandler(this.Form1_ResizeBegin);
			this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.panelSearch.ResumeLayout(false);
			this.panelSearch.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgSearchExitUnabled)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgSearchExitEnabled)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgSearchExit)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
				private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuNewFile;
        private System.Windows.Forms.ToolStripMenuItem menuOpenFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuSaveFile;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAsFile;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuUndo;
        private System.Windows.Forms.ToolStripMenuItem menuRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuCut;
        private System.Windows.Forms.ToolStripMenuItem menuCopy;
        private System.Windows.Forms.ToolStripMenuItem menuPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem menuSelectAll;
        private System.Windows.Forms.ToolStripMenuItem menuTool;
        private System.Windows.Forms.ToolStripMenuItem menuOption;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuContents;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripButton toolStripButtonNewFile;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveFile;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpenFile;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripButton toolButtonOutput;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonUndo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonCut;
        private System.Windows.Forms.ToolStripButton toolStripButtonCopy;
        private System.Windows.Forms.ToolStripButton toolStripButtonPaste;
        private System.Windows.Forms.ToolStripMenuItem menuViewToolBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuViewStatusBar;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem menuFont;
        private System.Windows.Forms.ToolStripButton toolStripButtonOption;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem menuViewWidthEvenly;
        private System.Windows.Forms.ToolStripButton toolStripButtonFont;
        private System.Windows.Forms.ToolStripMenuItem menuOutputHtmlFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFontInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCssFileName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHtmlEncoding;
        private System.Windows.Forms.ContextMenuStrip contextMenu1;
		private System.Windows.Forms.ToolStripMenuItem menuOutputHtmlToClipboard;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton toolStripButtonOutputHtmlToClipBoard;
		private System.Windows.Forms.SaveFileDialog saveFileDialog2;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTextEncoding;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
		private System.Windows.Forms.ToolStripMenuItem menuViewRefresh;
		private System.Windows.Forms.ToolStripMenuItem menuViewSample;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripMenuItem menuHistoryFiles;
		private System.Windows.Forms.ToolStripMenuItem menuNewWindow;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripButton toolStripButtonForward;
		private System.Windows.Forms.ToolStripButton toolStripButtonBack;
		private RichTextBoxEx richTextBox1;
		private System.Windows.Forms.ToolStripButton toolStripButtonStop;
		private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripButton toolStripButtonBrowserPreview;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
		private System.Windows.Forms.ToolStripMenuItem menuViewAssociateBrowser;
		private System.Windows.Forms.ContextMenuStrip contextMenu2;
		private System.Windows.Forms.ToolStripMenuItem menuShowHeaderListMenu;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
		private System.Windows.Forms.Panel panelSearch;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Label labelSearch;
		private System.Windows.Forms.Button cmdSearchNext;
		private System.Windows.Forms.Button cmdSearchPrev;
		private System.Windows.Forms.PictureBox imgSearchExit;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
		private System.Windows.Forms.ToolStripMenuItem menuSearch;
		private System.Windows.Forms.PictureBox imgSearchExitUnabled;
		private System.Windows.Forms.PictureBox imgSearchExitEnabled;
		private System.Windows.Forms.ToolStripMenuItem menuReplace;
		private System.Windows.Forms.CheckBox chkOptionCase;
		private System.Windows.Forms.Label labelReplace;
		private System.Windows.Forms.TextBox textBoxReplace;
		private System.Windows.Forms.Button cmdReplaceAll;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem11;
		private System.Windows.Forms.ToolStripMenuItem menuViewLanguage;
		private System.Windows.Forms.ToolStripMenuItem menuVieｗJapanese;
		private System.Windows.Forms.ToolStripMenuItem menuViewEnglish;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem12;
		private System.Windows.Forms.ToolStripMenuItem mnuCheckForUpdate;
		private System.ComponentModel.BackgroundWorker backgroundWorker2;
		private System.Windows.Forms.Timer timer2;

    }
}

