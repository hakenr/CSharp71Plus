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


			// C# 7.3
			if (pair71 == (5, "test")) { }
			if ((count, label) == (5, "test")) { }
			if ((pair71.count == 5) && (pair71.label == "test")) { } // C# 7.1
		}
	}
}
