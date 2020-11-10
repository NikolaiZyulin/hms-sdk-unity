using HuaweiMobileServices.Utils;
using UnityEngine;
using UnityEngine.Scripting;

namespace HuaweiMobileServices.Game
{
	// Wrapper for com.huawei.hms.jos.games.archive.ArchiveDetails
	public class ArchiveDetails : JavaObjectWrapper
	{
		[Preserve]
		public ArchiveDetails(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		public byte[] Get => Call<byte[]>("get");

		public void Set(byte[] paramArrayOfByte) => Call("set", paramArrayOfByte);

		public bool Update(int paramInt1, byte[] paramArrayOfByte, int paramInt2, int paramInt3)
			=> Call<bool>("update", paramArrayOfByte, paramInt2, paramInt3);

		// Wrapper for  com.huawei.hms.jos.games.archive.ArchiveDetails.Builder
		public class Builder : JavaObjectWrapper
		{
			[Preserve]
			public Builder(AndroidJavaObject javaObject) : base(javaObject)
			{
			}

			public Builder() : base("com.huawei.hms.jos.games.archive.ArchiveDetails$Builder")
			{
			}

			public ArchiveDetails Build() => CallAsWrapper<ArchiveDetails>("build");
		}
	}
}