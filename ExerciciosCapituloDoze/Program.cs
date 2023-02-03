namespace ExerciciosCapituloDoze
{
    public class Program
    {
        static void Main(string[] args)
        {
            Exercicio1 exercicio1 = new Exercicio1(1210.10, 1000);

            exercicio1.GetValorPorCadaKw();
            exercicio1.GetValorTotalASerPago();
            exercicio1.GetValorTotalASerPago(10);
        }
    }
}
