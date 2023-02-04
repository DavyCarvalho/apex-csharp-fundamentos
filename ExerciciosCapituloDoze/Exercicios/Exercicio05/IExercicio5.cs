namespace ExerciciosCapituloDoze.Exercicios.Exercicio05
{
    public interface IExercicio5
    {
        public double ValorConstanteAplicado { get; set; }
        public double ValorDaTaxa { get; set; }
        public int NumeroDeMeses { get; set; }
        
        void ImprimirRendimento();
    }
}
