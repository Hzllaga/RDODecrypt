using System;
using System.Windows.Forms;
using RDO.Data.Types;

// Token: 0x02000026 RID: 38
public sealed class GClass11 : TreeNode
{
	// Token: 0x0600014C RID: 332 RVA: 0x00002EBD File Offset: 0x000010BD
	public GClass11(IdCard idCard_1)
	{
		this.method_1(idCard_1);
		base.SelectedImageIndex = 5;
		base.StateImageIndex = 5;
		base.ImageIndex = 5;
	}

	// Token: 0x0600014D RID: 333 RVA: 0x00002EEC File Offset: 0x000010EC
	public IdCard method_0()
	{
		return this.idCard_0;
	}

	// Token: 0x0600014E RID: 334 RVA: 0x00002EF4 File Offset: 0x000010F4
	public void method_1(IdCard idCard_1)
	{
		base.Text = idCard_1.Text;
		this.idCard_0 = idCard_1;
	}

	// Token: 0x0400010B RID: 267
	private IdCard idCard_0 = new IdCard();
}
