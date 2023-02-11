using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Capitulo14TrabalhandoComArquivosDeTexto
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Ler arquivo - Inicio
            //var streamReader =
            //    new StreamReader(@"C:\repos\apex-csharp-fundamentos\Capitulo14TrabalhandoComArquivosDeTexto\Text.txt", Encoding.UTF8);

            //while (!streamReader.EndOfStream)
            //{
                //var linha = streamReader.ReadLine();

                //Console.WriteLine(linha);
            //}
            //Ler arquivo - Fim

            //Escrever arquivo - Inicio
            //var streamWriter = new StreamWriter(@"C:\repos\apex-csharp-fundamentos\Capitulo14TrabalhandoComArquivosDeTexto\ArquivoDeTexto.txt");

            //streamWriter.AutoFlush = true;

            //var conteudo = "esse é o conteudo do meu novo arquivo";

            //streamWriter.Write(conteudo);

            //streamWriter.Close();
            //Escrever arquivo - Fim

            //Exercicios Capitulo 14

            var leitor = new StreamReader(@"C:\repos\apex-csharp-fundamentos\Capitulo14TrabalhandoComArquivosDeTexto\Input\Alunos Interessados.txt", Encoding.UTF8);

            var listaDeLinhas = new List<string>();

            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();

                listaDeLinhas.Add(linha);
            }

            listaDeLinhas.Sort();

            var escritor = new StreamWriter(@"C:\repos\apex-csharp-fundamentos\Capitulo14TrabalhandoComArquivosDeTexto\Output\Feito.txt");

            escritor.AutoFlush = true;

            //for (int i = 0; i < listaDeLinhas.Count; i++)
            //{
            //    escritor.Write(listaDeLinhas[i]);
            //}

            foreach (var linha in listaDeLinhas)
            {
                escritor.Write($"{linha}\n");
            }

            escritor.Close();

            Console.WriteLine("Finalizou");
        }
    }
}
