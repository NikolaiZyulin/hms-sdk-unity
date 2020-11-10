namespace HuaweiMobileServices.Ads
{
	using Utils;
	using UnityEngine;

	// Wrapper for com.huawei.hms.ads.reward.OnMetadataChangedListener
	internal class OnMetadataChangedListener : JavaObjectWrapper
	{
		private class OnMetadataChangedListenerInterfaceWrapper : AndroidJavaProxy
		{
			private readonly IOnMetadataChangedListener m_listener;

			public OnMetadataChangedListenerInterfaceWrapper(IOnMetadataChangedListener listener) : base(
				"org.unity.android.hms.unity.ads.OnMetadataChangedListener")
			{
				m_listener = listener;
			}

			public void onMetadataChanged()
			{
				m_listener.OnMetadataChanged();
			}
		}

		public OnMetadataChangedListener(IOnMetadataChangedListener listener)
			: base("org.unity.android.hms.unity.ads.OnMetadataChangedListenerWrapper", new OnMetadataChangedListenerInterfaceWrapper(listener))
		{
		}
	}
}