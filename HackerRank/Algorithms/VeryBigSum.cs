using System;
using System.Linq;

namespace HackerRank
{
	public class VeryBigSum
	{
		public static void Run()
		{
			int length = Convert.ToInt32(Console.ReadLine());
			string[] parts = Console.ReadLine().Split(' ');
			long[] integers = Array.ConvertAll(parts, Int64.Parse);
			Console.WriteLine(integers.Sum());
		}
	}
}

