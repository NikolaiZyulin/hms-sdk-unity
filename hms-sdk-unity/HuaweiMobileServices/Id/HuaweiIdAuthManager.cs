using System.Collections.Generic;

namespace HuaweiMobileServices.Id
{
	using HuaweiMobileServices.Base;
	using Utils;
	using UnityEngine;

	// Wrapper for com.huawei.hms.support.hwid.HuaweiIdAuthManager
	public static class HuaweiIdAuthManager
	{
		private static readonly AndroidJavaClass HuaweiIdAuthManagerClass = new AndroidJavaClass("com.huawei.hms.support.hwid.HuaweiIdAuthManager");

		public static HuaweiIdAuthService GetService(HuaweiIdAuthParams paramHuaweiIdAuthParams) =>
			HuaweiIdAuthManagerClass.CallStaticAsWrapper<HuaweiIdAuthService>("getService", AndroidContext.ActivityContext, paramHuaweiIdAuthParams);

		public static ITask<AuthHuaweiId> ParseAuthResultFromIntent(AndroidIntent paramIntent) =>
			HuaweiIdAuthManagerClass.CallStaticAsWrapper<TaskJavaObjectWrapper<AuthHuaweiId>>("parseAuthResultFromIntent", paramIntent);

		public static AuthHuaweiId AuthResult => HuaweiIdAuthManagerClass.CallStaticAsWrapper<AuthHuaweiId>("getAuthResult");

		public static AuthHuaweiId GetAuthResultWithScopes(IList<Scope> paramList) =>
			HuaweiIdAuthManagerClass.CallStaticAsWrapper<AuthHuaweiId>("getAuthResultWithScopes", paramList.AsJavaListFromWrapper());
	}
}