using System;
using System.Linq;

namespace HackerRank
{
	public class Arrays
	{
		/// <summary>
		/// For this to run you have to capture the first input and ignore it as that is supposed to be the array length 
		/// according to the test rules. Type a number, press enter, then type the numbers space delimited and press enter again.
		/// </summary>
		public static void Run()
		{
			// ignore the first input or else program won't pass 7 get rid of unused warning
			var ignore = Console.ReadLine();
			ignore = ignore + "";

			var numbers = Console.ReadLine();
			string[] parts = numbers.Split(' ');
			var length = parts.Length;
			var reversed = String.Join(" ", parts.Reverse());
			Console.WriteLine(reversed);

			// wait to close window
			Console.ReadLine();
		}
	}
}