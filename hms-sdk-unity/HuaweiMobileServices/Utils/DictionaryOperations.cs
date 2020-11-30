using System;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using Object = System.Object;

namespace HuaweiMobileServices.Utils
{
	public static class DictionaryOperations
	{
		private static readonly AndroidJavaClass JavaArraysClass = new AndroidJavaClass("java.util.Arrays");

		public static AndroidJavaObject DictionaryToAndroidJavaObject(IDictionary<String, Object> dictionary)
		{
			var javaMap = new AndroidJavaObject("java.util.HashMap");
			var putMethod = AndroidJNIHelper.GetMethodID(javaMap.GetRawClass(), "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");

			var args = new object[2];
			foreach (var kvp in dictionary)
			{
				using (var k = new AndroidJavaObject("java.lang.String", kvp.Key))
				{
					using (var v = new AndroidJavaObject("java.lang.String", kvp.Value))
					{
						args[0] = k;
						args[1] = v;
						AndroidJNI.CallObjectMethod(javaMap.GetRawObject(), putMethod, AndroidJNIHelper.CreateJNIArgArray(args));
					}
				}
			}

			return javaMap;
		}

		public static Dictionary<string, object> XMLtoDictionary(string xmlPath)
		{
			var textFile = Resources.Load<TextAsset>(xmlPath);
			var rootElement = XElement.Parse(textFile.text);
			var dictionary = new Dictionary<String, Object>();

			foreach (var el in rootElement.Elements())
			{
				var key = el.Attribute("key");
				if (key != null)
				{
					dictionary.Add(key.Value, el.Value);
				}
			}

			return dictionary;
		}

		public static Dictionary<string, object> AndroidJavaObjectToDictionary(AndroidJavaObject javaList)
		{
			if (javaList == null || javaList.Call<int>("size") == 0) return null;

			var dictionary = new Dictionary<string, object>();
			var keyList = javaList.Call<AndroidJavaObject>("keySet").AsStringSet();
			foreach (var key in keyList)
			{
				dictionary.Add(key, javaList.Call<string>("get", key));
			}

			return dictionary;
		}
	}
}