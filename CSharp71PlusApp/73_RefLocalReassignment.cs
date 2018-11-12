using System;

namespace CSharp71PlusApp
{
	// C# 7.3:
	// https://github.com/dotnet/csharplang/blob/master/proposals/csharp-7.3/ref-local-reassignment.md
	public class RefLocalReassignment
	{
		public void Test()
		{
			var x = DateTime.Now;
			var y = DateTime.Today;

			ref DateTime refLocal = ref x;

			refLocal = ref y; // <------------ reassigned, refLocal refers to different storage.
		}
	} 
}