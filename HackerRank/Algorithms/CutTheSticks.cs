using System;
using System.Linq;

namespace HackerRank
{
	public class CutTheSticks
	{
		public static string Run()
		{
			/* 
			sample input:
			6
			5 4 4 2 2 8
			
			sample output:
			6
			4
			2
			1
			*/
			string output = "";

			int stickCount = Int32.Parse(Console.ReadLine());
			if (stickCount < 0 || stickCount > 1000)
				return "Number of sticks must be between 1 and 1000";
			
			var parts = Console.ReadLine().Trim().Split(' ');
			if (stickCount != parts.Length)
				return "Invalid number of sticks";

			int cutCount;
			int cutAmount;
			// int[] sticks = new int[parts.Length];
			var sticks = Array.ConvertAll(parts, Int32.Parse);

			for (var x = 0; x < stickCount; x++) 
			{
				if (sticks.Length > 0)
				{
					cutCount = 0;
					cutAmount = sticks.Min();
					// output += "Iteration " + x + " cutAmount: " + cutAmount + "\n";

					for (var y = 0; y < sticks.Length; y++)
					{
						if (sticks[y] > 0)
						{
							cutCount++;
							sticks[y] = sticks[y] - cutAmount;
						}
						// output += "stick x " + y + " val: " + sticks[y] + "\n";
					}

					// output += " - Cut count: " + cutCount + " \n";
					output += cutCount + "\n";

					sticks = sticks.Where(s => s > 0).ToArray(); // remove all 0 length sticks
				}
			}

			return output;
		}
	}
}

