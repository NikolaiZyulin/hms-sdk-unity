using HuaweiMobileServices.Utils;
using UnityEngine;
using UnityEngine.Scripting;

namespace HuaweiMobileServices.IAP
{
	// Wrapper for com.huawei.hms.iap.entity.PurchaseResultInfo
	public class PurchaseResultInfo : JavaObjectWrapper
	{
		[Preserve]
		public PurchaseResultInfo(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		public virtual int ReturnCode => Call<int>("getReturnCode");

		public virtual string ErrMsg => CallAsString("getErrMsg");

		public virtual string InAppPurchaseData => CallAsString("getInAppPurchaseData");

		public virtual string InAppDataSignature => CallAsString("getInAppDataSignature");
	}
}