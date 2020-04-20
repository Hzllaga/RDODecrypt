using System;
using System.Windows.Forms;
using RDO.Data.TreeNodes;
using RDO.Data.Types;

// Token: 0x02000023 RID: 35
public sealed class GClass9 : TreeNode
{
	// Token: 0x06000129 RID: 297 RVA: 0x00002D72 File Offset: 0x00000F72
	public GClass9()
	{
		base.Text = "Connections";
		base.Expand();
		base.SelectedImageIndex = 3;
		base.StateImageIndex = 3;
		base.ImageIndex = 3;
	}

	// Token: 0x0600012A RID: 298 RVA: 0x0000F088 File Offset: 0x0000D288
	public GClass9(Connections connections_0)
	{
		base.Text = "Connections";
		base.Expand();
		base.SelectedImageIndex = 3;
		base.StateImageIndex = 3;
		base.ImageIndex = 3;
		if (connections_0.Nodes != null && connections_0.Nodes.Count != 0)
		{
			for (int i = 0; i < connections_0.Nodes.Count; i++)
			{
				if (connections_0.Nodes[i].GetType() == typeof(Folder))
				{
					FolderTreeNode node = new FolderTreeNode((Folder)connections_0.Nodes[i]);
					base.Nodes.Add(node);
				}
				if (connections_0.Nodes[i].GetType() == typeof(RemoteDesktop))
				{
					RemoteDesktopTreeNode node2 = new RemoteDesktopTreeNode((RemoteDesktop)connections_0.Nodes[i]);
					base.Nodes.Add(node2);
				}
			}
			return;
		}
	}
}
