using HuaweiMobileServices.Id;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Game
{
	// Wrapper for com.huawei.hms.jos.games.Games
	public static class Games
	{
		private static readonly AndroidJavaClass GamesClass = new AndroidJavaClass("com.huawei.hms.jos.games.Games");

		public static IEventsClient GetEventsClient(AuthHuaweiId authHuaweiId) =>
			GamesClass.CallStaticAsWrapper<EventsClientWrapper>("getEventsClient", AndroidContext.ActivityContext, authHuaweiId.JavaObject);

		public static IPlayersClient GetPlayersClient(AuthHuaweiId authHuaweiId) =>
			GamesClass.CallStaticAsWrapper<PlayersClientWrapper>("getPlayersClient", AndroidContext.ActivityContext, authHuaweiId.JavaObject);

		public static IAchievementsClient GetAchievementsClient(AuthHuaweiId authHuaweiId) =>
			GamesClass.CallStaticAsWrapper<AchievementClientWrapper>("getAchievementsClient", AndroidContext.ActivityContext, authHuaweiId.JavaObject);

		public static IGamesClient GetGamesClient(AuthHuaweiId authHuaweiId) =>
			GamesClass.CallStaticAsWrapper<GamesClientWrapper>("getGamesClient", AndroidContext.ActivityContext, authHuaweiId.JavaObject);

		public static IRankingsClient GetRankingsClient(AuthHuaweiId authHuaweiId) =>
			GamesClass.CallStaticAsWrapper<RankingsClientWrapper>("getRankingsClient", AndroidContext.ActivityContext, authHuaweiId);

		public static IGameSummaryClient GetGameSummaryClient(AuthHuaweiId paramAuthHuaweiId) =>
			GamesClass.CallStaticAsWrapper<GameSummaryClientWrapper>("getGameSummaryClient", AndroidContext.ActivityContext, paramAuthHuaweiId);

		public static IGamePlayerStatisticsClient GetGamePlayerStatsClient(AuthHuaweiId paramAuthHuaweiId) =>
			GamesClass.CallStaticAsWrapper<GamePlayerStatisticsClientWrapper>("getGamePlayerStatsClient", AndroidContext.ActivityContext, paramAuthHuaweiId);

		public static IArchivesClient GetArchiveClient(AuthHuaweiId paramAuthHuaweiId) =>
			GamesClass.CallStaticAsWrapper<ArchivesClientWrapper>("getArchiveClient", AndroidContext.ActivityContext, paramAuthHuaweiId);

		public static IBuoyClient GetBuoyClient() =>
			GamesClass.CallStaticAsWrapper<BuoyClientWrapper>("getBuoyClient", AndroidContext.ActivityContext);
	}
}