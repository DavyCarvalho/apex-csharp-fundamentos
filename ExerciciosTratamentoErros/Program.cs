using System;

namespace ExerciciosTratamentoErros
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite um número");
                var numero = int.Parse(Console.ReadLine());

                if (numero < 10)
                {
                    throw new ValorMuitoBaixoException("Ops, assim não é divertido");
                }
                else if (numero > 10000)
                {
                    throw new ValorMuitoAltoException("Ops, muita coisa - vai com calma");
                }

                for (int i = 0; i < numero; i++)
                {
                    Console.WriteLine(i);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("O valor não INT");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
