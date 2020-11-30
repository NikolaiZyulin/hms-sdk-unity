using System.Collections.Generic;
using HuaweiMobileServices.Utils;
using UnityEngine;
using UnityEngine.Scripting;

namespace HuaweiMobileServices.IAP
{
	// Wrapper for com.huawei.hms.iap.entity.ProductInfoResult
	public class ProductInfoResult : JavaObjectWrapper
	{
		[Preserve]
		public ProductInfoResult(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		public virtual int ReturnCode => Call<int>("getReturnCode");

		public virtual string ErrMsg => CallAsString("getErrMsg");

		public virtual IList<ProductInfo> ProductInfoList =>
			Call<AndroidJavaObject>("getProductInfoList").AsListFromWrappable<ProductInfo>();
	}
}