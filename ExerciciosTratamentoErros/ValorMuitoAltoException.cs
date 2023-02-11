using System;

namespace ExerciciosTratamentoErros
{
    class ValorMuitoAltoException : Exception
    {
        public ValorMuitoAltoException(string msgDeErro) : base(msgDeErro)
        {
        }
    }
}
