using System;
using System.Runtime.Serialization;

namespace RDO.Data.Types
{
	// Token: 0x02000042 RID: 66
	[Serializable]
	public class RemoteDesktop
	{
		// Token: 0x060001A0 RID: 416 RVA: 0x000186B8 File Offset: 0x000168B8
		public RemoteDesktop()
		{
			this.IsPrivate = false;
			this.UseIdCard = false;
			this.IdCardGuid = Guid.Empty;
			this.Description = string.Empty;
			this.Host = string.Empty;
			this.Domain = string.Empty;
			this.User = string.Empty;
			this.Password = string.Empty;
			this.ConnectToConsole = false;
			this.Port = 3389;
			this.AllowWallpaper = false;
			this.AllowThemes = false;
			this.AllowAnimation = false;
			this.AllowContents = false;
			this.ColorDepth = 16;
			this.DeskSize = 2;
			this.DisplayWidth = 800;
			this.DisplayHeight = 600;
			this.AutoExpand = true;
			this.SmartSize = false;
			this.BitmapCaching = true;
			this.RedirectDisks = false;
			this.RedirectPrinters = false;
			this.RedirectPorts = false;
			this.RedirectSmartCard = false;
			this.KeyboardSetting = 0;
			this.AudioSetting = 2;
			this.AuthenticationLevel = 0U;
			this.GatewayBypass = true;
			this.GatewayDomain = string.Empty;
			this.GatewayIdCardGuid = Guid.Empty;
			this.GatewayLogonMethod = 0;
			this.GatewayPassword = string.Empty;
			this.GatewayServer = string.Empty;
			this.GatewayUseConnectionLogin = true;
			this.GatewayUseIdCard = false;
			this.GatewayUser = string.Empty;
			this.GatewayUsage = 0;
			this.EnableCredSspSupport = false;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00018818 File Offset: 0x00016A18
		public RemoteDesktop(RemoteDesktop DefaultSettings)
		{
			this.Text = DefaultSettings.Text;
			this.IsPrivate = DefaultSettings.IsPrivate;
			this.UseIdCard = DefaultSettings.UseIdCard;
			this.IdCardGuid = DefaultSettings.IdCardGuid;
			this.Description = DefaultSettings.Description;
			this.Host = DefaultSettings.Host;
			this.Domain = DefaultSettings.Domain;
			this.User = DefaultSettings.User;
			this.Password = DefaultSettings.Password;
			this.ConnectToConsole = DefaultSettings.ConnectToConsole;
			this.Port = DefaultSettings.Port;
			this.AllowWallpaper = DefaultSettings.AllowWallpaper;
			this.AllowThemes = DefaultSettings.AllowThemes;
			this.AllowAnimation = DefaultSettings.AllowAnimation;
			this.AllowContents = DefaultSettings.AllowContents;
			this.ColorDepth = DefaultSettings.ColorDepth;
			this.DeskSize = DefaultSettings.DeskSize;
			this.DisplayWidth = DefaultSettings.DisplayWidth;
			this.DisplayHeight = DefaultSettings.DisplayHeight;
			this.AutoExpand = DefaultSettings.AutoExpand;
			this.SmartSize = DefaultSettings.SmartSize;
			this.BitmapCaching = DefaultSettings.BitmapCaching;
			this.RedirectDisks = DefaultSettings.RedirectDisks;
			this.RedirectPrinters = DefaultSettings.RedirectPrinters;
			this.RedirectPorts = DefaultSettings.RedirectPorts;
			this.RedirectSmartCard = DefaultSettings.RedirectSmartCard;
			this.KeyboardSetting = DefaultSettings.KeyboardSetting;
			this.AudioSetting = DefaultSettings.AudioSetting;
			this.AuthenticationLevel = DefaultSettings.AuthenticationLevel;
			this.GatewayBypass = DefaultSettings.GatewayBypass;
			this.GatewayDomain = DefaultSettings.GatewayDomain;
			this.GatewayIdCardGuid = DefaultSettings.GatewayIdCardGuid;
			this.GatewayLogonMethod = DefaultSettings.GatewayLogonMethod;
			this.GatewayPassword = DefaultSettings.GatewayPassword;
			this.GatewayServer = DefaultSettings.GatewayServer;
			this.GatewayUseConnectionLogin = DefaultSettings.GatewayUseConnectionLogin;
			this.GatewayUseIdCard = DefaultSettings.GatewayUseIdCard;
			this.GatewayUser = DefaultSettings.GatewayUser;
			this.GatewayUsage = DefaultSettings.GatewayUsage;
			this.EnableCredSspSupport = DefaultSettings.EnableCredSspSupport;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00018A0C File Offset: 0x00016C0C
		[OnDeserializing]
		private void SetDefaults(StreamingContext sc)
		{
			this.IsPrivate = false;
			this.UseIdCard = false;
			this.IdCardGuid = Guid.Empty;
			this.Description = string.Empty;
			this.Host = string.Empty;
			this.Domain = string.Empty;
			this.User = string.Empty;
			this.Password = string.Empty;
			this.ConnectToConsole = false;
			this.Port = 3389;
			this.AllowWallpaper = false;
			this.AllowThemes = false;
			this.AllowAnimation = false;
			this.AllowContents = false;
			this.ColorDepth = 16;
			this.DeskSize = 2;
			this.DisplayWidth = 800;
			this.DisplayHeight = 600;
			this.AutoExpand = true;
			this.SmartSize = false;
			this.BitmapCaching = true;
			this.RedirectDisks = false;
			this.RedirectPrinters = false;
			this.RedirectPorts = false;
			this.RedirectSmartCard = false;
			this.KeyboardSetting = 0;
			this.AudioSetting = 2;
			this.AuthenticationLevel = 0U;
			this.GatewayBypass = true;
			this.GatewayDomain = string.Empty;
			this.GatewayIdCardGuid = Guid.Empty;
			this.GatewayLogonMethod = 0;
			this.GatewayPassword = string.Empty;
			this.GatewayServer = string.Empty;
			this.GatewayUseConnectionLogin = true;
			this.GatewayUseIdCard = false;
			this.GatewayUser = string.Empty;
			this.GatewayUsage = 0;
			this.EnableCredSspSupport = false;
		}

		// Token: 0x0400015D RID: 349
		public string Text;

		// Token: 0x0400015E RID: 350
		public bool IsPrivate;

		// Token: 0x0400015F RID: 351
		public bool UseIdCard;

		// Token: 0x04000160 RID: 352
		public Guid IdCardGuid;

		// Token: 0x04000161 RID: 353
		public string Description;

		// Token: 0x04000162 RID: 354
		public string Host;

		// Token: 0x04000163 RID: 355
		public string Domain;

		// Token: 0x04000164 RID: 356
		public string User;

		// Token: 0x04000165 RID: 357
		public string Password;

		// Token: 0x04000166 RID: 358
		public bool ConnectToConsole;

		// Token: 0x04000167 RID: 359
		public int Port;

		// Token: 0x04000168 RID: 360
		public int DeskSize;

		// Token: 0x04000169 RID: 361
		public int DisplayWidth;

		// Token: 0x0400016A RID: 362
		public int DisplayHeight;

		// Token: 0x0400016B RID: 363
		public bool AutoExpand;

		// Token: 0x0400016C RID: 364
		public bool SmartSize;

		// Token: 0x0400016D RID: 365
		public int ColorDepth;

		// Token: 0x0400016E RID: 366
		public int AudioSetting;

		// Token: 0x0400016F RID: 367
		public int KeyboardSetting;

		// Token: 0x04000170 RID: 368
		public bool RedirectDisks;

		// Token: 0x04000171 RID: 369
		public bool RedirectPrinters;

		// Token: 0x04000172 RID: 370
		public bool RedirectPorts;

		// Token: 0x04000173 RID: 371
		public bool RedirectSmartCard;

		// Token: 0x04000174 RID: 372
		public bool AllowWallpaper;

		// Token: 0x04000175 RID: 373
		public bool AllowContents;

		// Token: 0x04000176 RID: 374
		public bool AllowAnimation;

		// Token: 0x04000177 RID: 375
		public bool AllowThemes;

		// Token: 0x04000178 RID: 376
		public bool BitmapCaching;

		// Token: 0x04000179 RID: 377
		[OptionalField(VersionAdded = 2)]
		public uint AuthenticationLevel;

		// Token: 0x0400017A RID: 378
		[OptionalField(VersionAdded = 2)]
		public string GatewayServer;

		// Token: 0x0400017B RID: 379
		[OptionalField(VersionAdded = 2)]
		public bool GatewayBypass;

		// Token: 0x0400017C RID: 380
		[OptionalField(VersionAdded = 2)]
		public bool GatewayUseConnectionLogin;

		// Token: 0x0400017D RID: 381
		[OptionalField(VersionAdded = 2)]
		public string GatewayDomain;

		// Token: 0x0400017E RID: 382
		[OptionalField(VersionAdded = 2)]
		public string GatewayUser;

		// Token: 0x0400017F RID: 383
		[OptionalField(VersionAdded = 2)]
		public string GatewayPassword;

		// Token: 0x04000180 RID: 384
		[OptionalField(VersionAdded = 2)]
		public bool GatewayUseIdCard;

		// Token: 0x04000181 RID: 385
		[OptionalField(VersionAdded = 2)]
		public Guid GatewayIdCardGuid;

		// Token: 0x04000182 RID: 386
		[OptionalField(VersionAdded = 2)]
		public int GatewayLogonMethod;

		// Token: 0x04000183 RID: 387
		[OptionalField(VersionAdded = 2)]
		public int GatewayUsage;

		// Token: 0x04000184 RID: 388
		[OptionalField(VersionAdded = 3)]
		public bool EnableCredSspSupport;
	}
}
