using System;

namespace Capitulo11CSharpPOO.Polimorfismo
{
    public class Automovel : Veiculo
    {
        // Por que do ': base(tipoModelo)' no construtor de Automovel?
        // Simples, por que quando Herdamos de uma classe que também possui um construtor,
        // nós somos obrigados a 'construir' a classe pai passando os
        // parametros que o construtor dela espera
        public Automovel(string tipoModelo) : base(tipoModelo)
        { }

        // 'Override' significa 'Sobrescrever', neste caso abaixo estamos
        // Sobrescrevendo o comportamento da função herdada do PAI desta classe, no caso
        // se olharmos para o comportamento da função 'Mover' da classe pai veremos
        // que ela fara um 'Console.WriteLine("Acelerando o VEÍCULO");' mas como
        // estamos sobrescrevendo essa função, agora o novo comportamento da função 'Mover'
        // será 'Console.WriteLine("Acelerando o AUTOMOVEL");' e isto só é possivel
        // por que adicionamos a palavra 'override' na assinatura da função da classe filha (Automovel)
        // se removermos o override o código ainda compilara, porém receberemos um aviso de que
        // a função Mover da classe Automovel 'esconde' a função Mover da classe pai (Veiculo)
        // para corrigir isso teremos de adicionar novamente o 'override' na assinatura da função filha.
        // Este aviso seria algo como: "Olha só, a classe pai que vc está herdando já te entrega essa
        // ferramenta, do jeito que vc está fazendo vc está escondendo essa ferramenta, se vc quer mudar
        // o comportamento da ferramenta da classe pai, use a palavra 'override' na assinatura do seu método".

        // Mas por que usar o 'override' se SEM ele o código funciona como esperado?
        // Por que quando Herdamos props e comportamentos de uma outra classe, esperamos possuir
        // os mesmos comportamentos e props da classe PAI, quando queremos mudar algum comportamento,
        // 1º precisamos que a classe pai permita isso adicionando a palavra 'virtual' na assinatura do
        // método e 2º precisamos EXPLICITAR que estamos alterando o comportamento de um método herdado
        // usando a palavra 'override' na assinatura do método na classe filha
        public override void Mover()
        {
            Console.WriteLine("Acelerando o AUTOMOVEL");
        }

        public override void Parar()
        {
            Console.WriteLine("Parando o AUTOMOVEL.");
        }

        //Exemplo de 'Overload' (Sobrecarga) de método
        //Consiste em métodos com o mesmo nome, porém assinaturas diferentes (quantidade de parâmetros
        //e retornos possíveis). Fazemos isso com o objetivo de definir outra maneira de realizar a mesma operação.
        public void Parar(string comoParar)
        {
            Console.WriteLine("Parando o Automovel: " + comoParar);
        }
    }
}
