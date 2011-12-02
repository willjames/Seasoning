using System;

namespace Seasoning
{
	public class UsSeasonUtilities : SeasonUtilities
	{
		public static bool IsMartinLutherKingBirthday(DateTime dateToEvaluate)
		{
			if (dateToEvaluate.Month == 1 && dateToEvaluate == GetOrdinalDayOfWeekForSpecificMonth(dateToEvaluate, DayOfWeek.Monday, 3))
				return true;

			return false;
		}

		public static bool IsIndependenceDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 7 && dateToEvaluate.Day == 4);
		}

		public static bool IsVeteransDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 11 && dateToEvaluate.Day == 11);
		}

		public static bool IsWashingtonsBirthday(DateTime dateToEvaluate)
		{
			if (dateToEvaluate.Month == 2 && dateToEvaluate == GetOrdinalDayOfWeekForSpecificMonth(dateToEvaluate, DayOfWeek.Monday, 3))
				return true;

			return false;
		}

		public static bool IsLaborDay(DateTime dateToEvaluate)
		{
			if (dateToEvaluate.Month == 9 && dateToEvaluate == GetOrdinalDayOfWeekForSpecificMonth(dateToEvaluate, DayOfWeek.Monday, 1))
				return true;

			return false;
		}

		public static bool IsColumbusDay(DateTime dateToEvaluate)
		{
			if (dateToEvaluate.Month == 10 && dateToEvaluate == GetOrdinalDayOfWeekForSpecificMonth(dateToEvaluate, DayOfWeek.Monday, 2))
				return true;

			return false;
		}

		public static bool IsThanksgiving(DateTime dateToEvaluate)
		{
			if (dateToEvaluate.Month == 11 && dateToEvaluate == GetOrdinalDayOfWeekForSpecificMonth(dateToEvaluate, DayOfWeek.Thursday, 4))
				return true;

			return false;
		}

		public static bool IsGroundhogDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 2 && dateToEvaluate.Day == 2);
		}

		public static bool IsValentinesDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 2 && dateToEvaluate.Day == 14);
		}

		public static bool IsStPatricksDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 3 && dateToEvaluate.Day == 17);
		}

		public static bool IsAprilFoolsDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 4 && dateToEvaluate.Day == 1);
		}

		public static bool IsEarthDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 4 && dateToEvaluate.Day == 22);
		}

		public static bool IsMayDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 5 && dateToEvaluate.Day == 1);
		}

		public static bool IsCincoDeMayo(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 5 && dateToEvaluate.Day == 5);
		}

		public static bool IsMothersDay(DateTime dateToEvaluate)
		{
			if (dateToEvaluate.Month == 5 && dateToEvaluate == GetOrdinalDayOfWeekForSpecificMonth(dateToEvaluate, DayOfWeek.Sunday, 2))
				return true;

			return false;
		}

		public static bool IsFathersDay(DateTime dateToEvaluate)
		{
			if (dateToEvaluate.Month == 6 && dateToEvaluate == GetOrdinalDayOfWeekForSpecificMonth(dateToEvaluate, DayOfWeek.Sunday, 3))
				return true;

			return false;
		}

		public static bool IsFlagDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 6 && dateToEvaluate.Day == 14);
		}

		public static bool IsPatriotDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 9 && dateToEvaluate.Day == 11);
		}

		public static bool IsConstitutionCitizenshipDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 9 && dateToEvaluate.Day == 17);
		}

		public static bool IsLeifEriksonDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 10 && dateToEvaluate.Day == 9);
		}

		public static bool IsHalloween(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 10 && dateToEvaluate.Day == 31);
		}

		public static bool IsPearlHarborRemembranceDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 12 && dateToEvaluate.Day == 7);
		}
	}
}