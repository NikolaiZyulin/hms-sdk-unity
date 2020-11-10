namespace com.huawei.hms.ads
{
	using UnityEngine;

	// Wrapper for com.huawei.hms.ads.UnderAge
	public static class UnderAge
	{
		private static readonly AndroidJavaClass UnderAgeClass = new AndroidJavaClass("com.huawei.hms.ads.UnderAge");

		public static int PROMISE_TRUE = UnderAgeClass.GetStatic<int>("PROMISE_TRUE");
		public static int PROMISE_FALSE = UnderAgeClass.GetStatic<int>("PROMISE_FALSE");
		public static int PROMISE_UNSPECIFIED = UnderAgeClass.GetStatic<int>("PROMISE_UNSPECIFIED");
	}
}