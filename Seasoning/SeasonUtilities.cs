using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seasoning
{
	public class SeasonUtilities
	{
		public static bool IsChristmas(DateTime dateToEvaluate)
		{
			// returns true for Xmas eve, Xmas day and Boxing Day.
			// you wanna rock it until 12th night (Jan 5th)? Tweak away.
			return (dateToEvaluate.Month == 12 && (dateToEvaluate.Day == 24 || dateToEvaluate.Day == 25 || dateToEvaluate.Day == 26));
		}

		public static bool IsChristmasForMarketing(DateTime startDate, DateTime endDate, DateTime dateToEvaluate)
		{
			// because Xmas for marketeers can start in, like, September. 
			return (dateToEvaluate >= startDate && dateToEvaluate <= endDate);
		}

		public static bool IsNewYearsDay(DateTime dateToEvaluate)
		{
			return dateToEvaluate.DayOfYear == 1;
		}

		public static bool IsEaster(DateTime dateToEvaluate)
		{
			DateTime dtEasterSunday = EasterSunday(dateToEvaluate.Year);

			// return true for Good Friday through to Easter Monday inclusive
			return (dateToEvaluate >= dtEasterSunday.AddDays(-2) && dateToEvaluate <= dtEasterSunday.AddDays(1));
		}

		protected static DateTime GetOrdinalDayOfWeekForSpecificMonth(DateTime dateToEvaluate, DayOfWeek dayOfWeek, int ordinalDayOfWeek)
		{
			// gets, for example, the third Monday in January, or the second Friday in August.

			var listOfDayOfWeekInMonth = new List<int>();
			int daysinMonth = DateTime.DaysInMonth(dateToEvaluate.Year, dateToEvaluate.Month);
			var dateForIteration = new DateTime(dateToEvaluate.Year, dateToEvaluate.Month, 1);

			for (int i = 1; i <= daysinMonth; i++)
			{
				if (dateForIteration.DayOfWeek == dayOfWeek)
					listOfDayOfWeekInMonth.Add(i);

				dateForIteration = dateForIteration.AddDays(1);
			}

			return new DateTime(dateToEvaluate.Year, dateToEvaluate.Month, listOfDayOfWeekInMonth[ordinalDayOfWeek - 1]);
		}

		// the two methods below are taken from http://www.codeproject.com/cs/samples/christianholidays.asp

		private static void EasterSunday(int year, out int month, out int day)
		{
			int g = year % 19;
			int c = year / 100;
			int h = h = (c - (int)(c / 4) - (int)((8 * c + 13) / 25)
			             + 19 * g + 15) % 30;
			int i = h - (int)(h / 28) * (1 - (int)(h / 28) *
			                             (int)(29 / (h + 1)) * (int)((21 - g) / 11));

			day = i - ((year + (int)(year / 4) +
			            i + 2 - c + (int)(c / 4)) % 7) + 28;
			month = 3;

			if (day > 31)
			{
				month++;
				day -= 31;
			}
		}

		public static DateTime EasterSunday(int year)
		{
			int month = 0;
			int day = 0;
			EasterSunday(year, out month, out day);

			return new DateTime(year, month, day);
		}
	}
}
