using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp71PlusApp
{
	// C# 7.3: Stackalloc array initializers
	// https://github.com/dotnet/csharplang/blob/master/proposals/csharp-7.3/stackalloc-array-initializers.md
	public class StackallocArrayInitializers
    {
        unsafe public void Test()
		{
			// pre C# 7.3
			var a = stackalloc int[3];
			a[0] = 1;
			a[1] = 2;
			a[2] = 3;

			// C# 7.3
			var x = stackalloc int[] { 1, 2, 3 };
		}
    }
}
