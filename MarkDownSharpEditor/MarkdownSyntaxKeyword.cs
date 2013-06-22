using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;

namespace MarkDownSharpEditor
{
	//MarkdownキーワードSyntaxHighlighterクラス
	class MarkdownSyntaxKeyword
	{
		private const string mail_regex = @"<(?:(?:(?:(?:[a-zA-Z0-9_!#\$\%&'*+/=?\^`{}~|\-]+)(?:\.(?:[a-zA-Z0-9_!#\$\%&'*+/=?\^`{}~|\-]+))*)|(?:""(?:\\[^\r\n]|[^\\""])*"")))\@(?:(?:(?:(?:[a-zA-Z0-9_!#\$\%&'*+/=?\^`{}~|\-]+)(?:\.(?:[a-zA-Z0-9_!#\$\%&'*+/=?\^`{}~|\-]+))*)|(?:\[(?:\\\S|[\x21-\x5a\x5e-\x7e])*\])))>";
		private const string horisontal_regex = @"^(\* ){3,}$|^\*.$|^(- ){3,}|^-{3,}$|^(_ ){3,}$|^_{3,}$";

		//----------------------------------------------------------------------
		// シンタックス・ハイライター（Regex）のキーワード更新
		// Refresh regular expression of syntax hightlighter keyword
		//----------------------------------------------------------------------
		public static List<MarkdownSyntaxKeyword> CreateKeywordList()
		{
			var obj = MarkDownSharpEditor.AppSettings.Instance;
			var keywords = new List<MarkdownSyntaxKeyword> {
				//強制ブレーク ( Line break )
				new MarkdownSyntaxKeyword(@"  $", Color.FromArgb(obj.ForeColor_LineBreak), Color.FromArgb(obj.BackColor_LineBreak)),
				//見出し１ ( Header 1 )
				new MarkdownSyntaxKeyword(@"^#[^#]*?$", Color.FromArgb(obj.ForeColor_Headlines[1]), Color.FromArgb(obj.BackColor_Headlines[1])),
				new MarkdownSyntaxKeyword(@"^.*\n=+$", Color.FromArgb(obj.ForeColor_Headlines[1]), Color.FromArgb(obj.BackColor_Headlines[1])),
				//見出し２ ( Header 2 )
				new MarkdownSyntaxKeyword(@"^##[^#]*?$", Color.FromArgb(obj.ForeColor_Headlines[2]), Color.FromArgb(obj.BackColor_Headlines[2])),
				//見出し３ ( Header 3 )
				new MarkdownSyntaxKeyword(@"^###[^#]*?$", Color.FromArgb(obj.ForeColor_Headlines[3]), Color.FromArgb(obj.BackColor_Headlines[3])),
				//見出し４ ( Header 4 )
				new MarkdownSyntaxKeyword(@"^####[^#]*?$", Color.FromArgb(obj.ForeColor_Headlines[4]), Color.FromArgb(obj.BackColor_Headlines[4])),
				//見出し５ ( Header 5 )
				new MarkdownSyntaxKeyword(@"^#####[^#]*?$", Color.FromArgb(obj.ForeColor_Headlines[5]), Color.FromArgb(obj.BackColor_Headlines[5])),
				//見出し６ ( Header 6 )
				new MarkdownSyntaxKeyword(@"^#####[^#]*?$", Color.FromArgb(obj.ForeColor_Headlines[6]), Color.FromArgb(obj.BackColor_Headlines[6])),
				//引用 ( Brockquote )
				new MarkdownSyntaxKeyword(@"^>.*$", Color.FromArgb(obj.ForeColor_Blockquotes), Color.FromArgb(obj.BackColor_Blockquotes)),
				//リスト ( Lists )
				new MarkdownSyntaxKeyword(@"^ {0,3}\*[ \t]+.*$|^ {0,3}\+[ \t]+.*$|^ {0,3}-[ \t]+.*$|^ {0,3}[0-9]+\.[ \t]+.*$", Color.FromArgb(obj.ForeColor_Lists), Color.FromArgb(obj.BackColor_Lists)),
				//コードブロック ( Code blocks )
				new MarkdownSyntaxKeyword(@"^ {4,}$|^\t{1,}$", Color.FromArgb(obj.ForeColor_CodeBlocks), Color.FromArgb(obj.BackColor_CodeBlocks)),
				//罫線 ( Horizontal )
				new MarkdownSyntaxKeyword(horisontal_regex, Color.FromArgb(obj.ForeColor_Horizontal), Color.FromArgb(obj.BackColor_Horizontal)),
				//「見出し２」だけは罫線よりも後に
				// Parse "Header 2" after "Horizontal" 
				new MarkdownSyntaxKeyword(@"^.+\n-+$", Color.FromArgb(obj.ForeColor_Headlines[2]), Color.FromArgb(obj.BackColor_Headlines[2])),
				//リンク ( Link )
				// [an example](http://example.com/ "Title") 
				new MarkdownSyntaxKeyword(@"\[.*\]\((https?|ftp)(:\/\/[-_.!~*\'()a-zA-Z0-9;\/?:\@&=+\$,%#]+)[\t{1,}| {1,}]"".*""\)", Color.FromArgb(obj.ForeColor_Links), Color.FromArgb(obj.BackColor_Links)),
				// [This link](http://example.net/)
				new MarkdownSyntaxKeyword(@"\[.*\]\((https?|ftp)(:\/\/[-_.!~*\'()a-zA-Z0-9;\/?:\@&=+\$,%#]+)\)", Color.FromArgb(obj.ForeColor_Links), Color.FromArgb(obj.BackColor_Links)),
				// [an example][id] 
				// [an example] [id]
				new MarkdownSyntaxKeyword(@"\[.*\]\((https?|ftp)(:\/\/[-_.!~*\'()a-zA-Z0-9;\/?:\@&=+\$,%#]+)\)", Color.FromArgb(obj.ForeColor_Links), Color.FromArgb(obj.BackColor_Links)),
				// [id]: http://example.com/  "Optional Title Here"
				new MarkdownSyntaxKeyword(@"\[.*\]:[\t{1,}| {1,}](https?|ftp)(:\/\/[-_.!~*\'()a-zA-Z0-9;\/?:\@&=+\$,%#]+)[\t{1,}| {1,}]"".*""", Color.FromArgb(obj.ForeColor_Links), Color.FromArgb(obj.BackColor_Links)),
				//強調（em, em, strong, strong）
				new MarkdownSyntaxKeyword(@"\*.*\*|_.*_|\*\*.*\*\*|__.*__", Color.FromArgb(obj.ForeColor_Emphasis), Color.FromArgb(obj.BackColor_Emphasis)),
				//ソースコード ( Source code )
				new MarkdownSyntaxKeyword(@"`.*`", Color.FromArgb(obj.ForeColor_Code), Color.FromArgb(obj.BackColor_Emphasis)),
				//画像 ( Image )
				new MarkdownSyntaxKeyword(@"!\[.*\]\(.*\)|!\[.*\]\[.*\]|\[.*\]: .*"".*""", Color.FromArgb(obj.ForeColor_Images), Color.FromArgb(obj.BackColor_Emphasis)),
				//自動リンク（メールアドレスとURL） ( Auto Links )
				new MarkdownSyntaxKeyword(@"<(https?|ftp)(:\/\/[-_.!~*\'()a-zA-Z0-9;\/?:\@&=+\$,%#]+)>", Color.FromArgb(obj.ForeColor_Links), Color.FromArgb(obj.BackColor_Links)),
				new MarkdownSyntaxKeyword(mail_regex, Color.FromArgb(obj.ForeColor_Links), Color.FromArgb(obj.BackColor_Links)),
				//コメントアウト（複数行含めたコメント全部）( Comment out )
				new MarkdownSyntaxKeyword(@"<!--((?:.|\n)+)-->", Color.FromArgb(obj.ForeColor_Comments), Color.FromArgb(obj.BackColor_Comments))
			};

			//-----------------------------------
			// Markdown "Extra" SyntaxHighlighter
			//-----------------------------------
			if (MarkDownSharpEditor.AppSettings.Instance.fMarkdownExtraMode == true)
			{
				//HTMLブロック内のMarkdown記法（Markdown Inside HTML Blocks）
				keywords.Add(new MarkdownSyntaxKeyword("\\s*markdown\\s*=\\s*(?>([\"\'])(.*?)\\1|([^\\s>]*))()", Color.FromArgb(obj.ForeColor_MarkdownInsideHTMLBlocks), Color.FromArgb(obj.BackColor_MarkdownInsideHTMLBlocks)));
				keywords.Add(new MarkdownSyntaxKeyword("(</?[\\w:$]+(?:(?=[\\s\"\'/a-zA-Z0-9])(?>\".*?\"|\'.*?\'|.+?)*?)?>|<!--.*?-->|<\\?.*?\\?>|<%.*?%>|<!\\[CDATA\\[.*?\\]\\]>)", Color.FromArgb(obj.ForeColor_MarkdownInsideHTMLBlocks), Color.FromArgb(obj.BackColor_MarkdownInsideHTMLBlocks)));
				//特殊な属性 ( Special Attributes )
				keywords.Add(new MarkdownSyntaxKeyword("(^.+?)(?:[ ]+.+?)?[ ]*\n(=+|-+)[ ]*\n+", Color.FromArgb(obj.ForeColor_SpecialAttributes), Color.FromArgb(obj.BackColor_SpecialAttributes)));
				keywords.Add(new MarkdownSyntaxKeyword("^(\\#{1,6})[ ]*(.+?)[ ]*\\#*(?:[ ]+.+?)?[ ]*\n+", Color.FromArgb(obj.ForeColor_SpecialAttributes), Color.FromArgb(obj.BackColor_SpecialAttributes)));
				//コードブロック区切り（Fenced Code Blocks）
				keywords.Add(new MarkdownSyntaxKeyword("(?:\\n|\\A)(~{3,})[ ]*(?:\\.?([-_:a-zA-Z0-9]+)|\\{.+?\\})?[ ]*\\n((?>(?!\\1[ ]*\\n).*\\n+)+)\\1[ ]*\\n", Color.FromArgb(obj.ForeColor_FencedCodeBlocks), Color.FromArgb(obj.BackColor_FencedCodeBlocks)));
				//表組み ( Tables )
				keywords.Add(new MarkdownSyntaxKeyword("^[ ]{0,2}[|](.+)\\n[ ]{0,2}[|]([ ]*[-:]+[-| :]*)\\n((?:[ ]*[|].*\\n)*)(?=\\n|\\Z)", Color.FromArgb(obj.ForeColor_Tables), Color.FromArgb(obj.BackColor_Tables)));
				keywords.Add(new MarkdownSyntaxKeyword("^[ ]{0,2}(\\S.*[|].*)\\n[ ]{0,2}([-:]+[ ]*[|][-| :]*)\\n((?:.*[|].*\\n)*)(?=\\n|\\Z)", Color.FromArgb(obj.ForeColor_Tables), Color.FromArgb(obj.BackColor_Tables)));
				//定義リスト ( Definition Lists )
				keywords.Add(new MarkdownSyntaxKeyword("(?>\\A\\n?|(?<=\n\n))(?>(([ ]{0,}((?>.*\\S.*\\n)+)\\n?[ ]{0,}:[ ]+)(?s:.+?)(\\z|\\n{2,}(?=\\S)(?![ ]{0,}(?: \\S.*\\n )+?\\n?[ ]{0,}:[ ]+)(?![ ]{0,}:[ ]+))))", Color.FromArgb(obj.ForeColor_DefinitionLists), Color.FromArgb(obj.BackColor_DefinitionLists)));
				//脚注 ( Footnotes )
				keywords.Add(new MarkdownSyntaxKeyword("^[ ]{0,}\\[\\^(.+?)\\][ ]?:[ ]*\n?((?:.+|\n(?!\\[\\^.+?\\]:\\s)(?!\\n+[ ]{0,3}\\S))*)", Color.FromArgb(obj.ForeColor_Footnotes), Color.FromArgb(obj.BackColor_Footnotes)));
				//省略表記 ( Abbreviations )
				keywords.Add(new MarkdownSyntaxKeyword("^[ ]{0,}\\*\\[(.+?)\\][ ]?:(.*)", Color.FromArgb(obj.ForeColor_Abbreviations), Color.FromArgb(obj.BackColor_Abbreviations)));
				//強調表示 : むしろダブルコーテーション内は解除する
				//Emphasis : Rather than remove the syntaxHighlighter of Emphasis within the double quotes
				keywords.Add(new MarkdownSyntaxKeyword("\".*?\"", Color.FromArgb(obj.ForeColor_MainText), Color.FromArgb(obj.BackColor_MainText)));
				//バックスラッシュエスケープ ( Backslash Escapes )
				keywords.Add(new MarkdownSyntaxKeyword(@"(\\:)|(\\|)", Color.FromArgb(obj.ForeColor_BackslashEscapes), Color.FromArgb(obj.BackColor_BackslashEscapes)));
			}
			return keywords;
		}

