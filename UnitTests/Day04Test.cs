using NUnit.Framework;
using System;
using HackerRank;

namespace UnitTests
{
	[TestFixture()]
	public class Day04Test
	{
		[Test()]
		public void TestInvalidNumberOnString()
		{
			Assert.AreEqual(-1, Day04.ParseNumber("fail"));
		}

		[Test()]
		public void TestNumberLessThan1()
		{
			Assert.AreEqual(-1, Day04.ParseNumber("-2"));
		}

		[Test()]
		public void TestNumberGreaterThan100()
		{
			Assert.AreEqual(-1, Day04.ParseNumber("101"));
		}	


		[Test()]
		public void Test100IsValid()
		{
			Assert.AreEqual(100, Day04.ParseNumber("100"));
		}	

		[Test()]
		public void Test1IsValid()
		{
			Assert.AreEqual(1, Day04.ParseNumber("1"));
		}
	}
}

