namespace Capitulo11CSharpPOO.Interfaces
{
    // Enquanto as Classes são a definição das propriedades e comportamentos que a OBJETO deve ter
    // As interfaces definem as propriedades e comportamentos que o CLASSE deve ter
    public interface IVeiculo
    {
        public int Prop { get; set; }

        void Mover();

        void Parar();

        int CavalosDePotencia(bool eHTurbo);
    }
}
