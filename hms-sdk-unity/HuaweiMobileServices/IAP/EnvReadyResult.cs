namespace HuaweiMobileServices.IAP
{
    using Utils;
    using UnityEngine;

    public class EnvReadyResult : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public EnvReadyResult(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual int ReturnCode
        {
            get => Call<int>("getReturnCode");
        }
    }
}
