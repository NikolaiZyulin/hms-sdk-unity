using HuaweiMobileServices.Utils;
using UnityEngine;
using UnityEngine.Scripting;

namespace HuaweiMobileServices.Ads
{
	// Wrapper for com.huawei.hms.ads.identifier.AdvertisingIdClient
	public class AdvertisingIdClient
	{
		private static readonly AndroidJavaClass ClientClass = new AndroidJavaClass("com.huawei.hms.ads.identifier.AdvertisingIdClient");

		public static bool VerifyAdId(string adId, bool isLimitAdTracking) =>
			ClientClass.CallStatic<bool>("verifyAdId", AndroidContext.ActivityContext, adId, isLimitAdTracking);

		public static Info AdvertisingIdInfo => ClientClass.CallStaticAsWrapper<Info>("getAdvertisingIdInfo", AndroidContext.ActivityContext);

		// Wrapper for com.huawei.hms.ads.identifier.AdvertisingIdClient.Info
		public class Info : JavaObjectWrapper
		{
			[Preserve]
			public Info(AndroidJavaObject javaObject) : base(javaObject)
			{
			}

			public string Id => CallAsString("getId");

			public bool LimitAdTrackingEnabled => Call<bool>("isLimitAdTrackingEnabled");
		}
	}
}