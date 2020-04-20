using System;
using System.Collections;
using System.Windows.Forms;
using RDO.Data.TreeNodes;

namespace RDO.Data.Types
{
	// Token: 0x02000043 RID: 67
	[Serializable]
	public class Root
	{
		// Token: 0x060001A3 RID: 419 RVA: 0x00018B64 File Offset: 0x00016D64
		public Root(TreeView treeview)
		{
			this.Nodes = new ArrayList(treeview.Nodes.Count);
			if (treeview.Nodes.Count == 0)
			{
				return;
			}
			for (int i = 0; i < treeview.Nodes.Count; i++)
			{
				if (treeview.Nodes[i].GetType() == typeof(GClass10))
				{
					this.Nodes.Insert(i, new IdCards((GClass10)treeview.Nodes[i]));
				}
				if (treeview.Nodes[i].GetType() == typeof(GClass9))
				{
					this.Nodes.Insert(i, new Connections((GClass9)treeview.Nodes[i]));
				}
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000324A File Offset: 0x0000144A
		public Root()
		{
			this.Nodes = new ArrayList(2);
			this.Nodes.Insert(0, new IdCards());
			this.Nodes.Insert(1, new Connections());
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00018C38 File Offset: 0x00016E38
		public void PopulateTree(TreeView treeview)
		{
			if (this.Nodes != null && this.Nodes.Count != 0)
			{
				treeview.BeginUpdate();
				for (int i = 0; i < this.Nodes.Count; i++)
				{
					if (this.Nodes[i].GetType() == typeof(IdCards))
					{
						GClass10 node = new GClass10((IdCards)this.Nodes[i]);
						treeview.Nodes.Add(node);
					}
					if (this.Nodes[i].GetType() == typeof(Connections))
					{
						GClass9 node2 = new GClass9((Connections)this.Nodes[i]);
						treeview.Nodes.Add(node2);
					}
					if (this.Nodes[i].GetType() == typeof(Folder))
					{
						GClass10 node3 = new GClass10();
						treeview.Nodes.Add(node3);
						TreeNode treeNode = new FolderTreeNode((Folder)this.Nodes[i]);
						GClass9 gclass = new GClass9();
						foreach (object obj in treeNode.Nodes)
						{
							TreeNode node4 = (TreeNode)obj;
							gclass.Nodes.Add(node4);
						}
						treeview.Nodes.Add(gclass);
					}
				}
				treeview.EndUpdate();
				return;
			}
		}

		// Token: 0x04000185 RID: 389
		public ArrayList Nodes;
	}
}
