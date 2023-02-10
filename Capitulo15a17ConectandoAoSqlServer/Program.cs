using System;
using System.Data.SqlClient;

namespace CapituloQuinzeConectandoAoSqlServer
{
    class Program
    {
        const string stringDeConexao = @"Server=localhost\SQLEXPRESS;Database=Ex16;Trusted_Connection=True;";

        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection(stringDeConexao);
            
            //Leitura de Dados - Início

            try
            {
                connection.Open();
                Console.WriteLine("Conexão com o Banco de Dados aberta com sucesso!\n");

                string comandoSqlParaSelecionar = @"SELECT * FROM Produto ORDER BY Descricao";

                SqlCommand command = new SqlCommand(comandoSqlParaSelecionar, connection);
                SqlDataReader linhasRetornadasDaQuery = command.ExecuteReader();

                while (linhasRetornadasDaQuery.Read())
                {
                    int idDoProduto = Convert.ToInt32(linhasRetornadasDaQuery["ID"]);
                    string descricaoDoProduto = linhasRetornadasDaQuery["DESCRICAO"].ToString();
                    int quantidadeDoProduto = Convert.ToInt32(linhasRetornadasDaQuery["QUANTIDADE"]);

                    Produto objetoDeProduto = new Produto(idDoProduto, descricaoDoProduto, quantidadeDoProduto);

                    Console.WriteLine($"O Id do Produto é {objetoDeProduto.Id}");
                    Console.WriteLine($"A Quantidade do Produto é {objetoDeProduto.Quantidade}");
                    Console.WriteLine($"A Descrição do Produto é {objetoDeProduto.Descricao}\n");
                }

                Console.WriteLine("Ação de Leitura executada com sucesso! Pressione ENTER para seguir.");
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Ocorreu um erro ao abrir a conexão com o Banco de Dados");
            }
            finally
            {
                connection.Close();
                Console.WriteLine("Conexão com o Banco de Dados fechada com sucesso!");
            }

            //Leitura de dados - Fim

            //Inserção de dados - Início

            try
            {
                connection.Open();

                string descricao = "Banana";
                int quantidade = 10;
                string comandoSqlParaInserir = @"INSERT INTO Produto (Descricao, Quantidade) VALUES (@descricao, @quantidade)";

                SqlCommand command = new SqlCommand(comandoSqlParaInserir, connection);

                command.Parameters.AddWithValue("@descricao", descricao);
                command.Parameters.AddWithValue("@quantidade", quantidade);

                command.ExecuteNonQuery();

                Console.WriteLine("Ação de Inserção executada com sucesso! Pressione ENTER para seguir.");
                Console.ReadLine();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
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

                string novaDescricao = "Caju";
                int idDoRegistroQueSeraAtualizado = 2;
                string comandoSqlParaAtualizarDescricao = @"UPDATE Produto 
                                                            SET Descricao = @novaDescricao 
                                                            WHERE Id = @idDoRegistroQueSeraAtualizado";

                SqlCommand command = new SqlCommand(comandoSqlParaAtualizarDescricao, connection);

                command.Parameters.AddWithValue("@novaDescricao", novaDescricao);
                command.Parameters.AddWithValue("@idDoRegistroQueSeraAtualizado", idDoRegistroQueSeraAtualizado);

                command.ExecuteNonQuery();

                Console.WriteLine("Ação de Atualização executada com sucesso! Pressione ENTER para seguir.");
                Console.ReadLine();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
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

                int idDoRegistroASerApagado = 1;
                string comandoSqlApagarUmRegistro = @"DELETE FROM Produto WHERE Id = @idDoRegistroASerApagado";

                SqlCommand command = new SqlCommand(comandoSqlApagarUmRegistro, connection);

                command.Parameters.AddWithValue("@idDoRegistroASerApagado", idDoRegistroASerApagado);

                command.ExecuteNonQuery();

                Console.WriteLine("Ação de Exclusão executada com sucesso! Pressione ENTER para finalizar.");
                Console.ReadLine();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                connection.Close();
            }

            //Exclusão de dados - Fim
        }
    }

    class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Quantidade { get; set; }

        public Produto(int id, string descricao, decimal quantidade)
        {
            Id = id;
            Descricao = descricao;
            Quantidade = quantidade;
        }
    }
}
