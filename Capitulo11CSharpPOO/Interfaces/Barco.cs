using System;

namespace Capitulo11CSharpPOO.Interfaces
{
    // Como a classe Barco herda da interface IVeiculo, ela é OBRIGADA a implementar todos
    // os métodos e propriedades que existam na interface IVeiculo
    // *Remover um dos métodos da classe barco para notar a mensagem de erro!
    // *Adicionar mais uma assinatura de método e uma nova propriedade na interface IVeiculo
    // e notar a mensagem de erro na classe Barco!
    public class Barco : IVeiculo
    {
        public void Mover()
        {
            Console.WriteLine("O barco está se movendo!");
        }

        public void Parar()
        {
            Console.WriteLine("O barco está parando!");
        }
    }
}
