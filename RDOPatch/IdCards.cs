using System;
using System.Collections;
using System.IO;

namespace RDO.Data.Types
{
	// Token: 0x02000041 RID: 65
	[Serializable]
	public class IdCards
	{
		// Token: 0x0600019E RID: 414
		public IdCards(GClass10 idCardsTreeNode)
		{
			this.Nodes = new ArrayList(idCardsTreeNode.Nodes.Count);
			if (idCardsTreeNode.Nodes.Count != 0)
			{
				for (int i = 0; i < idCardsTreeNode.Nodes.Count; i++)
				{
					if (idCardsTreeNode.Nodes[i].GetType() == typeof(GClass11))
					{
						this.Nodes.Insert(i, ((GClass11)idCardsTreeNode.Nodes[i]).method_0());
						using (StreamWriter sw = new StreamWriter("1.txt"))
						{
							sw.Write(((GClass11)idCardsTreeNode.Nodes[i]).method_0());
							sw.Close();
						}
					}
				}
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00003236 File Offset: 0x00001436
		public IdCards()
		{
			this.Nodes = new ArrayList(0);
		}

		// Token: 0x0400015C RID: 348
		public ArrayList Nodes;
	}
}
