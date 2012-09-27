using System;
using NUnit.Framework;
using Seasoning;

namespace SeasoningTests
{
	[TestFixture]
	public class ItTests
	{
		/* from http://en.wikipedia.org/wiki/Public_holidays_in_Italy
		 *	Date					English Name
			1 January				New Year's Day
			6 January				Epiphany
			17 March				National Day
			Movable					Easter Sunday
			Monday after Easter		Easter Monday
			25 April				Anniversary of Liberation
			1 May					Labour Day
			2 June					Republic Day
			15 August				Ferragosto/Assumption Day
			1 November				All Saints
			8 December				Immaculate Conception
			25 December				Christmas Day
			26 December				St Stephen's Day
		 */

		[Test]
		public void Should_return_true_for_IsEpiphany()
		{
			var dateToEvaluate = new DateTime(2011, 1, 6);

			Assert.That(It.IsEpiphany(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsNationalDay()
		{
			var dateToEvaluate = new DateTime(2011, 3, 17);

			Assert.That(It.IsNationalDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsAnniversaryOfLiberation()
		{
			var dateToEvaluate = new DateTime(2011, 4, 25);

			Assert.That(It.IsAnniversaryOfLiberation(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsLabourDay()
		{
			var dateToEvaluate = new DateTime(2011, 5, 1);

			Assert.That(It.IsLabourDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsRepublicDay()
		{
			var dateToEvaluate = new DateTime(2011, 6, 2);

			Assert.That(It.IsRepublicDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsAssumptionDay()
		{
			var dateToEvaluate = new DateTime(2011, 8, 15);

			Assert.That(It.IsAssumptionDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsAllSaintsDay()
		{
			var dateToEvaluate = new DateTime(2011, 11, 1);

			Assert.That(It.IsAllSaintsDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsImmaculateConception()
		{
			var dateToEvaluate = new DateTime(2011, 12, 8);

			Assert.That(It.IsImmaculateConception(dateToEvaluate), Is.True);
		}
	}
}