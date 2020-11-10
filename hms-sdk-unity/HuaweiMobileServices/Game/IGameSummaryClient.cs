using HuaweiMobileServices.Base;

namespace HuaweiMobileServices.Game
{
	// Wrapper for com.huawei.hms.jos.games.GameSummaryClient
	public interface IGameSummaryClient
	{
		ITask<GameSummary> LocalGameSummary { get; }

		ITask<GameSummary> GameSummary { get; }
	}
}