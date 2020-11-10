using UnityEngine;

namespace HuaweiMobileServices.Ads
{
	public class AdListener : AndroidJavaProxy
	{
		private readonly IAdListener m_listener;

		public AdListener(IAdListener listener) : base("org.unity.android.hms.unity.ads.AdListener")
		{
			m_listener = listener;
		}

		public void onAdClosed()
		{
			m_listener.OnAdClosed();
		}

		public void onAdFailed(int paramInt)
		{
			m_listener.OnAdFailed(paramInt);
		}

		public void onAdLeave()
		{
			m_listener.OnAdLeave();
		}

		public void onAdOpened()
		{
			m_listener.OnAdOpened();
		}

		public void onAdLoaded()
		{
			m_listener.OnAdLoaded();
		}

		public void onAdClicked()
		{
			m_listener.OnAdClicked();
		}

		public void onAdImpression()
		{
			m_listener.OnAdImpression();
		}
	}
}