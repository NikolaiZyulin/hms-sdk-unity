using UnityEngine;
using UnityEngine.Scripting;

namespace HuaweiMobileServices.Utils
{
	public class AndroidBitmapFactory : JavaObjectWrapper
	{
		private static readonly AndroidJavaClass BitmapFactoryClass = new AndroidJavaClass("android.graphics.BitmapFactory");

		[Preserve]
		public AndroidBitmapFactory(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		public static AndroidJavaObject DecodeFile(string fileName) => BitmapFactoryClass.CallStatic<AndroidJavaObject>("decodeFile", fileName);
	}
}