using System;

namespace ExerciciosCapituloDoze.Exercicios.Exercicio03
{
    public class Exercicio3 : IExercicio3
    {
        public double ValorHoraAula { get; set; }
        public double NumeroDeAulas { get; set; }
        public double DescontoInss { get; set; }

        public Exercicio3(double valorHoraAula, double numeroDeAulas, double descontoInss)
        {
            ValorHoraAula = valorHoraAula;
            NumeroDeAulas = numeroDeAulas;
            DescontoInss = descontoInss;
        }

        public void ImprimirValorDoSalarioLiquido()
        {
            
        }
    }
}
