using System;

namespace Capitulo11CSharpPOO.Polimorfismo
{
    public class Veiculo
    {
        public string TipoModelo { get; private set; }

        public Veiculo(string tipoModelo)
        {
            TipoModelo = tipoModelo;
        }

        public virtual void Mover()
        {
            Console.WriteLine("Acelerando o VEÍCULO!");
        }
        public virtual void Parar()
        {
            Console.WriteLine("Parando o VEÍCULO!");
        }
    }
}
