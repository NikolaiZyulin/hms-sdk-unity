using HuaweiMobileServices.Utils;
using UnityEngine;
using UnityEngine.Scripting;

namespace HuaweiMobileServices.Game
{
	// Wrapper for com.huawei.hms.jos.games.player.PlayerExtraInfo
	public class PlayerExtraInfo : JavaObjectWrapper
	{
		[Preserve]
		public PlayerExtraInfo(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		public PlayerExtraInfo(string json) : base("com.huawei.hms.jos.games.player.PlayerExtraInfo", json.AsJavaString())
		{
		}

		public virtual bool IsAdult => Call<bool>("getIsAdult");

		public virtual string PlayerId => CallAsString("getPlayerId");

		public virtual int PlayerDuration => Call<int>("getPlayerDuration");

		public virtual bool IsRealName => Call<bool>("getIsRealName");
	}
}