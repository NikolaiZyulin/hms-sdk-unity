namespace HuaweiMobileServices.Ads
{
	using Utils;
	using UnityEngine;

	internal class RewardAdStatusListener : JavaObjectWrapper
	{
		private class RewardAdStatusListenerInterfaceWrapper : AndroidJavaProxy
		{
			private readonly IRewardAdStatusListener m_listener;

			public RewardAdStatusListenerInterfaceWrapper(IRewardAdStatusListener listener) : base("org.unity.android.hms.unity.ads.RewardAdStatusListener")
			{
				m_listener = listener;
			}

			public void onRewardAdClosed()
			{
				m_listener.OnRewardAdClosed();
			}

			public void onRewardAdFailedToShow(int errorCode)
			{
				m_listener.OnRewardAdFailedToShow(errorCode);
			}

			public void onRewardAdOpened()
			{
				m_listener.OnRewardAdOpened();
			}

			public void onRewarded(AndroidJavaObject reward)
			{
				m_listener.OnRewarded(new Reward(reward));
			}
		}

		public RewardAdStatusListener(IRewardAdStatusListener listener)
			: base("org.unity.android.hms.unity.ads.RewardAdStatusListenerWrapper", new RewardAdStatusListenerInterfaceWrapper(listener))
		{
		}
	}
}