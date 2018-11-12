using System;

namespace CSharp71PlusApp
{
	// C# 7.3: Expression variables in initializers (contructors, properties, query clauses)
	// https://github.com/dotnet/csharplang/blob/master/proposals/csharp-7.3/expression-variables-in-initializers.md
	public class ExpressionVariablesInInitializers
	{
		public class Foo
		{
			public Foo(int i, out int j)
			{
				j = i;
			}
		}

		public class Derived : Foo
		{
			public Derived(int i) : base(i, out var j)  // <----------------
			{
				Console.WriteLine($"The value of 'j' is {j}");
			}
		}
	}
}