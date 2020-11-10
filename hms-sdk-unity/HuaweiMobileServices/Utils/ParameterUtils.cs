namespace HuaweiMobileServices.Utils
{
	internal static class ParameterUtils
	{
		public static object[] AsAutoParams(this object[] args)
		{
			var newArgs = new object[args.Length];
			for (var i = 0; i < args.Length; i++)
			{
				newArgs[i] = AsAutoType(args[i]);
			}

			return newArgs;
		}

		public static object AsAutoType(this object arg)
		{
			if (arg is JavaObjectWrapper wrapper)
			{
				return wrapper.JavaObject;
			}

			if (arg is string s)
			{
				return s.AsJavaString();
			}

			return arg;
		}
	}
}