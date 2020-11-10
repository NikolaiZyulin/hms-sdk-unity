namespace HuaweiMobileServices.Base
{
	using Utils;
	using UnityEngine;

	public static class MetadataHelper
	{
		private static readonly AndroidJavaClass MetadataHelperClass = new AndroidJavaClass("org.unity.android.hms.unity.helper.MetadataHelper");

		public static string AppId => MetadataHelperClass.CallStaticAsString("getAppId");
	}
}