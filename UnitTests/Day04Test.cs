using NUnit.Framework;
using System;
using HackerRank;

namespace UnitTests
{
	[TestFixture()]
	public class Day04Test
	{
		[SetUp]
		public void Init()
		{
			// Output.Clear();
		}

		[Test()]
		public void TestNegativeNumberReturnsError()
		{
			//var ex = Assert.Throws<Exception>(delegate { var i = new Person(-1); });
			//Assert.That(ex.Message, Is.EqualTo("Age is not valid, setting age to 0."));
			var i = new Person(-1);
			Assert.AreEqual("Age is not valid, setting age to 0.", Output.Flush());
		}

		[Test()]
		public void TestNegativeNumberSetsAgeToZero()
		{
			var i = new Person(-1);
			Assert.AreEqual(0, i.age);
		}

		[Test()]
		public void TestSetAgeTo5()
		{
			var i = new Person(5);
			Assert.AreEqual(5, i.age);
		}

		[Test()]
		public void TestYearPassesIncrementsAgeBy1()
		{
			var i = new Person(5);
			i.yearPasses();
			Assert.AreEqual(6, i.age);
		}

		[Test()]
		public void TestLessThan13PrintsYoung()
		{
			var i = new Person(12);
			i.amIOld();
			Assert.AreEqual("You are young.", Output.Flush());
		}

		[Test()]
		public void Test13To18PrintsTeenager()
		{
			for (var age = 13; age < 18; age++)
			{
				var i = new Person(age);
				i.amIOld();
				Assert.AreEqual("You are a teenager.", Output.Flush());
			}
		}

		[Test()]
		public void Test18PrintsOld()
		{
			var i = new Person(18);
			i.amIOld();
			Assert.AreEqual("You are old.", Output.Flush());
		}
	}
}

