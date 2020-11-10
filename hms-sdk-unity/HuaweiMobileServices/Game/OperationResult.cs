using HuaweiMobileServices.Utils;
using UnityEngine;
using UnityEngine.Scripting;

namespace HuaweiMobileServices.Game
{
	// Wrapper for com.huawei.hms.jos.games.archive.OperationResult
	public class OperationResult : JavaObjectWrapper
	{
		[Preserve]
		public OperationResult(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		public virtual bool Different => Call<bool>("isDifference");

		public virtual Archive Archive => CallAsWrapper<Archive>("getArchive");

		public virtual Difference Difference => CallAsWrapper<Difference>("getDifference");
	}
}