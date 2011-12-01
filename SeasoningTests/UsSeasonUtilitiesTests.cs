using System;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Seasoning;

namespace SeasoningTests
{
	[TestFixture]
	public class UsSeasonUtilitiesTests
	{

		/*
		 *	http://en.wikipedia.org/wiki/Public_holidays_in_the_United_States
		 *	Date													Official Name
			January 1												New Year's Day
			July 4													Independence Day
			November 11												Veterans Day
			December 25												Christmas

			Third Monday in January									Birthday of Martin Luther King, Jr.
			First January 20th following a Presidential election	Inauguration Day
			Third Monday in February								Washington's Birthday
			Last Monday in May										Memorial Day
			First Monday in September								Labor Day
			Second Monday in October								Columbus Day
			Fourth Thursday in November								Thanksgiving Day
		 */

		[Test]
		public void Should_return_true_for_IsMartinLutherKingBirthday()
		{
			var dateToEvaluate = new DateTime(2012, 01, 16); //known third Monday in January

			Assert.That(UsSeasonUtilities.IsMartinLutherKingBirthday(dateToEvaluate), Is.True);
		}
	}
}
