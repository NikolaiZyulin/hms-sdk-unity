using HuaweiMobileServices.Utils;
using UnityEngine;
using UnityEngine.Scripting;

namespace HuaweiMobileServices.Ads
{
	// Wrapper for com.huawei.hms.ads.reward.RewardVerifyConfig
	public class RewardVerifyConfig : JavaObjectWrapper
	{
		[Preserve]
		public RewardVerifyConfig(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		public virtual string Data => CallAsString("getData");
		public virtual string UserId => CallAsString("getUserId");
	}
}