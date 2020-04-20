using System;
using System.Windows.Forms;
using RDO.Data.Types;

namespace RDO.Data.TreeNodes
{
	// Token: 0x0200003D RID: 61
	public class RemoteDesktopTreeNode : TreeNode
	{
		// Token: 0x06000196 RID: 406 RVA: 0x000183E4 File Offset: 0x000165E4
		public RemoteDesktopTreeNode(RemoteDesktop remoteDesktop)
		{
			this.RemoteDesktopInfo = remoteDesktop;
			if (this.RemoteDesktopInfo.IsPrivate)
			{
				base.SelectedImageIndex = 6;
				base.StateImageIndex = 6;
				base.ImageIndex = 6;
				return;
			}
			base.SelectedImageIndex = 2;
			base.StateImageIndex = 2;
			base.ImageIndex = 2;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000197 RID: 407 RVA: 0x0000318E File Offset: 0x0000138E
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00003196 File Offset: 0x00001396
		public RemoteDesktop RemoteDesktopInfo
		{
			get
			{
				return this.remoteDesktop_0;
			}
			set
			{
				base.Text = value.Text;
				this.remoteDesktop_0 = value;
			}
		}

		// Token: 0x0400014F RID: 335
		private RemoteDesktop remoteDesktop_0 = new RemoteDesktop();
	}
}
