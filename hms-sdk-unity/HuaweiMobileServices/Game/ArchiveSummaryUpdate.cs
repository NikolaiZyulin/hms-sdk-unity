using System;
using HuaweiMobileServices.Utils;
using UnityEngine;
using UnityEngine.Scripting;

namespace HuaweiMobileServices.Game
{
	// Wrapper for com.huawei.hms.jos.games.archive.ArchiveSummaryUpdate
	public class ArchiveSummaryUpdate : JavaObjectWrapper
	{
		[Preserve]
		public ArchiveSummaryUpdate(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		public string DescInfo => Call<string>("getDescInfo");

		public long? ActiveTime => Call<long>("getActiveTime");

		public long? CurrentProgress => Call<long>("getCurrentProgress");

		public AndroidBitmap Thumbnail => Call<AndroidBitmap>("getThumbnail");

		public string ThumbnailMimeType => Call<string>("getThumbnailMimeType");

		// Wrapper for  com.huawei.hms.jos.games.archive.ArchiveSummaryUpdate.Builder
		public class Builder : JavaObjectWrapper
		{
			[Preserve]
			public Builder(AndroidJavaObject javaObject) : base(javaObject)
			{
			}

			public Builder() : base("com.huawei.hms.jos.games.archive.ArchiveSummaryUpdate$Builder")
			{
			}

			public ArchiveSummaryUpdate Build() => CallAsWrapper<ArchiveSummaryUpdate>("build");

			public Builder FromSummary(ArchiveSummary summary)
			{
				JavaObject = Call<AndroidJavaObject>("fromSummary", summary);
				return this;
			}

			public Builder SetActiveTime(long setActiveTime)
			{
				JavaObject = Call<AndroidJavaObject>("setActiveTime", setActiveTime);
				return this;
			}

			public Builder SetCurrentProgress(long progressValue)
			{
				JavaObject = Call<AndroidJavaObject>("setCurrentProgress", progressValue);
				return this;
			}

			public Builder SetDescInfo(String description)
			{
				JavaObject = Call<AndroidJavaObject>("setDescInfo", description);
				return this;
			}

			public Builder SetThumbnail(AndroidBitmap bitmap)
			{
				JavaObject = Call<AndroidJavaObject>("setThumbnail", bitmap);
				return this;
			}

			public Builder SetThumbnailMimeType(String imageMimeType)
			{
				JavaObject = Call<AndroidJavaObject>("setThumbnailMimeType", imageMimeType);
				return this;
			}
		}
	}
}