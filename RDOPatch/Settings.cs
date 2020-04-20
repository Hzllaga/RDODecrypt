using System;
using System.Drawing;
using System.Windows.Forms;

namespace RDO.Data.Types
{
	// Token: 0x02000044 RID: 68
	[Serializable]
	public class Settings
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x00003280 File Offset: 0x00001480
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x00003288 File Offset: 0x00001488
		public Point WindowLocation
		{
			get
			{
				return this._WindowLocation;
			}
			set
			{
				this._WindowLocation = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00003291 File Offset: 0x00001491
		// (set) Token: 0x060001AA RID: 426 RVA: 0x00003299 File Offset: 0x00001499
		public Size WindowSize
		{
			get
			{
				return this._WindowSize;
			}
			set
			{
				this._WindowSize = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060001AB RID: 427 RVA: 0x000032A2 File Offset: 0x000014A2
		// (set) Token: 0x060001AC RID: 428 RVA: 0x000032AA File Offset: 0x000014AA
		public FormWindowState WindowState
		{
			get
			{
				return this._WindowState;
			}
			set
			{
				this._WindowState = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060001AD RID: 429 RVA: 0x000032B3 File Offset: 0x000014B3
		// (set) Token: 0x060001AE RID: 430 RVA: 0x000032BB File Offset: 0x000014BB
		public bool UseProxy
		{
			get
			{
				return this._UseProxy;
			}
			set
			{
				this._UseProxy = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060001AF RID: 431 RVA: 0x000032C4 File Offset: 0x000014C4
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x000032CC File Offset: 0x000014CC
		public string ProxyServer
		{
			get
			{
				return this._ProxyServer;
			}
			set
			{
				this._ProxyServer = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x000032D5 File Offset: 0x000014D5
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x000032DD File Offset: 0x000014DD
		public int ProxyPort
		{
			get
			{
				return this._ProxyPort;
			}
			set
			{
				this._ProxyPort = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x000032E6 File Offset: 0x000014E6
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x000032EE File Offset: 0x000014EE
		public int ToolBoxWidth
		{
			get
			{
				return this._ToolBoxWidth;
			}
			set
			{
				this._ToolBoxWidth = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x000032F7 File Offset: 0x000014F7
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x000032FF File Offset: 0x000014FF
		public bool AutoHide
		{
			get
			{
				return this._AutoHide;
			}
			set
			{
				this._AutoHide = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x00003308 File Offset: 0x00001508
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x00003310 File Offset: 0x00001510
		public bool CloseToTray
		{
			get
			{
				return this._CloseToTray;
			}
			set
			{
				this._CloseToTray = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x00003319 File Offset: 0x00001519
		// (set) Token: 0x060001BA RID: 442 RVA: 0x00003321 File Offset: 0x00001521
		public bool MinimizeToTray
		{
			get
			{
				return this._MinimizeToTray;
			}
			set
			{
				this._MinimizeToTray = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060001BB RID: 443 RVA: 0x0000332A File Offset: 0x0000152A
		// (set) Token: 0x060001BC RID: 444 RVA: 0x00003332 File Offset: 0x00001532
		public bool EnableSysTray
		{
			get
			{
				return this._EnableSysTray;
			}
			set
			{
				this._EnableSysTray = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060001BD RID: 445 RVA: 0x0000333B File Offset: 0x0000153B
		// (set) Token: 0x060001BE RID: 446 RVA: 0x00003343 File Offset: 0x00001543
		public RemoteDesktop QuickConnection
		{
			get
			{
				return this._QuickConnection;
			}
			set
			{
				this._QuickConnection = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060001BF RID: 447 RVA: 0x0000334C File Offset: 0x0000154C
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x00003354 File Offset: 0x00001554
		public RemoteDesktop DefaultConnection
		{
			get
			{
				return this.defaultConnection;
			}
			set
			{
				this.defaultConnection = value;
			}
		}

		// Token: 0x04000186 RID: 390
		private Point _WindowLocation = new Point(0, 0);

		// Token: 0x04000187 RID: 391
		private Size _WindowSize = new Size(640, 480);

		// Token: 0x04000188 RID: 392
		private FormWindowState _WindowState = FormWindowState.Maximized;

		// Token: 0x04000189 RID: 393
		private bool _UseProxy;

		// Token: 0x0400018A RID: 394
		private string _ProxyServer = string.Empty;

		// Token: 0x0400018B RID: 395
		private int _ProxyPort = 8080;

		// Token: 0x0400018C RID: 396
		private int _ToolBoxWidth = 225;

		// Token: 0x0400018D RID: 397
		private bool _AutoHide;

		// Token: 0x0400018E RID: 398
		private bool _EnableSysTray;

		// Token: 0x0400018F RID: 399
		private bool _CloseToTray;

		// Token: 0x04000190 RID: 400
		private bool _MinimizeToTray;

		// Token: 0x04000191 RID: 401
		private RemoteDesktop _QuickConnection = new RemoteDesktop();

		// Token: 0x04000192 RID: 402
		private RemoteDesktop defaultConnection = new RemoteDesktop();
	}
}
