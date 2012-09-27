using System;
using NUnit.Framework;
using Seasoning;

namespace SeasoningTests
{
	[TestFixture]
	public class UsTests
	{

		/*
		 *	http://en.wikipedia.org/wiki/Public_holidays_in_the_United_States
		 *	Date													Official Name

			January 1												New Year's Day
			July 4													Independence Day
			November 11												Veterans Day
			Third Monday in January									Birthday of Martin Luther King, Jr.
			Third Monday in February								Washington's Birthday
			First Monday in September								Labor Day
			Second Monday in October								Columbus Day
			Fourth Thursday in November								Thanksgiving Day

			February 2												Groundhog Day
			February 14												Valentine's Day
			March 17												Saint Patrick's Day
			April 1													April Fools' Day
			April 22 (varies by location and observance)			Earth Day

			May 1													May Day
			May 5													Cinco de Mayo
			Second Sunday in May									Mother's Day
			June 14													Flag Day
			Third Sunday in June									Father's Day
			June 21													Summer Solstice
			September 11											Patriot Day
			September 17											Constitution/Citizenship Day
			October 9												Leif Erikson Day
			October 31												Halloween

			December 7												Pearl Harbor Remembrance Day
			December 21												Winter Solstice
			December 24												Christmas Eve
			December 31												New Year's Eve
		 */



		[Test]
		public void Should_return_true_for_IsMartinLutherKingBirthday()
		{
			var dateToEvaluate = new DateTime(2012, 01, 16); //known third Monday in January
			Assert.That(Us.IsMartinLutherKingBirthday(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsIndependenceDay()
		{
			var dateToEvaluate = new DateTime(2012, 07, 04);
			Assert.That(Us.IsIndependenceDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsVeteransDay()
		{
			var dateToEvaluate = new DateTime(2012, 11, 11);
			Assert.That(Us.IsVeteransDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsWashingtonsBirthday()
		{
			var dateToEvaluate = new DateTime(2012, 02, 20);
			Assert.That(Us.IsWashingtonsBirthday(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsLaborDay()
		{
			var dateToEvaluate = new DateTime(2011, 09, 05);
			Assert.That(Us.IsLaborDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsColumbusDay()
		{
			var dateToEvaluate = new DateTime(2011, 10, 10);
			Assert.That(Us.IsColumbusDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsThanksgiving()
		{
			var dateToEvaluate = new DateTime(2011, 11, 24);
			Assert.That(Us.IsThanksgiving(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsGroundhogDay()
		{
			var dateToEvaluate = new DateTime(2011, 02, 02);
			Assert.That(Us.IsGroundhogDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsValentinesDay()
		{
			var dateToEvaluate = new DateTime(2011, 02, 14);
			Assert.That(Us.IsValentinesDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsStPatricksDay()
		{
			var dateToEvaluate = new DateTime(2011, 03, 17);
			Assert.That(Us.IsStPatricksDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsAprilFoolsDay()
		{
			var dateToEvaluate = new DateTime(2011, 04, 01);
			Assert.That(Us.IsAprilFoolsDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsEarthDay()
		{
			var dateToEvaluate = new DateTime(2011, 04, 22);
			Assert.That(Us.IsEarthDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsMayDay()
		{
			var dateToEvaluate = new DateTime(2011, 05, 01);
			Assert.That(Us.IsMayDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsCincoDeMayo()
		{
			var dateToEvaluate = new DateTime(2011, 05, 05);
			Assert.That(Us.IsCincoDeMayo(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsMothersDay()
		{
			var dateToEvaluate = new DateTime(2011, 05, 08);
			Assert.That(Us.IsMothersDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsFathersDay()
		{
			var dateToEvaluate = new DateTime(2011, 06, 19);
			Assert.That(Us.IsFathersDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsFlagsDay()
		{
			var dateToEvaluate = new DateTime(2011, 06, 14);
			Assert.That(Us.IsFlagDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsPatriotDay()
		{
			var dateToEvaluate = new DateTime(2011, 9, 11);
			Assert.That(Us.IsPatriotDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsConstitutionCitizenshipDay()
		{
			var dateToEvaluate = new DateTime(2011, 9, 17);
			Assert.That(Us.IsConstitutionCitizenshipDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsLeifEriksonDay()
		{
			var dateToEvaluate = new DateTime(2011, 10, 9);
			Assert.That(Us.IsLeifEriksonDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsHalloween()
		{
			var dateToEvaluate = new DateTime(2011, 10, 31);
			Assert.That(Us.IsHalloween(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsPearlHarborRemembranceDay()
		{
			var dateToEvaluate = new DateTime(2011, 12, 7);
			Assert.That(Us.IsPearlHarborRemembranceDay(dateToEvaluate), Is.True);
		}

		//#TODO

		//First Tuesday after the first Monday in November			Election Day (in election years)
		//First Friday after the fourth Thursday in November		Black Friday
		//First Tuesday after the first Monday in November			Election Day
		//First Friday after the fourth Thursday in November		Black Friday
		//Last Monday in May										Memorial Day
		//First January 20th following a Presidential election		Inauguration Day
		//Last Friday in April										Arbor Day
	}
}
