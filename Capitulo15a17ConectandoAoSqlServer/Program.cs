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

                Console.WriteLine("Inserção executada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            //Inserção de dados - Fim

            //Atualização de dados - Início

            try
            {
                connection.Open();

                var idDoRegistroQueSeraAtualizado = 2;
                var novoValorDaColunaDescricao = "Carro";
                var novoValorDaColunaQuantidade = 800;
                var comandoSqlDeAtualizacaoDeProduto = @"UPDATE Produto
                                                        SET Descricao = @novoValorDaColunaDescricao,
                                                            Quantidade = @novoValorDaColunaQuantidade
                                                        WHERE Id = @idDoRegistroQueSeraAtualizado";

                var comando = new SqlCommand(comandoSqlDeAtualizacaoDeProduto, connection);

                comando.Parameters.AddWithValue("@novoValorDaColunaDescricao", novoValorDaColunaDescricao);
                comando.Parameters.AddWithValue("@novoValorDaColunaQuantidade", novoValorDaColunaQuantidade);
                comando.Parameters.AddWithValue("@idDoRegistroQueSeraAtualizado", idDoRegistroQueSeraAtualizado);

                comando.ExecuteNonQuery();

                Console.WriteLine("Ação de Atualização executada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            //Atualização de dados - Fim

            //Exclusão de dados - Início

            try
            {
                connection.Open();

                var idDoRegistroQueSeraApagado = 3;
                var comandoSqlDeExclusao = "DELETE FROM Produto WHERE Id = @idDoRegistroQueSeraApagado";

                var comando = new SqlCommand(comandoSqlDeExclusao, connection);

                comando.Parameters.AddWithValue("@idDoRegistroQueSeraApagado", idDoRegistroQueSeraApagado);

                comando.ExecuteNonQuery();
                Console.WriteLine("Ação de Exclusão executada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            //Exclusão de dados - Fim

            //Leitura de dados EXTRA - Início
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
                    var descricaoDoRegistro = linhasRetornadasDaQuery["Descricao"].ToString();
                    var quantidadeDoRegistro = Convert.ToInt32(linhasRetornadasDaQuery["Quantidade"]);

                    var objetoDeProduto = new Produto(idDoRegistro, descricaoDoRegistro, quantidadeDoRegistro);

                    Console.WriteLine($"O Id do registro é: {objetoDeProduto.Id}");
                    Console.WriteLine($"A descrição do registro é: {objetoDeProduto.Descricao}");
                    Console.WriteLine($"A quantidade do registro é: {objetoDeProduto.Quantidade}");
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
            //Leitura de dados EXTRA - Fim
        }
    }

    class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }

        public Produto(int id, string descricao, int quantidade)
        {
            Id = id;
            Descricao = descricao;
            Quantidade = quantidade;
        }
    }
}
