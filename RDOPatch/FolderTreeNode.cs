using System;
using System.Windows.Forms;
using RDO.Data.Types;

namespace RDO.Data.TreeNodes
{
	// Token: 0x0200003C RID: 60
	public class FolderTreeNode : TreeNode
	{
		// Token: 0x06000193 RID: 403 RVA: 0x000182B4 File Offset: 0x000164B4
		public FolderTreeNode(Folder folder)
		{
			this.FolderInfo = folder;
			base.SelectedImageIndex = 0;
			base.StateImageIndex = 0;
			base.ImageIndex = 0;
			if (this.FolderInfo.Expanded)
			{
				base.Expand();
			}
			if (this.FolderInfo.Nodes == null)
			{
				return;
			}
			if (this.FolderInfo.Nodes.Count != 0)
			{
				for (int i = 0; i < this.FolderInfo.Nodes.Count; i++)
				{
					if (this.FolderInfo.Nodes[i].GetType() == typeof(Folder))
					{
						FolderTreeNode node = new FolderTreeNode((Folder)this.FolderInfo.Nodes[i]);
						base.Nodes.Add(node);
					}
					if (this.FolderInfo.Nodes[i].GetType() == typeof(RemoteDesktop))
					{
						new RemoteDesktop();
						RemoteDesktopTreeNode node2 = new RemoteDesktopTreeNode((RemoteDesktop)this.FolderInfo.Nodes[i]);
						base.Nodes.Add(node2);
					}
				}
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00003171 File Offset: 0x00001371
		// (set) Token: 0x06000195 RID: 405 RVA: 0x00003179 File Offset: 0x00001379
		public Folder FolderInfo
		{
			get
			{
				return this.folder_0;
			}
			set
			{
				base.Text = value.Text;
				this.folder_0 = value;
			}
		}

		// Token: 0x0400014E RID: 334
		private Folder folder_0 = new Folder();
	}
}
