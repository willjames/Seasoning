using System;
using System.Collections.Generic;

namespace Seasoning
{
	public class UsSeasonUtilities : SeasonUtilities
	{
		public static bool IsMartinLutherKingBirthday(DateTime dateToEvaluate)
		{
			if (dateToEvaluate == GetNthDayOfWeekForSpecificMonth(dateToEvaluate, DayOfWeek.Monday, 3))
				return true;

			return false;
		}

		private static DateTime GetThirdMondayInJanuary(DateTime dateToEvaluate)
		{
			var listOfMondaysInJanuary = new List<int>();
			int daysinMonth = DateTime.DaysInMonth(dateToEvaluate.Year, dateToEvaluate.Month);

			var dateForIteration = new DateTime(dateToEvaluate.Year, dateToEvaluate.Month, 1);

			for (int i = 1; i<=daysinMonth; i++)
			{
				if (dateForIteration.DayOfWeek == DayOfWeek.Monday)
					listOfMondaysInJanuary.Add(i);

				dateForIteration = dateForIteration.AddDays(1);
			}

			return new DateTime(dateToEvaluate.Year, dateToEvaluate.Month, listOfMondaysInJanuary[2]);
		}
	}
}