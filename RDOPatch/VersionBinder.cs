using System;
using System.Runtime.Serialization;

namespace RDO.Data
{
	// Token: 0x02000045 RID: 69
	public class VersionBinder : SerializationBinder
	{
		// Token: 0x060001C2 RID: 450 RVA: 0x00018E3C File Offset: 0x0001703C
		public override Type BindToType(string assemblyName, string typeName)
		{
			if (typeName.Contains("RDO.DataBase+ConnectionsData"))
			{
				typeName = typeName.Replace("RDO.DataBase+ConnectionsData", "RDO.Data.Types.Root");
			}
			if (typeName.Contains("RDO.DataBase+RDConnection"))
			{
				typeName = typeName.Replace("RDO.DataBase+RDConnection", "RDO.Data.Types.RemoteDesktop");
			}
			if (typeName.Contains("RDO.DataBase+Folder"))
			{
				typeName = typeName.Replace("RDO.DataBase+Folder", "RDO.Data.Types.Folder");
			}
			if (typeName.Contains("RDO.DataBase+ColorDepthEnum"))
			{
				typeName = typeName.Replace("RDO.DataBase+ColorDepthEnum", "RDO.Data.Enums.ColorDepth");
			}
			if (typeName.Contains("RDO.DataBase+DesktopSize"))
			{
				typeName = typeName.Replace("RDO.DataBase+DesktopSize", "RDO.Data.Enums.DesktopSize");
			}
			if (typeName.Contains("RDO.DataBase+AudioRedirection"))
			{
				typeName = typeName.Replace("RDO.DataBase+AudioRedirection", "RDO.Data.Enums.AudioRedirection");
			}
			if (typeName.Contains("RDO.DataBase+KeyboardRedirection"))
			{
				typeName = typeName.Replace("RDO.DataBase+KeyboardRedirection", "RDO.Data.Enums.KeyboardRedirection");
			}
			if (typeName.Contains("RDO.AppSettings"))
			{
				typeName = typeName.Replace("RDO.AppSettings", "RDO.Data.Types.Settings");
			}
			if (typeName.Contains("RDOData.Root"))
			{
				typeName = typeName.Replace("RDOData.Root", "RDO.Data.Types.Root");
			}
			if (typeName.Contains("RDOData.IdentificationsRoot"))
			{
				typeName = typeName.Replace("RDOData.IdentificationsRoot", "RDO.Data.Types.IdCards");
			}
			if (typeName.Contains("RDOData.IdentificationsID"))
			{
				typeName = typeName.Replace("RDOData.IdentificationsID", "RDO.Data.Types.IdCard");
			}
			if (typeName.Contains("RDOData.ConnectionsRoot"))
			{
				typeName = typeName.Replace("RDOData.ConnectionsRoot", "RDO.Data.Types.Connections");
			}
			if (typeName.Contains("RDOData.ConnectionsRDP"))
			{
				typeName = typeName.Replace("RDOData.ConnectionsRDP", "RDO.Data.Types.RemoteDesktop");
			}
			if (typeName.Contains("RDOData.ConnectionsFolder"))
			{
				typeName = typeName.Replace("RDOData.ConnectionsFolder", "RDO.Data.Types.Folder");
			}
			if (typeName.Contains("RDOData.Enums+ColorDepth"))
			{
				typeName = typeName.Replace("RDOData.Enums+ColorDepth", "RDO.Data.Enums.ColorDepth");
			}
			if (typeName.Contains("RDOData.Enums+DesktopSize"))
			{
				typeName = typeName.Replace("RDOData.Enums+DesktopSize", "RDO.Data.Enums.DesktopSize");
			}
			if (typeName.Contains("RDOData.Enums+AudioRedirection"))
			{
				typeName = typeName.Replace("RDOData.Enums+AudioRedirection", "RDO.Data.Enums.AudioRedirection");
			}
			if (typeName.Contains("RDOData.Enums+KeyboardRedirection"))
			{
				typeName = typeName.Replace("RDOData.Enums+KeyboardRedirection", "RDO.Data.Enums.KeyboardRedirection");
			}
			return Type.GetType(string.Format("{0}, {1}", typeName, assemblyName));
		}
	}
}
