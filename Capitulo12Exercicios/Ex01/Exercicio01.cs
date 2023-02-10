using Capitulo12Exercicios.Ex01;
using System;

namespace Capitulo12Exercicios.Ex01
{
    public class Exercicio01 : IExercicio01
    {
        public double SalarioMin { get; set; }
        public int QuantidadeDeKWGastosPelaResidencia { get; set; }

        public Exercicio01(double salarioMinPassadoPeloUsuario, int quantidadeDeKwPassadaPeloUsuario)
        {
            SalarioMin = salarioMinPassadoPeloUsuario;
            QuantidadeDeKWGastosPelaResidencia = quantidadeDeKwPassadaPeloUsuario;
        }

        public void ImprimirValorEmReaisDeCadaKW()
        {
            double valorEmReaisDeCemKW = SalarioMin / 7;
            double valorDaUnidadeDeKW = valorEmReaisDeCemKW / 100;

            Console.WriteLine($"O valor é: R$ {Math.Round(valorDaUnidadeDeKW, 2)}");
        }

        public void ImprimirValorTotal()
        {
            double valorEmReaisDeCemKW = SalarioMin / 7;
            double valorDaUnidadeDeKW = valorEmReaisDeCemKW / 100;
            double valorTotalGastoPelaResidencia = QuantidadeDeKWGastosPelaResidencia * valorDaUnidadeDeKW;

            Console.WriteLine($"O valor total é: R$ {Math.Round(valorTotalGastoPelaResidencia, 2)}");
        }

        public void ImprimirValorTotal(double desconto)
        {
            double valorEmReaisDeCemKW = SalarioMin / 7;
            double valorDaUnidadeDeKW = valorEmReaisDeCemKW / 100;
            double valorTotalGastoPelaResidencia = QuantidadeDeKWGastosPelaResidencia * valorDaUnidadeDeKW;

            double valorDoDesconto = valorTotalGastoPelaResidencia * desconto / 100;
            double valorTotalGastoPelaResidenciaComDesconto = valorTotalGastoPelaResidencia - valorDoDesconto;

            Console.WriteLine($"O valor com desconto é: R$ {Math.Round(valorTotalGastoPelaResidenciaComDesconto, 2)}");
        }
    }
}