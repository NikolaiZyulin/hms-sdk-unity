using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using UnityEngine;
using UnityEngine.Scripting;

namespace HuaweiMobileServices.Game
{
	internal class JosAppsClientWrapper : JavaObjectWrapper, IJosAppsClient
	{
		[Preserve]
		public JosAppsClientWrapper(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		public ITask<string> AppId
		{
			get
			{
				var javaTask = JavaObject.Call<AndroidJavaObject>("getAppId");
				return new TaskWrapper<string>(javaTask, AndroidJavaObjectExtensions.AsString);
			}
		}

		public void Init()
		{
			JavaObject.Call("init");
		}
	}
}