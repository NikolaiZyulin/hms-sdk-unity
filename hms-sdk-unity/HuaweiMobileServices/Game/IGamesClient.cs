﻿using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;

namespace HuaweiMobileServices.Game
{
	// Wrapper for com.huawei.hms.jos.games.GamesClient
	public interface IGamesClient
	{
		ITask<string> AppId { get; }

		ITask<Void> SetPopupsPosition(int paramInt);
	}
}