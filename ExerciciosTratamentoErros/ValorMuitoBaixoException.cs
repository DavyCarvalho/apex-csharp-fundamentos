using System;

namespace ExerciciosTratamentoErros
{
    class ValorMuitoBaixoException : Exception
    {
        public ValorMuitoBaixoException(string mensagemDeErro) : base(mensagemDeErro)
        {
        }
    }
}
