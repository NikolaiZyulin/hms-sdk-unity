using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;

namespace HuaweiMobileServices.Game
{
	// Wrapper for com.huawei.hms.jos.games.PlayersClient
	public interface IPlayersClient
	{
		ITask<Player> CurrentPlayer { get; }

		ITask<string> CachePlayerId { get; }

		ITask<Void> SavePlayerInfo(AppPlayerInfo paramAppPlayerInfo);

		ITask<PlayerExtraInfo> GetPlayerExtraInfo(string paramString);

		ITask<string> SubmitPlayerEvent(string paramString1, string paramString2, string paramString3);
	}
}