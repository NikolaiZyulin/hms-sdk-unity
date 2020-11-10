using HuaweiMobileServices.Base;
using UnityEngine;

namespace HuaweiMobileServices.Analytics
{
	using Utils;

	public sealed class HiAnalyticsInstance : JavaObjectWrapper
	{
		[UnityEngine.Scripting.Preserve]
		public HiAnalyticsInstance(AndroidJavaObject hiAnalyticsInstance) : base(hiAnalyticsInstance)
		{
		}

		public void ClearCachedData()
		{
			Call("clearCachedData");
		}

		public void SetAnalyticsEnabled(bool enabled)
		{
			Call("setAnalyticsEnabled", enabled);
		}

		public void SetMinActivitySessions(long milliseconds)
		{
			Call("setMinActivitySessions", milliseconds);
		}

		public void SetSessionDuration(long milliseconds)
		{
			Call("setSessionDuration", milliseconds);
		}

		public void SetUserProfile(string name, string value)
		{
			Call("setUserProfile", name, value);
		}

		public void PageStart(string pageName, string pageClassOverride)
		{
			Call("pageStart", pageName, pageClassOverride);
		}

		public void PageEnd(string pageName)
		{
			Call("pageEnd", pageName);
		}

		public void SetUserId(string id)
		{
			Call("setUserId", id);
		}

		public void SetPushToken(string token)
		{
			Call("setPushToken", token);
		}

		public Task GetAAID()
		{
			return Call<Task>("getAAID");
		}

		public Map<string, string> GetUserProfiles(bool var1)
		{
			return Call<Map<string, string>>("getUserProfiles", var1);
		}

		public void OnEvent(string eventId, Bundle androidBundle)
		{
			Call("onEvent", eventId, androidBundle);
		}

		public void SetAutoCollectionEnabled(bool isEnabled)
		{
			Call("setAutoCollectionEnabled", isEnabled);
		}

		public void SetCurrentActivity(string activityName, string activityClassOverride)
		{
			Call("setCurrentActivity", activityName, activityClassOverride);
		}

		public void RegHmsSvcEvent()
		{
			Call("regHmsSvcEvent");
		}

		public void UnRegHmsSvcEvent()
		{
			Call("unRegHmsSvcEvent");
		}
	}
}