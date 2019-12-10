using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solutions
{
	public class Solution2
	{
		private const int ARR_SIZE = 1_000_000;
		private string[] randomStrings = new string[ARR_SIZE];
		private static string[] sortedRandomStrings = new string[ARR_SIZE];
		private static Dictionary<string, List<string>> sortedStringDictionary = new Dictionary<string, List<string>>();
		private static Random random = new Random((int)DateTime.Now.Ticks);

		public Solution2()
		{
			InitRandomStrings();
		}

		private void InitRandomStrings()
		{
			for (int index = 0; index < ARR_SIZE; index++)
			{
				var randomString = GenerateRandomString(5);
				var sortedRandomString = String.Concat(randomString.OrderBy(c => c));
				if (sortedStringDictionary.ContainsKey(sortedRandomString))
				{
					var matchStrings = sortedStringDictionary[sortedRandomString];
					if (!matchStrings.Contains(randomString))
					{
						matchStrings.Add(randomString);
					}
				}
				else
				{
					sortedStringDictionary.Add(sortedRandomString,new List<string>() {randomString});
				}
			}
		}

		private static string GenerateRandomString(int length)
		{
			const string pool = "abcdefghijklmnopqrstuvwxyz";
			var chars = Enumerable.Range(0, length)
				.Select(x => pool[random.Next(0, pool.Length)]);
			return new string(chars.ToArray());
		}

		public List<string> SearchForString(string input)
		{
			var sortedInput = String.Concat(input.OrderBy(c => c));
			var stringMatches = sortedStringDictionary[sortedInput];
			return stringMatches;
		}

	}
}
