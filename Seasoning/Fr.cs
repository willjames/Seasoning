using System;

namespace Seasoning
{
	public class Fr : SeasonUtilities
	{
		public static bool IsLabourDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 5 && dateToEvaluate.Day == 1);
		}

		public static bool IsVEDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 5 && dateToEvaluate.Day == 8);
		}

		public static bool IsAscensionDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 5 && dateToEvaluate.Day == 17);
		}

		public static bool IsPentecost(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 5 && dateToEvaluate.Day == 28);
		}

		public static bool IsFeteNational(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 7 && dateToEvaluate.Day == 14);
		}

		public static bool IsAssumption(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 8 && dateToEvaluate.Day == 15);
		}

		public static bool IsAllSaintsDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 11 && dateToEvaluate.Day == 1);
		}

		public static bool IsArmisticeDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 11 && dateToEvaluate.Day == 11);
		}
	}
}
