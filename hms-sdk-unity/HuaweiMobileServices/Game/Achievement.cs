using HuaweiMobileServices.Utils;
using UnityEngine;
using UnityEngine.Scripting;

namespace HuaweiMobileServices.Game
{
	// Wrapper for com.huawei.hms.jos.games.achievement.Achievement
	public class Achievement : JavaObjectWrapper
	{
		public const int STATE_REACHED = 0;
		public const int STATE_VISUALIZED = 1;
		public const int STATE_UN_DISPLAY = 2;
		public const int TYPE_NORMAL = 0;
		public const int TYPE_GROW_ABLE = 1;

		[Preserve]
		public Achievement(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		public virtual string Id => CallAsString("getId");

		public virtual int Type => Call<int>("getType");

		public virtual string DisplayName => CallAsString("getId");

		public virtual string DescInfo => CallAsString("getDescInfo");

		public virtual string ReachedThumbnailUri => CallAsUriString("getReachedThumbnailUri");

		public virtual string VisualizedThumbnailUri => CallAsUriString("getVisualizedThumbnailUri");

		public virtual int AllSteps => Call<int>("getAllSteps");

		public virtual string LocaleAllSteps => CallAsString("getLocaleAllSteps");

		public virtual Player GamePlayer => CallAsWrapper<Player>("getGamePlayer");

		public virtual int State => Call<int>("getState");

		public virtual int ReachedSteps => Call<int>("getReachedSteps");

		public virtual string LocaleReachedSteps => CallAsString("getLocaleReachedSteps");

		public virtual long RecentUpdateTime => Call<long>("getRecentUpdateTime");
	}
}