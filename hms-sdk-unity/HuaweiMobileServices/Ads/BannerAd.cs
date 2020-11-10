using UnityEngine;

namespace HuaweiMobileServices.Ads
{
	using Utils;
	public class BannerAd : JavaObjectWrapper
	{
		[UnityEngine.Scripting.Preserve]
		public BannerAd(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		public BannerAd(AdListener adStatusListener) : base("org.unity.android.hms.unity.ads.BannerAdProxy", AndroidContext.ActivityContext,
			adStatusListener)
		{
		}

		public string AdId { set; get; }

		public int positionType { set; get; }
		public string sizeType { set; get; }

		public void ShowBanner(AdParam adRequest)
		{
			HandleRequestAd(adRequest);
		}

		public void HideBanner()
		{
			Call("hide");
		}

		public void DestroyBanner()
		{
			Call("destroy");
		}

		private void HandleRequestAd(AdParam adRequest)
		{
			Call("setAdId", AdId);
			Call("setBannerAdPosition", positionType);
			Call("setAdSizeType", sizeType);
			Call("loadAd", adRequest);
		}

		public void Show()
		{
			Call("show");
		}
	}
}