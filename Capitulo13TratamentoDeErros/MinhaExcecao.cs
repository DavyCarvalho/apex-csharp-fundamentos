using System;

namespace Capitulo13TratamentoDeErros
{
    public class MinhaExcecao : Exception
    {
        public MinhaExcecao(string mensagemDeErro) : base(mensagemDeErro)
        {
        }
    }
}
