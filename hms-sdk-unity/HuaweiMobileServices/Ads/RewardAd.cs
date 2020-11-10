namespace HuaweiMobileServices.Ads
{
	using Utils;
	using System;
	using System.Threading.Tasks;
	using UnityEngine;

	// Wrapper for com.huawei.hms.ads.reward.RewardAd
	public class RewardAd : JavaObjectWrapper
	{
		private class LoadAdListener : IRewardAdLoadListener
		{
			private readonly Action m_onSuccess;
			private readonly Action<int> m_onError;

			public LoadAdListener(Action onSuccess, Action<int> onError)
			{
				m_onSuccess = onSuccess;
				m_onError = onError;
			}

			public void OnRewardAdFailedToLoad(int errorCode)
			{
				m_onError.Invoke(errorCode);
			}

			public void OnRewardedLoaded()
			{
				m_onSuccess.Invoke();
			}
		}

		private const string CLASS_NAME = "com.huawei.hms.ads.reward.RewardAd";

		private static readonly AndroidJavaClass RewardAdClass = new AndroidJavaClass(CLASS_NAME);

		public static RewardAd CreateRewardAdInstance() =>
			RewardAdClass.CallStaticAsWrapper<RewardAd>("createRewardAdInstance", AndroidContext.ActivityContext);

		[UnityEngine.Scripting.Preserve]
		public RewardAd(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		public RewardAd(string paramString) : base("com.huawei.hms.ads.reward.RewardAd", AndroidContext.ActivityContext, paramString)
		{
		}

		public virtual Reward Reward => CallAsWrapper<Reward>("getReward");

		public virtual bool Loaded => Call<bool>("isLoaded");

		public virtual void LoadAd(AdParam paramAdParam, Action onSuccess, Action<int> onError)
		{
			var listener = new LoadAdListener(onSuccess, onError);
			Call("loadAd", paramAdParam, new RewardAdLoadListener(listener));
		}

		public virtual Task LoadAdAsync(AdParam paramAdParam)
		{
			var task = new TaskCompletionSource<int>();
			LoadAd(paramAdParam, () => task.SetResult(0), (errorCode) =>
			{
				var error = new HMSException(errorCode);
				task.SetException(error);
			});
			return task.Task;
		}

		public virtual IOnMetadataChangedListener OnMetadataChangedListener
		{
			set { Call("setOnMetadataChangedListener", new OnMetadataChangedListener(value)); }
		}

		public virtual void Show(IRewardAdStatusListener paramRewardAdStatusListener, bool paramBoolean) =>
			Call("show", AndroidContext.ActivityContext, new RewardAdStatusListener(paramRewardAdStatusListener), paramBoolean);

		public virtual void Show(IRewardAdStatusListener paramRewardAdStatusListener) =>
			Call("show", AndroidContext.ActivityContext, new RewardAdStatusListener(paramRewardAdStatusListener));

		public virtual RewardVerifyConfig RewardVerifyConfig => CallAsWrapper<RewardVerifyConfig>("getRewardVerifyConfig");

		public virtual void Destroy() => Call("destroy", AndroidContext.ActivityContext);

		public virtual IRewardAdListener RewardAdListener
		{
			set { Call("setRewardAdListener", new RewardAdListenerWrapper(value)); }
		}

		public virtual string Data
		{
			get => CallAsString("getData");
			set => Call("setData", value);
		}

		public virtual string UserId
		{
			get => CallAsString("getUserId");
			set => Call("setUserId", value);
		}
		
		public virtual void LoadAd(string paramString, AdParam paramAdParam) => Call("loadAd", paramString, paramAdParam);

		public virtual void Pause() => Call("pause", AndroidContext.ActivityContext);

		public virtual void Resume() => Call("resume", AndroidContext.ActivityContext);

		public virtual bool Immersive => Call<bool>("isImmersive");

		public virtual void Show() => Call("show");
	}
}