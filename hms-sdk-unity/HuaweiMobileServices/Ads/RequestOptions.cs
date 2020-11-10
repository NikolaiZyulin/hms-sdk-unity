namespace HuaweiMobileServices.Ads
{
	using Utils;
	using UnityEngine;

	// Wrapper for com.huawei.hms.ads.RequestOptions
	public class RequestOptions : JavaObjectWrapper
	{
		[UnityEngine.Scripting.Preserve]
		public RequestOptions(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		public virtual int TagForChildProtection => Call<int>("getTagForChildProtection");

		public virtual int TagForUnderAgeOfPromise => Call<int>("getTagForUnderAgeOfPromise");

		public virtual int NonPersonalizedAd => Call<int>("getNonPersonalizedAd");

		public virtual string AppLang => CallAsString("getAppLang");

		public virtual string AppCountry => CallAsString("getAppCountry");

		public virtual string AdContentClassification => CallAsString("getAdContentClassification");

		public virtual Builder ToBuilder() => CallAsWrapper<Builder>("toBuilder");

		public class Builder : JavaObjectWrapper
		{
			[UnityEngine.Scripting.Preserve]
			public Builder(AndroidJavaObject javaObject) : base(javaObject)
			{
			}

			public virtual RequestOptions Build() => CallAsWrapper<RequestOptions>("build");

			public virtual Builder SetTagForChildProtection(int param1Integer) =>
				CallAsWrapper<Builder>("setTagForChildProtection", param1Integer.AsJavaInteger());

			public virtual Builder SetTagForUnderAgeOfPromise(int param1Integer) =>
				CallAsWrapper<Builder>("setTagForUnderAgeOfPromise", param1Integer.AsJavaInteger());

			public virtual Builder SetAdContentClassification(string param1String) => CallAsWrapper<Builder>("setAdContentClassification", param1String);

			public virtual Builder SetNonPersonalizedAd(int param1Integer) => CallAsWrapper<Builder>("setNonPersonalizedAd", param1Integer.AsJavaInteger());

			public virtual Builder SetAppLang(string param1String) => CallAsWrapper<Builder>("setAppLang", param1String);

			public virtual Builder SetAppCountry(string param1String) => CallAsWrapper<Builder>("setAppCountry", param1String);
		}
	}
}