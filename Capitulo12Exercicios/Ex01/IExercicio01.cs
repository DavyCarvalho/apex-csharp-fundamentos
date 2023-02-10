namespace Capitulo12Exercicios.Ex01
{
    public interface IExercicio01
    {
        public double SalarioMin { get; set; }
        public int QuantidadeDeKWGastosPelaResidencia { get; set; }

        void ImprimirValorEmReaisDeCadaKW();
        void ImprimirValorTotal();
        void ImprimirValorTotal(double desconto);
    }
}