using HuaweiMobileServices.Base;
using UnityEngine;
using UnityEngine.Scripting;

namespace HuaweiMobileServices.IAP
{
	public class PurchaseIntentResult : Result
	{
		[Preserve]
		public PurchaseIntentResult(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		public virtual int ReturnCode => Call<int>("getReturnCode");

		public virtual string ErrMsg => CallAsString("getErrMsg");

		public virtual string PaymentData => CallAsString("getPaymentData");

		public virtual string PaymentSignature => CallAsString("getPaymentSignature");
	}
}