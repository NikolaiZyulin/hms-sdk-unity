using HuaweiMobileServices.Utils;
using UnityEngine;
using UnityEngine.Scripting;

namespace HuaweiMobileServices.IAP
{
	public class EnvReadyResult : JavaObjectWrapper
	{
		[Preserve]
		public EnvReadyResult(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		public virtual int ReturnCode => Call<int>("getReturnCode");
	}
}