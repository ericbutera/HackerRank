using System;

namespace HackerRank
{
	public class SortIntro
	{
		public static void Run()
		{
			/* 
			sample input:
			4
			6
			1 4 5 7 9 12
			
			sample output:
			1
			*/

			string find = Console.ReadLine();
			int size = Int32.Parse(Console.ReadLine());
			string line = Console.ReadLine();
			string[] numbers = line.Split();

			//Console.WriteLine("Finding: "+ find +" in "+ line);

			string number;
			for (var index = 0; index < size; index++)
			{
				number = numbers[index];
				//Console.WriteLine(" - Searching number: " + number);
				if (number == find)
				{
					//Console.WriteLine("Match found at index " + index);
					Console.WriteLine(index);
					break;
				}
			}

			//Console.WriteLine("-------------");
		}
	}
}

