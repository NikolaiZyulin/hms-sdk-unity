namespace HuaweiMobileServices.Ads
{
	using Utils;
	using UnityEngine;

	// Wrapper for com.huawei.hms.ads.reward.RewardAdLoadListener
	internal class RewardAdLoadListener : JavaObjectWrapper
	{
		private class RewardAdLoadListenerInterfaceWrapper : AndroidJavaProxy
		{
			private readonly IRewardAdLoadListener m_listener;

			public RewardAdLoadListenerInterfaceWrapper(IRewardAdLoadListener listener) : base("org.unity.android.hms.unity.ads.RewardAdLoadListener")
			{
				m_listener = listener;
			}

			public void onRewardedLoaded()
			{
				m_listener.OnRewardedLoaded();
			}

			public void onRewardAdFailedToLoad(int errorCode)
			{
				m_listener.OnRewardAdFailedToLoad(errorCode);
			}
		}

		public RewardAdLoadListener(IRewardAdLoadListener listener)
			: base("org.unity.android.hms.unity.ads.RewardAdLoadListenerWrapper", new RewardAdLoadListenerInterfaceWrapper(listener))
		{
		}
	}
}