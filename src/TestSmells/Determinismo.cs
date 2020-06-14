using System;

namespace TestSmells
{
    public class Determinismo
    {
        public bool ÉVálido { get; set; }

        public DayOfWeek DiaDaSemana { get; set; }

        public void Validar()
        {
            ÉVálido = DiaDaSemana == DayOfWeek.Saturday || DiaDaSemana == DayOfWeek.Sunday;
        }
    }
}