using HuaweiMobileServices.Utils;
using UnityEngine;
using UnityEngine.Scripting;

namespace HuaweiMobileServices.Game
{
	// Wrapper for com.huawei.hms.jos.games.archive.Archive
	public class Archive : JavaObjectWrapper
	{
		[Preserve]
		public Archive(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		public virtual ArchiveSummary Summary => CallAsWrapper<ArchiveSummary>("getSummary");

		public virtual ArchiveDetails Details => CallAsWrapper<ArchiveDetails>("getDetails");
	}
}