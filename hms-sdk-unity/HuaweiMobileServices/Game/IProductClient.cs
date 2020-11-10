using System.Collections.Generic;
using HuaweiMobileServices.Base;

namespace HuaweiMobileServices.Game
{
	// Wrapper for com.huawei.hms.jos.product.ProductClient
	public interface IProductClient
	{
		ITask<IList<ProductOrderInfo>> GetMissProductOrder();
	}
}