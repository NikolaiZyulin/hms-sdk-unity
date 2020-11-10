using System.Collections.Generic;
using HuaweiMobileServices.Utils;
using UnityEngine;
using UnityEngine.Scripting;

namespace HuaweiMobileServices.Game
{
	// Wrapper for com.huawei.hms.jos.games.RankingsClient.RankingScores
	public class RankingScores : JavaObjectWrapper
	{
		[Preserve]
		public RankingScores(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		public Ranking Ranking => CallAsWrapper<Ranking>("getRanking");

		public IList<RankingScore> RankingScore => CallAsWrapperList<RankingScore>("getRankingScore");
	}
}