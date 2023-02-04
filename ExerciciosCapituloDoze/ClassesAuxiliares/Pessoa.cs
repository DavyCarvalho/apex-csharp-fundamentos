namespace ExerciciosCapituloDoze.ClassesAuxiliares
{
    public class Pessoa
    {
        public int Idade { get; set; }
        public int AlturaEmCentimentros { get; set; }
        public double Peso { get; set; }
     
        public Pessoa(int idade, int alturaEmCentimentros, double peso)
        {
            Idade = idade;
            AlturaEmCentimentros = alturaEmCentimentros;
            Peso = peso;
        }

        public Pessoa(int idade, double peso)
        {
            Idade = idade;
            Peso = peso;
        }
    }
}
