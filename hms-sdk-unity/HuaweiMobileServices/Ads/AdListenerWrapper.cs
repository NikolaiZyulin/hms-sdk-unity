namespace HuaweiMobileServices.Ads
{
	using Utils;

	internal class AdListenerWrapper : JavaObjectWrapper
	{
		public AdListenerWrapper(IAdListener listener)
			: base("org.unity.android.hms.unity.ads.AdListenerWrapper", new AdListener(listener))
		{
		}
	}
}