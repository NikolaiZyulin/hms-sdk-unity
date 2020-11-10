using HuaweiMobileServices.Base;

namespace HuaweiMobileServices.Game
{
	public interface IJosAppsClient
	{
		void Init();

		ITask<string> AppId { get; }
	}
}