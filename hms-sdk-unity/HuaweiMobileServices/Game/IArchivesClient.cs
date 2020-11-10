using System;
using System.Collections.Generic;
using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;

namespace HuaweiMobileServices.Game
{
	// Wrapper for com.huawei.hms.jos.games.ArchivesClient
	public interface IArchivesClient
	{
		ITask<ArchiveSummary> AddArchive(ArchiveDetails paramArchiveDetails, ArchiveSummaryUpdate paramArchiveSummaryUpdate, bool paramBoolean);

		ITask<string> RemoveArchive(ArchiveSummary paramArchiveSummary);

		ITask<OperationResult> UpdateArchive(string paramString, ArchiveSummaryUpdate paramArchiveSummaryUpdate, ArchiveDetails paramArchiveDetails);

		ITask<OperationResult> UpdateArchive(Archive paramArchive);

		ITask<OperationResult> LoadArchiveDetails(ArchiveSummary paramArchiveSummary);

		ITask<OperationResult> LoadArchiveDetails(ArchiveSummary paramArchiveSummary, int paramInt);

		ITask<OperationResult> LoadArchiveDetails(string paramString, int paramInt);

		ITask<OperationResult> LoadArchiveDetails(string paramString);

		ITask<ArchiveSummary> ParseSummary(AndroidBundle paramBundle);

		ITask<int> LimitThumbnailSize { get; }

		ITask<int> LimitDetailsSize { get; }

		ITask<AndroidIntent> ShowArchiveListIntent(String title, Boolean allowAddBtn, Boolean allowDeleteBtn, int maxArchiv);

		ITask<IList<ArchiveSummary>> GetArchiveSummaryList(bool paramBoolean);

		ITask<AndroidBitmap> GetThumbnail(string paramString);
	}
}