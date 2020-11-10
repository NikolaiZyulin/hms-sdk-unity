namespace HuaweiMobileServices.Base
{
	using System;
	using UnityEngine;

	// Wrapper for com.huawei.hmf.tasks.OnSuccessListener
	internal class OnSuccessListenerConverterWrapper<T> : AndroidJavaProxy
	{
		private readonly Action<T> m_listener;
		private readonly Func<AndroidJavaObject, T> m_converter;

		public OnSuccessListenerConverterWrapper(Action<T> listener, Func<AndroidJavaObject, T> func) : base("com.huawei.hmf.tasks.OnSuccessListener")
		{
			m_listener = listener;
			m_converter = func;
		}

		public void onSuccess(AndroidJavaObject result)
		{
			var convertedResult = m_converter(result);
			m_listener.Invoke(convertedResult);
		}
	}

	// Wrapper for com.huawei.hmf.tasks.OnSuccessListener
	internal class OnSuccessListenerWrapper<T> : AndroidJavaProxy
	{
		private readonly Action<T> m_listener;

		public OnSuccessListenerWrapper(Action<T> listener) : base("com.huawei.hmf.tasks.OnSuccessListener")
		{
			m_listener = listener;
		}

		public void onSuccess(T result)
		{
			m_listener.Invoke(result);
		}
	}
}