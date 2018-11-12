using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp71PlusApp
{
	// C# 7.3: Support for == and != on tuple types
	// https://github.com/dotnet/csharplang/blob/master/proposals/csharp-7.3/tuple-equality.md
	public class TupleEquality
    {
		public void Test()
		{
			var myTuple = (5, "test");

			if (myTuple == (2, "ddd"))  // <------------------- pre C# 7.3: ((myTuple.Item1 == 2) && (myTuple.Item2 == "ddd"))
			{
				Console.WriteLine("equal");
			}

			int count = 3;
			string x = "ddd";
			if ((count, x) != (2, "bla"))   // <-------------------
			{
				Console.WriteLine("not equal");
			}
		}
	}
}
