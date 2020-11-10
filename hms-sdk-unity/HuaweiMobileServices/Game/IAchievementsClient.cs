using System;
using System.Collections.Generic;
using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using Task = System.Threading.Tasks.Task;
using Void = HuaweiMobileServices.Utils.Void;

namespace HuaweiMobileServices.Game
{
	// Wrapper for com.huawei.hms.jos.games.AchievementsClient
	public interface IAchievementsClient
	{
		void ShowAchievementList(Action onSuccess, Action<HMSException> onFailure);

		Task ShowAchievementListAsync();

		void Grow(string paramString, int paramInt);

		ITask<bool> GrowWithResult(string paramString, int paramInt);

		ITask<IList<Achievement>> GetAchievementList(bool paramBoolean);

		void Visualize(string paramString);

		ITask<Void> VisualizeWithResult(string paramString);

		void MakeSteps(string paramString, int paramInt);

		ITask<bool> MakeStepsWithResult(string paramString, int paramInt);

		void Reach(string paramString);

		ITask<Void> ReachWithResult(string paramString);
	}
}