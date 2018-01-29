using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp71PlusApp;

namespace PrivateProtectedOtherAssembly
{
    public class DerivedClassInOtherAssembly : PrivateProtectedDemo
    {
		public void Foo()
		{
			// var x = someService;			// .. is inaccesible due to its protection level

			// DoSomething();				// .. is inaccesible due to its protection level
		}

		// private protected override void DoSomething()	// No suitable methods found to override
	}
}
