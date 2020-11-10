using UnityEngine;

namespace HuaweiMobileServices.Analytics
{
    using Utils;
    
    public class HiAnalytics : JavaObjectWrapper
    {
        private static readonly AndroidJavaClass AnalyticsClass = new AndroidJavaClass("com.huawei.hms.analytics.HiAnalytics");

        private static HiAnalyticsInstance m_hiAnalyticsInstance = null;

        public HiAnalytics() : base("com.huawei.hms.analytics.HiAnalytics")
        {
        }

        public static HiAnalyticsInstance GetInstance()
        {
            if (m_hiAnalyticsInstance == null)
            {
                var analyticsClassObject = AnalyticsClass.CallStatic<AndroidJavaObject>("getInstance", AndroidContext.ApplicationContext);
                m_hiAnalyticsInstance = new HiAnalyticsInstance(analyticsClassObject);
            }

            return m_hiAnalyticsInstance;
        }
    }
}