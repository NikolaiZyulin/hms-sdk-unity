namespace HuaweiMobileServices.Base
{
	using Utils;
	using UnityEngine;

	internal class TaskStringWrapper : TaskWrapper<string>
	{
		[UnityEngine.Scripting.Preserve]
		public TaskStringWrapper(AndroidJavaObject javaObject) : base(javaObject, AndroidJavaObjectExtensions.AsString)
		{
		}
	}
}