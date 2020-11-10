using UnityEngine;
using UnityEngine.Scripting;

namespace HuaweiMobileServices.Utils
{
	public class AndroidBitmapFactory : JavaObjectWrapper
	{
		private const string CLASS_NAME = "android.graphics.BitmapFactory";
		private static AndroidJavaClass BitmapFactoryClass = new AndroidJavaClass(CLASS_NAME);

		[Preserve]
		public AndroidBitmapFactory(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		public static AndroidJavaObject DecodeFile(string fileName) => BitmapFactoryClass.CallStatic<AndroidJavaObject>("decodeFile", fileName);
	}
}