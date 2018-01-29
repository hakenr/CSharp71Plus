using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp71PlusApp
{
	// https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7-1#default-literal-expressions
	public class DefaultLiteralExpressions
	{
		public void Demo()
		{
			// C# 7
			int int7 = default(int);
			Dictionary<int, string> dictionary7 = default(Dictionary<int, string>);
			Func<int, string, bool, string> func7 = default(Func<int, string, bool, string>);
			if (func7 == default(Func<int, string, bool, string>))
			{
			}

			// C# 7.1
			int int71 = default;
			Dictionary<int, string> dictionary71 = default;
			Func<int, string, bool, string> func71 = default;
			if (func71 == default)
			{
			}
		}
	}
}
