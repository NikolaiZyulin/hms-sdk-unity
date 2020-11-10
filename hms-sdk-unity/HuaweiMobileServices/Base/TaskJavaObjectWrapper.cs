namespace HuaweiMobileServices.Base
{
    using Utils;
    using UnityEngine;

    internal class TaskJavaObjectWrapper<T> : TaskWrapper<T> where T : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public TaskJavaObjectWrapper(AndroidJavaObject javaObject) : base(javaObject, AndroidJavaObjectExtensions.AsWrapper<T>) { }
    }
}
