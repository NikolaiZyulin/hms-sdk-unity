namespace HuaweiMobileServices.Base
{
    using Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.support.api.client.Result
    public abstract class Result : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public Result(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual Status Status => CallAsWrapper<Status>("getStatus");
    }
}