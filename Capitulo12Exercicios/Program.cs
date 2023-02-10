using Capitulo12Exercicios.Ex01;
using System;

namespace Capitulo12Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios Capitulo 12");

            Console.WriteLine("Ex. 01\n");

            Console.WriteLine("Digite o valor do Salario Minimo:");
            double valorDoSalarioMin = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de KW gasto pela residencia:");
            int KWgastosPelaResidencia = int.Parse(Console.ReadLine());

            Exercicio01 objetoDoExercicio01 = new Exercicio01(valorDoSalarioMin, KWgastosPelaResidencia);

            objetoDoExercicio01.ImprimirValorEmReaisDeCadaKW();
            objetoDoExercicio01.ImprimirValorTotal();
            objetoDoExercicio01.ImprimirValorTotal(10);

            Console.WriteLine("Ex. 02\n");
        }
    }
}