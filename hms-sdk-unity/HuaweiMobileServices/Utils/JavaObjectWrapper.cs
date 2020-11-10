namespace HuaweiMobileServices.Utils
{
	using System.Collections.Generic;
	using UnityEngine;

	public abstract class JavaObjectWrapper
	{
		protected internal AndroidJavaObject JavaObject { get; protected set; }
		
		public JavaObjectWrapper(AndroidJavaObject javaObject)
		{
			JavaObject = javaObject;
		}

		protected internal JavaObjectWrapper(string javaObjectCanonicalName, params object[] args)
		{
			JavaObject = new AndroidJavaObject(javaObjectCanonicalName, args.AsAutoParams());
		}

		protected internal T Call<T>(string methodName, params object[] args) => JavaObject.Call<T>(methodName, args.AsAutoParams());

		protected internal void Call(string methodName, params object[] args) => JavaObject.Call(methodName, args.AsAutoParams());

		protected internal string CallAsString(string methodName, params object[] args) =>
			Call<AndroidJavaObject>(methodName, args.AsAutoParams())?.AsString();

		protected internal T CallAsWrapper<T>(string methodName, params object[] args) where T : JavaObjectWrapper =>
			Call<AndroidJavaObject>(methodName, args.AsAutoParams())?.AsWrapper<T>();

		protected internal string CallAsUriString(string methodName, params object[] args) =>
			Call<AndroidJavaObject>(methodName, args.AsAutoParams())?.Call<AndroidJavaObject>("toString")?.AsString();

		protected internal IList<T> CallAsWrapperList<T>(string methodName, params object[] args) where T : JavaObjectWrapper =>
			Call<AndroidJavaObject>(methodName, args.AsAutoParams())?.AsListFromWrappable<T>();

		protected internal T[] CallAsWrapperArray<T>(string methodName, params object[] args) where T : JavaObjectWrapper =>
			Call<AndroidJavaObject>(methodName, args.AsAutoParams())?.AsArray<T>();
	}
}