namespace CSharpPOO.Objetos
{
    // Como a classe Aluno está dentro do mesmo contexto da classe pessoa, (ambos estão detro do namespace 'CSharpPOO.Objetos')
    // não precisamos adicionar um 'using'
    public class Aluno : Pessoa
    {
        // Na linha 5 estamos dizendo que além das propriedades e comportamentos (métodos)
        // que a minha classe Aluno vai ter, ela tbm terá todas as props e comportamentos
        // contidos na Classe Pessoa
        public int NumeroMatricula { get; set; }
        public string CursoMatriculado { get; set; }
        public string Escola { get; set; }
    }
}
