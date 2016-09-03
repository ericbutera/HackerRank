using System;
namespace HackerRank
{
	public class Day05
	{
		public Day05()
		{
		}

		public static string Run()
		{
			var n = Int32.Parse(Console.ReadLine());
			string output = "";
			int current;

			for (var x = 1; x <= 10; x++)
			{
				current = n * x;
				output += String.Format("{0} x {1} = {2}\r\n", n, x, current);
			}

			return output;
		}
	}
}

