using System;

namespace ExerciciosCapituloDoze.Exercicios.Exercicio02
{
    public class Exercicio2 : IExercicio2
    {
        public double ValorDoProduto { get; set; }

        public Exercicio2(double valorDoProduto)
        {
            ValorDoProduto = valorDoProduto;
        }

        public void ImprimirValorComDesconto()
        {
            double valorDoDesconto = ValorDoProduto * 9 / 100;

            Console.WriteLine($"O valor com desconto é: {Math.Round(ValorDoProduto - valorDoDesconto, 2)}");
        }
    }
}
