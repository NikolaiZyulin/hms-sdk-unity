namespace HuaweiMobileServices.Ads
{
    using Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.ads.HwAds
    public static class HwAds
    {
        private static readonly AndroidJavaClass HwAdsClass = new AndroidJavaClass("com.huawei.hms.ads.HwAds");

        public static RequestOptions RequestOptions
        {
            get => HwAdsClass.CallStaticAsWrapper<RequestOptions>("getRequestOptions");
            set => HwAdsClass.CallStatic("setRequestOptions", value.JavaObject);
        }

        public static void Init() => HwAdsClass.CallStatic("init", AndroidContext.ActivityContext);

        public static void SetVideoVolume(float volume)
        {
            HwAdsClass.CallStatic("setVideoVolume", volume);
        }

        public static void SetConsent(string consent)
        {
            HwAdsClass.CallStatic("setConsent", consent);
        }

        public static void SetVideoMuted(bool muted)
        {
            HwAdsClass.CallStatic("setVideoMuted", muted);
        }

        public static string GetSdkVersion()
        {
            return HwAdsClass.CallStaticAsString("getSDKVersion");
        }
    }
}
