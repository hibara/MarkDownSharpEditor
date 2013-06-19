using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text;

class RichTextBoxEx : RichTextBox
{

	public void BeginUpdate()
	{
		SendMessage(this.Handle, WM_SETREDRAW, (IntPtr)0, IntPtr.Zero);
	}

	public void EndUpdate()
	{
		SendMessage(this.Handle, WM_SETREDRAW, (IntPtr)1, IntPtr.Zero);
		this.Invalidate();
	}

	// Scroll
	[DllImport("user32.dll")]
	private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
	private const int WM_SETREDRAW = 0x0b;
	[DllImport("user32.dll")]
	private static extern int SetScrollPos(IntPtr hWnd, UInt32 nBar, int nPos, bool bRedraw);
	[DllImport("user32.dll")]
	private static extern int GetScrollPos(IntPtr hwnd, UInt32 nBar);
	[DllImport("user32", EntryPoint = "SendMessageA")]
	public static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, IntPtr lParam);

	// IME
	[DllImport("imm32.dll", CharSet = CharSet.Unicode)]
	private static extern int ImmGetCompositionString(IntPtr hIMC, uint dwIndex, byte[] lpBuf, int dwBufLen);
	[DllImport("imm32.dll", CharSet = CharSet.Unicode)]
	private static extern IntPtr ImmGetContext(IntPtr hWnd);
	[DllImport("imm32.dll", CharSet = CharSet.Unicode)]
	public static extern IntPtr ImmReleaseContext(IntPtr hWnd, IntPtr context);

	public enum WM_IME
	{
		GCS_RESULTSTR = 0x800,
		EM_STREAMOUT = 0x044A,
		WM_IME_COMPOSITION = 0x10F,
		WM_IME_ENDCOMPOSITION = 0x10E,
		WM_IME_STARTCOMPOSITION = 0x10D
	}

	private bool skipImeComposition = false;
	private bool imeComposing = false;
	public bool IMEWorkaroundEnabled = true;
	string _mText = "";


	//======================================================================
	// Handle and get Scroll Positions.
	//======================================================================
	private const int SB_HORZ = 0x0;
	private const int SB_VERT = 0x1;
	private const int SB_THUMBPOSITION = 0x4;
	private const int WM_HSCROLL = 0x0114;
	private const int WM_VSCROLL = 0x0115;

	public int HorizontalPosition
	{
		get { return GetScrollPos((IntPtr)this.Handle, SB_HORZ); }
		set
		{
			SetScrollPos((IntPtr)this.Handle, SB_HORZ, value, true);
			SendMessage(this.Handle, WM_HSCROLL, (value << 16) | SB_THUMBPOSITION, IntPtr.Zero);
		}
	}

	public int VerticalPosition
	{
		get { return GetScrollPos((IntPtr)this.Handle, SB_VERT); }
		set
		{
			SetScrollPos((IntPtr)this.Handle, SB_VERT, value, true);
			SendMessage(this.Handle, WM_VSCROLL, (value << 16) | SB_THUMBPOSITION, IntPtr.Zero);
		}
	}

	//======================================================================
	// IME Handler
	//
	// refer to...
	//  Get text from richtextbox control without disturbing IME when input east Asian language
	//  http://social.msdn.microsoft.com/Forums/en-US/winforms/thread/cefa5376-7912-47f6-b86a-197a211c2b70/
	//======================================================================
	protected override void WndProc(ref Message m)
	{
		if (IMEWorkaroundEnabled)
		{
			switch (m.Msg)
			{
				case (int)WM_IME.EM_STREAMOUT:
					if (imeComposing)
					{
						skipImeComposition = true;
					}
					base.WndProc(ref m);
					break;

				case (int)WM_IME.WM_IME_COMPOSITION:
					if (m.LParam.ToInt32() == (int)WM_IME.GCS_RESULTSTR)
					{
						IntPtr hImm = ImmGetContext(this.Handle);
						int dwSize = ImmGetCompositionString(hImm, (int)WM_IME.GCS_RESULTSTR, null, 0);
						byte[] outstr = new byte[dwSize];
						ImmGetCompositionString(hImm, (int)WM_IME.GCS_RESULTSTR, outstr, dwSize);
						_mText += Encoding.Unicode.GetString(outstr).ToString();
						ImmReleaseContext(this.Handle, hImm);
					}
					if (skipImeComposition)
					{
						skipImeComposition = false;
						break;
					}
					base.WndProc(ref m);
					break;

				case (int)WM_IME.WM_IME_STARTCOMPOSITION:
					imeComposing = true;
					base.WndProc(ref m);
					break;

				case (int)WM_IME.WM_IME_ENDCOMPOSITION:
					imeComposing = false;
					base.WndProc(ref m);
					break;

				default:
					base.WndProc(ref m);
					break;
			}
		}
		else
			base.WndProc(ref m);
	}

	public override string Text
	{
		get
		{
			if (!imeComposing)
			{
				_mText = base.Text;
				return base.Text;
			}
			else
			{
				return _mText;
			}
		}
		set
		{
			base.Text = value;
			_mText = value;
		}
	}
	//======================================================================

}
