using HuaweiMobileServices.Utils;
using UnityEngine;
using UnityEngine.Scripting;

namespace HuaweiMobileServices.Id
{
	// Wrapper for com.huawei.hms.aaid.entity.AAIDResult
	public class AAIDResult : JavaObjectWrapper
	{
		[Preserve]
		public AAIDResult(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		public virtual string Id
		{
			get => CallAsString("getId");
			set => Call("setId", value);
		}
	}
}