using System;
namespace HackerRank
{
	public class Day02
	{
		public static void Run()
		{
			int i = 4;
			double d = 4.0;
			string s = "HackerRank ";

			// Declare second integer, double, and String variables.
			int i2;
			double d2;
			string s2;

			// im not bothering with error handling on this. good luck.
			// Read and save an integer, double, and String to your variables.
			i2 = Int32.Parse(Console.ReadLine());
			d2 = Double.Parse(Console.ReadLine());
			s2 = Console.ReadLine();

			// Print the sum of both integer variables on a new line.
			Console.WriteLine(i + i2);

			// Print the sum of the double variables on a new line.
			Console.WriteLine((d + d2).ToString("0.0"));

			// Concatenate and print the String variables on a new line
			// The 's' variable above should be printed first.
			Console.WriteLine(s + s2);
		}
	}
}
