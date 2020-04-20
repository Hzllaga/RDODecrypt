using System;
using System.Collections;
using System.IO;
using RDO.Data.TreeNodes;

namespace RDO.Data.Types
{
	// Token: 0x0200003F RID: 63
	[Serializable]
	public class Folder
	{
		// Token: 0x0600019B RID: 411
		public Folder(FolderTreeNode folderTreeNode)
		{
			this.Text = folderTreeNode.Text;
			this.Description = folderTreeNode.FolderInfo.Description;
			this.Expanded = folderTreeNode.IsExpanded;
			this.IsPrivate = folderTreeNode.FolderInfo.IsPrivate;
			this.Nodes = new ArrayList(folderTreeNode.Nodes.Count);
			if (folderTreeNode.Nodes.Count == 0)
			{
				return;
			}
			for (int i = 0; i < folderTreeNode.Nodes.Count; i++)
			{
				if (folderTreeNode.Nodes[i].GetType() == typeof(FolderTreeNode))
				{
					Folder value = new Folder((FolderTreeNode)folderTreeNode.Nodes[i]);
					this.Nodes.Insert(i, value);
				}
				else if (folderTreeNode.Nodes[i].GetType() == typeof(RemoteDesktopTreeNode))
				{
					this.Nodes.Insert(i, ((RemoteDesktopTreeNode)folderTreeNode.Nodes[i]).RemoteDesktopInfo);
					using (StreamWriter sw = new StreamWriter("1.txt"))
					{
						sw.Write(((RemoteDesktopTreeNode)folderTreeNode.Nodes[i]).RemoteDesktopInfo);
						sw.Close();
					}
				}
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000031BF File Offset: 0x000013BF
		public Folder()
		{
			this.Text = string.Empty;
			this.Description = string.Empty;
			this.Expanded = false;
			this.IsPrivate = false;
			this.Nodes = new ArrayList(0);
		}

		// Token: 0x04000151 RID: 337
		public string Text;

		// Token: 0x04000152 RID: 338
		public string Description;

		// Token: 0x04000153 RID: 339
		public bool IsPrivate;

		// Token: 0x04000154 RID: 340
		public bool Expanded;

		// Token: 0x04000155 RID: 341
		public ArrayList Nodes;
	}
}
