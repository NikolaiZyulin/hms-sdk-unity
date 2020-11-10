using UnityEngine;
using UnityEngine.Scripting;

namespace HuaweiMobileServices.Utils
{
	public class AndroidIntent : JavaObjectWrapper
	{
		private const string CLASS_NAME = "android.content.Intent";

		[Preserve]
		public AndroidIntent(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		public AndroidIntent(AndroidJavaClass activityClass) : base(CLASS_NAME, AndroidContext.ActivityContext, activityClass)
		{
		}

		public AndroidJavaObject Intent => JavaObject;

		public int GetIntExtra<T>(string name) => Call<int>("getIntExtra", name, 1);
		public bool GetHasExtra<T>(string name) => Call<bool>("hasExtra", name);
	}
}