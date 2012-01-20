using System;

namespace Seasoning
{
	public class PtSeasonUtilities : SeasonUtilities
	{
		public static bool IsFreedomDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 4 && dateToEvaluate.Day == 25);
		}

		public static bool IsLabourDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 5 && dateToEvaluate.Day == 1);
		}

		public static bool IsPortugalDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 6 && dateToEvaluate.Day == 10);
		}

		public static bool IsAssumption(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 8 && dateToEvaluate.Day == 15);
		}

		public static bool IsRepublicDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 10 && dateToEvaluate.Day == 5);
		}

		public static bool IsAllSaintsDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 11 && dateToEvaluate.Day == 1);
		}

		public static bool IsRestorationOfIndependenceDay(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 12 && dateToEvaluate.Day == 1);
		}

		public static bool IsImmaculateConception(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Month == 12 && dateToEvaluate.Day == 8);
		}

		public static bool IsCarnival(DateTime dateToEvaluate)
		{
			// carnival lasts 2 days and finishes on Shrove Tuesday
			var easterSunday = EasterSunday(dateToEvaluate.Year);
			var shroveTuesday = easterSunday.AddDays(-47);

			return ((dateToEvaluate.Day == shroveTuesday.Day || dateToEvaluate.Day == shroveTuesday.Day-1) && dateToEvaluate.Month == shroveTuesday.Month); 
		}

		public static bool IsCorpusChristi(DateTime dateToEvaluate)
		{
			return (dateToEvaluate.Date == EasterSunday(dateToEvaluate.Year).AddDays(60));
		}
	}
}