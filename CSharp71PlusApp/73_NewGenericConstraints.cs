namespace CSharp71PlusApp
{

	public class NewGenericConstraints
	{
		// https://github.com/dotnet/csharplang/issues/104
		public void DoSomething<T>(T value)
			where T : System.Enum
		{
			// ...
		}

		// https://github.com/dotnet/csharplang/issues/103
		public void DoSomething2<T>(T value)
			where T : System.Delegate
		{
			// ...
		}

		// https://github.com/dotnet/csharplang/blob/master/proposals/csharp-7.3/blittable.md
		public void DoSomething3<T>(T value)
			where T : unmanaged
		{
			// ...
		}

	}
}
