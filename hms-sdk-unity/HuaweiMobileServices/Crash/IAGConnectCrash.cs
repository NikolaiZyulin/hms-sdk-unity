namespace HuaweiMobileServices.Crash
{
	public interface IAGConnectCrash
	{
		void EnableCrashCollection(bool enable);
		void TestIt();
		void SetUserId(string userId);
		void SetCustomKey(string key, string value);
		void SetCustomKey(string key, bool value);
		void SetCustomKey(string key, double value);
		void SetCustomKey(string key, float value);
		void SetCustomKey(string key, int value);
		void SetCustomKey(string key, long value);
		void Log(string message);
		void Log(int level, string message);
	}
}