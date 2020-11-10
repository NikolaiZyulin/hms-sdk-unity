namespace HuaweiMobileServices.Base
{
    using UnityEngine;

    public static class ServiceHelper
    {
        private static readonly AndroidJavaClass ServiceHelperClass = new AndroidJavaClass("org.unity.android.hms.unity.helper.ServiceHelper");

        public static bool GMSAvailable => ServiceHelperClass.CallStatic<bool>("isGMSAvailable");

        public static bool HMSAvailable => ServiceHelperClass.CallStatic<bool>("isHMSAvailable");
    }
}
