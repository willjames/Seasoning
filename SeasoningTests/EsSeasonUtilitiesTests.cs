using System;
using NUnit.Framework;
using Seasoning;

namespace SeasoningTests
{
	[TestFixture]
	public class EsSeasonUtilitiesTests
	{
		/*
		 * from 
		 * 
		 *	January 1		New Year's Day (national holiday)				Año Nuevo
			January 6		Epiphany										Día de Reyes/Epifanía del Señor
			March 19		St. Joseph's Day								San José
		 
			March or April	Maundy Thursday									Jueves Santo
			Good Friday		(national holiday)								Viernes Santo
			Easter Monday	Lunes de Pascua
		 
			May 1			Labour Day (national holiday)					Día del Trabajador
			August 15		Assumption (national holiday)					Asunción
			October 12		Fiesta Nacional de España (national holiday)	Fiesta Nacional de España
			November 1		All Saints Day (national holiday)				Día de todos los Santos
			December 6		Constitution Day (national holiday)				Día de la Constitución
			December 8		Immaculate Conception (national holiday)		Inmaculada Concepción
			December 25		Christmas Day (national holiday)				Navidad
		 */

		[Test]
		public void Should_return_true_for_IsStJosephsDay()
		{
			var dateToEvaluate = new DateTime(2011, 3, 19);
			Assert.That(EsSeasonUtilities.IsStJosephsDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsLabourDay()
		{
			var dateToEvaluate = new DateTime(2011, 5, 1);
			Assert.That(EsSeasonUtilities.IsLabourDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsAssumption()
		{
			var dateToEvaluate = new DateTime(2011, 8, 15);
			Assert.That(EsSeasonUtilities.IsAssumption(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsFiesta()
		{
			var dateToEvaluate = new DateTime(2011, 10, 12);
			Assert.That(EsSeasonUtilities.IsFiesta(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsAllSaintsDay()
		{
			var dateToEvaluate = new DateTime(2011, 11, 1);
			Assert.That(EsSeasonUtilities.IsAllSaintsDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsConstitutionDay()
		{
			var dateToEvaluate = new DateTime(2011, 12, 6);
			Assert.That(EsSeasonUtilities.IsConstitutionDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsImmaculateConception()
		{
			var dateToEvaluate = new DateTime(2011, 12, 8);
			Assert.That(EsSeasonUtilities.IsImmaculateConception(dateToEvaluate), Is.True);
		}
	}
}