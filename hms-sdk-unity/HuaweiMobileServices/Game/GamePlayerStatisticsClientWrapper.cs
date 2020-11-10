using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using UnityEngine;
using UnityEngine.Scripting;

namespace HuaweiMobileServices.Game
{
	internal class GamePlayerStatisticsClientWrapper : JavaObjectWrapper, IGamePlayerStatisticsClient
	{
		[Preserve]
		public GamePlayerStatisticsClientWrapper(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		public ITask<GamePlayerStatistics> GetGamePlayerStatistics(bool paramBoolean) =>
			CallAsWrapper<TaskJavaObjectWrapper<GamePlayerStatistics>>("getGamePlayerStatistics", paramBoolean);
	}
}