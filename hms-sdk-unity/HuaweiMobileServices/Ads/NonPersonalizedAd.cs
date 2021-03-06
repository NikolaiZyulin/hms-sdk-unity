﻿namespace HuaweiMobileServices.Ads
{
	using UnityEngine;

	// Wrapper for com.huawei.hms.ads.NonPersonalizedAd
	public static class NonPersonalizedAd
	{
		private static readonly AndroidJavaClass NonPersonalizedAdJavaClass = new AndroidJavaClass("com.huawei.hms.ads.NonPersonalizedAd");

		public static int ALLOW_NON_PERSONALIZED = NonPersonalizedAdJavaClass.GetStatic<int>("ALLOW_NON_PERSONALIZED");

		public static int ALLOW_ALL = NonPersonalizedAdJavaClass.GetStatic<int>("ALLOW_ALL");
	}
}