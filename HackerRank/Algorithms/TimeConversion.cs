using System;
namespace HackerRank
{
	public class TimeConversion
	{
		public static void Run()
		{
			/* 
			sample input:
			07:05:45PM
			
			sample output:
			19:05:45
			*/

			// i think in the spirit of this test we want to write out code instead of relying on the standard
			// library, sooooo, substring here we go!
			string input = Console.ReadLine();

			string inHours = input.Substring(0, 2);
			string meridian = input.Substring(8, 2);
			string militaryTime;

			if (inHours == "12")
			{
				militaryTime = meridian == "AM" ? "00" : "12";
			}
			else if (meridian == "PM")
			{
				// add 12 hours
				militaryTime = (Int32.Parse(inHours) + 12).ToString("00");
			}
			else 
			{
				militaryTime = inHours;
			}

			militaryTime += input.Substring(2, 6);
			Console.WriteLine(militaryTime);
		}
	}
}

