using System;
namespace HackerRank
{
	public class Day02
	{
		public static void Run()
		{
			double mealCost = 0;
			int tipPercent = 0;
			int taxPercent = 0;
			double totalCost = 0;

			mealCost = Double.Parse(Console.ReadLine());
			tipPercent = Int32.Parse(Console.ReadLine());
			taxPercent = Int32.Parse(Console.ReadLine());

			double tip = mealCost * ((double)tipPercent / (double)100);
			double tax = mealCost * ((double)taxPercent / (double)100);

			totalCost = mealCost + tip + tax;

			// Print the sum of both integer variables on a new line.
			Console.WriteLine("The total meal cost is " + totalCost.ToString("0") + " dollars.");
		}
	}
}
