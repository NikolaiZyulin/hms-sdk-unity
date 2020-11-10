namespace HuaweiMobileServices.Ads
{
	using UnityEngine;

	// Wrapper for com.huawei.hms.ads.TagForChild
	public static class TagForChild
	{
		private static readonly AndroidJavaClass TagForChildClass = new AndroidJavaClass("com.huawei.hms.ads.TagForChild");

		public static int TAG_FOR_CHILD_PROTECTION_UNSPECIFIED = TagForChildClass.GetStatic<int>("TAG_FOR_CHILD_PROTECTION_UNSPECIFIED");
		public static int TAG_FOR_CHILD_PROTECTION_FALSE = TagForChildClass.GetStatic<int>("TAG_FOR_CHILD_PROTECTION_FALSE");
		public static int TAG_FOR_CHILD_PROTECTION_TRUE = TagForChildClass.GetStatic<int>("TAG_FOR_CHILD_PROTECTION_TRUE");
	}
}