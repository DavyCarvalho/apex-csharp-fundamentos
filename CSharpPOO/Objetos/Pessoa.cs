using System;

namespace CSharpPOO.Objetos
{
    public class Pessoa
    {
        // Construtores são declarados usando o mesmo nome da classe, no
        // exemplo temos a classe Pessoa e o 3 construtores, um vazio,
        // um que solicita valor de todas as props como parametro e um ultimo
        // que solicita apenas o nome e idade.
        // O uso de construtores é uma das maneiras usadas para atribuir
        // valores a propriedades da classe no momento de criação de um objeto.
        // Toda classe no C# por padrão já possui um construtor vazio
        // (sem atribuição de valores a props), então não é necessário
        // fazer a declaração abaixo caso não existam outros construtores.
        // A partir do momento que criamos um construtor que espara N parâmetros o C#
        // entenderá que esse é novo construtor padrão e toda vez que formos criar
        // um novo objeto seremos obrigados a passar os parametros do construtor existente.
        public Pessoa() //Apagar este construtor e notar erro na classe 'Principal'
        {
        }

        // Um objeto criado a partir de uma classe com um construtor
        // vazio é declarado da seguinte maneira:

        // Pessoa objetoDePessoa = new Pessoa(); 
        
        // Perceba que não passamos valor algum para o construtor, note a
        // diferença no exemplo abaixo.

        public Pessoa(string nome, string endereco, int idade, DateTime diaNascimento)
        {
            Nome = nome;
            Endereco = endereco;
            Idade = idade;
            DiaNascimento = diaNascimento;
        }

        // Para criar um objeto a partir do construtor acima será nescessário
        // prover o valor de todos os parametros da seguinte maneira:

        // Pessoa objetoDePessoa = new Pessoa("Nome", "Endereço", 99, new DateTime(1999, 11, 01));

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        // Para criar um objeto a partir do construtor acima será nescessário
        // prover APENAS o valor do nome e da idade da seguinte maneira:

        // Pessoa objetoDePessoa = new Pessoa("Nome", 99);

        // Ao adicionarmos a palavra 'private' aos 'set' das nossas propriedades
        // estamos dizendo que apenas a Classe pode alterar os valores das propriedades
        // não poderemos alterar os valores livremente pela notação ponto
        // (algo como 'objeto.prop = umValorQualquer' não será possivel)

        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public int Idade { get; private set; }
        public DateTime DiaNascimento { get; private set; }

        //public string Nome { get; set; }
        //public string Endereco { get; set; }
        //public int Idade { get; set; }
        //public DateTime DiaNascimento { get; set; }

        public void Cadastrar(string nome, string endereco, int idade, DateTime nascimento)
        {
            Nome = nome;
            Endereco = endereco;
            Idade= idade;
            DiaNascimento = nascimento;
        }

        //public Pessoa Cadastrar(string _nome, string _endereco, int _idade, DateTime _diaNascimento)
        //{
        //    this.DiaNascimento = _diaNascimento;
        //    this.Endereco = _endereco;
        //    this.Nome = _nome;
        //    this.Idade = _idade;

        //    return this;
        //}

        //public void Beber()
        //{ }

        //public void Comer()
        //{ }

        //public void Andar()
        //{
        //}
    }
}
