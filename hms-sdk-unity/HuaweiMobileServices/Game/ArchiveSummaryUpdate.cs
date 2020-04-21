﻿using System;

namespace HuaweiMobileServices.Game
{
    using UnityEngine;
    using HuaweiMobileServices.Utils;

    // Wrapper for com.huawei.hms.jos.games.archive.ArchiveSummaryUpdate
    public class ArchiveSummaryUpdate : JavaObjectWrapper
    {
        public ArchiveSummaryUpdate(AndroidJavaObject javaObject) : base(javaObject) { }

        public string DescInfo => throw new NotImplementedException();

        public long? ActiveTime => throw new NotImplementedException();

        public long? CurrentProgress => throw new NotImplementedException();

        public AndroidBitmap Thumbnail => throw new NotImplementedException();

        public string ThumbnailMimeType => throw new NotImplementedException();
    }

}