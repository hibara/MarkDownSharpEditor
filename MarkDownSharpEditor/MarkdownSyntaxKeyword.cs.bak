using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MarkDownSharpEditor
{
	//MarkdownキーワードSyntaxHighlighterクラス
	class MarkdownSyntaxKeyword
	{
		private string _RegText;
		private Color _ForeColor = Color.Black;
		private Color _BackColor = Color.White;

		public MarkdownSyntaxKeyword(string reg, Color f, Color b)
		{
			_RegText = reg;
			_ForeColor = f;
			_BackColor = b;
		}
		public string RegText
		{
			get { return _RegText; }
			set { _RegText = RegText; }
		}
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
