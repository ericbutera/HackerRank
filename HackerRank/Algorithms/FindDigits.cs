using System;

namespace HackerRank
{
	public class FindDigits
	{
		public static void Run()
		{
			/* 
			sample input:
			2
			12
			1012
			
			sample output:
			2
			3
			*/

			int testCases = Int32.Parse(Console.ReadLine()); // between 1 and 15
			//Console.WriteLine("# Test  Cases: " + testCases);

			string testCase;
			long number;
			int digit, total;
			for (var x = 0; x < testCases; x++)
			{
				testCase = Console.ReadLine(); 
				number = Int64.Parse(testCase); // N - between 1 and 1,000,000,000 [1 billion]

				//Console.WriteLine("Test Case: " + testCase);

				// iterate over each digit calculating total of digits that have a remainder of 0 when divided against testCase
				total = 0;
				for (var y = 0; y < testCase.Length; y++)
				{
					digit = Int32.Parse(testCase.Substring(y, 1));
					//Console.WriteLine("Digit " + digit);
					if (digit != 0 && number % digit == 0)
						total++;
				}

				Console.WriteLine(total);
				//Console.WriteLine("Testing " + number);
			}

			//Console.WriteLine("-------------");
		}
	}
}

