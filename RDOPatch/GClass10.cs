using System;
using System.Windows.Forms;
using RDO.Data.Types;

// Token: 0x02000025 RID: 37
public sealed class GClass10 : TreeNode
{
	// Token: 0x0600014A RID: 330 RVA: 0x00002E8F File Offset: 0x0000108F
	public GClass10()
	{
		base.Text = "ID Cards";
		base.Expand();
		base.SelectedImageIndex = 4;
		base.StateImageIndex = 4;
		base.ImageIndex = 4;
	}

	// Token: 0x0600014B RID: 331 RVA: 0x000161FC File Offset: 0x000143FC
	public GClass10(IdCards idCards_0)
	{
		base.Text = "ID Cards";
		base.Expand();
		base.SelectedImageIndex = 4;
		base.StateImageIndex = 4;
		base.ImageIndex = 4;
		if (idCards_0.Nodes == null)
		{
			return;
		}
		if (idCards_0.Nodes.Count != 0)
		{
			for (int i = 0; i < idCards_0.Nodes.Count; i++)
			{
				if (idCards_0.Nodes[i].GetType() == typeof(IdCard))
				{
					GClass11 node = new GClass11((IdCard)idCards_0.Nodes[i]);
					base.Nodes.Add(node);
				}
			}
		}
	}
}
