using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Caching;

namespace CSharp71PlusApp
{
	public class NontrailingNamedArguments
	{
		// C# 7.2 - Non-trailing named arguments (https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7-2#non-trailing-named-arguments)
		public void Demo()
		{
			var cache = HttpRuntime.Cache;

			// C# 7
			cache.Add(
				"key",
				"value",
				dependencies: null,
				absoluteExpiration: Cache.NoAbsoluteExpiration,
				slidingExpiration: Cache.NoSlidingExpiration,
				priority: CacheItemPriority.Default,
				onRemoveCallback: null);


			// C# 7.2
			cache.Add(
				"key",
				"value",
				dependencies: null,									// named arguments can preceed posiotional argument !!!
				Cache.NoAbsoluteExpiration,							// positional argument
				Cache.NoSlidingExpiration,                          // positional argument
				CacheItemPriority.Default,							// positional argument
				onRemoveCallback: null);
		}
	}
}
