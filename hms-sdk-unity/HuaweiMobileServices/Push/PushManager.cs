using HuaweiMobileServices.Base;
using HuaweiMobileServices.Id;
using UnityEngine;

namespace HuaweiMobileServices.Push
{
	public static class PushManager
	{
		public static readonly AndroidJavaClass HMSPushServiceJavaClass = new AndroidJavaClass("org.unity.android.hms.unity.push.HMSPushService");

		public static IPushListener Listener
		{
			set => HMSPushServiceJavaClass.CallStatic("setListener", new PushListenerWrapper(value));
		}

		public static string Token => HmsInstanceId.GetInstance().GetToken(MetadataHelper.AppId, "HCM");
	}
}