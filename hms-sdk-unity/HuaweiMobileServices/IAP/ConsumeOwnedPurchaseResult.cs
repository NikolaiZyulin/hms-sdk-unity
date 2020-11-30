using HuaweiMobileServices.Utils;
using UnityEngine;
using UnityEngine.Scripting;

namespace HuaweiMobileServices.IAP
{
	// Wrapper for com.huawei.hms.iap.entity.ConsumeOwnedPurchaseResult
	public class ConsumeOwnedPurchaseResult : JavaObjectWrapper
	{
		[Preserve]
		public ConsumeOwnedPurchaseResult(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		public virtual string ConsumePurchaseData => CallAsString("getConsumePurchaseData");
		public virtual string DataSignature => CallAsString("getDataSignature");
		public virtual int ReturnCode => Call<int>("getReturnCode");
		public virtual string ErrMsg => CallAsString("getErrMsg");
	}
}