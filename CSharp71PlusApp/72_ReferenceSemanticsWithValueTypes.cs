using System;
using System.Collections.Generic;

namespace CSharp71PlusApp
{
	// C# 7.2 - Reference semantics with value types (https://docs.microsoft.com/en-us/dotnet/csharp/reference-semantics-with-value-types)
	public class ReferenceSemanticsWithValueTypes
	{
		public void Demo()
		{
			var pointA = new Point3D { X = 10, Y = 12, Z = 13 };
			var pointB = new Point3D { X = 17, Y = 20, Z = -1 };

			// (1) in-parameters (passed by reference, not allowed to modify)
			var distance1 = CalculateDistance(in pointA, in pointB);
			var distance2 = CalculateDistance(pointA, pointB); // in-modifier can be omitted
			var distance3 = CalculateDistance(new Point3D()); // temporary variable created and passed (+ allows passing constants)

			// (2) - ref readonly returns (return a value type by reference, but disallow the caller from modifying that value)
			ref readonly var originReference = ref Point3D.Origin;
		}

		// (1) in-parameters (passed by reference, not allowed to modify)
		private static double CalculateDistance(in Point3D point1, in Point3D point2 = default) // allows default values - [0,0,0] in this case
		{
			double xDifference = point1.X - point2.X;
			double yDifference = point1.Y - point2.Y;
			double zDifference = point1.Z - point2.Z;

			// point1.Z = 10; - does not compile

			return Math.Sqrt(xDifference * xDifference + yDifference * yDifference + zDifference * zDifference);
		}

		private struct Point3D
		{
			private static Point3D origin = new Point3D() { X = 0, Y = 0, Z = 0 };

			public double X { get; set; }
			public double Y { get; set; }
			public double Z { get; set; }

			// (2) - ref readonly returns (return a value type by reference, but disallow the caller from modifying that value)
			public static ref readonly Point3D Origin => ref origin;
		}

		// (3) - readonly struct type (immutable) - avoids unnecessary copies in many different scenarios (in-parameters, ...)
		private readonly struct ReadonlyPoint3D
		{
			public ReadonlyPoint3D(double x, double y, double z)
			{
				this.X = x;
				this.Y = y;
				this.Z = z;
			}

			public double X { get; }
			public double Y { get; }
			public double Z { get; }

			private static ReadonlyPoint3D origin = new ReadonlyPoint3D(); // [0,0,0]
			public static ref readonly ReadonlyPoint3D Origin => ref origin;
		}

		// (4) - ref struct type (stack only, cannot be allocated on heap) - to support Span<T> and simmilar scenarios
		private ref struct StackOnlyPoint3D
		{
			public double X { get; set; }
			public double Y { get; set; }
			public double Z { get; set; }
		}

		private class Polygon
		{
			// (4)
			//public List<StackOnlyPoint3D> Points = new List<StackOnlyPoint3D>(); - does not compile

			public List<ReadonlyPoint3D> Points = new List<ReadonlyPoint3D>();
		}
	}
}
