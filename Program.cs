using System;

namespace Solutions
{
	class Program
	{
		static void Main(string[] args)
		{

			Solution1 sol1 = new Solution1();
			sol1.StartProccessing();


			Solution2 sol2 = new Solution2();
			var input = Console.ReadLine();
			var testInput = "oznbg"; //example
			var matches = sol2.SearchForString(testInput);

			Console.WriteLine($"Test Input: {testInput}");
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
