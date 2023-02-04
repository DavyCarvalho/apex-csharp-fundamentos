using System;

namespace ExerciciosCapituloDoze.Exercicios.Exercicio01
{
    public class Exercicio1 : IExercicio1
    {
        public double SalarioMin { get; set; }
        public int QuantidadeDeKW { get; set; }

        public Exercicio1(double salarioMin, int quantidadeDeKW)
        {
            SalarioMin = salarioMin;
            QuantidadeDeKW = quantidadeDeKW;
        }

        public void ImprimirValorPorCadaKw()
        {
            double valorDeCemWattsDeEnergia = SalarioMin / 7;
            double valorDeUmWattDeEnergia = valorDeCemWattsDeEnergia / 100;

            Console.WriteLine($"O valor de cada Watt é: R$ {Math.Round(valorDeUmWattDeEnergia, 2)}");
        }

        public void ImprimirValorTotalASerPago()
        {
            double valorDeCemWattsDeEnergia = SalarioMin / 7;
            double valorDeUmWattDeEnergia = valorDeCemWattsDeEnergia / 100;
            double valorTotal = valorDeUmWattDeEnergia * QuantidadeDeKW;

            Console.WriteLine($"O valor total a ser pago é: R$ {Math.Round(valorTotal, 2)}");
        }

        public void ImprimirValorTotalASerPago(int desconto)
        {
            double valorDeCemWattsDeEnergia = SalarioMin / 7;
            double valorDeUmWattDeEnergia = valorDeCemWattsDeEnergia / 100;
            double valorTotal = valorDeUmWattDeEnergia * QuantidadeDeKW;
            double valorDoDesconto = valorTotal * desconto / 100;
            double valorComDesconto = valorTotal - valorDoDesconto;

            Console.WriteLine($"O valor total a ser pago com desconto de {desconto}% é: R$ {Math.Round(valorComDesconto, 2)}");
        }
    }
}
