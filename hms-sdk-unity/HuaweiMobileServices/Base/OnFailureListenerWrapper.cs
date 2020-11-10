namespace HuaweiMobileServices.Base
{
	using Utils;
	using System;
	using UnityEngine;

	// Wrapper for com.huawei.hmf.tasks.OnFailureListener
	internal class OnFailureListenerWrapper : AndroidJavaProxy
	{
		private readonly Action<HMSException> m_listener;

		internal OnFailureListenerWrapper(Action<HMSException> listener) : base("com.huawei.hmf.tasks.OnFailureListener")
		{
			m_listener = listener;
		}

		public void onFailure(AndroidJavaObject javaException)
		{
			m_listener.Invoke(javaException.AsException());
		}
	}
}