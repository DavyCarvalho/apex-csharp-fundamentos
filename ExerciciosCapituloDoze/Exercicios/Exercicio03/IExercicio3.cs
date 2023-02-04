namespace ExerciciosCapituloDoze.Exercicios.Exercicio03
{
    public interface IExercicio3
    {
        public double ValorHoraAula { get; set; }
        public double NumeroDeAulas { get; set; }
        public double DescontoInss { get; set; }

        void ImprimirValorDoSalarioLiquido();
    }
}
