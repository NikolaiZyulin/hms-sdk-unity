namespace HuaweiMobileServices.Ads
{
	using Utils;
	using UnityEngine;

	// Wrapper for com.huawei.hms.ads.reward.RewardAdListener
	internal class RewardAdListenerWrapper : AndroidJavaProxy
	{
		private readonly IRewardAdListener m_listener;

		public RewardAdListenerWrapper(IRewardAdListener listener) : base("com.huawei.hms.ads.reward.RewardAdListener")
		{
			m_listener = listener;
		}

		public void onRewarded(AndroidJavaObject reward)
		{
			m_listener.OnRewarded(reward.AsWrapper<Reward>());
		}

		public void onRewardAdClosed()
		{
			m_listener.OnRewardAdClosed();
		}

		public void onRewardAdFailedToLoad(int errorCode)
		{
			m_listener.OnRewardAdFailedToLoad(errorCode);
		}

		public void onRewardAdLeftApp()
		{
			m_listener.OnRewardAdLeftApp();
		}

		public void onRewardAdLoaded()
		{
			m_listener.OnRewardAdLoaded();
		}

		public void onRewardAdOpened()
		{
			m_listener.OnRewardAdOpened();
		}

		public void onRewardAdCompleted()
		{
			m_listener.OnRewardAdCompleted();
		}

		public void onRewardAdStarted()
		{
			m_listener.OnRewardAdStarted();
		}
	}
}