using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Crash
{
	public class AgConnectCrash : JavaObjectWrapper
	{
		private static readonly AndroidJavaClass CrashClass = new AndroidJavaClass("com.huawei.agconnect.crash.AGConnectCrash");

		[UnityEngine.Scripting.Preserve]
		public AgConnectCrash() : base("com.huawei.agconnect.crash.AGConnectCrash")
		{
		}

		[UnityEngine.Scripting.Preserve]
		public AgConnectCrash(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		public static AgConnectCrash GetInstance() => CrashClass.CallStaticAsWrapper<AgConnectCrash>("getInstance");

		public void TestIt()
		{
			Call("testIt", AndroidContext.ActivityContext);
		}

		public void EnableCrashCollection(bool enable)
		{
			Call("enableCrashCollection", enable);
		}

		public void SetUserId(string id)
		{
			Call("setUserId", id);
		}

		public void SetCustomKey(string key, string value)
		{
			Call("setCustomKey", key, value);
		}

		public void SetCustomKey(string key, bool value)
		{
			Call("setCustomKey", key, value);
		}

		public void SetCustomKey(string key, double value)
		{
			Call("setCustomKey", key, value);
		}

		public void SetCustomKey(string key, float value)
		{
			Call("setCustomKey", key, value);
		}

		public void SetCustomKey(string key, int value)
		{
			Call("setCustomKey", key, value);
		}

		public void SetCustomKey(string key, long value)
		{
			Call("setCustomKey", key, value);
		}

		public void Log(int key, string value)
		{
			Call("log", key, value);
		}

		public void Log(string value)
		{
			Call("log", value);
		}
	}
}