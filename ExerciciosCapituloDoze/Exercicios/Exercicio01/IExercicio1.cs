namespace ExerciciosCapituloDoze.Exercicios.Exercicio01
{
    public interface IExercicio1
    {
        public double SalarioMin { get; set; }
        public int QuantidadeDeKW { get; set; }

        void ImprimirValorPorCadaKw();
        void ImprimirValorTotalASerPago();
        void ImprimirValorTotalASerPago(int desconto);
    }
}
