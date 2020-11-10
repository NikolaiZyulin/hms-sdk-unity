using HuaweiMobileServices.Utils;
using UnityEngine;
using UnityEngine.Scripting;

namespace HuaweiMobileServices.Game
{
	internal class BuoyClientWrapper : JavaObjectWrapper, IBuoyClient
	{
		[Preserve]
		public BuoyClientWrapper(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		public void HideFloatWindow() => Call("hideFloatWindow");

		public void ShowFloatWindow() => Call("showFloatWindow");
	}
}