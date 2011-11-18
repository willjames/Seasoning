using System;
using NUnit.Framework;
using Seasoning;

namespace SeasoningTests
{
	[TestFixture]
	public class SeasonUtilitiesTests
	{
		[Test]
		public void Should_return_true_for_IsNewYearsDay()
		{
			var dateToEvaluate = new DateTime(2011, 1, 1);
			Assert.That(SeasonUtilities.IsNewYearsDay(dateToEvaluate), Is.True);
		}
	}
}
