using HuaweiMobileServices.Id;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Game
{
	// Wrapper for com.huawei.hms.jos.JosApps
	public static class JosApps
	{
		private static readonly AndroidJavaClass JosAppsClass = new AndroidJavaClass("com.huawei.hms.jos.JosApps");

		public static IJosAppsClient GetJosAppsClient(AuthHuaweiId authHuaweiId)
		{
			var josAppsClient = JosAppsClass.CallStatic<AndroidJavaObject>(
				"getJosAppsClient",
				AndroidContext.ActivityContext,
				authHuaweiId.JavaObject
			);
			return new JosAppsClientWrapper(josAppsClient);
		}

		public static IProductClient GetProductClient()
		{
			var productClient = JosAppsClass.CallStatic<AndroidJavaObject>("getProductClient", AndroidContext.ApplicationContext);
			return new ProductClientWrapper(productClient);
		}
	}
}