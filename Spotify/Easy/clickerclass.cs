using System;
using System.Runtime.InteropServices;

namespace Easy
{
	// Token: 0x02000007 RID: 7
	internal class clickerclass
	{
		// Token: 0x06000019 RID: 25
		[DllImport("user32", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
		public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

		// Token: 0x0600001A RID: 26 RVA: 0x000021B3 File Offset: 0x000003B3
		public static void leftclick(int count)
		{
			clickerclass.mouse_event(4, 0, 0, 0, 0);
			clickerclass.mouse_event(2, 0, 0, 0, 0);
		}

		// Token: 0x04000018 RID: 24
		private const int MOUSEEVENTF_MOVE = 1;

		// Token: 0x04000019 RID: 25
		private const int MOUSEEVENTF_LEFTDOWN = 2;

		// Token: 0x0400001A RID: 26
		private const int MOUSEEVENTF_LEFTUP = 4;

		// Token: 0x0400001B RID: 27
		private const int MOUSEEVENTF_RIGHTDOWN = 8;

		// Token: 0x0400001C RID: 28
		private const int MOUSEEVENTF_RIGHTUP = 16;
	}
}
