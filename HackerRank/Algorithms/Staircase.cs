using System;
namespace HackerRank
{
	public class Staircase
	{
		public static void Run()
		{
			/* 
			sample input:
			6
			
			sample output:
			     #
			    ##
			   ###
			  ####
			 #####
			######
			*/
			int size = int.Parse(Console.ReadLine());
			string line;

			for (var x = 1; x < size + 1; x++)
			{
				// pad to the left minus the number of pound signs we are going to write
				line = "".PadLeft(size - x, ' ');

				for (var stair = 0; stair < x; stair++)
				{
					line += "#";
				}

				Console.WriteLine(line);
			}
		}
	}
}

