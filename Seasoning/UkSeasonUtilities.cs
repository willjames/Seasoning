using System;

namespace Seasoning
{
	public class UkSeasonUtilities : SeasonUtilities
	{
		public static bool IsAprilFoolsDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 4 && dateToEvaluate.Day >= 1);
		}

		public static bool IsArmisticeDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 11 && dateToEvaluate.Day == 11);
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

		public static bool IsShroveTuesday(DateTime dateToEvaluate)
		{
			// Shrove Tuesday is 47 days before Easter 
			var easterSunday = EasterSunday(dateToEvaluate.Year);
			var shroveTuesday = easterSunday.AddDays(-47);

			return (dateToEvaluate.Day == shroveTuesday.Day && dateToEvaluate.Month == shroveTuesday.Month);
		}

		public static bool IsAshWednesday(DateTime dateToEvaluate)
		{
			// Ash Wednesday is 46 days before Easter 
			var easterSunday = EasterSunday(dateToEvaluate.Year);
			var ashWednesday = easterSunday.AddDays(-46);

			return (dateToEvaluate.Day == ashWednesday.Day && dateToEvaluate.Month == ashWednesday.Month);
		}
	}
}