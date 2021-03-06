﻿using UnityEngine;

namespace HuaweiMobileServices.Base
{
	using Utils;

	public class Task : JavaObjectWrapper
	{
		public Task(AndroidJavaObject javaObject) : base(javaObject)
		{
		}

		public Task() : base("com.huawei.hmf.tasks.Task")
		{
		}

		public void PutByte(string arg0, byte arg1)
		{
			Call("putByte", arg0, arg1);
		}

		public void PutShort(string arg0, short arg1)
		{
			Call("putShort", arg0, arg1);
		}

		public void PutChar(string arg0, char arg1)
		{
			Call("putChar", arg0, arg1);
		}

		public void PutFloat(string arg0, float arg1)
		{
			Call("putFloat", arg0, arg1);
		}

		public void PutBoolean(string arg0, bool arg1)
		{
			Call("putBoolean", arg0, arg1);
		}

		public void PutInt(string arg0, int arg1)
		{
			Call("putInt", arg0, arg1);
		}

		public void PutLong(string arg0, long arg1)
		{
			Call("putLong", arg0, arg1);
		}

		public void PutDouble(string arg0, double arg1)
		{
			Call("putDouble", arg0, arg1);
		}

		public void PutString(string arg0, string arg1)
		{
			Call("putString", arg0, arg1);
		}
	}
}