using System;

namespace HuaweiMobileServices.Utils
{
	using HuaweiMobileServices.Base;
	using UnityEngine;

	internal static class GenericBridgeWrapper
	{
		private static readonly AndroidJavaClass GenericBridgeClass = new AndroidJavaClass("org.unity.android.hms.unity.GenericBridge");

		public static void CallGenericBridge(this JavaObjectWrapper javaObjectWrapper, string methodName, Action onSuccess, Action<HMSException> onFailure)
		{
			javaObjectWrapper.CallAsWrapper<TaskAndroidJavaObject>(methodName)
				.AddOnSuccessListener((intent) =>
				{
					var callback = new GenericBridgeCallbackWrapper()
						.AddOnFailureListener(onFailure)
						.AddOnSuccessListener((nothing) => { onSuccess.Invoke(); });
					GenericBridgeClass.CallStatic("receiveShow", intent, callback);
				}).AddOnFailureListener(onFailure.Invoke);
		}
	}
}