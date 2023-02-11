using System;
using System.Data.SqlClient;

namespace CapituloQuinzeConectandoAoSqlServer
{
    class Program
    {
        const string stringDeConexao = @"Server=localhost\SQLEXPRESS;Database=Ex016;Trusted_Connection=True;";

        static void Main(string[] args)
        {
            var connection = new SqlConnection(stringDeConexao);

            //Leitura de dados - Inicio
            try
            {
                connection.Open();
                Console.WriteLine("A conexão foi aberta com sucesso");

                var comandoSqlDeLeitura = "SELECT * FROM Produto ORDER BY Id DESC";

                var comando = new SqlCommand(comandoSqlDeLeitura, connection);

                var linhasRetornadasDaQuery = comando.ExecuteReader();

                while (linhasRetornadasDaQuery.Read())
                {
                    var idDoRegistro = Convert.ToInt32(linhasRetornadasDaQuery["Id"]);
                    var descricaoDoRegistro = linhasRetornadasDaQuery["Descricao"];
                    var quantidadeDoRegistro = Convert.ToInt32(linhasRetornadasDaQuery["Quantidade"]);

                    Console.WriteLine($"O Id do registro é: {idDoRegistro}");
                    Console.WriteLine($"A descrição do registro é: {descricaoDoRegistro}");
                    Console.WriteLine($"A quantidade do registro é: {quantidadeDoRegistro}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            //Leitura de dados - Fim

            //Inserção de dados - Início
            try
            {
                connection.Open();

                var descricaoDoNovoProduto = "Maçã";
                var quantidadeDoNovoProduto = 500;

                var comandoSqlDeCriacaoDeProduto = @"INSERT INTO Produto VALUES
                                                     (@descricaoDoNovoProduto, @quantidadeDoNovoProduto)";

                var comando = new SqlCommand(comandoSqlDeCriacaoDeProduto, connection);

                comando.Parameters.AddWithValue("@descricaoDoNovoProduto", descricaoDoNovoProduto);
                comando.Parameters.AddWithValue("@quantidadeDoNovoProduto", quantidadeDoNovoProduto);

                comando.ExecuteNonQuery();

                Console.WriteLine("");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
