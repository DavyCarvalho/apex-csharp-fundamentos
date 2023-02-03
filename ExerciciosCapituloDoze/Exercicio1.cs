using System;

namespace ExerciciosCapituloDoze
{

    // 1. Antes do racionamento de energia ser decretado, quase ninguém falava em quilowatts;
    // mas, agora, todos incorporaram essa palavra em seu vocabulário. Sabendo-se que 100 quilowatts
    // de energia custa um sétimo do salário mínimo, fazer um algoritmo que receba o valor do
    // salário mínimo e a quantidade de quilowatts gasta por uma residência e calcule e imprima:
    // • O valor em reais de cada quilowatt
    // • O valor em reais a ser pago
    // • O novo valor a ser pago por essa residência com um desconto de 10%

    public class Exercicio1
    {
        public double SalarioMin { get; set; }
        public int QuantidadeDeKW { get; set; }
        
        public Exercicio1(double salarioMin, int quantidadeDeKW)
        {
            SalarioMin = salarioMin;
            QuantidadeDeKW = quantidadeDeKW;
        }

        public void GetValorPorCadaKw()
        {
            double valorDeCemWattsDeEnergia = SalarioMin / 7;
            double valorDeUmWattDeEnergia = valorDeCemWattsDeEnergia / 100;

            Console.WriteLine($"O valor de cada Watt é: R$ {Math.Round(valorDeUmWattDeEnergia, 2)}");
        }

        public void GetValorTotalASerPago()
        {
            double valorDeCemWattsDeEnergia = SalarioMin / 7;
            double valorDeUmWattDeEnergia = valorDeCemWattsDeEnergia / 100;
            double valorTotal = valorDeUmWattDeEnergia * QuantidadeDeKW;

            Console.WriteLine($"O valor total a ser pago é: R$ {Math.Round(valorTotal, 2)}");
        }

        public void GetValorTotalASerPago(int desconto)
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
