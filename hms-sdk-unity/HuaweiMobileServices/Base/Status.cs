﻿using System;
using System.Threading.Tasks;

namespace HuaweiMobileServices.Base
{
	using Utils;
	using UnityEngine;

	// Wrapper for com.huawei.hms.support.api.client.Status
	public sealed class Status : JavaObjectWrapper
	{
		private static readonly AndroidJavaClass StatusBridge = new AndroidJavaClass("org.unity.android.hms.unity.base.StatusBridge");
		
		public static readonly Status SUCCESS = new Status(0);

		public static readonly Status FAILURE = new Status(1);

		public static readonly Status MESSAGE_NOT_FOUND = new Status(404);

		public static readonly Status CORE_EXCEPTION = new Status(500);

		[UnityEngine.Scripting.Preserve]
		public Status(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		private Status(int paramInt) : base("com.huawei.hms.support.api.client.Status", paramInt, null)
		{
		}

		public bool HasResolution() => Call<bool>("hasResolution");

		public void StartResolutionForResult(Action<AndroidIntent> onSuccessListener, Action<HMSException> onFailureListener)
		{
			var callback = new GenericBridgeCallbackWrapper()
				.AddOnSuccessListener(onSuccessListener)
				.AddOnFailureListener(onFailureListener);
			StatusBridge.CallStatic("receiveStartResolutionForResult", JavaObject, callback);
		}

		public Task<AndroidIntent> StartResolutionForResultAsync()
		{
			var task = new TaskCompletionSource<AndroidIntent>();
			StartResolutionForResult((intent) => { task.SetResult(intent); }, (error) => { task.SetException(error); });
			return task.Task;
		}

		public int StatusCode => Call<int>("getStatusCode");

		public string StatusMessage => CallAsString("getStatusMessage");

		public AndroidPendingIntent Resolution => CallAsWrapper<AndroidPendingIntent>("getResolution");

		public bool Success => Call<bool>("isSuccess");

		public string ErrorString => CallAsString("getErrorString");

		public bool Canceled => Call<bool>("isCanceled");

		public bool Interrupted => Call<bool>("isInterrupted");
	}
}