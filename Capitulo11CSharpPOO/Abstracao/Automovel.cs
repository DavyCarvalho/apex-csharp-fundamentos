using System;

namespace Capitulo11CSharpPOO.Abstracao
{
    public class Automovel : Veiculo
    {
        public Automovel(string tipoModelo) : base(tipoModelo)
        { }

        public override void Mover()
        {
            Console.WriteLine("Acelerando o AUTOMOVEL");
        }

        public override void Parar()
        {
            Console.WriteLine("Parando o AUTOMOVEL.");
        }
    }
}
