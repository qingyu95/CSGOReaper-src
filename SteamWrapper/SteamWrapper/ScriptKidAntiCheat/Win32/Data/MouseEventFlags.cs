﻿using System;

namespace ScriptKidAntiCheat.Win32.Data
{
	// Token: 0x0200001F RID: 31
	[Flags]
	public enum MouseEventFlags : uint
	{
		// Token: 0x0400010D RID: 269
		MOUSEEVENTF_MOVE = 1U,
		// Token: 0x0400010E RID: 270
		MOUSEEVENTF_LEFTDOWN = 2U,
		// Token: 0x0400010F RID: 271
		MOUSEEVENTF_LEFTUP = 4U,
		// Token: 0x04000110 RID: 272
		MOUSEEVENTF_RIGHTDOWN = 8U,
		// Token: 0x04000111 RID: 273
		MOUSEEVENTF_RIGHTUP = 16U,
		// Token: 0x04000112 RID: 274
		MOUSEEVENTF_MIDDLEDOWN = 32U,
		// Token: 0x04000113 RID: 275
		MOUSEEVENTF_MIDDLEUP = 64U,
		// Token: 0x04000114 RID: 276
		MOUSEEVENTF_XDOWN = 128U,
		// Token: 0x04000115 RID: 277
		MOUSEEVENTF_XUP = 256U,
		// Token: 0x04000116 RID: 278
		MOUSEEVENTF_WHEEL = 2048U,
		// Token: 0x04000117 RID: 279
		MOUSEEVENTF_VIRTUALDESK = 16384U,
		// Token: 0x04000118 RID: 280
		MOUSEEVENTF_ABSOLUTE = 32768U
	}
}
