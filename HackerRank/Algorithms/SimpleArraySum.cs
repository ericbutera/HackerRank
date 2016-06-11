using System;
using System.Linq;

namespace HackerRank
{
	public class SimpleArraySum
	{
		public static void Run()
		{
			int length = Convert.ToInt32(Console.ReadLine());
			string[] parts = Console.ReadLine().Split(' ');
			int[] integers = Array.ConvertAll(parts, Int32.Parse);
			Console.WriteLine(integers.Sum());
		}
	}
}

