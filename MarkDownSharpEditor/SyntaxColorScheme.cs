using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MarkDownSharpEditor
{
	class SyntaxColorScheme
	{

		//-----------------------------------
		#region member
		//-----------------------------------

		private int _SelectionStartIndex;
		private int _SelectionLength;
		private Color _ForeColor;
		private Color _BackColor;

		#endregion

		//-----------------------------------
		#region property
		//-----------------------------------
		public int SelectionStartIndex
		{
			get { return _SelectionStartIndex; }
			set { _SelectionStartIndex = value; }
		}
		public int SelectionLength
		{
			get { return _SelectionLength; }
			set { _SelectionLength = value; }
		}
		public Color ForeColor
		{
			get { return _ForeColor; }
			set { _ForeColor = value; }
		}
		public Color BackColor
		{
			get { return _BackColor; }
			set { _BackColor = value; }
		}
		#endregion

		//-----------------------------------
		#region 
		//-----------------------------------
		public SyntaxColorScheme()
		{
			_SelectionStartIndex = 0;
			_SelectionLength = 0;
			_ForeColor = Color.Black;
			_BackColor = Color.White;
		}
		#endregion

	}
}