		private string _RegText;
		private Color _ForeColor = Color.Black;
		private Color _BackColor = Color.White;

		public MarkdownSyntaxKeyword(string reg, Color f, Color b)
		{
			_RegText = reg;
			Regex = new Regex(RegText, RegexOptions.Multiline | RegexOptions.IgnoreCase | RegexOptions.Compiled);
			_ForeColor = f;
			_BackColor = b;
		}
		public string RegText
		{
			get { return _RegText; }
			set { _RegText = RegText; }
		}
		public Regex Regex { get; private set; }
		public Color ForeColor
		{
			get { return _ForeColor; }
			set { _ForeColor = ForeColor; }
		}
		public Color BackColor
		{
			get { return _BackColor; }
			set { _BackColor = BackColor; }
		}

		//-----------------------------------
		//前景色をARGB値で代入・取り出す
		public void setForeColorFromARGB(int argb)
		{
			_ForeColor = Color.FromArgb(argb);
		}
		public int getForeColorToARGB()
		{
			return ForeColor.ToArgb();
		}

		//背景色をARGB値で代入・取り出す
		public void setBackColorFromARGB(int argb)
		{
			_BackColor = Color.FromArgb(argb);
		}
		public int getBackColorToARGB()
		{
			return BackColor.ToArgb();
		}





	}
}
