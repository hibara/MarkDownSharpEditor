namespace MarkDownSharpEditor
{
    partial class Form3
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
			this.panel1 = new System.Windows.Forms.Panel();
			this.cmdOpenAppData = new System.Windows.Forms.Button();
			this.cmdCancel = new System.Windows.Forms.Button();
			this.cmdApply = new System.Windows.Forms.Button();
			this.cmdOK = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageMain = new System.Windows.Forms.TabPage();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBoxMarkdownType = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cmdUnAssociateFiles = new System.Windows.Forms.Button();
			this.cmdAssociateFiles = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.imgStrike = new System.Windows.Forms.PictureBox();
			this.comboPreviewInterval = new System.Windows.Forms.ComboBox();
			this.lblPreviewIntervalCaption = new System.Windows.Forms.Label();
			this.checkBoxEditingHighlightColor = new System.Windows.Forms.CheckBox();
			this.labelHtmlColorName = new System.Windows.Forms.Label();
			this.labelHighLightColor = new System.Windows.Forms.Label();
			this.checkBoxShowHtmlToClipboardMessage = new System.Windows.Forms.CheckBox();
			this.checkBoxShowHtmlSaveDialog = new System.Windows.Forms.CheckBox();
			this.checkBoxOpenEditFileBefore = new System.Windows.Forms.CheckBox();
			this.tabPageEdit = new System.Windows.Forms.TabPage();
			this.tabControl2 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBoxMarkdown = new System.Windows.Forms.GroupBox();
			this.labelMainBackColor = new System.Windows.Forms.Label();
			this.labelMainForeColor = new System.Windows.Forms.Label();
			this.labelMainColor = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.labelBlockquotesBackColor = new System.Windows.Forms.Label();
			this.labelBlockquotesForeColor = new System.Windows.Forms.Label();
			this.labelBlockquotesColor = new System.Windows.Forms.Label();
			this.labelCodeBlockBackColor = new System.Windows.Forms.Label();
			this.labelCodeBlockForeColor = new System.Windows.Forms.Label();
			this.labelCodeBlockColor = new System.Windows.Forms.Label();
			this.labelCommentsBackColor = new System.Windows.Forms.Label();
			this.labelCommentsForeColor = new System.Windows.Forms.Label();
			this.labelHorizontalBackColor = new System.Windows.Forms.Label();
			this.labelHorizontalForeColor = new System.Windows.Forms.Label();
			this.labelCodeBackColor = new System.Windows.Forms.Label();
			this.labelCodeForeColor = new System.Windows.Forms.Label();
			this.labelListsBackColor = new System.Windows.Forms.Label();
			this.labelListsForeColor = new System.Windows.Forms.Label();
			this.labelEmphasisBackColor = new System.Windows.Forms.Label();
			this.labelEmphasisForeColor = new System.Windows.Forms.Label();
			this.labelLinksBackColor = new System.Windows.Forms.Label();
			this.labelLinksForeColor = new System.Windows.Forms.Label();
			this.labelImagesBackColor = new System.Windows.Forms.Label();
			this.labelImagesForeColor = new System.Windows.Forms.Label();
			this.labelHeadLine6BackColor = new System.Windows.Forms.Label();
			this.labelHeadLine6ForeColor = new System.Windows.Forms.Label();
			this.labelHeadLine5BackColor = new System.Windows.Forms.Label();
			this.labelHeadLine5ForeColor = new System.Windows.Forms.Label();
			this.labelHeadLine4BackColor = new System.Windows.Forms.Label();
			this.labelHeadLine4ForeColor = new System.Windows.Forms.Label();
			this.labelHeadLine3BackColor = new System.Windows.Forms.Label();
			this.labelHeadLine3ForeColor = new System.Windows.Forms.Label();
			this.labelHeadLine2BackColor = new System.Windows.Forms.Label();
			this.labelHeadLine2ForeColor = new System.Windows.Forms.Label();
			this.labelHeadLine1BackColor = new System.Windows.Forms.Label();
			this.labelHeadLine1ForeColor = new System.Windows.Forms.Label();
			this.labelLineBreakBackColor = new System.Windows.Forms.Label();
			this.labelLineBreakForeColor = new System.Windows.Forms.Label();
			this.labelCommentsColor = new System.Windows.Forms.Label();
			this.labelImagesColor = new System.Windows.Forms.Label();
			this.labelEmphasisColor = new System.Windows.Forms.Label();
			this.labelHorizontalColor = new System.Windows.Forms.Label();
			this.labelLinksColor = new System.Windows.Forms.Label();
			this.labelCodeColor = new System.Windows.Forms.Label();
			this.labelListsColor = new System.Windows.Forms.Label();
			this.labelHeadLine6Color = new System.Windows.Forms.Label();
			this.labelHeadLine5Color = new System.Windows.Forms.Label();
			this.labelHeadLine4Color = new System.Windows.Forms.Label();
			this.labelHeadLine3Color = new System.Windows.Forms.Label();
			this.labelHeadLine2Color = new System.Windows.Forms.Label();
			this.labelHeadLine1Color = new System.Windows.Forms.Label();
			this.labelLineBreakColor = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBoxMarkdownExtra = new System.Windows.Forms.GroupBox();
			this.labelMarkdownExtraNotice = new System.Windows.Forms.Label();
			this.labelBackslashEscapesBackColor = new System.Windows.Forms.Label();
			this.labelBackslashEscapesForeColor = new System.Windows.Forms.Label();
			this.labelAbbreviationsBackColor = new System.Windows.Forms.Label();
			this.labelAbbreviationsForeColor = new System.Windows.Forms.Label();
			this.labelFootnotesBackColor = new System.Windows.Forms.Label();
			this.labelFootnotesForeColor = new System.Windows.Forms.Label();
			this.labelDefinitionListsBackColor = new System.Windows.Forms.Label();
			this.labelDefinitionListsForeColor = new System.Windows.Forms.Label();
			this.labelTablesBackColor = new System.Windows.Forms.Label();
			this.labelTablesForeColor = new System.Windows.Forms.Label();
			this.labelFencedCodeBlocksBackColor = new System.Windows.Forms.Label();
			this.labelFencedCodeBlocksForeColor = new System.Windows.Forms.Label();
			this.labelSpecialAttributesBackColor = new System.Windows.Forms.Label();
			this.labelSpecialAttributesForeColor = new System.Windows.Forms.Label();
			this.labelBackslashEscapesColor = new System.Windows.Forms.Label();
			this.labelAbbreviationsColor = new System.Windows.Forms.Label();
			this.labelFootnotesColor = new System.Windows.Forms.Label();
			this.labelDefinitionListsColor = new System.Windows.Forms.Label();
			this.labelTablesColor = new System.Windows.Forms.Label();
			this.labelFencedCodeBlocksColor = new System.Windows.Forms.Label();
			this.labelSpecialAttributesColor = new System.Windows.Forms.Label();
			this.labelMarkdownInsideHTMLBlocksBackColor = new System.Windows.Forms.Label();
			this.labelMarkdownInsideHTMLBlocksForeColor = new System.Windows.Forms.Label();
			this.labelMarkdownInsideHTMLBlocksColor = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.tabPageCSS = new System.Windows.Forms.TabPage();
			this.cmdDownItem = new System.Windows.Forms.Button();
			this.cmdUpItem = new System.Windows.Forms.Button();
			this.cmdAddCssFolder = new System.Windows.Forms.Button();
			this.lblDefaultCssFileName = new System.Windows.Forms.Label();
			this.listViewCssFiles = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cmdOpenCssDir = new System.Windows.Forms.Button();
			this.cmdDeleteCssItem = new System.Windows.Forms.Button();
			this.cmdAddCssFile = new System.Windows.Forms.Button();
			this.tabPageHTML = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBoxCssOption = new System.Windows.Forms.GroupBox();
			this.radioButtonInsertLinkTag = new System.Windows.Forms.RadioButton();
			this.radioButtonImportCssFile = new System.Windows.Forms.RadioButton();
			this.comboBoxHtmlHeader = new System.Windows.Forms.ComboBox();
			this.chkInsertHtmlHeader = new System.Windows.Forms.CheckBox();
			this.groupBoxEncoding = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxSelectEncoding = new System.Windows.Forms.ComboBox();
			this.radioButtonChangeEncoding = new System.Windows.Forms.RadioButton();
			this.radioButtonDefaultEncoding = new System.Windows.Forms.RadioButton();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.fontDialog1 = new System.Windows.Forms.FontDialog();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.panel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPageMain.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgStrike)).BeginInit();
			this.tabPageEdit.SuspendLayout();
			this.tabControl2.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBoxMarkdown.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBoxMarkdownExtra.SuspendLayout();
			this.tabPageCSS.SuspendLayout();
			this.tabPageHTML.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBoxCssOption.SuspendLayout();
			this.groupBoxEncoding.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cmdOpenAppData);
			this.panel1.Controls.Add(this.cmdCancel);
			this.panel1.Controls.Add(this.cmdApply);
			this.panel1.Controls.Add(this.cmdOK);
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Name = "panel1";
			// 
			// cmdOpenAppData
			// 
			resources.ApplyResources(this.cmdOpenAppData, "cmdOpenAppData");
			this.cmdOpenAppData.Name = "cmdOpenAppData";
			this.toolTip1.SetToolTip(this.cmdOpenAppData, resources.GetString("cmdOpenAppData.ToolTip"));
			this.cmdOpenAppData.UseVisualStyleBackColor = true;
			this.cmdOpenAppData.Click += new System.EventHandler(this.cmdAppDataFolder_Click);
			// 
			// cmdCancel
			// 
			resources.ApplyResources(this.cmdCancel, "cmdCancel");
			this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.UseVisualStyleBackColor = true;
			this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
			// 
			// cmdApply
			// 
			resources.ApplyResources(this.cmdApply, "cmdApply");
			this.cmdApply.Name = "cmdApply";
			this.cmdApply.UseVisualStyleBackColor = true;
			this.cmdApply.Click += new System.EventHandler(this.cmdApply_Click);
			// 
			// cmdOK
			// 
			resources.ApplyResources(this.cmdOK, "cmdOK");
			this.cmdOK.Name = "cmdOK";
			this.cmdOK.UseVisualStyleBackColor = true;
			this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
			// 
			// tabControl1
			// 
			resources.ApplyResources(this.tabControl1, "tabControl1");
			this.tabControl1.Controls.Add(this.tabPageMain);
			this.tabControl1.Controls.Add(this.tabPageEdit);
			this.tabControl1.Controls.Add(this.tabPageCSS);
			this.tabControl1.Controls.Add(this.tabPageHTML);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			// 
			// tabPageMain
			// 
			this.tabPageMain.Controls.Add(this.label3);
			this.tabPageMain.Controls.Add(this.comboBoxMarkdownType);
			this.tabPageMain.Controls.Add(this.groupBox1);
			this.tabPageMain.Controls.Add(this.groupBox2);
			this.tabPageMain.Controls.Add(this.checkBoxOpenEditFileBefore);
			resources.ApplyResources(this.tabPageMain, "tabPageMain");
			this.tabPageMain.Name = "tabPageMain";
			this.tabPageMain.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// comboBoxMarkdownType
			// 
			this.comboBoxMarkdownType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMarkdownType.FormattingEnabled = true;
			this.comboBoxMarkdownType.Items.AddRange(new object[] {
            resources.GetString("comboBoxMarkdownType.Items"),
            resources.GetString("comboBoxMarkdownType.Items1")});
			resources.ApplyResources(this.comboBoxMarkdownType, "comboBoxMarkdownType");
			this.comboBoxMarkdownType.Name = "comboBoxMarkdownType";
			this.comboBoxMarkdownType.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarkdownType_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.cmdUnAssociateFiles);
			this.groupBox1.Controls.Add(this.cmdAssociateFiles);
			resources.ApplyResources(this.groupBox1, "groupBox1");
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.TabStop = false;
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.ForeColor = System.Drawing.Color.Green;
			this.label2.Name = "label2";
			// 
			// cmdUnAssociateFiles
			// 
			resources.ApplyResources(this.cmdUnAssociateFiles, "cmdUnAssociateFiles");
			this.cmdUnAssociateFiles.Name = "cmdUnAssociateFiles";
			this.cmdUnAssociateFiles.UseVisualStyleBackColor = true;
			this.cmdUnAssociateFiles.Click += new System.EventHandler(this.cmdUnAssociateFiles_Click);
			// 
			// cmdAssociateFiles
			// 
			resources.ApplyResources(this.cmdAssociateFiles, "cmdAssociateFiles");
			this.cmdAssociateFiles.Name = "cmdAssociateFiles";
			this.cmdAssociateFiles.UseVisualStyleBackColor = true;
			this.cmdAssociateFiles.Click += new System.EventHandler(this.cmdAssociateFiles_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.imgStrike);
			this.groupBox2.Controls.Add(this.comboPreviewInterval);
			this.groupBox2.Controls.Add(this.lblPreviewIntervalCaption);
			this.groupBox2.Controls.Add(this.checkBoxEditingHighlightColor);
			this.groupBox2.Controls.Add(this.labelHtmlColorName);
			this.groupBox2.Controls.Add(this.labelHighLightColor);
			this.groupBox2.Controls.Add(this.checkBoxShowHtmlToClipboardMessage);
			this.groupBox2.Controls.Add(this.checkBoxShowHtmlSaveDialog);
			resources.ApplyResources(this.groupBox2, "groupBox2");
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.TabStop = false;
			// 
			// imgStrike
			// 
			resources.ApplyResources(this.imgStrike, "imgStrike");
			this.imgStrike.Name = "imgStrike";
			this.imgStrike.TabStop = false;
			// 
			// comboPreviewInterval
			// 
			this.comboPreviewInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboPreviewInterval.FormattingEnabled = true;
			this.comboPreviewInterval.Items.AddRange(new object[] {
            resources.GetString("comboPreviewInterval.Items"),
            resources.GetString("comboPreviewInterval.Items1"),
            resources.GetString("comboPreviewInterval.Items2"),
            resources.GetString("comboPreviewInterval.Items3"),
            resources.GetString("comboPreviewInterval.Items4"),
            resources.GetString("comboPreviewInterval.Items5"),
            resources.GetString("comboPreviewInterval.Items6"),
            resources.GetString("comboPreviewInterval.Items7"),
            resources.GetString("comboPreviewInterval.Items8"),
            resources.GetString("comboPreviewInterval.Items9"),
            resources.GetString("comboPreviewInterval.Items10")});
			resources.ApplyResources(this.comboPreviewInterval, "comboPreviewInterval");
			this.comboPreviewInterval.Name = "comboPreviewInterval";
			this.comboPreviewInterval.SelectionChangeCommitted += new System.EventHandler(this.comboPreviewInterval_SelectionChangeCommitted);
			// 
			// lblPreviewIntervalCaption
			// 
			resources.ApplyResources(this.lblPreviewIntervalCaption, "lblPreviewIntervalCaption");
			this.lblPreviewIntervalCaption.Name = "lblPreviewIntervalCaption";
			// 
			// checkBoxEditingHighlightColor
			// 
			resources.ApplyResources(this.checkBoxEditingHighlightColor, "checkBoxEditingHighlightColor");
			this.checkBoxEditingHighlightColor.Name = "checkBoxEditingHighlightColor";
			this.checkBoxEditingHighlightColor.UseVisualStyleBackColor = true;
			this.checkBoxEditingHighlightColor.Click += new System.EventHandler(this.checkBoxEditingHighlightColor_Click);
			// 
			// labelHtmlColorName
			// 
			resources.ApplyResources(this.labelHtmlColorName, "labelHtmlColorName");
			this.labelHtmlColorName.Name = "labelHtmlColorName";
			// 
			// labelHighLightColor
			// 
			this.labelHighLightColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelHighLightColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.labelHighLightColor, "labelHighLightColor");
			this.labelHighLightColor.Name = "labelHighLightColor";
			this.labelHighLightColor.Click += new System.EventHandler(this.labelHighLightColor_Click);
			// 
			// checkBoxShowHtmlToClipboardMessage
			// 
			resources.ApplyResources(this.checkBoxShowHtmlToClipboardMessage, "checkBoxShowHtmlToClipboardMessage");
			this.checkBoxShowHtmlToClipboardMessage.Name = "checkBoxShowHtmlToClipboardMessage";
			this.checkBoxShowHtmlToClipboardMessage.UseVisualStyleBackColor = true;
			// 
			// checkBoxShowHtmlSaveDialog
			// 
			resources.ApplyResources(this.checkBoxShowHtmlSaveDialog, "checkBoxShowHtmlSaveDialog");
			this.checkBoxShowHtmlSaveDialog.Name = "checkBoxShowHtmlSaveDialog";
			this.checkBoxShowHtmlSaveDialog.UseVisualStyleBackColor = true;
			// 
			// checkBoxOpenEditFileBefore
			// 
			resources.ApplyResources(this.checkBoxOpenEditFileBefore, "checkBoxOpenEditFileBefore");
			this.checkBoxOpenEditFileBefore.Name = "checkBoxOpenEditFileBefore";
			this.checkBoxOpenEditFileBefore.UseVisualStyleBackColor = true;
			// 
			// tabPageEdit
			// 
			this.tabPageEdit.Controls.Add(this.tabControl2);
			resources.ApplyResources(this.tabPageEdit, "tabPageEdit");
			this.tabPageEdit.Name = "tabPageEdit";
			this.tabPageEdit.UseVisualStyleBackColor = true;
			// 
			// tabControl2
			// 
			this.tabControl2.Controls.Add(this.tabPage1);
			this.tabControl2.Controls.Add(this.tabPage2);
			resources.ApplyResources(this.tabControl2, "tabControl2");
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.SelectedIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.groupBoxMarkdown);
			resources.ApplyResources(this.tabPage1, "tabPage1");
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// groupBoxMarkdown
			// 
			this.groupBoxMarkdown.Controls.Add(this.labelMainBackColor);
			this.groupBoxMarkdown.Controls.Add(this.labelMainForeColor);
			this.groupBoxMarkdown.Controls.Add(this.labelMainColor);
			this.groupBoxMarkdown.Controls.Add(this.label6);
			this.groupBoxMarkdown.Controls.Add(this.label7);
			this.groupBoxMarkdown.Controls.Add(this.label5);
			this.groupBoxMarkdown.Controls.Add(this.label4);
			this.groupBoxMarkdown.Controls.Add(this.labelBlockquotesBackColor);
			this.groupBoxMarkdown.Controls.Add(this.labelBlockquotesForeColor);
			this.groupBoxMarkdown.Controls.Add(this.labelBlockquotesColor);
			this.groupBoxMarkdown.Controls.Add(this.labelCodeBlockBackColor);
			this.groupBoxMarkdown.Controls.Add(this.labelCodeBlockForeColor);
			this.groupBoxMarkdown.Controls.Add(this.labelCodeBlockColor);
			this.groupBoxMarkdown.Controls.Add(this.labelCommentsBackColor);
			this.groupBoxMarkdown.Controls.Add(this.labelCommentsForeColor);
			this.groupBoxMarkdown.Controls.Add(this.labelHorizontalBackColor);
			this.groupBoxMarkdown.Controls.Add(this.labelHorizontalForeColor);
			this.groupBoxMarkdown.Controls.Add(this.labelCodeBackColor);
			this.groupBoxMarkdown.Controls.Add(this.labelCodeForeColor);
			this.groupBoxMarkdown.Controls.Add(this.labelListsBackColor);
			this.groupBoxMarkdown.Controls.Add(this.labelListsForeColor);
			this.groupBoxMarkdown.Controls.Add(this.labelEmphasisBackColor);
			this.groupBoxMarkdown.Controls.Add(this.labelEmphasisForeColor);
			this.groupBoxMarkdown.Controls.Add(this.labelLinksBackColor);
			this.groupBoxMarkdown.Controls.Add(this.labelLinksForeColor);
			this.groupBoxMarkdown.Controls.Add(this.labelImagesBackColor);
			this.groupBoxMarkdown.Controls.Add(this.labelImagesForeColor);
			this.groupBoxMarkdown.Controls.Add(this.labelHeadLine6BackColor);
			this.groupBoxMarkdown.Controls.Add(this.labelHeadLine6ForeColor);
			this.groupBoxMarkdown.Controls.Add(this.labelHeadLine5BackColor);
			this.groupBoxMarkdown.Controls.Add(this.labelHeadLine5ForeColor);
			this.groupBoxMarkdown.Controls.Add(this.labelHeadLine4BackColor);
			this.groupBoxMarkdown.Controls.Add(this.labelHeadLine4ForeColor);
			this.groupBoxMarkdown.Controls.Add(this.labelHeadLine3BackColor);
			this.groupBoxMarkdown.Controls.Add(this.labelHeadLine3ForeColor);
			this.groupBoxMarkdown.Controls.Add(this.labelHeadLine2BackColor);
			this.groupBoxMarkdown.Controls.Add(this.labelHeadLine2ForeColor);
			this.groupBoxMarkdown.Controls.Add(this.labelHeadLine1BackColor);
			this.groupBoxMarkdown.Controls.Add(this.labelHeadLine1ForeColor);
			this.groupBoxMarkdown.Controls.Add(this.labelLineBreakBackColor);
			this.groupBoxMarkdown.Controls.Add(this.labelLineBreakForeColor);
			this.groupBoxMarkdown.Controls.Add(this.labelCommentsColor);
			this.groupBoxMarkdown.Controls.Add(this.labelImagesColor);
			this.groupBoxMarkdown.Controls.Add(this.labelEmphasisColor);
			this.groupBoxMarkdown.Controls.Add(this.labelHorizontalColor);
			this.groupBoxMarkdown.Controls.Add(this.labelLinksColor);
			this.groupBoxMarkdown.Controls.Add(this.labelCodeColor);
			this.groupBoxMarkdown.Controls.Add(this.labelListsColor);
			this.groupBoxMarkdown.Controls.Add(this.labelHeadLine6Color);
			this.groupBoxMarkdown.Controls.Add(this.labelHeadLine5Color);
			this.groupBoxMarkdown.Controls.Add(this.labelHeadLine4Color);
			this.groupBoxMarkdown.Controls.Add(this.labelHeadLine3Color);
			this.groupBoxMarkdown.Controls.Add(this.labelHeadLine2Color);
			this.groupBoxMarkdown.Controls.Add(this.labelHeadLine1Color);
			this.groupBoxMarkdown.Controls.Add(this.labelLineBreakColor);
			resources.ApplyResources(this.groupBoxMarkdown, "groupBoxMarkdown");
			this.groupBoxMarkdown.Name = "groupBoxMarkdown";
			this.groupBoxMarkdown.TabStop = false;
			// 
			// labelMainBackColor
			// 
			this.labelMainBackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelMainBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelMainBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelMainBackColor, "labelMainBackColor");
			this.labelMainBackColor.Name = "labelMainBackColor";
			this.labelMainBackColor.Click += new System.EventHandler(this.labelBackColor_Click);
			// 
			// labelMainForeColor
			// 
			this.labelMainForeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelMainForeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.labelMainForeColor, "labelMainForeColor");
			this.labelMainForeColor.Name = "labelMainForeColor";
			this.labelMainForeColor.Click += new System.EventHandler(this.labelForeColor_Click);
			// 
			// labelMainColor
			// 
			this.labelMainColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelMainColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelMainColor, "labelMainColor");
			this.labelMainColor.Name = "labelMainColor";
			// 
			// label6
			// 
			resources.ApplyResources(this.label6, "label6");
			this.label6.Name = "label6";
			// 
			// label7
			// 
			resources.ApplyResources(this.label7, "label7");
			this.label7.Name = "label7";
			// 
			// label5
			// 
			resources.ApplyResources(this.label5, "label5");
			this.label5.Name = "label5";
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			// 
			// labelBlockquotesBackColor
			// 
			this.labelBlockquotesBackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelBlockquotesBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelBlockquotesBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelBlockquotesBackColor, "labelBlockquotesBackColor");
			this.labelBlockquotesBackColor.Name = "labelBlockquotesBackColor";
			this.labelBlockquotesBackColor.Click += new System.EventHandler(this.labelBackColor_Click);
			// 
			// labelBlockquotesForeColor
			// 
			this.labelBlockquotesForeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelBlockquotesForeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.labelBlockquotesForeColor, "labelBlockquotesForeColor");
			this.labelBlockquotesForeColor.Name = "labelBlockquotesForeColor";
			this.labelBlockquotesForeColor.Click += new System.EventHandler(this.labelForeColor_Click);
			// 
			// labelBlockquotesColor
			// 
			this.labelBlockquotesColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelBlockquotesColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelBlockquotesColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelBlockquotesColor, "labelBlockquotesColor");
			this.labelBlockquotesColor.Name = "labelBlockquotesColor";
			// 
			// labelCodeBlockBackColor
			// 
			this.labelCodeBlockBackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelCodeBlockBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelCodeBlockBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelCodeBlockBackColor, "labelCodeBlockBackColor");
			this.labelCodeBlockBackColor.Name = "labelCodeBlockBackColor";
			this.labelCodeBlockBackColor.Click += new System.EventHandler(this.labelBackColor_Click);
			// 
			// labelCodeBlockForeColor
			// 
			this.labelCodeBlockForeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelCodeBlockForeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.labelCodeBlockForeColor, "labelCodeBlockForeColor");
			this.labelCodeBlockForeColor.Name = "labelCodeBlockForeColor";
			this.labelCodeBlockForeColor.Click += new System.EventHandler(this.labelForeColor_Click);
			// 
			// labelCodeBlockColor
			// 
			this.labelCodeBlockColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelCodeBlockColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelCodeBlockColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelCodeBlockColor, "labelCodeBlockColor");
			this.labelCodeBlockColor.Name = "labelCodeBlockColor";
			// 
			// labelCommentsBackColor
			// 
			this.labelCommentsBackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelCommentsBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelCommentsBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelCommentsBackColor, "labelCommentsBackColor");
			this.labelCommentsBackColor.Name = "labelCommentsBackColor";
			this.labelCommentsBackColor.Click += new System.EventHandler(this.labelBackColor_Click);
			// 
			// labelCommentsForeColor
			// 
			this.labelCommentsForeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelCommentsForeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.labelCommentsForeColor, "labelCommentsForeColor");
			this.labelCommentsForeColor.Name = "labelCommentsForeColor";
			this.labelCommentsForeColor.Click += new System.EventHandler(this.labelForeColor_Click);
			// 
			// labelHorizontalBackColor
			// 
			this.labelHorizontalBackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelHorizontalBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelHorizontalBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelHorizontalBackColor, "labelHorizontalBackColor");
			this.labelHorizontalBackColor.Name = "labelHorizontalBackColor";
			this.labelHorizontalBackColor.Click += new System.EventHandler(this.labelBackColor_Click);
			// 
			// labelHorizontalForeColor
			// 
			this.labelHorizontalForeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelHorizontalForeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.labelHorizontalForeColor, "labelHorizontalForeColor");
			this.labelHorizontalForeColor.Name = "labelHorizontalForeColor";
			this.labelHorizontalForeColor.Click += new System.EventHandler(this.labelForeColor_Click);
			// 
			// labelCodeBackColor
			// 
			this.labelCodeBackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelCodeBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelCodeBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelCodeBackColor, "labelCodeBackColor");
			this.labelCodeBackColor.Name = "labelCodeBackColor";
			this.labelCodeBackColor.Click += new System.EventHandler(this.labelBackColor_Click);
			// 
			// labelCodeForeColor
			// 
			this.labelCodeForeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelCodeForeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.labelCodeForeColor, "labelCodeForeColor");
			this.labelCodeForeColor.Name = "labelCodeForeColor";
			this.labelCodeForeColor.Click += new System.EventHandler(this.labelForeColor_Click);
			// 
			// labelListsBackColor
			// 
			this.labelListsBackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelListsBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelListsBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelListsBackColor, "labelListsBackColor");
			this.labelListsBackColor.Name = "labelListsBackColor";
			this.labelListsBackColor.Click += new System.EventHandler(this.labelBackColor_Click);
			// 
			// labelListsForeColor
			// 
			this.labelListsForeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelListsForeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.labelListsForeColor, "labelListsForeColor");
			this.labelListsForeColor.Name = "labelListsForeColor";
			this.labelListsForeColor.Click += new System.EventHandler(this.labelForeColor_Click);
			// 
			// labelEmphasisBackColor
			// 
			this.labelEmphasisBackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelEmphasisBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelEmphasisBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelEmphasisBackColor, "labelEmphasisBackColor");
			this.labelEmphasisBackColor.Name = "labelEmphasisBackColor";
			this.labelEmphasisBackColor.Click += new System.EventHandler(this.labelBackColor_Click);
			// 
			// labelEmphasisForeColor
			// 
			this.labelEmphasisForeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelEmphasisForeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.labelEmphasisForeColor, "labelEmphasisForeColor");
			this.labelEmphasisForeColor.Name = "labelEmphasisForeColor";
			this.labelEmphasisForeColor.Click += new System.EventHandler(this.labelForeColor_Click);
			// 
			// labelLinksBackColor
			// 
			this.labelLinksBackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelLinksBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelLinksBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelLinksBackColor, "labelLinksBackColor");
			this.labelLinksBackColor.Name = "labelLinksBackColor";
			this.labelLinksBackColor.Click += new System.EventHandler(this.labelBackColor_Click);
			// 
			// labelLinksForeColor
			// 
			this.labelLinksForeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelLinksForeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.labelLinksForeColor, "labelLinksForeColor");
			this.labelLinksForeColor.Name = "labelLinksForeColor";
			this.labelLinksForeColor.Click += new System.EventHandler(this.labelForeColor_Click);
			// 
			// labelImagesBackColor
			// 
			this.labelImagesBackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelImagesBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelImagesBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelImagesBackColor, "labelImagesBackColor");
			this.labelImagesBackColor.Name = "labelImagesBackColor";
			this.labelImagesBackColor.Click += new System.EventHandler(this.labelBackColor_Click);
			// 
			// labelImagesForeColor
			// 
			this.labelImagesForeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelImagesForeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.labelImagesForeColor, "labelImagesForeColor");
			this.labelImagesForeColor.Name = "labelImagesForeColor";
			this.labelImagesForeColor.Click += new System.EventHandler(this.labelForeColor_Click);
			// 
			// labelHeadLine6BackColor
			// 
			this.labelHeadLine6BackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelHeadLine6BackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelHeadLine6BackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelHeadLine6BackColor, "labelHeadLine6BackColor");
			this.labelHeadLine6BackColor.Name = "labelHeadLine6BackColor";
			this.labelHeadLine6BackColor.Click += new System.EventHandler(this.labelBackColor_Click);
			// 
			// labelHeadLine6ForeColor
			// 
			this.labelHeadLine6ForeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelHeadLine6ForeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.labelHeadLine6ForeColor, "labelHeadLine6ForeColor");
			this.labelHeadLine6ForeColor.Name = "labelHeadLine6ForeColor";
			this.labelHeadLine6ForeColor.Click += new System.EventHandler(this.labelForeColor_Click);
			// 
			// labelHeadLine5BackColor
			// 
			this.labelHeadLine5BackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelHeadLine5BackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelHeadLine5BackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelHeadLine5BackColor, "labelHeadLine5BackColor");
			this.labelHeadLine5BackColor.Name = "labelHeadLine5BackColor";
			this.labelHeadLine5BackColor.Click += new System.EventHandler(this.labelBackColor_Click);
			// 
			// labelHeadLine5ForeColor
			// 
			this.labelHeadLine5ForeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelHeadLine5ForeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.labelHeadLine5ForeColor, "labelHeadLine5ForeColor");
			this.labelHeadLine5ForeColor.Name = "labelHeadLine5ForeColor";
			this.labelHeadLine5ForeColor.Click += new System.EventHandler(this.labelForeColor_Click);
			// 
			// labelHeadLine4BackColor
			// 
			this.labelHeadLine4BackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelHeadLine4BackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelHeadLine4BackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelHeadLine4BackColor, "labelHeadLine4BackColor");
			this.labelHeadLine4BackColor.Name = "labelHeadLine4BackColor";
			this.labelHeadLine4BackColor.Click += new System.EventHandler(this.labelBackColor_Click);
			// 
			// labelHeadLine4ForeColor
			// 
			this.labelHeadLine4ForeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelHeadLine4ForeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.labelHeadLine4ForeColor, "labelHeadLine4ForeColor");
			this.labelHeadLine4ForeColor.Name = "labelHeadLine4ForeColor";
			this.labelHeadLine4ForeColor.Click += new System.EventHandler(this.labelForeColor_Click);
			// 
			// labelHeadLine3BackColor
			// 
			this.labelHeadLine3BackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelHeadLine3BackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelHeadLine3BackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelHeadLine3BackColor, "labelHeadLine3BackColor");
			this.labelHeadLine3BackColor.Name = "labelHeadLine3BackColor";
			this.labelHeadLine3BackColor.Click += new System.EventHandler(this.labelBackColor_Click);
			// 
			// labelHeadLine3ForeColor
			// 
			this.labelHeadLine3ForeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelHeadLine3ForeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.labelHeadLine3ForeColor, "labelHeadLine3ForeColor");
			this.labelHeadLine3ForeColor.Name = "labelHeadLine3ForeColor";
			this.labelHeadLine3ForeColor.Click += new System.EventHandler(this.labelForeColor_Click);
			// 
			// labelHeadLine2BackColor
			// 
			this.labelHeadLine2BackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelHeadLine2BackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelHeadLine2BackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelHeadLine2BackColor, "labelHeadLine2BackColor");
			this.labelHeadLine2BackColor.Name = "labelHeadLine2BackColor";
			this.labelHeadLine2BackColor.Click += new System.EventHandler(this.labelBackColor_Click);
			// 
			// labelHeadLine2ForeColor
			// 
			this.labelHeadLine2ForeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelHeadLine2ForeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.labelHeadLine2ForeColor, "labelHeadLine2ForeColor");
			this.labelHeadLine2ForeColor.Name = "labelHeadLine2ForeColor";
			this.labelHeadLine2ForeColor.Click += new System.EventHandler(this.labelForeColor_Click);
			// 
			// labelHeadLine1BackColor
			// 
			this.labelHeadLine1BackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelHeadLine1BackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelHeadLine1BackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelHeadLine1BackColor, "labelHeadLine1BackColor");
			this.labelHeadLine1BackColor.Name = "labelHeadLine1BackColor";
			this.labelHeadLine1BackColor.Click += new System.EventHandler(this.labelBackColor_Click);
			// 
			// labelHeadLine1ForeColor
			// 
			this.labelHeadLine1ForeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelHeadLine1ForeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.labelHeadLine1ForeColor, "labelHeadLine1ForeColor");
			this.labelHeadLine1ForeColor.Name = "labelHeadLine1ForeColor";
			this.labelHeadLine1ForeColor.Click += new System.EventHandler(this.labelForeColor_Click);
			// 
			// labelLineBreakBackColor
			// 
			this.labelLineBreakBackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelLineBreakBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelLineBreakBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelLineBreakBackColor, "labelLineBreakBackColor");
			this.labelLineBreakBackColor.Name = "labelLineBreakBackColor";
			this.labelLineBreakBackColor.Click += new System.EventHandler(this.labelBackColor_Click);
			// 
			// labelLineBreakForeColor
			// 
			this.labelLineBreakForeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelLineBreakForeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.labelLineBreakForeColor, "labelLineBreakForeColor");
			this.labelLineBreakForeColor.Name = "labelLineBreakForeColor";
			this.labelLineBreakForeColor.Click += new System.EventHandler(this.labelForeColor_Click);
			// 
			// labelCommentsColor
			// 
			this.labelCommentsColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelCommentsColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelCommentsColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelCommentsColor, "labelCommentsColor");
			this.labelCommentsColor.Name = "labelCommentsColor";
			// 
			// labelImagesColor
			// 
			this.labelImagesColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelImagesColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelImagesColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelImagesColor, "labelImagesColor");
			this.labelImagesColor.Name = "labelImagesColor";
			// 
			// labelEmphasisColor
			// 
			this.labelEmphasisColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelEmphasisColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelEmphasisColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelEmphasisColor, "labelEmphasisColor");
			this.labelEmphasisColor.Name = "labelEmphasisColor";
			// 
			// labelHorizontalColor
			// 
			this.labelHorizontalColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelHorizontalColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelHorizontalColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelHorizontalColor, "labelHorizontalColor");
			this.labelHorizontalColor.Name = "labelHorizontalColor";
			// 
			// labelLinksColor
			// 
			this.labelLinksColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelLinksColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelLinksColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelLinksColor, "labelLinksColor");
			this.labelLinksColor.Name = "labelLinksColor";
			// 
			// labelCodeColor
			// 
			this.labelCodeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelCodeColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelCodeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelCodeColor, "labelCodeColor");
			this.labelCodeColor.Name = "labelCodeColor";
			// 
			// labelListsColor
			// 
			this.labelListsColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelListsColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelListsColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelListsColor, "labelListsColor");
			this.labelListsColor.Name = "labelListsColor";
			// 
			// labelHeadLine6Color
			// 
			this.labelHeadLine6Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelHeadLine6Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelHeadLine6Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelHeadLine6Color, "labelHeadLine6Color");
			this.labelHeadLine6Color.Name = "labelHeadLine6Color";
			// 
			// labelHeadLine5Color
			// 
			this.labelHeadLine5Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelHeadLine5Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelHeadLine5Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelHeadLine5Color, "labelHeadLine5Color");
			this.labelHeadLine5Color.Name = "labelHeadLine5Color";
			// 
			// labelHeadLine4Color
			// 
			this.labelHeadLine4Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelHeadLine4Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelHeadLine4Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelHeadLine4Color, "labelHeadLine4Color");
			this.labelHeadLine4Color.Name = "labelHeadLine4Color";
			// 
			// labelHeadLine3Color
			// 
			this.labelHeadLine3Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelHeadLine3Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelHeadLine3Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelHeadLine3Color, "labelHeadLine3Color");
			this.labelHeadLine3Color.Name = "labelHeadLine3Color";
			// 
			// labelHeadLine2Color
			// 
			this.labelHeadLine2Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelHeadLine2Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelHeadLine2Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelHeadLine2Color, "labelHeadLine2Color");
			this.labelHeadLine2Color.Name = "labelHeadLine2Color";
			// 
			// labelHeadLine1Color
			// 
			this.labelHeadLine1Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelHeadLine1Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelHeadLine1Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelHeadLine1Color, "labelHeadLine1Color");
			this.labelHeadLine1Color.Name = "labelHeadLine1Color";
			// 
			// labelLineBreakColor
			// 
			this.labelLineBreakColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelLineBreakColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelLineBreakColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelLineBreakColor, "labelLineBreakColor");
			this.labelLineBreakColor.Name = "labelLineBreakColor";
			this.toolTip1.SetToolTip(this.labelLineBreakColor, resources.GetString("labelLineBreakColor.ToolTip"));
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.groupBoxMarkdownExtra);
			resources.ApplyResources(this.tabPage2, "tabPage2");
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// groupBoxMarkdownExtra
			// 
			this.groupBoxMarkdownExtra.BackColor = System.Drawing.Color.WhiteSmoke;
			this.groupBoxMarkdownExtra.Controls.Add(this.labelMarkdownExtraNotice);
			this.groupBoxMarkdownExtra.Controls.Add(this.labelBackslashEscapesBackColor);
			this.groupBoxMarkdownExtra.Controls.Add(this.labelBackslashEscapesForeColor);
			this.groupBoxMarkdownExtra.Controls.Add(this.labelAbbreviationsBackColor);
			this.groupBoxMarkdownExtra.Controls.Add(this.labelAbbreviationsForeColor);
			this.groupBoxMarkdownExtra.Controls.Add(this.labelFootnotesBackColor);
			this.groupBoxMarkdownExtra.Controls.Add(this.labelFootnotesForeColor);
			this.groupBoxMarkdownExtra.Controls.Add(this.labelDefinitionListsBackColor);
			this.groupBoxMarkdownExtra.Controls.Add(this.labelDefinitionListsForeColor);
			this.groupBoxMarkdownExtra.Controls.Add(this.labelTablesBackColor);
			this.groupBoxMarkdownExtra.Controls.Add(this.labelTablesForeColor);
			this.groupBoxMarkdownExtra.Controls.Add(this.labelFencedCodeBlocksBackColor);
			this.groupBoxMarkdownExtra.Controls.Add(this.labelFencedCodeBlocksForeColor);
			this.groupBoxMarkdownExtra.Controls.Add(this.labelSpecialAttributesBackColor);
			this.groupBoxMarkdownExtra.Controls.Add(this.labelSpecialAttributesForeColor);
			this.groupBoxMarkdownExtra.Controls.Add(this.labelBackslashEscapesColor);
			this.groupBoxMarkdownExtra.Controls.Add(this.labelAbbreviationsColor);
			this.groupBoxMarkdownExtra.Controls.Add(this.labelFootnotesColor);
			this.groupBoxMarkdownExtra.Controls.Add(this.labelDefinitionListsColor);
			this.groupBoxMarkdownExtra.Controls.Add(this.labelTablesColor);
			this.groupBoxMarkdownExtra.Controls.Add(this.labelFencedCodeBlocksColor);
			this.groupBoxMarkdownExtra.Controls.Add(this.labelSpecialAttributesColor);
			this.groupBoxMarkdownExtra.Controls.Add(this.labelMarkdownInsideHTMLBlocksBackColor);
			this.groupBoxMarkdownExtra.Controls.Add(this.labelMarkdownInsideHTMLBlocksForeColor);
			this.groupBoxMarkdownExtra.Controls.Add(this.labelMarkdownInsideHTMLBlocksColor);
			this.groupBoxMarkdownExtra.Controls.Add(this.label11);
			this.groupBoxMarkdownExtra.Controls.Add(this.label12);
			resources.ApplyResources(this.groupBoxMarkdownExtra, "groupBoxMarkdownExtra");
			this.groupBoxMarkdownExtra.Name = "groupBoxMarkdownExtra";
			this.groupBoxMarkdownExtra.TabStop = false;
			// 
			// labelMarkdownExtraNotice
			// 
			this.labelMarkdownExtraNotice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			resources.ApplyResources(this.labelMarkdownExtraNotice, "labelMarkdownExtraNotice");
			this.labelMarkdownExtraNotice.Name = "labelMarkdownExtraNotice";
			// 
			// labelBackslashEscapesBackColor
			// 
			this.labelBackslashEscapesBackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelBackslashEscapesBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelBackslashEscapesBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelBackslashEscapesBackColor, "labelBackslashEscapesBackColor");
			this.labelBackslashEscapesBackColor.Name = "labelBackslashEscapesBackColor";
			this.labelBackslashEscapesBackColor.Click += new System.EventHandler(this.labelBackColor_Click);
			// 
			// labelBackslashEscapesForeColor
			// 
			this.labelBackslashEscapesForeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelBackslashEscapesForeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.labelBackslashEscapesForeColor, "labelBackslashEscapesForeColor");
			this.labelBackslashEscapesForeColor.Name = "labelBackslashEscapesForeColor";
			this.labelBackslashEscapesForeColor.Click += new System.EventHandler(this.labelForeColor_Click);
			// 
			// labelAbbreviationsBackColor
			// 
			this.labelAbbreviationsBackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelAbbreviationsBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelAbbreviationsBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelAbbreviationsBackColor, "labelAbbreviationsBackColor");
			this.labelAbbreviationsBackColor.Name = "labelAbbreviationsBackColor";
			this.labelAbbreviationsBackColor.Click += new System.EventHandler(this.labelBackColor_Click);
			// 
			// labelAbbreviationsForeColor
			// 
			this.labelAbbreviationsForeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelAbbreviationsForeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.labelAbbreviationsForeColor, "labelAbbreviationsForeColor");
			this.labelAbbreviationsForeColor.Name = "labelAbbreviationsForeColor";
			this.labelAbbreviationsForeColor.Click += new System.EventHandler(this.labelForeColor_Click);
			// 
			// labelFootnotesBackColor
			// 
			this.labelFootnotesBackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelFootnotesBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelFootnotesBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelFootnotesBackColor, "labelFootnotesBackColor");
			this.labelFootnotesBackColor.Name = "labelFootnotesBackColor";
			this.labelFootnotesBackColor.Click += new System.EventHandler(this.labelBackColor_Click);
			// 
			// labelFootnotesForeColor
			// 
			this.labelFootnotesForeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelFootnotesForeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.labelFootnotesForeColor, "labelFootnotesForeColor");
			this.labelFootnotesForeColor.Name = "labelFootnotesForeColor";
			this.labelFootnotesForeColor.Click += new System.EventHandler(this.labelForeColor_Click);
			// 
			// labelDefinitionListsBackColor
			// 
			this.labelDefinitionListsBackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelDefinitionListsBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelDefinitionListsBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelDefinitionListsBackColor, "labelDefinitionListsBackColor");
			this.labelDefinitionListsBackColor.Name = "labelDefinitionListsBackColor";
			this.labelDefinitionListsBackColor.Click += new System.EventHandler(this.labelBackColor_Click);
			// 
			// labelDefinitionListsForeColor
			// 
			this.labelDefinitionListsForeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelDefinitionListsForeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.labelDefinitionListsForeColor, "labelDefinitionListsForeColor");
			this.labelDefinitionListsForeColor.Name = "labelDefinitionListsForeColor";
			this.labelDefinitionListsForeColor.Click += new System.EventHandler(this.labelForeColor_Click);
			// 
			// labelTablesBackColor
			// 
			this.labelTablesBackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelTablesBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelTablesBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelTablesBackColor, "labelTablesBackColor");
			this.labelTablesBackColor.Name = "labelTablesBackColor";
			this.labelTablesBackColor.Click += new System.EventHandler(this.labelBackColor_Click);
			// 
			// labelTablesForeColor
			// 
			this.labelTablesForeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelTablesForeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.labelTablesForeColor, "labelTablesForeColor");
			this.labelTablesForeColor.Name = "labelTablesForeColor";
			this.labelTablesForeColor.Click += new System.EventHandler(this.labelForeColor_Click);
			// 
			// labelFencedCodeBlocksBackColor
			// 
			this.labelFencedCodeBlocksBackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelFencedCodeBlocksBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelFencedCodeBlocksBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelFencedCodeBlocksBackColor, "labelFencedCodeBlocksBackColor");
			this.labelFencedCodeBlocksBackColor.Name = "labelFencedCodeBlocksBackColor";
			this.labelFencedCodeBlocksBackColor.Click += new System.EventHandler(this.labelBackColor_Click);
			// 
			// labelFencedCodeBlocksForeColor
			// 
			this.labelFencedCodeBlocksForeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelFencedCodeBlocksForeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.labelFencedCodeBlocksForeColor, "labelFencedCodeBlocksForeColor");
			this.labelFencedCodeBlocksForeColor.Name = "labelFencedCodeBlocksForeColor";
			this.labelFencedCodeBlocksForeColor.Click += new System.EventHandler(this.labelForeColor_Click);
			// 
			// labelSpecialAttributesBackColor
			// 
			this.labelSpecialAttributesBackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelSpecialAttributesBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelSpecialAttributesBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelSpecialAttributesBackColor, "labelSpecialAttributesBackColor");
			this.labelSpecialAttributesBackColor.Name = "labelSpecialAttributesBackColor";
			this.labelSpecialAttributesBackColor.Click += new System.EventHandler(this.labelBackColor_Click);
			// 
			// labelSpecialAttributesForeColor
			// 
			this.labelSpecialAttributesForeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelSpecialAttributesForeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.labelSpecialAttributesForeColor, "labelSpecialAttributesForeColor");
			this.labelSpecialAttributesForeColor.Name = "labelSpecialAttributesForeColor";
			this.labelSpecialAttributesForeColor.Click += new System.EventHandler(this.labelForeColor_Click);
			// 
			// labelBackslashEscapesColor
			// 
			this.labelBackslashEscapesColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelBackslashEscapesColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelBackslashEscapesColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelBackslashEscapesColor, "labelBackslashEscapesColor");
			this.labelBackslashEscapesColor.Name = "labelBackslashEscapesColor";
			// 
			// labelAbbreviationsColor
			// 
			this.labelAbbreviationsColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelAbbreviationsColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelAbbreviationsColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelAbbreviationsColor, "labelAbbreviationsColor");
			this.labelAbbreviationsColor.Name = "labelAbbreviationsColor";
			// 
			// labelFootnotesColor
			// 
			this.labelFootnotesColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelFootnotesColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelFootnotesColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelFootnotesColor, "labelFootnotesColor");
			this.labelFootnotesColor.Name = "labelFootnotesColor";
			// 
			// labelDefinitionListsColor
			// 
			this.labelDefinitionListsColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelDefinitionListsColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelDefinitionListsColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelDefinitionListsColor, "labelDefinitionListsColor");
			this.labelDefinitionListsColor.Name = "labelDefinitionListsColor";
			// 
			// labelTablesColor
			// 
			this.labelTablesColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelTablesColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelTablesColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelTablesColor, "labelTablesColor");
			this.labelTablesColor.Name = "labelTablesColor";
			// 
			// labelFencedCodeBlocksColor
			// 
			this.labelFencedCodeBlocksColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelFencedCodeBlocksColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelFencedCodeBlocksColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelFencedCodeBlocksColor, "labelFencedCodeBlocksColor");
			this.labelFencedCodeBlocksColor.Name = "labelFencedCodeBlocksColor";
			// 
			// labelSpecialAttributesColor
			// 
			this.labelSpecialAttributesColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelSpecialAttributesColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelSpecialAttributesColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelSpecialAttributesColor, "labelSpecialAttributesColor");
			this.labelSpecialAttributesColor.Name = "labelSpecialAttributesColor";
			// 
			// labelMarkdownInsideHTMLBlocksBackColor
			// 
			this.labelMarkdownInsideHTMLBlocksBackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelMarkdownInsideHTMLBlocksBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelMarkdownInsideHTMLBlocksBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelMarkdownInsideHTMLBlocksBackColor, "labelMarkdownInsideHTMLBlocksBackColor");
			this.labelMarkdownInsideHTMLBlocksBackColor.Name = "labelMarkdownInsideHTMLBlocksBackColor";
			this.labelMarkdownInsideHTMLBlocksBackColor.Click += new System.EventHandler(this.labelBackColor_Click);
			// 
			// labelMarkdownInsideHTMLBlocksForeColor
			// 
			this.labelMarkdownInsideHTMLBlocksForeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelMarkdownInsideHTMLBlocksForeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.labelMarkdownInsideHTMLBlocksForeColor, "labelMarkdownInsideHTMLBlocksForeColor");
			this.labelMarkdownInsideHTMLBlocksForeColor.Name = "labelMarkdownInsideHTMLBlocksForeColor";
			this.labelMarkdownInsideHTMLBlocksForeColor.Click += new System.EventHandler(this.labelForeColor_Click);
			// 
			// labelMarkdownInsideHTMLBlocksColor
			// 
			this.labelMarkdownInsideHTMLBlocksColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.labelMarkdownInsideHTMLBlocksColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelMarkdownInsideHTMLBlocksColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			resources.ApplyResources(this.labelMarkdownInsideHTMLBlocksColor, "labelMarkdownInsideHTMLBlocksColor");
			this.labelMarkdownInsideHTMLBlocksColor.Name = "labelMarkdownInsideHTMLBlocksColor";
			// 
			// label11
			// 
			resources.ApplyResources(this.label11, "label11");
			this.label11.Name = "label11";
			// 
			// label12
			// 
			resources.ApplyResources(this.label12, "label12");
			this.label12.Name = "label12";
			// 
			// tabPageCSS
			// 
			this.tabPageCSS.Controls.Add(this.cmdDownItem);
			this.tabPageCSS.Controls.Add(this.cmdUpItem);
			this.tabPageCSS.Controls.Add(this.cmdAddCssFolder);
			this.tabPageCSS.Controls.Add(this.lblDefaultCssFileName);
			this.tabPageCSS.Controls.Add(this.listViewCssFiles);
			this.tabPageCSS.Controls.Add(this.cmdOpenCssDir);
			this.tabPageCSS.Controls.Add(this.cmdDeleteCssItem);
			this.tabPageCSS.Controls.Add(this.cmdAddCssFile);
			resources.ApplyResources(this.tabPageCSS, "tabPageCSS");
			this.tabPageCSS.Name = "tabPageCSS";
			this.tabPageCSS.UseVisualStyleBackColor = true;
			// 
			// cmdDownItem
			// 
			resources.ApplyResources(this.cmdDownItem, "cmdDownItem");
			this.cmdDownItem.Name = "cmdDownItem";
			this.toolTip1.SetToolTip(this.cmdDownItem, resources.GetString("cmdDownItem.ToolTip"));
			this.cmdDownItem.UseVisualStyleBackColor = true;
			this.cmdDownItem.Click += new System.EventHandler(this.cmdDownItem_Click);
			// 
			// cmdUpItem
			// 
			resources.ApplyResources(this.cmdUpItem, "cmdUpItem");
			this.cmdUpItem.Name = "cmdUpItem";
			this.toolTip1.SetToolTip(this.cmdUpItem, resources.GetString("cmdUpItem.ToolTip"));
			this.cmdUpItem.UseVisualStyleBackColor = true;
			this.cmdUpItem.Click += new System.EventHandler(this.cmdUpItem_Click);
			// 
			// cmdAddCssFolder
			// 
			resources.ApplyResources(this.cmdAddCssFolder, "cmdAddCssFolder");
			this.cmdAddCssFolder.Name = "cmdAddCssFolder";
			this.toolTip1.SetToolTip(this.cmdAddCssFolder, resources.GetString("cmdAddCssFolder.ToolTip"));
			this.cmdAddCssFolder.UseVisualStyleBackColor = true;
			this.cmdAddCssFolder.Click += new System.EventHandler(this.cmdAddCssFolder_Click);
			// 
			// lblDefaultCssFileName
			// 
			resources.ApplyResources(this.lblDefaultCssFileName, "lblDefaultCssFileName");
			this.lblDefaultCssFileName.Name = "lblDefaultCssFileName";
			// 
			// listViewCssFiles
			// 
			this.listViewCssFiles.AllowDrop = true;
			this.listViewCssFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.listViewCssFiles.FullRowSelect = true;
			this.listViewCssFiles.GridLines = true;
			resources.ApplyResources(this.listViewCssFiles, "listViewCssFiles");
			this.listViewCssFiles.MultiSelect = false;
			this.listViewCssFiles.Name = "listViewCssFiles";
			this.listViewCssFiles.UseCompatibleStateImageBehavior = false;
			this.listViewCssFiles.View = System.Windows.Forms.View.Details;
			this.listViewCssFiles.SelectedIndexChanged += new System.EventHandler(this.listViewCssFiles_SelectedIndexChanged);
			this.listViewCssFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewCssFiles_DragDrop);
			this.listViewCssFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewCssFiles_DragEnter);
			// 
			// columnHeader1
			// 
			resources.ApplyResources(this.columnHeader1, "columnHeader1");
			// 
			// columnHeader2
			// 
			resources.ApplyResources(this.columnHeader2, "columnHeader2");
			// 
			// cmdOpenCssDir
			// 
			resources.ApplyResources(this.cmdOpenCssDir, "cmdOpenCssDir");
			this.cmdOpenCssDir.Name = "cmdOpenCssDir";
			this.toolTip1.SetToolTip(this.cmdOpenCssDir, resources.GetString("cmdOpenCssDir.ToolTip"));
			this.cmdOpenCssDir.UseVisualStyleBackColor = true;
			this.cmdOpenCssDir.Click += new System.EventHandler(this.cmdOpenCssDir_Click);
			// 
			// cmdDeleteCssItem
			// 
			resources.ApplyResources(this.cmdDeleteCssItem, "cmdDeleteCssItem");
			this.cmdDeleteCssItem.Name = "cmdDeleteCssItem";
			this.toolTip1.SetToolTip(this.cmdDeleteCssItem, resources.GetString("cmdDeleteCssItem.ToolTip"));
			this.cmdDeleteCssItem.UseVisualStyleBackColor = true;
			this.cmdDeleteCssItem.Click += new System.EventHandler(this.cmdDeleteCssItem_Click);
			// 
			// cmdAddCssFile
			// 
			resources.ApplyResources(this.cmdAddCssFile, "cmdAddCssFile");
			this.cmdAddCssFile.Name = "cmdAddCssFile";
			this.toolTip1.SetToolTip(this.cmdAddCssFile, resources.GetString("cmdAddCssFile.ToolTip"));
			this.cmdAddCssFile.UseVisualStyleBackColor = true;
			this.cmdAddCssFile.Click += new System.EventHandler(this.cmdAddCssFile_Click);
			// 
			// tabPageHTML
			// 
			this.tabPageHTML.Controls.Add(this.groupBox3);
			this.tabPageHTML.Controls.Add(this.groupBoxEncoding);
			resources.ApplyResources(this.tabPageHTML, "tabPageHTML");
			this.tabPageHTML.Name = "tabPageHTML";
			this.tabPageHTML.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.groupBoxCssOption);
			this.groupBox3.Controls.Add(this.comboBoxHtmlHeader);
			this.groupBox3.Controls.Add(this.chkInsertHtmlHeader);
			resources.ApplyResources(this.groupBox3, "groupBox3");
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.TabStop = false;
			// 
			// groupBoxCssOption
			// 
			this.groupBoxCssOption.Controls.Add(this.radioButtonInsertLinkTag);
			this.groupBoxCssOption.Controls.Add(this.radioButtonImportCssFile);
			resources.ApplyResources(this.groupBoxCssOption, "groupBoxCssOption");
			this.groupBoxCssOption.Name = "groupBoxCssOption";
			this.groupBoxCssOption.TabStop = false;
			// 
			// radioButtonInsertLinkTag
			// 
			resources.ApplyResources(this.radioButtonInsertLinkTag, "radioButtonInsertLinkTag");
			this.radioButtonInsertLinkTag.Name = "radioButtonInsertLinkTag";
			this.radioButtonInsertLinkTag.TabStop = true;
			this.radioButtonInsertLinkTag.UseVisualStyleBackColor = true;
			this.radioButtonInsertLinkTag.CheckedChanged += new System.EventHandler(this.radioButtonInsertLinkTag_CheckedChanged);
			// 
			// radioButtonImportCssFile
			// 
			resources.ApplyResources(this.radioButtonImportCssFile, "radioButtonImportCssFile");
			this.radioButtonImportCssFile.Name = "radioButtonImportCssFile";
			this.radioButtonImportCssFile.TabStop = true;
			this.radioButtonImportCssFile.UseVisualStyleBackColor = true;
			this.radioButtonImportCssFile.CheckedChanged += new System.EventHandler(this.radioButtonImportCssFile_CheckedChanged);
			// 
			// comboBoxHtmlHeader
			// 
			this.comboBoxHtmlHeader.FormattingEnabled = true;
			resources.ApplyResources(this.comboBoxHtmlHeader, "comboBoxHtmlHeader");
			this.comboBoxHtmlHeader.Name = "comboBoxHtmlHeader";
			this.comboBoxHtmlHeader.SelectedIndexChanged += new System.EventHandler(this.comboBoxHtmlHeader_SelectedIndexChanged);
			// 
			// chkInsertHtmlHeader
			// 
			resources.ApplyResources(this.chkInsertHtmlHeader, "chkInsertHtmlHeader");
			this.chkInsertHtmlHeader.Name = "chkInsertHtmlHeader";
			this.chkInsertHtmlHeader.UseVisualStyleBackColor = true;
			this.chkInsertHtmlHeader.CheckedChanged += new System.EventHandler(this.chkInsertHtmlHeader_CheckedChanged);
			// 
			// groupBoxEncoding
			// 
			this.groupBoxEncoding.Controls.Add(this.label1);
			this.groupBoxEncoding.Controls.Add(this.comboBoxSelectEncoding);
			this.groupBoxEncoding.Controls.Add(this.radioButtonChangeEncoding);
			this.groupBoxEncoding.Controls.Add(this.radioButtonDefaultEncoding);
			resources.ApplyResources(this.groupBoxEncoding, "groupBoxEncoding");
			this.groupBoxEncoding.Name = "groupBoxEncoding";
			this.groupBoxEncoding.TabStop = false;
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.ForeColor = System.Drawing.Color.DarkGreen;
			this.label1.Name = "label1";
			// 
			// comboBoxSelectEncoding
			// 
			this.comboBoxSelectEncoding.BackColor = System.Drawing.SystemColors.Window;
			this.comboBoxSelectEncoding.FormattingEnabled = true;
			resources.ApplyResources(this.comboBoxSelectEncoding, "comboBoxSelectEncoding");
			this.comboBoxSelectEncoding.Name = "comboBoxSelectEncoding";
			// 
			// radioButtonChangeEncoding
			// 
			resources.ApplyResources(this.radioButtonChangeEncoding, "radioButtonChangeEncoding");
			this.radioButtonChangeEncoding.Name = "radioButtonChangeEncoding";
			this.radioButtonChangeEncoding.TabStop = true;
			this.radioButtonChangeEncoding.UseVisualStyleBackColor = true;
			this.radioButtonChangeEncoding.CheckedChanged += new System.EventHandler(this.radioButtonChangeEncoding_CheckedChanged);
			// 
			// radioButtonDefaultEncoding
			// 
			resources.ApplyResources(this.radioButtonDefaultEncoding, "radioButtonDefaultEncoding");
			this.radioButtonDefaultEncoding.Name = "radioButtonDefaultEncoding";
			this.radioButtonDefaultEncoding.TabStop = true;
			this.radioButtonDefaultEncoding.UseVisualStyleBackColor = true;
			this.radioButtonDefaultEncoding.CheckedChanged += new System.EventHandler(this.radioButtonDefaultEncoding_CheckedChanged);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DefaultExt = "css";
			this.openFileDialog1.FileName = "openFileDialog1";
			resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
			this.openFileDialog1.Multiselect = true;
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "css";
			resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
			// 
			// folderBrowserDialog1
			// 
			resources.ApplyResources(this.folderBrowserDialog1, "folderBrowserDialog1");
			// 
			// fontDialog1
			// 
			this.fontDialog1.Color = System.Drawing.SystemColors.ControlText;
			// 
			// colorDialog1
			// 
			this.colorDialog1.AnyColor = true;
			this.colorDialog1.FullOpen = true;
			// 
			// Form3
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cmdCancel;
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form3";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
			this.Load += new System.EventHandler(this.Form3_Load);
			this.Enter += new System.EventHandler(this.Form3_Enter);
			this.panel1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPageMain.ResumeLayout(false);
			this.tabPageMain.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgStrike)).EndInit();
			this.tabPageEdit.ResumeLayout(false);
			this.tabControl2.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBoxMarkdown.ResumeLayout(false);
			this.groupBoxMarkdown.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.groupBoxMarkdownExtra.ResumeLayout(false);
			this.groupBoxMarkdownExtra.PerformLayout();
			this.tabPageCSS.ResumeLayout(false);
			this.tabPageCSS.PerformLayout();
			this.tabPageHTML.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBoxCssOption.ResumeLayout(false);
			this.groupBoxCssOption.PerformLayout();
			this.groupBoxEncoding.ResumeLayout(false);
			this.groupBoxEncoding.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdApply;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageCSS;
		private System.Windows.Forms.Button cmdDeleteCssItem;
		private System.Windows.Forms.Button cmdAddCssFile;
		private System.Windows.Forms.TabPage tabPageHTML;
        private System.Windows.Forms.GroupBox groupBoxEncoding;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSelectEncoding;
        private System.Windows.Forms.RadioButton radioButtonChangeEncoding;
		private System.Windows.Forms.RadioButton radioButtonDefaultEncoding;
        private System.Windows.Forms.CheckBox checkBoxOpenEditFileBefore;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox checkBoxShowHtmlToClipboardMessage;
		private System.Windows.Forms.CheckBox checkBoxShowHtmlSaveDialog;
		private System.Windows.Forms.Button cmdOpenCssDir;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBoxCssOption;
		private System.Windows.Forms.RadioButton radioButtonInsertLinkTag;
		private System.Windows.Forms.RadioButton radioButtonImportCssFile;
		private System.Windows.Forms.ComboBox comboBoxHtmlHeader;
		private System.Windows.Forms.CheckBox chkInsertHtmlHeader;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button cmdUnAssociateFiles;
		private System.Windows.Forms.Button cmdAssociateFiles;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Label lblDefaultCssFileName;
		private System.Windows.Forms.ListView listViewCssFiles;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.FontDialog fontDialog1;
		private System.Windows.Forms.Button cmdAddCssFolder;
		private System.Windows.Forms.Label labelHighLightColor;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Label labelHtmlColorName;
		private System.Windows.Forms.CheckBox checkBoxEditingHighlightColor;
		private System.Windows.Forms.TabPage tabPageEdit;
		private System.Windows.Forms.Button cmdDownItem;
		private System.Windows.Forms.Button cmdUpItem;
		private System.Windows.Forms.ComboBox comboPreviewInterval;
		private System.Windows.Forms.Label lblPreviewIntervalCaption;
		private System.Windows.Forms.PictureBox imgStrike;
    private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBoxMarkdownType;
		private System.Windows.Forms.TabControl tabControl2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.GroupBox groupBoxMarkdown;
		private System.Windows.Forms.Label labelMainBackColor;
		private System.Windows.Forms.Label labelMainForeColor;
		private System.Windows.Forms.Label labelMainColor;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label labelBlockquotesBackColor;
		private System.Windows.Forms.Label labelBlockquotesForeColor;
		private System.Windows.Forms.Label labelBlockquotesColor;
		private System.Windows.Forms.Label labelCodeBlockBackColor;
		private System.Windows.Forms.Label labelCodeBlockForeColor;
		private System.Windows.Forms.Label labelCodeBlockColor;
		private System.Windows.Forms.Label labelCommentsBackColor;
		private System.Windows.Forms.Label labelCommentsForeColor;
		private System.Windows.Forms.Label labelHorizontalBackColor;
		private System.Windows.Forms.Label labelHorizontalForeColor;
		private System.Windows.Forms.Label labelCodeBackColor;
		private System.Windows.Forms.Label labelCodeForeColor;
		private System.Windows.Forms.Label labelListsBackColor;
		private System.Windows.Forms.Label labelListsForeColor;
		private System.Windows.Forms.Label labelEmphasisBackColor;
		private System.Windows.Forms.Label labelEmphasisForeColor;
		private System.Windows.Forms.Label labelLinksBackColor;
		private System.Windows.Forms.Label labelLinksForeColor;
		private System.Windows.Forms.Label labelImagesBackColor;
		private System.Windows.Forms.Label labelImagesForeColor;
		private System.Windows.Forms.Label labelHeadLine6BackColor;
		private System.Windows.Forms.Label labelHeadLine6ForeColor;
		private System.Windows.Forms.Label labelHeadLine5BackColor;
		private System.Windows.Forms.Label labelHeadLine5ForeColor;
		private System.Windows.Forms.Label labelHeadLine4BackColor;
		private System.Windows.Forms.Label labelHeadLine4ForeColor;
		private System.Windows.Forms.Label labelHeadLine3BackColor;
		private System.Windows.Forms.Label labelHeadLine3ForeColor;
		private System.Windows.Forms.Label labelHeadLine2BackColor;
		private System.Windows.Forms.Label labelHeadLine2ForeColor;
		private System.Windows.Forms.Label labelHeadLine1BackColor;
		private System.Windows.Forms.Label labelHeadLine1ForeColor;
		private System.Windows.Forms.Label labelLineBreakBackColor;
		private System.Windows.Forms.Label labelLineBreakForeColor;
		private System.Windows.Forms.Label labelCommentsColor;
		private System.Windows.Forms.Label labelImagesColor;
		private System.Windows.Forms.Label labelEmphasisColor;
		private System.Windows.Forms.Label labelHorizontalColor;
		private System.Windows.Forms.Label labelLinksColor;
		private System.Windows.Forms.Label labelCodeColor;
		private System.Windows.Forms.Label labelListsColor;
		private System.Windows.Forms.Label labelHeadLine6Color;
		private System.Windows.Forms.Label labelHeadLine5Color;
		private System.Windows.Forms.Label labelHeadLine4Color;
		private System.Windows.Forms.Label labelHeadLine3Color;
		private System.Windows.Forms.Label labelHeadLine2Color;
		private System.Windows.Forms.Label labelHeadLine1Color;
		private System.Windows.Forms.Label labelLineBreakColor;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.GroupBox groupBoxMarkdownExtra;
		private System.Windows.Forms.Label labelBackslashEscapesBackColor;
		private System.Windows.Forms.Label labelBackslashEscapesForeColor;
		private System.Windows.Forms.Label labelAbbreviationsBackColor;
		private System.Windows.Forms.Label labelAbbreviationsForeColor;
		private System.Windows.Forms.Label labelFootnotesBackColor;
		private System.Windows.Forms.Label labelFootnotesForeColor;
		private System.Windows.Forms.Label labelDefinitionListsBackColor;
		private System.Windows.Forms.Label labelDefinitionListsForeColor;
		private System.Windows.Forms.Label labelTablesBackColor;
		private System.Windows.Forms.Label labelTablesForeColor;
		private System.Windows.Forms.Label labelFencedCodeBlocksBackColor;
		private System.Windows.Forms.Label labelFencedCodeBlocksForeColor;
		private System.Windows.Forms.Label labelSpecialAttributesBackColor;
		private System.Windows.Forms.Label labelSpecialAttributesForeColor;
		private System.Windows.Forms.Label labelBackslashEscapesColor;
		private System.Windows.Forms.Label labelAbbreviationsColor;
		private System.Windows.Forms.Label labelFootnotesColor;
		private System.Windows.Forms.Label labelDefinitionListsColor;
		private System.Windows.Forms.Label labelTablesColor;
		private System.Windows.Forms.Label labelFencedCodeBlocksColor;
		private System.Windows.Forms.Label labelSpecialAttributesColor;
		private System.Windows.Forms.Label labelMarkdownInsideHTMLBlocksBackColor;
		private System.Windows.Forms.Label labelMarkdownInsideHTMLBlocksForeColor;
		private System.Windows.Forms.Label labelMarkdownInsideHTMLBlocksColor;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label labelMarkdownExtraNotice;
		private System.Windows.Forms.Button cmdOpenAppData;
    }
}