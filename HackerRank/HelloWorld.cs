using System;

	class MainClass
	{
		public static void Main(string[] args)
		{
			var ignore = Console.ReadLine();
			var numbers = Console.ReadLine();
			string[] parts = numbers.Split(' ');
			var length = parts.Length;
			var reversed = String.Join(" ", parts.Reverse());
			Console.WriteLine(reversed);
		}
	}

