using System;
using NUnit.Framework;
using Seasoning;

namespace SeasoningTests
{
	[TestFixture]
	public class CaTests
	{
		/*
		 * New Year's Day
			Good Friday
			Canada Day
			1st mon in Sept Labour Day
			Christmas Day
		 * 
		 * Statutory hols for federal employees and in some provinces/territories
		 * 
			Monday on or before May 24	Victoria Day
			Second Monday in October	Thanksgiving
			November 11	Remembrance Day
			December 26	Boxing Day
			Third Monday in February	February Civic Holiday
			First Monday in August	August Civic Holiday
		 */

		[Test]
		public void Should_return_true_for_IsCanadaDay()
		{
			var dateToEvaluate = new DateTime(2011, 7, 1);
			Assert.That(Ca.IsCanadaDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsLabourDay()
		{
			var dateToEvaluate = new DateTime(2011, 9, 5);// a known 1st Monday in September
			Assert.That(Ca.IsLabourDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsThanksgiving()
		{
			var dateToEvaluate = new DateTime(2011, 10, 10);// a known 2nd Monday in October
			Assert.That(Ca.IsThanksgiving(dateToEvaluate), Is.True);
		}
	}
}