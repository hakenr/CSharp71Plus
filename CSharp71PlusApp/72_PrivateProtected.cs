using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp71PlusApp
{
	// C# 7.2 - private protected access modifier (https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7-2#private-protected)
	public class PrivateProtectedDemo
	{
		private protected readonly ISomeService someService;

		private protected virtual void DoSomething()
		{
			// limits access to derived types declared in the same assembly
		}
	}

	// same assembly => accessible
	public class DerivedClass : PrivateProtectedDemo
	{
		private protected override void DoSomething()
		{
			var x = someService;

			base.DoSomething();
		}
	}

	public interface ISomeService
	{
	}
}
