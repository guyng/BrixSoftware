using System;
using System.Threading.Tasks;

namespace Solutions
{
	class Program
	{
		static async Task Main(string[] args)
		{
			Console.WriteLine("Choose solution: (1 or 2)");
			var input = Console.ReadLine();
			if (input == "1")
			{
				await Solution1();
			}
			else if (input == "2")
			{
				Solution2();
			}
		}

		public static async Task Solution1()
		{
			Solution1 sol1 = new Solution1();
			await sol1.StartProccessing();
		}

		public static void Solution2()
		{
			Console.WriteLine("Please wait...");
			Solution2 sol2 = new Solution2();
			Console.WriteLine("Please input 5 letter string");
			var input = Console.ReadLine();
	//		var testInput = "oznbg"; //example
			var matches = sol2.SearchForString(input);

			Console.WriteLine($"Input: {input}");
			Console.WriteLine($"Matches Count: {matches.Count}");
			if (matches.Count > 0)
			{
				Console.WriteLine($"Matches:");
				foreach (var match in matches)
				{
					Console.WriteLine(match);
				}
			}
		}
	}
}
