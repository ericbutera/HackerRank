using System;
namespace HackerRank
{
	public class PlusMinus
	{
		public static void Run()
		{
			/* 
			sample input:
			
			6
			-4 3 -9 0 4 1 
			*/
			double positive, negative, zero;
			int number;


			// these must be doubles as c# will round the numbers upon division otherwise and lose precision
			double positiveCount = 0, negativeCount = 0, zeroCount = 0; 
			double size = Convert.ToInt32(Console.ReadLine());

			string line = Console.ReadLine().Trim(); // sample had a trailing space causing failure
			int[] numbers = Array.ConvertAll(line.Split(' '), Int32.Parse);

			for (var x = 0; x < size; x++)
			{
				number = numbers[x];
				if (number > 0)
					positiveCount++;

				if (number < 0)
					negativeCount++;

				if (number == 0)
					zeroCount++;
			}

			positive = positiveCount / size;
			negative = negativeCount / size;
			zero = zeroCount / size;

			Console.WriteLine(positive.ToString("0.000000"));
			Console.WriteLine(negative.ToString("0.000000"));
			Console.WriteLine(zero.ToString("0.000000"));
		}
	}
}

