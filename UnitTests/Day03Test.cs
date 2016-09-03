using NUnit.Framework;
using System;
using HackerRank;

namespace UnitTests
{
	[TestFixture()]
	public class Day03Test
	{
		[Test()]
		public void TestInvalidNumberOnString()
		{
			Assert.AreEqual(-1, Day03.ParseNumber("fail"));
		}

		[Test()]
		public void TestNumberLessThan1()
		{
			Assert.AreEqual(-1, Day03.ParseNumber("-2"));
		}

		[Test()]
		public void TestNumberGreaterThan100()
		{
			Assert.AreEqual(-1, Day03.ParseNumber("101"));
		}	


		[Test()]
		public void Test100IsValid()
		{
			Assert.AreEqual(100, Day03.ParseNumber("100"));
		}	

		[Test()]
		public void Test1IsValid()
		{
			Assert.AreEqual(1, Day03.ParseNumber("1"));
		}

		[Test()]
		public void TestOddPrintWeird()
		{
			Assert.AreEqual("Weird", Day03.Odd(1));
		}

		// If n is even and in the inclusive range of 2 to 5, print Not Weird
		[Test()]
		public void TestEven2PrintNotWeird()
		{
			Assert.AreEqual("Not Weird", Day03.Even(2));
		}

		[Test()]
		public void TestEven4PrintNotWeird()
		{
			Assert.AreEqual("Not Weird", Day03.Even(4));
		}

		// If n is even and in the inclusive range of 6 to 20, print Weird
		[Test()]
		public void TestEven6PrintNotWeird()
		{
			Assert.AreEqual("Weird", Day03.Even(6));
		}

		[Test()]
		public void TestEven20PrintNotWeird()
		{
			Assert.AreEqual("Weird", Day03.Even(20));
		}

		// If n is even and greater than 20, print Not Weird
		[Test()]
		public void TestEven21PrintNotWeird()
		{
			Assert.AreEqual("Not Weird", Day03.Even(21));
		}
	}
}

