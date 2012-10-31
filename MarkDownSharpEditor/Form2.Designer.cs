namespace MarkDownSharpEditor
{
  partial class Form2
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
		this.cmdOK = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.labelAppName = new System.Windows.Forms.Label();
		this.labelVersion = new System.Windows.Forms.Label();
		this.labelCopyright = new System.Windows.Forms.Label();
		this.linkLabel1 = new System.Windows.Forms.LinkLabel();
		this.labelSpecialThanks = new System.Windows.Forms.Label();
		this.linkLabel2 = new System.Windows.Forms.LinkLabel();
		this.label1 = new System.Windows.Forms.Label();
		this.linkLabel3 = new System.Windows.Forms.LinkLabel();
		this.label2 = new System.Windows.Forms.Label();
		this.linkLabel4 = new System.Windows.Forms.LinkLabel();
		((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
		this.SuspendLayout();
		// 
		// cmdOK
		// 
		this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
		this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.cmdOK.Location = new System.Drawing.Point(276, 226);
		this.cmdOK.Name = "cmdOK";
		this.cmdOK.Size = new System.Drawing.Size(75, 23);
		this.cmdOK.TabIndex = 0;
		this.cmdOK.Text = "&OK";
		this.cmdOK.UseVisualStyleBackColor = true;
		this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
		// 
		// pictureBox1
		// 
		this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
		this.pictureBox1.InitialImage = null;
		this.pictureBox1.Location = new System.Drawing.Point(12, 23);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(48, 48);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.pictureBox1.TabIndex = 1;
		this.pictureBox1.TabStop = false;
		// 
		// labelAppName
		// 
		this.labelAppName.AutoSize = true;
		this.labelAppName.Location = new System.Drawing.Point(77, 23);
		this.labelAppName.Name = "labelAppName";
		this.labelAppName.Size = new System.Drawing.Size(78, 12);
		this.labelAppName.TabIndex = 2;
		this.labelAppName.Text = "labelAppName";
		// 
		// labelVersion
		// 
		this.labelVersion.AutoSize = true;
		this.labelVersion.Location = new System.Drawing.Point(77, 42);
		this.labelVersion.Name = "labelVersion";
		this.labelVersion.Size = new System.Drawing.Size(68, 12);
		this.labelVersion.TabIndex = 3;
		this.labelVersion.Text = "labelVersion";
		// 
		// labelCopyright
		// 
		this.labelCopyright.AutoSize = true;
		this.labelCopyright.Location = new System.Drawing.Point(77, 59);
		this.labelCopyright.Name = "labelCopyright";
		this.labelCopyright.Size = new System.Drawing.Size(78, 12);
		this.labelCopyright.TabIndex = 4;
		this.labelCopyright.Text = "labelCopyright";
		// 
		// linkLabel1
		// 
		this.linkLabel1.AutoSize = true;
		this.linkLabel1.Location = new System.Drawing.Point(79, 75);
		this.linkLabel1.Name = "linkLabel1";
		this.linkLabel1.Size = new System.Drawing.Size(94, 12);
		this.linkLabel1.TabIndex = 5;
		this.linkLabel1.TabStop = true;
		this.linkLabel1.Text = "http://hibara.org/";
		this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
		// 
		// labelSpecialThanks
		// 
		this.labelSpecialThanks.AutoSize = true;
		this.labelSpecialThanks.Location = new System.Drawing.Point(15, 106);
		this.labelSpecialThanks.Name = "labelSpecialThanks";
		this.labelSpecialThanks.Size = new System.Drawing.Size(325, 24);
		this.labelSpecialThanks.TabIndex = 6;
		this.labelSpecialThanks.Text = "Markdown  -  A text-to-HTML conversion tool for web writers\r\nCopyright (c) 2004 J" +
			"ohn Gruber\r\n";
		// 
		// linkLabel2
		// 
		this.linkLabel2.AutoSize = true;
		this.linkLabel2.Location = new System.Drawing.Point(15, 130);
		this.linkLabel2.Name = "linkLabel2";
		this.linkLabel2.Size = new System.Drawing.Size(233, 12);
		this.linkLabel2.TabIndex = 7;
		this.linkLabel2.TabStop = true;
		this.linkLabel2.Text = "http://daringfireball.net/projects/markdown/";
		this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
		// 
		// label1
		// 
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(15, 153);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(282, 12);
		this.label1.TabIndex = 8;
		this.label1.Text = "Copyright (c) 2004 Michel Fortin - Translation to PHP";
		// 
		// linkLabel3
		// 
		this.linkLabel3.AutoSize = true;
		this.linkLabel3.Location = new System.Drawing.Point(15, 165);
		this.linkLabel3.Name = "linkLabel3";
		this.linkLabel3.Size = new System.Drawing.Size(259, 12);
		this.linkLabel3.TabIndex = 9;
		this.linkLabel3.TabStop = true;
		this.linkLabel3.Text = "http://www.michelf.com/projects/php-markdown/";
		this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
		// 
		// label2
		// 
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(15, 185);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(337, 12);
		this.label2.TabIndex = 10;
		this.label2.Text = "Copyright (c) 2004-2005 Milan Negovan - C# translation to .NET";
		// 
		// linkLabel4
		// 
		this.linkLabel4.AutoSize = true;
		this.linkLabel4.Location = new System.Drawing.Point(17, 201);
		this.linkLabel4.Name = "linkLabel4";
		this.linkLabel4.Size = new System.Drawing.Size(172, 12);
		this.linkLabel4.TabIndex = 11;
		this.linkLabel4.TabStop = true;
		this.linkLabel4.Text = "http://www.aspnetresources.com";
		this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
		// 
		// Form2
		// 
		this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.CancelButton = this.cmdOK;
		this.ClientSize = new System.Drawing.Size(363, 261);
		this.Controls.Add(this.linkLabel4);
		this.Controls.Add(this.label2);
		this.Controls.Add(this.linkLabel3);
		this.Controls.Add(this.label1);
		this.Controls.Add(this.linkLabel2);
		this.Controls.Add(this.labelSpecialThanks);
		this.Controls.Add(this.linkLabel1);
		this.Controls.Add(this.labelCopyright);
		this.Controls.Add(this.labelVersion);
		this.Controls.Add(this.labelAppName);
		this.Controls.Add(this.pictureBox1);
		this.Controls.Add(this.cmdOK);
		this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
		this.MaximizeBox = false;
		this.MinimizeBox = false;
		this.Name = "Form2";
		this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "MarkDownSharp";
		this.Load += new System.EventHandler(this.Form2_Load);
		((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button cmdOK;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label labelAppName;
    private System.Windows.Forms.Label labelVersion;
    private System.Windows.Forms.Label labelCopyright;
    private System.Windows.Forms.LinkLabel linkLabel1;
    private System.Windows.Forms.Label labelSpecialThanks;
    private System.Windows.Forms.LinkLabel linkLabel2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.LinkLabel linkLabel3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.LinkLabel linkLabel4;
  }
}