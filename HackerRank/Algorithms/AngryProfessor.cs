using System;

namespace HackerRank
{
	public class AngryProfessor
	{
		public static void Run()
		{
			/* 
			sample input:
			2
			4 3
			-1 -3 4 2
			4 2
			0 -1 2 1
			
			sample output:
			YES
			NO
			*/

			int testCases = Int32.Parse(Console.ReadLine());
			if (testCases < 0 || testCases > 100)
				throw new Exception("Number of test cases must be between 1 and 100");

			int studentCount = 0    // N
				, requiredCount = 0 // K
				, onTimeCount = 0;
			
			string[] parts;
			
			for (var testCase = 0; testCase < testCases; testCase++)
			{
				// read student count and required threshold from stdin
				parts = Console.ReadLine().Split(' ');
				studentCount = Int32.Parse(parts[0]);
				requiredCount = Int32.Parse(parts[1]);

				//Console.WriteLine("Test Case " + testCase);

				if (studentCount < 1 || studentCount > 1000)
					throw new Exception("Error: Student count for test " + testCase + " must be between 1 and 1000");

				if (requiredCount < 0 || requiredCount > studentCount)
					throw new Exception("Error: Cancellation threshold for test " + testCase + " must be between 1 and " + studentCount);

				// read student arrival times from stdin
				parts = Console.ReadLine().Split(' ');
				var students = Array.ConvertAll(parts, Int32.Parse);
				//Console.WriteLine("Student times " + string.Join(", ", students));

				if (students.Length != studentCount)
					throw new Exception("Student arrival times do not match expected count.");

				// calculate totals to figure out of students are late
				onTimeCount = 0;
				foreach (int studentTime in students)
				{
					// Non-positive arrival times (studentTime <= 0) indicate the student arrived early or on time; 
					// positive arrival times (studentTime > 0) indicate the student arrived  minutes late.
					if (studentTime <= 0)
						onTimeCount++;
				}

				bool isCancelled = requiredCount > onTimeCount;
				//Console.WriteLine("Required "+ requiredCount +" have "+ onTimeCount);
				Console.WriteLine(isCancelled ? "YES" : "NO");
				//Console.WriteLine("-----------------------------");
			}
		}
	}
}

