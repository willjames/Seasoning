using System;

namespace Seasoning
{
	public class EsSeasonUtilities : SeasonUtilities
	{
		public static bool IsStJosephsDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 3 && dateToEvaluate.Day == 19);
		}

		public static bool IsLabourDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 5 && dateToEvaluate.Day == 1);
		}

		public static bool IsAssumption(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 8 && dateToEvaluate.Day == 15);
		}

		public static bool IsFiesta(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 10 && dateToEvaluate.Day == 12);
		}

		public static bool IsAllSaintsDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 11 && dateToEvaluate.Day == 1);
		}

		public static bool IsConstitutionDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 12 && dateToEvaluate.Day == 6);
		}

		public static bool IsImmaculateConception(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 12 && dateToEvaluate.Day == 8);
		}
	}
}
