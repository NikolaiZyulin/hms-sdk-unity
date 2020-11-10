using HuaweiMobileServices.Utils;
using UnityEngine;
using UnityEngine.Scripting;

namespace HuaweiMobileServices.Game
{
	public class Difference : JavaObjectWrapper
	{
		[Preserve]
		public Difference(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		public Archive ServerArchive => CallAsWrapper<Archive>("getServerArchive");

		public ArchiveDetails EmptyArchiveDetails => CallAsWrapper<ArchiveDetails>("getEmptyArchiveDetails");

		public Archive RecentArchive() => CallAsWrapper<Archive>("getRecentArchive");
	}
}