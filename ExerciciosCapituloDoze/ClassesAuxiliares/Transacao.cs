namespace ExerciciosCapituloDoze.ClassesAuxiliares
{
    public class Transacao
    {
        public Transacao(string codigo, double valor)
        {
            Codigo = codigo;
            ValorDaTransacao = valor;
        }

        public string Codigo { get; set; }
        public double ValorDaTransacao { get; set; }
    }
}
