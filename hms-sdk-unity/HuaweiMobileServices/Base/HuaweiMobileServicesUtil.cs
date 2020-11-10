namespace HuaweiMobileServices.Base
{
	using Utils;
	using UnityEngine;

	// Wrapper for com.huawei.hms.api.HuaweiMobileServicesUtil
	public static class HuaweiMobileServicesUtil
	{
		private static readonly AndroidJavaClass HuaweiMobileServicesUtilClass = new AndroidJavaClass("com.huawei.hms.api.HuaweiMobileServicesUtil");

		public static void SetApplication()
		{
			HuaweiMobileServicesUtilClass.CallStatic("setApplication", AndroidContext.ApplicationContext);
		}
	}
}