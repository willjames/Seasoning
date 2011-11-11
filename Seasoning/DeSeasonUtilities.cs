using System;

namespace Seasoning
{
	public class DeSeasonUtilities : SeasonUtilities
	{
		public static bool IsEpiphany(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 1 && dateToEvaluate.Day >= 6);
		}

		public static bool IsLabourDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 5 && dateToEvaluate.Day >= 1);
		}

		public static bool IsAscensionDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Date == EasterSunday(dateToEvaluate.Year).AddDays(39));
		}

		public static bool IsWhitMonday(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Date == EasterSunday(dateToEvaluate.Year).AddDays(50));
		}

		public static bool IsCorpusChristi(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Date == EasterSunday(dateToEvaluate.Year).AddDays(60));
		}

		public static bool IsPeaceFestival(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 8 && dateToEvaluate.Day == 8);
		}

		public static bool IsAssumptionDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 8 && dateToEvaluate.Day == 15);
		}

		public static bool IsGermanUnityDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 10 && dateToEvaluate.Day == 3);
		}

		public static bool IsReformationDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 10 && dateToEvaluate.Day == 31);
		}

		public static bool IsAllSaints(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 11 && dateToEvaluate.Day == 1);
		}

	}
}
