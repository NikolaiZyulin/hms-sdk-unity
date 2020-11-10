using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using UnityEngine;
using UnityEngine.Scripting;

namespace HuaweiMobileServices.Game
{
	internal class GamesClientWrapper : JavaObjectWrapper, IGamesClient
	{
		[Preserve]
		public GamesClientWrapper(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		public ITask<string> AppId => CallAsWrapper<TaskStringWrapper>("getAppId");

		public ITask<Void> SetPopupsPosition(int paramInt) => CallAsWrapper<TaskVoidWrapper>("setPopupsPosition", paramInt);
	}
}