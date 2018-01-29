﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp71PlusApp
{
	// C# 7.1 - Inferred tuple element names (https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7-1#inferred-tuple-element-names)
	public class InferredTupleElementNames
	{
		public void Demo()
		{
			int count = 5;
			string label = "Colors used in the map";

			// C# 7
			var pair7 = (count: count, label: label);

			// C# 7.1
			var pair71 = (count, label);

			// Tuple Items - camelCase vs. PascalCase ?!
		}
	}
}