using FluentAssertions;
using NUnit.Framework;
using System.Threading.Tasks;

namespace TestSmells.UnitTests.Specs
{
    public class DelayTestes
    {
        [Test]
        public async Task FazerChamadaDeveMudarEstáCarregandoParaTrue()
        {
            var delay = new Delay(new Dependencia());

            await delay.FazerChamada();

            delay.EstáCarregando.Should().BeTrue();
        }
    }
}