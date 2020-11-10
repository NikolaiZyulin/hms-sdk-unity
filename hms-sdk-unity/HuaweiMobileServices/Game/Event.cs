using HuaweiMobileServices.Utils;
using UnityEngine;
using UnityEngine.Scripting;

namespace HuaweiMobileServices.Game
{
	// Wrapper for com.huawei.hms.jos.games.event.Event
	public class Event : JavaObjectWrapper
	{
		[Preserve]
		public Event(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		public virtual string Description => CallAsString("getDescription");

		public virtual string EventId => CallAsString("getEventId");

		public virtual string ThumbnailUri => CallAsUriString("getThumbnailUri");

		public virtual string Name => CallAsString("getName");

		public virtual Player GamePlayer => Call<AndroidJavaObject>("getGamePlayer").AsWrapper<Player>();

		public virtual long Value => Call<long>("getValue");

		public virtual string LocaleValue => CallAsString("getLocaleValue");

		public virtual bool Visible => Call<bool>("isVisible");
	}
}