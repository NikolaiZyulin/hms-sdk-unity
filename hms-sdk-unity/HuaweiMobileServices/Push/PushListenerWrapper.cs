namespace HuaweiMobileServices.Push
{
	using Utils;
	using UnityEngine;

	internal class PushListenerWrapper : AndroidJavaProxy
	{
		private readonly IPushListener m_listener;

		public PushListenerWrapper(IPushListener listener) : base("org.unity.android.hms.unity.push.PushListener")
		{
			m_listener = listener;
		}

		public void onNewToken(string token)
		{
			m_listener?.OnNewToken(token);
		}

		public void onTokenError(AndroidJavaObject e)
		{
			m_listener?.OnTokenError(e.AsException());
		}

		public void onMessageReceived(AndroidJavaObject remoteMessage)
		{
			m_listener?.OnMessageReceived(remoteMessage.AsWrapper<RemoteMessage>());
		}
	}
}