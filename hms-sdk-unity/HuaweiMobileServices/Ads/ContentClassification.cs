namespace HuaweiMobileServices.Ads
{
	using UnityEngine;

	// Wrapper for com.huawei.hms.ads.ContentClassification
	public static class ContentClassification
	{
		private static readonly AndroidJavaClass ContentClassificationClass = new AndroidJavaClass("com.huawei.hms.ads.ContentClassification");

		public static string AD_CONTENT_CLASSIFICATION_W = ContentClassificationClass.GetStatic<string>("AD_CONTENT_CLASSIFICATION_W");

		public static string AD_CONTENT_CLASSIFICATION_PI = ContentClassificationClass.GetStatic<string>("AD_CONTENT_CLASSIFICATION_PI");

		public static string AD_CONTENT_CLASSIFICATION_J = ContentClassificationClass.GetStatic<string>("AD_CONTENT_CLASSIFICATION_J");

		public static string AD_CONTENT_CLASSIFICATION_A = ContentClassificationClass.GetStatic<string>("AD_CONTENT_CLASSIFICATION_A");

		public static string AD_CONTENT_CLASSIFICATION_UNKOWN = ContentClassificationClass.GetStatic<string>("AD_CONTENT_CLASSIFICATION_UNKOWN");
	}
}