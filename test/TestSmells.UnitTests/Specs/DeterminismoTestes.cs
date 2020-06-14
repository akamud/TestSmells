using Bogus;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace TestSmells.UnitTests.Specs
{
    public class DeterminismoTestes
    {
        [Test]
        public void ÉVálidoDeveSerTrueSeDiaDaSemanaForSabadoOuDomingo()
        {
            var determinismo = new Determinismo();
            determinismo.DiaDaSemana = DateTime.UtcNow.DayOfWeek;
            
            determinismo.Validar();

            determinismo.ÉVálido.Should().BeTrue();
        }
        
        [Test]
        public void ÉVálidoDeveSerFalseSeDiaDaSemanaNãoForSábadoOuDomingo()
        {
            var determinismo = new Determinismo();
            determinismo.DiaDaSemana = new Faker().PickRandom<DayOfWeek>();
            
            determinismo.Validar();

            determinismo.ÉVálido.Should().BeFalse();
        }
    }
}