namespace HuaweiMobileServices.Base
{
	using System;
	using UnityEngine;

	// Note: this class cannot be called with AsWrapper() since constructor has 2 parameters
	internal class TaskWrapper<T> : AbstractTask<T>
	{
		private readonly Func<AndroidJavaObject, T> m_converter;

		[UnityEngine.Scripting.Preserve]
		internal TaskWrapper(AndroidJavaObject javaObject, Func<AndroidJavaObject, T> func) : base(javaObject)
		{
			m_converter = func;
		}

		public override T Result
		{
			get
			{
				var result = Call<AndroidJavaObject>("getResult");
				return m_converter.Invoke(result);
			}
		}

		public override ITask<T> AddOnSuccessListener(Action<T> onSuccessListener)
		{
			var listenerWrapper = new OnSuccessListenerConverterWrapper<T>(onSuccessListener, m_converter);
			JavaObject = Call<AndroidJavaObject>("addOnSuccessListener", listenerWrapper);
			return this;
		}
	}
}