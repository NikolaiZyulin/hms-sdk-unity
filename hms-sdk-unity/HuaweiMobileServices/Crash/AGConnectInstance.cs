using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Crash
{
	public class AGConnectInstance : JavaObjectWrapper
	{
		private static readonly AndroidJavaClass ConnectClass = new AndroidJavaClass("com.huawei.agconnect.AGConnectInstance");

		[UnityEngine.Scripting.Preserve]
		public AGConnectInstance() : base("com.huawei.agconnect.AGConnectInstance")
		{
		}

		[UnityEngine.Scripting.Preserve]
		public AGConnectInstance(AndroidJavaObject javaObject) : base(javaObject)
		{
		}
		
		public static AGConnectInstance GetInstance() => ConnectClass.CallStaticAsWrapper<AGConnectInstance>("getInstance");

		public static void Initialize()
		{
			ConnectClass.CallStatic("initialize", AndroidContext.ActivityContext);
		}
	}
}