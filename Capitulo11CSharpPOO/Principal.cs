using Capitulo11CSharpPOO.Objetos;
using Capitulo11CSharpPOO.Polimorfismo;
//um Namespace é um contexto próprio fechado com suas ferramentas,
//exemplo disso é o System que contem ferramentas como a classe Console
//que tem diversas funçoes que vimos na aula passada, quando
//escrevemos "using (Nome do Namespace);" teremos a nossa disposição
//todas as ferramentas (classes) contidas dentro do namespace. Ex: Linhas 22-27
using System;

namespace Capitulo11CSharpPOO
{
    // Correção de fala da aula anterior:
    // É possível sim alterar o nome da classe Program, o que
    // não é permitido é alterar a assinatura do método Main => "static void Main(string[] args)"
    // se não ouver um método Main com essa exata assinatura o programa não ira compilar
    class Principal
    {
        static void Main(string[] args)
        {
            // Classes e Objetos - Início
            //Pessoa pessoa = new Pessoa();

            //pessoa.DiaNascimento = new DateTime(1992, 02, 23);
            //pessoa.Endereco = "Rua Lauro Muller 370";
            //pessoa.Nome = "Gustavo Rosaro";
            //pessoa.Idade = 27;

            //Todos os valores estarão vazios pois criamos um objeto do tipo pessoa,
            //mas nao atribuímos valores às suas propriedades
            //Console.WriteLine(pessoa.DiaNascimento);
            //Console.WriteLine(pessoa.Nome);
            //Console.WriteLine(pessoa.Idade);
            //Console.WriteLine(pessoa.Endereco);

            //pessoa.Cadastrar("Gustavo Rosauro", "Rua Lauro Muller 370", 27, new DateTime(1992, 02, 23));

            //Após cadastradas as informações do objeto podemos acessa-las
            //Console.WriteLine(pessoa.DiaNascimento);
            //Console.WriteLine(pessoa.Nome);
            //Console.WriteLine(pessoa.Idade);
            //Console.WriteLine(pessoa.Endereco);

            //Console.Read();

            // Classes e Objetos - Fim  

            // Herança - Início

            //Aluno aluno = new Aluno();

            // Como a classe Aluno herda tudo de pessoa, é possivel usarmos o método Cadastrar
            // contido na classe Pessoa

            //aluno.Cadastrar("Yuri da Silva", "Rua Itajaí, 5000", 24, new DateTime(1999, 02, 23));
            //aluno.Beber();
            //aluno.Comer();

            //aluno.Nome = "Yuri da Silva";
            //aluno.Endereco = "Rua Itajaí, 5000";
            //aluno.Idade = 24;
            //aluno.DiaNascimento = new DateTime(1999, 02, 23);
            //aluno.NumeroMatricula = 1234567;
            //aluno.CursoMatriculado = "C# Fundamentos";
            //aluno.Escola = "Apex";

            //Console.WriteLine(aluno.Nome);
            //Console.WriteLine(aluno.Endereco);
            //Console.WriteLine(aluno.Idade);
            //Console.WriteLine(aluno.DiaNascimento);
            //Console.WriteLine(aluno.NumeroMatricula);
            //Console.WriteLine(aluno.CursoMatriculado);
            //Console.WriteLine(aluno.Escola);

            // Herança - Fim

            //Polimorfismo - Início

            // Lembrando do vimos sobre vetores/arrays, vimos que eles apenas podem
            // conter valores do mesmo tipo, o código da linha abaixo não ira compilar 
            // pois string é != de int
            
            //int[] arrayDeNumeros = new int[] { 1,2,3, "texto" };

            // Já aqui criamos um array de 2 posições do tipo Veiculo,
            // e nas linhas 88 e 89 adicionamos 2 objetos ao nosso vetor,
            // mas como isso é possivel se nosso vetor aceita apenas objetos
            // do tipo Veiculo? Isso é possivel por que as classes Barco
            // e Automovel HERDAM todas as caracteriscas de Veiculo,
            // se removermos a herança de uma delas o código não ira compilar
            
            //Veiculo[] veiculo = new Veiculo[2];

            //veiculo[0] = new Automovel("BMW");
            //veiculo[1] = new Barco("Phantom");

            //MovimentarVeiculo(veiculo[0]);
            //MovimentarVeiculo(veiculo[1]);

            //Console.WriteLine("Pressione Enter para os veículos pararem. ");
            //Console.ReadLine();

            //PararVeiculo(veiculo[0]);
            //PararVeiculo(veiculo[1]);

            //Console.Read();

            //Automovel auto = new Automovel("Escort XR3");

            //Console.WriteLine("Criamos um novo Automóvel com um método Parar com sobrecarga!");
            //Console.WriteLine("Digite o modo como você deseja parar o Automovel.");
            //string modo = Console.ReadLine(); //Exemplo: "Muito depressa.".

            //auto.Parar(modo);

            //Console.Read();

            //Polimorfismo - Fim
        }

        // Linhas abaixo são sobre o tema 'Polimorfismo'

        // Outro ponto interessante é que ambas as funções abaixo
        // recebem um parametro do tipo Veiculo, porém quando chamamos
        // elas nas linhas 95, 96, 101 e 102 estamos passando objetos
        // de tipos diferentes de Veiculo, mas as funções aceitam
        // esses objetos por que ambos HERDAM as caracteriscas de Veiculo

        //public static void MovimentarVeiculo(Veiculo veiculo)
        //{
        //    Console.WriteLine(veiculo.TipoModelo);
        //    veiculo.Mover();
        //}

        //public static void PararVeiculo(Veiculo veiculo)
        //{
        //    Console.WriteLine(veiculo.TipoModelo);
        //    veiculo.Parar();
        //}

        // Linhas abaixo são sobre o tema 'Namespaces'

        //public void FuncaoQueUsaClassesDeOutroNamespace()
        //{
        //    var classe1 = new Class1();
        //    var classe2 = new Class2();
        //    var classe3 = new Class3();
        //}

        // Linhas acima são sobre o tema 'Namespaces'
    }
}

