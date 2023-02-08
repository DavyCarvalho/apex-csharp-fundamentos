using System.IO;
using System.Text;

namespace Capitulo14TrabalhandoComArquivosDeTexto
{
    public class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\davy.carvalho\source\repos\apex-csharp-fundamentos\CapituloQuatorze\ArquivoDeTexto.txt", Encoding.UTF8);
            while (!streamReader.EndOfStream)
            {
                string linha = streamReader.ReadLine();
                //Aqui, quando estamos em debug, visualizar o valor de cada linha do arquivo.
            }
        }
    }
}
