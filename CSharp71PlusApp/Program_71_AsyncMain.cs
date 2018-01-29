using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CSharp71PlusApp
{
	public class Program
	{
		// C# 7.1 - Async Main
		public static async Task<int> Main(string[] args)
		{
			// C# 7.1 - Async Main - https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7-1#async-main
			var havitWebContent = await DoSomethingAsync();
			Console.WriteLine(havitWebContent.Substring(0, 100));

			return await GetReturnCodeAsync();
		}

		private static Task<string> DoSomethingAsync()
		{
			WebClient client = new WebClient();
			return client.DownloadStringTaskAsync("https://www.havit.cz");
		}

		private static Task<int> GetReturnCodeAsync()
		{
			return Task.Run(() => 2);
		}
	}
}
