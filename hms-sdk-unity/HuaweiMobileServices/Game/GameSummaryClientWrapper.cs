using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using UnityEngine;
using UnityEngine.Scripting;

namespace HuaweiMobileServices.Game
{
	internal class GameSummaryClientWrapper : JavaObjectWrapper, IGameSummaryClient
	{
		[Preserve]
		public GameSummaryClientWrapper(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		public ITask<GameSummary> LocalGameSummary => CallAsWrapper<TaskJavaObjectWrapper<GameSummary>>("getLocalGameSummary");

		public ITask<GameSummary> GameSummary => CallAsWrapper<TaskJavaObjectWrapper<GameSummary>>("getGameSummary");
	}
}