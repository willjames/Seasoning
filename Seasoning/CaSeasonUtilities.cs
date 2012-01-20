using System;
using Seasoning;

namespace Seasoning
{
	public class CaSeasonUtilities : SeasonUtilities
	{
		public static bool IsCanadaDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 7 && dateToEvaluate.Day == 1);
		}

		public static bool IsLabourDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 9 &&
			        dateToEvaluate == GetOrdinalDayOfWeekForSpecificMonth(dateToEvaluate, DayOfWeek.Monday, 1));
		}

		public static bool IsThanksgiving(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 10 &&
					dateToEvaluate == GetOrdinalDayOfWeekForSpecificMonth(dateToEvaluate, DayOfWeek.Monday, 2));
		}
	}
}