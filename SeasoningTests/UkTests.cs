using System;
using NUnit.Framework;
using Seasoning;

namespace SeasoningTests
{
	[TestFixture]
	public class UkTests
	{
		[Test]
		public void Should_return_true_for_IsAprilFoolsDay()
		{
			var dateToEvaluate = new DateTime(2011, 4, 1);

			Assert.That(Uk.IsAprilFoolsDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsArmisticeDay()
		{
			var dateToEvaluate = new DateTime(2011, 11, 11);
			Assert.That(Uk.IsArmisticeDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_Christmas_Day_when_date_is_December_25th()
		{
			var dateToEvaluate = new DateTime(2011, 12, 25);

			Assert.That(SeasonUtilities.IsChristmas(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsFireworksNight_when_date_is_November_5th()
		{
			var dateToEvaluate = new DateTime(2011, 11, 05);

			Assert.That(Uk.IsFireworksNight(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsHalloween()
		{
			var dateToEvaluate = new DateTime(2011, 10, 31);

			Assert.That(Uk.IsHalloween(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsNewYearsDay()
		{
			var dateToEvaluate = new DateTime(2011, 1, 1);

			Assert.That(Uk.IsNewYearsDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsStDavidsDay()
		{
			var dateToEvaluate = new DateTime(2011, 3, 1);

			Assert.That(Uk.IsStDavidsDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsStPatricksDay()
		{
			var dateToEvaluate = new DateTime(2011, 3, 17);

			Assert.That(Uk.IsStPatricksDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsStAndrewsDay()
		{
			var dateToEvaluate = new DateTime(2011, 11, 30);

			Assert.That(Uk.IsStAndrewsDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsStGeorgesDay()
		{
			var dateToEvaluate = new DateTime(2011, 4, 23);

			Assert.That(Uk.IsStGeorgesDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsValentinesDay()
		{
			var dateToEvaluate = new DateTime(2011, 2, 14);
			Assert.That(Uk.IsValentinesDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsBritishSummerTimeStartDay()
		{
			var dateToEvaluate = new DateTime(2011, 03, 27); // known last Sunday in March
			Assert.That(Uk.IsBritishSummerTimeStartDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsBritishSummerTimeEndDay()
		{
			var dateToEvaluate = new DateTime(2011, 10, 30); // known last Sunday in March
			Assert.That(Uk.IsBritishSummerTimeEndDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void should_return_true_for_IsEaster()
		{
			// april 24th 2011 is a known easter sunday 
			var dateToEvaluate = new DateTime(2011, 4, 24);
			Assert.That(SeasonUtilities.IsEaster(dateToEvaluate), Is.True);

		}

		[Test]
		public void should_return_true_for_IsShroveTuesday()
		{
			// april 24th 2011 is a known easter sunday 
			var dateToEvaluate = new DateTime(2011, 3, 8);
			Assert.That(Uk.IsShroveTuesday(dateToEvaluate), Is.True);

		}

		[Test]
		public void should_return_true_for_IsAshWednesday()
		{
			// april 24th 2011 is a known easter sunday 
			var dateToEvaluate = new DateTime(2011, 3, 9);
			Assert.That(Uk.IsAshWednesday(dateToEvaluate), Is.True);

		}
	}
}