using System;

namespace Capitulo13TratamentoDeErros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite o primeiro numero");
                var primeiroNumero = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo numero");
                var segundoNumero = int.Parse(Console.ReadLine());

                var resposta = DividirPrimeiroPeloSegundo(primeiroNumero, segundoNumero);

                Console.WriteLine(resposta);
            }
            catch (DivideByZeroException objException)
            {
                Console.WriteLine("Opa, vc tentou dividir um numero por Zero");
                Console.WriteLine(objException.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Houve um erro");
            }
            finally
            {
                Console.WriteLine("Se não há mensagem de erro acima, deu tudo certo!");

                //throw new MinhaExcecao("Deu ruim!");
            }
        }

        static double DividirPrimeiroPeloSegundo(int primeiroNumero, int segundoNumero)
        {
            return primeiroNumero / segundoNumero;
        }
    }
}
