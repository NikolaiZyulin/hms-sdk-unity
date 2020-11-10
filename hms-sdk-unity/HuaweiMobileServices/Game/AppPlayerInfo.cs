using HuaweiMobileServices.Utils;
using UnityEngine;
using UnityEngine.Scripting;

namespace HuaweiMobileServices.Game
{
	// Wrapper for com.huawei.hms.jos.games.AppPlayerInfo
	public class AppPlayerInfo : JavaObjectWrapper
	{
		[Preserve]
		public AppPlayerInfo(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		public virtual string Rank => CallAsString("getRank");

		public virtual string Role => CallAsString("getRole");

		public virtual string Area => CallAsString("getArea");

		public virtual string Sociaty => CallAsString("getSociaty");

		public virtual string PlayerId => CallAsString("getPlayerId");
	}
}