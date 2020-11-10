using System.Collections.Generic;
using HuaweiMobileServices.Utils;
using UnityEngine;
using UnityEngine.Scripting;

namespace HuaweiMobileServices.Game
{
	// Wrapper for com.huawei.hms.jos.games.ranking.Ranking
	public class Ranking : JavaObjectWrapper
	{
		[Preserve]
		private static readonly AndroidJavaClass RankingClass = new AndroidJavaClass("com.huawei.hms.jos.games.ranking.Ranking");

		public const int SCORE_VALUE_HIGH_BETTER = 1;
		public const int SCORE_VALUE_SMALL_BETTER = 0;

		public Ranking(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		public virtual string RankingDisplayName => CallAsString("getRankingDisplayName");

		public virtual string RankingImageUri => CallAsUriString("getRankingImageUri");

		public virtual string RankingId => CallAsString("getRankingId");

		public virtual int RankingScoreOrder => Call<int>("getRankingScoreOrder");

		public virtual IList<RankingVariant> RankingVariants =>
			Call<AndroidJavaObject>("getRankingVariants").AsListFromWrappable<RankingVariant>();
	}
}