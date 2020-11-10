using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using UnityEngine;
using UnityEngine.Scripting;

namespace HuaweiMobileServices.Game
{
	// Wrapper for com.huawei.hms.jos.games.ranking.ScoreSubmissionInfo
	public sealed class ScoreSubmissionInfo : JavaObjectWrapper
	{
		[Preserve]
		public ScoreSubmissionInfo(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		public string RankingId => CallAsString("getRankingId");

		public string PlayerId => CallAsString("getPlayerId");

		public Result GetSubmissionScoreResult(int paramInt) => CallAsWrapper<Result>("getSubmissionScoreResult", paramInt);
	}
}