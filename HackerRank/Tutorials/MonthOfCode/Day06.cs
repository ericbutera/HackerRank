using System;
namespace HackerRank
{
	public class Day06
	{
		public static string Run()
		{
			var testcases = Int32.Parse(Console.ReadLine());

			string output = "";
			string current;

			string even, odd;

			for (var x = 0; x <= testcases; x++)
			{
				current = Console.ReadLine();
				even = "";
				odd = "";
				for (var y = 0; y < current.Length; y++)
				{
					if (y % 2 == 0)
					{
						even += current[y];
					}
					else 
					{
						odd += current[y];
					}
				}
				Console.WriteLine(even + " " + odd);
			}
			return "";
		}
	}
}

