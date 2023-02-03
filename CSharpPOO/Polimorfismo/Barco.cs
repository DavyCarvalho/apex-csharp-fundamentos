using System;

namespace CSharpPOO.Polimorfismo
{
    public class Barco : Veiculo
    {
        public Barco(string tipoModelo) : base(tipoModelo)
        { 
        }

        public override void Mover()
        {
            Console.WriteLine("Acelerando BARCO");
        }

        public override void Parar()
        {
            Console.WriteLine("Atracando BARCO no porto.");
        }
    }
}
