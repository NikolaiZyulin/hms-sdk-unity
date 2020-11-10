﻿using HuaweiMobileServices.Utils;
using UnityEngine;
using UnityEngine.Scripting;

namespace HuaweiMobileServices.Game
{
	// Wrapper for com.huawei.hms.jos.games.ranking.RankingScore
	public class RankingScore : JavaObjectWrapper
	{
		public const int RANK_UNKNOWN = -1;

		[Preserve]
		public RankingScore(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		public virtual string DisplayRank => CallAsString("getDisplayRank");

		public virtual int TimeDimension => Call<int>("getTimeDimension");

		public virtual string RankingDisplayScore => CallAsString("getRankingDisplayScore");

		public virtual long PlayerRank => Call<long>("getPlayerRank");

		public virtual long PlayerRawScore => Call<long>("getPlayerRawScore");

		public virtual Player ScoreOwnerPlayer => CallAsWrapper<Player>("getScoreOwnerPlayer");

		public virtual string ScoreOwnerDisplayName => CallAsString("getScoreOwnerDisplayName");

		public virtual string ScoreOwnerHiIconUri => CallAsUriString("getScoreOwnerHiIconUri");

		public virtual string ScoreOwnerIconUri => CallAsUriString("getScoreOwnerIconUri");

		public virtual string ScoreTips => CallAsString("getScoreTips");

		public virtual long ScoreTimestamp => Call<long>("getScoreTimestamp");
	}
}