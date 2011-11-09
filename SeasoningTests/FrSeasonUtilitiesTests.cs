﻿using System;
using NUnit.Framework;
using Seasoning;

namespace SeasoningTests
{
	[TestFixture]
	public class FrSeasonUtilitiesTests
	{
		/* Specific dates below good for 2012
			* 
			* Need to research whether some of them vary 
			* 
			* New Year's Day
			* Good Friday (regional)
			* Easter Monday
			* Labour Day - May 1st
			* VE Day - May 8th
			* Ascension Day - May 17th
			* Pentecost - May 28th
			* FeteNational - July 14th
			* Assumption - August 15th
			* All Saint's Day - November 1st
			* Armistice Day - November 11th
			* Christmas
			*/

		[Test]
		public void Should_return_true_for_IsLabourDay()
		{
			var dateToEvaluate = new DateTime(2011, 5, 1);
			Assert.That(FrSeasonUtilities.IsLabourDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsVEDay()
		{
			var dateToEvaluate = new DateTime(2011, 5, 8);
			Assert.That(FrSeasonUtilities.IsVEDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsAscensionDay()
		{
			var dateToEvaluate = new DateTime(2011, 5, 17);
			Assert.That(FrSeasonUtilities.IsAscensionDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsPentecost()
		{
			var dateToEvaluate = new DateTime(2011, 5, 28);
			Assert.That(FrSeasonUtilities.IsPentecost(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsFeteNational()
		{
			var dateToEvaluate = new DateTime(2011, 7, 14);
			Assert.That(FrSeasonUtilities.IsFeteNational(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsAssumption()
		{
			var dateToEvaluate = new DateTime(2011, 8, 15);
			Assert.That(FrSeasonUtilities.IsAssumption(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsAllSaintsDay()
		{
			var dateToEvaluate = new DateTime(2011, 11, 1);
			Assert.That(FrSeasonUtilities.IsAllSaintsDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsArmisticeDay()
		{
			var dateToEvaluate = new DateTime(2011, 11, 11);
			Assert.That(FrSeasonUtilities.IsArmisticeDay(dateToEvaluate), Is.True);
		}

	}
}
