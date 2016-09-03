using System;
namespace HackerRank
{
	public class Day03
	{
		public static string Run()
		{
			int n = ParseNumber(Console.ReadLine());
			if (n > 0)
			{
				return n % 2 == 0 ? Even(n) : Odd(n);
			}

			return "Please provide a valid number between 1 and 100";
		}

		/// <summary>
		/// Returns a valid number between 1 and 100, else -1
		/// </summary>
		/// <returns>The number.</returns>
		/// <param name="val">Value.</param>
		public static int ParseNumber(string val)
		{
			int n;
			if (Int32.TryParse(val, out n) &&
				n > 0 &&
				n < 101)
			{
				return n;
			}
			return -1;
		}

		/// <summary>
		/// Even integer logic
		/// </summary>
		/// <param name="n">N.</param>
		public static string Even(int n)
		{
			if (n >= 2 && n <= 5) return "Not Weird";
			if (n >= 6 && n <= 20) return "Weird";
			if (n > 20) return "Not Weird";
			return "";
		}

		/// <summary>
		/// Odd integer logic
		/// </summary>
		/// <param name="n">N.</param>
		public static string Odd(int n)
		{
			return "Weird";
		}
	}
}
