using ExerciciosCapituloDoze.ClassesAuxiliares;
using System.Collections.Generic;

namespace ExerciciosCapituloDoze.Exercicios.Exercicio38
{
    public interface IExercicio38
    {
        public List<Transacao> Transacoes { get; set; }

        void ImprimirResposta();
    }
}
