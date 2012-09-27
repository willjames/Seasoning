using System;
using NUnit.Framework;
using Seasoning;

namespace SeasoningTests
{
	[TestFixture]
	public class PtTests
	{
		/*
		 * from http://en.wikipedia.org/wiki/Public_holidays_in_Portugal
		 * 
			moveable	Carnival					Carnaval	Carnival in Portugal as is the Carnival of Madeira is an annual festival, 
		 *											that ends on Shrove Tuesday (called Fat Tuesday in Madeira - Terça-feira Gorda in Portuguese) 
		 *											the day before Ash Wednesday (first day of Lent). This is an optional holiday, although it is usually observed. 
		 *											47 days before Easter Sunday.

			moveable	Good Friday						Sexta-feira Santa	Friday before Easter Sunday
			moveable	Easter							Páscoa					Sunday, date varies. *
			moveable	Corpus Christi (feast)			Corpo de Deus	Thursday, date varies. 60 days after Easter Sunday. It is religion based.

			1 January	New Year's Day				Ano Novo	
			* 25 April	Freedom Day						Dia da Liberdade	Celebrates the 1974 Revolution that ended the Dictatorship and started Democracy
			* 1 May		Labor Day						Dia do Trabalhador	Similar to Labor Day in the States.
			* 10 June		Portugal Day					Dia de Portugal, de Camões e das Comunidades Portuguesas	National Day
			* 15 August	Assumption						Assunção de Nossa Senhora	A religious account of the taking up of Mary into heaven.
			* 5 October	Republic Day					Implantação da República	Celebrates the end of Monarchy and the beginning of the Portuguese Republic
			* 1 November	All Saints Day					Todos os Santos	In terms of Western Christian theology, the feast commemorates all those who have attained the beatific vision in heaven.
			* 1 December	Restoration of Independence		Restauração da Independência	Celebrates the end of the Iberian Union (1580–1640)
			* 8 December	Immaculate Conception			Imaculada Conceição	According to Roman Catholic Dogma, the conception of the Virgin Mary without any stain of original sin
			25 December	Christmas Day					Natal	
		 */

		[Test]
		public void Should_return_true_for_IsCarnival()
		{
			var dateToEvaluate = new DateTime(2011, 3, 8);

			Assert.That(Pt.IsCarnival(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsFreedomDay()
		{
			var dateToEvaluate = new DateTime(2011, 4, 25);

			Assert.That(Pt.IsFreedomDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsLabourDay()
		{
			var dateToEvaluate = new DateTime(2011, 5, 1);

			Assert.That(Pt.IsLabourDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsPortugalDay()
		{
			var dateToEvaluate = new DateTime(2011, 6, 10);

			Assert.That(Pt.IsPortugalDay(dateToEvaluate), Is.True);
		}

		public void Should_return_true_for_IsAssumption()
		{
			var dateToEvaluate = new DateTime(2011, 8, 15);

			Assert.That(Pt.IsAssumption(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsRepublicDay()
		{
			var dateToEvaluate = new DateTime(2011, 10, 5);

			Assert.That(Pt.IsRepublicDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsAllSaintsDay()
		{
			var dateToEvaluate = new DateTime(2011, 11, 1);

			Assert.That(Pt.IsAllSaintsDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsRestorationOfIndependenceDay()
		{
			var dateToEvaluate = new DateTime(2011, 12, 1);

			Assert.That(Pt.IsRestorationOfIndependenceDay(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsImmaculateConception()
		{
			var dateToEvaluate = new DateTime(2011, 12, 8);

			Assert.That(Pt.IsImmaculateConception(dateToEvaluate), Is.True);
		}

		[Test]
		public void Should_return_true_for_IsCorpusChristi()
		{
			var dateToEvaluate = SeasonUtilities.EasterSunday(2011).AddDays(60);

			Assert.That(Pt.IsCorpusChristi(dateToEvaluate), Is.True);
		}

	}
}