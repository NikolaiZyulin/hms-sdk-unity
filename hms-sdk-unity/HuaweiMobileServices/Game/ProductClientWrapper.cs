using System.Collections.Generic;
using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using UnityEngine;
using UnityEngine.Scripting;

namespace HuaweiMobileServices.Game
{
	// Wrapper for com.huawei.hms.jos.product.ProductClientImpl
	public class ProductClientWrapper : JavaObjectWrapper, IProductClient
	{
		[Preserve]
		public ProductClientWrapper(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		public virtual ITask<IList<ProductOrderInfo>> GetMissProductOrder()
		{
			var javaResult = Call<AndroidJavaObject>("getMissProductOrder", AndroidContext.ActivityContext);
			return new TaskWrapper<IList<ProductOrderInfo>>(javaResult, AndroidJavaObjectExtensions.AsListFromWrappable<ProductOrderInfo>);
		}
	}
}