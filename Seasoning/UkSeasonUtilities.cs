using System;

namespace Seasoning
{
	public class UkSeasonUtilities
	{
		public static bool IsAprilFoolsDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 4 && dateToEvaluate.Day >= 1);
		}

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

		public static bool IsFireworksNight(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 11 && dateToEvaluate.Day == 5);
		}

		public static bool IsHalloween(DateTime dateToEvaluate)
		{
			//show halloween logo for two days
			return (dateToEvaluate.Month == 10 && dateToEvaluate.Day >= 30);
		}

		public static bool IsNewYearsDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 1 && dateToEvaluate.Day == 1);
		}

		public static bool IsStDavidsDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 3 && dateToEvaluate.Day == 1);
		}

		public static bool IsStPatricksDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 3 && dateToEvaluate.Day == 17);
		}

		public static bool IsStGeorgesDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 4 && dateToEvaluate.Day == 23);
		}

		public static bool IsStAndrewsDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 11 && dateToEvaluate.Day == 30);
		}

		public static bool IsValentinesDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 2 && dateToEvaluate.Day == 14);
		}

		public static bool IsBritishSummerTimeStartDay(DateTime dateToEvaluate)
		{
			if (dateToEvaluate.Month == 3 && dateToEvaluate.Day == GetLastSundayOfTheMonth(dateToEvaluate))
				return true;

			return false;
		}

		public static bool IsBritishSummerTimeEndDay(DateTime dateToEvaluate)
		{
			if (dateToEvaluate.Month == 10 && dateToEvaluate.Day == GetLastSundayOfTheMonth(dateToEvaluate))
				return true;

			return false;
		}

		public static bool IsEaster(DateTime dateToEvaluate)
		{
			DateTime dtEasterSunday = EasterSunday(dateToEvaluate.Year);

			// return true for Good Friday through to Easter Monday inclusive
			return (dateToEvaluate >= dtEasterSunday.AddDays(-2) && dateToEvaluate <= dtEasterSunday.AddDays(1));
		}

		private static int GetLastSundayOfTheMonth(DateTime dateToEvaluate)
		{
			var sundaysOfTheMonth = new int[5];
			int positionCounter = 0;

			for (int i = 1; i < 32; i++)
			{
				var iterator = new DateTime(dateToEvaluate.Year, dateToEvaluate.Month, i);

				if (iterator.DayOfWeek == DayOfWeek.Sunday)
				{
					sundaysOfTheMonth[positionCounter] = iterator.Day;
					positionCounter++;
				}
			}

			// get array length and pull out the last day
			int lastSundayOfTheMonth = 0;

			for (int i = 0; i < sundaysOfTheMonth.Length; i++)
			{
				if (sundaysOfTheMonth[i] != 0)
					lastSundayOfTheMonth = sundaysOfTheMonth[i];
			}
			return lastSundayOfTheMonth;
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

		private static DateTime EasterSunday(int year)
		{
			int month = 0;
			int day = 0;
			EasterSunday(year, out month, out day);

			return new DateTime(year, month, day);
		}
	}
}