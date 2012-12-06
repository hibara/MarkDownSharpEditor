using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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
	
	[DllImport("user32.dll")]
	private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
	private const int WM_SETREDRAW = 0x0b;
	[DllImport("user32.dll")]
	private static extern int SetScrollPos(IntPtr hWnd, UInt32 nBar, int nPos, bool bRedraw);
	[DllImport("user32.dll")]
	private static extern int GetScrollPos(IntPtr hwnd, UInt32 nBar);
	[DllImport("user32", EntryPoint = "SendMessageA")]
	public static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, IntPtr lParam);

	
	private const int SB_HORZ = 0x0;
	private const int SB_VERT = 0x1;
	private const int SB_THUMBPOSITION = 0x4;
	private const int WM_HSCROLL = 0x0114;
	private const int WM_VSCROLL = 0x0115;

	public int HorizontalPosition
	{
		get { return GetScrollPos((IntPtr)this.Handle, SB_HORZ); }
		set { 
			SetScrollPos((IntPtr)this.Handle, SB_HORZ, value, true);
			SendMessage(this.Handle, WM_HSCROLL, (value << 16) | SB_THUMBPOSITION, IntPtr.Zero);
		}
	}

	public int VerticalPosition
	{
		get { return GetScrollPos((IntPtr)this.Handle, SB_VERT); }
		set { 
			SetScrollPos((IntPtr)this.Handle, SB_VERT, value, true);
			SendMessage(this.Handle,	WM_VSCROLL, (value << 16) | SB_THUMBPOSITION,	IntPtr.Zero);
		}
	}


}
