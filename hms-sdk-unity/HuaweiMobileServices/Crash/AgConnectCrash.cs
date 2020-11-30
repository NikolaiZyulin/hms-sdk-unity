using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Crash
{
	public class AGConnectCrash
	{
		private static readonly AndroidJavaClass AGConnectCrashJavaClass = new AndroidJavaClass("com.huawei.agconnect.crash.AGConnectCrash");

		public static IAGConnectCrash GetInstance()
		{
			return AGConnectCrashJavaClass.CallStaticAsWrapper<AGConnectCrashWrapper>("getInstance");
		}
	}
}