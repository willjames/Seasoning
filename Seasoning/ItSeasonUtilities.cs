using System;

namespace Seasoning
{
	public class ItSeasonUtilities : SeasonUtilities
	{
		public static bool IsNationalDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 3 && dateToEvaluate.Day == 17);
		}

		public static bool IsEpiphany(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 1 && dateToEvaluate.Day == 6);
		}

		public static bool IsAnniversaryOfLiberation(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 4 && dateToEvaluate.Day == 25);
		}

		public static bool IsLabourDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 5 && dateToEvaluate.Day == 1);
		}

		public static bool IsRepublicDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 6 && dateToEvaluate.Day == 2);
		}

		public static bool IsAssumptionDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 8 && dateToEvaluate.Day == 15);
		}

		public static bool IsImmaculateConception(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 12 && dateToEvaluate.Day == 8);
		}

		public static bool IsAllSaintsDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 11 && dateToEvaluate.Day == 1);
		}
	}
}