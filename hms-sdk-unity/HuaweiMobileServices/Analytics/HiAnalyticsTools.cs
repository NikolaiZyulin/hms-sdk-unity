 using UnityEngine;

namespace HuaweiMobileServices.Analytics
{
    public static class HiAnalyticsTools
    {
        private static readonly AndroidJavaClass IapClass = new AndroidJavaClass("com.huawei.hms.analytics.HiAnalyticsTools");

        public static void EnableLog()
        {
            IapClass.CallStatic("enableLog");
        }

        public static void EnableLog(int level)
        {
            IapClass.CallStatic("enableLog", level);
        }
    }
}
