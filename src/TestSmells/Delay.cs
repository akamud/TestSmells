using System.Threading.Tasks;

namespace TestSmells
{
    public interface IDependencia
    {
        Task Chamada();
    }

    public class Dependencia : IDependencia
    {
        public async Task Chamada()
        {
            await Task.Yield();
        }
    }
    
    public class Delay
    {
        private readonly IDependencia _dependencia;
        public bool EstáCarregando { get; set; }
        
        public Delay(IDependencia dependencia)
        {
            _dependencia = dependencia;
        }
        
        public async Task FazerChamada()
        {
            EstáCarregando = true;

            await _dependencia.Chamada();
            await Task.Delay(5000);
        }
    }
}