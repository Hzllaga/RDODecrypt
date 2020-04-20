using System;

namespace RDO.Data.Types
{
	// Token: 0x02000040 RID: 64
	[Serializable]
	public class IdCard
	{
		// Token: 0x04000156 RID: 342
		public string Text = string.Empty;

		// Token: 0x04000157 RID: 343
		public string Description = string.Empty;

		// Token: 0x04000158 RID: 344
		public bool IsPrivate;

		// Token: 0x04000159 RID: 345
		public string User = string.Empty;

		// Token: 0x0400015A RID: 346
		public string Password = string.Empty;

		// Token: 0x0400015B RID: 347
		public Guid ID = Guid.NewGuid();
	}
}
