using System;

namespace HuaweiMobileServices.Utils
{
	using UnityEngine;

	internal class GenericBridgeCallbackWrapper : AndroidJavaProxy
	{
		private Action<AndroidIntent> m_onSuccessListener;
		private Action<HMSException> m_onFailureListener;

		public GenericBridgeCallbackWrapper() : base("org.unity.android.hms.unity.GenericBridgeCallback")
		{
		}

		public GenericBridgeCallbackWrapper AddOnSuccessListener(Action<AndroidIntent> onSuccessListener)
		{
			m_onSuccessListener = onSuccessListener;
			return this;
		}

		public GenericBridgeCallbackWrapper AddOnFailureListener(Action<HMSException> onFailureListener)
		{
			m_onFailureListener = onFailureListener;
			return this;
		}

		public void onSuccess(AndroidJavaObject intent)
		{
			m_onSuccessListener?.Invoke(intent.AsWrapper<AndroidIntent>());
		}

		public void onFailure(AndroidJavaObject exception)
		{
			m_onFailureListener?.Invoke(exception.AsException());
		}
	}
}