using System;
using System.Collections.Generic;

namespace HackerRank
{
	/*
	Input:
	4 // # of testcases 1 to 4
	-1 
	10
	16
	18

	Output:
	Age is not valid, setting age to 0.
	You are young.
	You are young.

	You are young.
	You are a teenager.

	You are a teenager.
	You are old.

	You are old.
	You are old.
	 */
	public class Day04
	{
		public static string Run()
		{
			int T = int.Parse(Console.In.ReadLine());
			for (int i = 0; i < T; i++)
			{
				int age = int.Parse(Console.In.ReadLine());
				Person p = new Person(age);
				p.amIOld();
				for (int j = 0; j < 3; j++)
				{
					p.yearPasses();
				}
				p.amIOld();
			}
			return Output.Flush();
			// return string.Join("\r\n", output);
		}
	}

	public static class Output
	{
		public static List<string> output = new List<string>();
		public static void Write(string message)
		{
			output.Add(message);
			Console.WriteLine(message);
		}

		public static void Clear()
		{
			output = new List<string>();
		}

		public static string Flush()
		{
			var tmp = Output.Get();
			Output.Clear();
			return tmp;
		}
		public static string Get()
		{
			return string.Join("\r\n", output);
		}
	}

	public class Person
	{
		public int age;
		public Person(int initialAge)
		{
			if (initialAge < 1)
			{
				age = 0;
				Output.Write("Age is not valid, setting age to 0.");
				return;
			}

			age = initialAge;
		}

		public void amIOld()
		{
			// Do some computations in here and print out the correct statement to the console 
			if (age < 13)
				Output.Write("You are young.");
			else if (age >= 13 && age < 18) 
				Output.Write("You are a teenager.");
			else 
				Output.Write("You are old.");
		}

		public void yearPasses()
		{
			// Increment the age of the person in here
			++age;
		}
	}
}
