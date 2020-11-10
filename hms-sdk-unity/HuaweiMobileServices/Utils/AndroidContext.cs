namespace HuaweiMobileServices.Utils
{
	using UnityEngine;

	internal static class AndroidContext
	{
		private static AndroidJavaClass m_unityPlayerClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		private static AndroidJavaObject m_applicationContextJava = null;

		public static AndroidJavaObject ActivityContext => m_unityPlayerClass.GetStatic<AndroidJavaObject>("currentActivity");

		public static AndroidJavaObject ApplicationContext
		{
			get
			{
				if (m_applicationContextJava == null)
				{
					m_applicationContextJava = ActivityContext.Call<AndroidJavaObject>("getApplicationContext");
				}

				return m_applicationContextJava;
			}
		}
	}
}