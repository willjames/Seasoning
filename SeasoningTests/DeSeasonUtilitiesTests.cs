using System;
using NUnit.Framework;
using Seasoning;

namespace SeasoningTests
{
	[TestFixture]
	public class DeSeasonUtilitiesTests
	{
		/* from http://en.wikipedia.org/wiki/Public_holidays_in_Germany
		 * German Public Holidays:
		 *	New Year's Day					Neujahrstag					1 January
			Epiphany						Heilige Drei Könige			6 January
			Good Friday						Karfreitag					Easter Sunday - 2d
			Easter Monday					Ostermontag					Easter Sunday + 1d
			Labour Day						Tag der Arbeit				1 May
			Ascension Day					Christi Himmelfahrt			Easter Sunday + 39d
			Whit Monday						Pfingstmontag				Easter Sunday + 50d
			Corpus Christi					Fronleichnam				Easter Sunday + 60d
			Peace Festival					Friedensfest				8 August
			Assumption Day					Mariä Himmelfahrt			15 August
			German Unity Day				Tag der Deutschen Einheit	3 October
			Reformation Day					Reformationstag				31 October
			All Saints						Allerheiligen				1 November
			Christmas Day					Weihnachtstag				25 December
			St Stephen's Day				Zweiter Weihnachtsfeiertag	26 December
		 */

		[Test]
		public void Should_return_true_for_IsEpiphany()
		{
			var dateToEvaluate = new DateTime(2011, 1, 6);

			Assert.That(DeSeasonUtilities.IsEpiphany(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsLabourDay()
		{
			var dateToEvaluate = new DateTime(2011, 5, 1);

			Assert.That(DeSeasonUtilities.IsLabourDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsAscensionDay()
		{
			var dateToEvaluate = SeasonUtilities.EasterSunday(2011).AddDays(39);

			Assert.That(DeSeasonUtilities.IsAscensionDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsWhitMonday()
		{
			var dateToEvaluate = SeasonUtilities.EasterSunday(2011).AddDays(50);

			Assert.That(DeSeasonUtilities.IsWhitMonday(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsCorpusChristi()
		{
			var dateToEvaluate = SeasonUtilities.EasterSunday(2011).AddDays(60);

			Assert.That(DeSeasonUtilities.IsCorpusChristi(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsPeaceFestival()
		{
			var dateToEvaluate = new DateTime(2011,8,8);

			Assert.That(DeSeasonUtilities.IsPeaceFestival(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsAssumptionDay()
		{
			var dateToEvaluate = new DateTime(2011, 8, 15);

			Assert.That(DeSeasonUtilities.IsAssumptionDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsGermanUnityDay()
		{
			var dateToEvaluate = new DateTime(2011, 10, 3);

			Assert.That(DeSeasonUtilities.IsGermanUnityDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsReformationDay()
		{
			var dateToEvaluate = new DateTime(2011, 10, 31);

			Assert.That(DeSeasonUtilities.IsReformationDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsAllSaints()
		{
			var dateToEvaluate = new DateTime(2011, 11, 1);

			Assert.That(DeSeasonUtilities.IsAllSaints(dateToEvaluate), Is.True);
		}

	}
}
