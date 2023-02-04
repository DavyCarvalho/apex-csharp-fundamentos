namespace ExerciciosCapituloDoze.Exercicios.Exercicio22
{
    public interface IExercicio22
    {
        public int PrimeiroNumero { get; set; }
        public int SegundoNumero { get; set; }
        public int TerceiroNumero { get; set; }

        public int MaiorNumero { get; set; }
        public int NumeroIntermediario { get; set; }
        public int MenorNumero { get; set; }

        void ImprimirResposta();
    }
}
