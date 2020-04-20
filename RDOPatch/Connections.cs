using System;
using System.Collections;
using RDO.Data.TreeNodes;

namespace RDO.Data.Types
{
	// Token: 0x0200003E RID: 62
	[Serializable]
	public class Connections
	{
		// Token: 0x06000199 RID: 409 RVA: 0x00018444 File Offset: 0x00016644
		public Connections(GClass9 node)
		{
			this.Nodes = new ArrayList(node.Nodes.Count);
			if (node.Nodes.Count == 0)
			{
				return;
			}
			for (int i = 0; i < node.Nodes.Count; i++)
			{
				if (node.Nodes[i].GetType() == typeof(FolderTreeNode))
				{
					Folder value = new Folder((FolderTreeNode)node.Nodes[i]);
					this.Nodes.Insert(i, value);
				}
				else if (node.Nodes[i].GetType() == typeof(RemoteDesktopTreeNode))
				{
					this.Nodes.Insert(i, ((RemoteDesktopTreeNode)node.Nodes[i]).RemoteDesktopInfo);
				}
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000031AB File Offset: 0x000013AB
		public Connections()
		{
			this.Nodes = new ArrayList(0);
		}

		// Token: 0x04000150 RID: 336
		public ArrayList Nodes;
	}
}
