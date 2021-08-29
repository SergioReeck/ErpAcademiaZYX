using Entities;
using Entities.Enum;
using Entities.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProdutoDAL : IProduto
    {
        private SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING);

        public DataResponse<Produto> GetAll()
        {
            SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM PRODUTOS ORDER BY ID";

            DataResponse<Produto> response = new DataResponse<Produto>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Produto> produtos = new List<Produto>();
                while (reader.Read())
                {
                    Produto produto = new Produto();
                    produto.ID = Convert.ToInt32(reader["ID"]);
                    produto.Descricao = Convert.ToString(reader["DESCRICAO"]);
                    produto.Categoria = (Categoria)reader["CATEGORIA"];
                    produto.ValorVenda = Convert.ToDouble(reader["VALORVENDA"]);
                    produto.Estoque = Convert.ToInt32(reader["ESTOQUE"]);
                    
                    produtos.Add(produto);
                }
                response.Success = true;
                response.Message = "Dados selecionados com sucesso.";
                response.Data = produtos;
                return response;
            }
            catch (Exception)
            {
                response.Success = false; response.Message = "Erro no banco de dados contate o suporte.";
                response.Data = new List<Produto>();
                return response;
            }
        }


        public SingleResponse<Produto> GetByID(int id)
        {
            SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM PRODUTOS where Id = @id";
            command.Parameters.AddWithValue("@ID", id);

            SingleResponse<Produto> response = new SingleResponse<Produto>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Produto produto = new Produto();
                    produto.ID = Convert.ToInt32(reader["ID"]);
                    produto.Descricao = Convert.ToString(reader["DESCRICAO"]);
                    produto.ValorVenda = Convert.ToDouble(reader["VALORVENDA"]);
                    produto.Estoque = Convert.ToInt32(reader["ESTOQUE"]);
                    response.Item = produto;
                    response.Success = true;
                    response.Message = "Dados selecionados com sucesso.";
                }
                return response;
            }
            catch (Exception)
            {
                response.Success = false; response.Message = "Erro no banco de dados contate o suporte.";
                return response;
            }
        }

        public Response Insert(Produto produto)
        {
            SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO PRODUTOS (DESCRICAO, VALORCUSTO, VALORVENDA) VALUES (@DESCRICAO, @VALORCUSTO, @VALORVENDA)";
            command.Parameters.AddWithValue("@DESCRICAO", produto.Descricao);
            command.Parameters.AddWithValue("@VALORCUSTO", produto.ValorCusto);
            command.Parameters.AddWithValue("@VALORVENDA", produto.ValorVenda);

            Response response = new Response();

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                response.Success = true; response.Message = "Produto cadastrado com sucesso.";
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                if (ex.Message.Contains("UQ_PRODUTOS"))
                {
                    response.Message = "Produto já cadastrado.";
                    return response;
                }
                response.Message = "Erro no banco de dados, contate o suporte.";
                return response;
            }
            finally
            {
                connection.Close();
            }
        }

        public Response Update(Produto produto)
        {
            SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "UPDATE PRODUTOS SET VALORCUSTO = @VALORCUSTO, VALORVENDA = @VALORVENDA WHERE ID = @ID";
            command.Parameters.AddWithValue("@PRECOCUSTO", produto.ValorCusto);
            command.Parameters.AddWithValue("@PRECOVENDA", produto.ValorVenda);
            command.Parameters.AddWithValue("@ID", produto.ID);

            Response response = new Response();

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                response.Success = true; response.Message = "Produto editado com sucesso.";
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                if (ex.Message.Contains("UQ_PRODUTOS"))
                {
                    response.Message = "Produto já cadastrado.";
                    return response;
                }
                response.Message = "Erro no banco de dados, contate o suporte.";
                return response;
            }
            finally
            {
                connection.Close();
            }
        }

        public Response Delete(int id)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "DELETE FROM PRODUTOS WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", id);

            Response response = new Response();

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                response.Success = true; response.Message = "Produto deletado com sucesso.";
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                if (ex.Message.Contains("FK__PRODUTOS"))
                {
                    response.Message = "Produto não pode ser excluído, pois já existem vendas vinculadas.";
                    return response;
                }
                response.Message = "Erro no banco de dados, contate o suporte.";
                return response;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataResponse<Produto> PesquisarProduto(Produto produto)
        {
            SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM PRODUTOS WHERE NOME LIKE '%" + produto.Descricao + "%'";
            DataResponse<Produto> response = new DataResponse<Produto>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Produto> produtos = new List<Produto>();

                while (reader.Read())
                {
                    produto.ID = Convert.ToInt32(reader["ID"]);
                    produto.Descricao = Convert.ToString(reader["DESCRICAO"]);
                    produto.Estoque = Convert.ToInt32(reader["ESTOQUE"]);
                    produto.ValorCusto = Convert.ToDouble(reader["VALORCUSTO"]);
                    produto.ValorVenda = Convert.ToDouble(reader["VALORVENDA"]);
                    produtos.Add(produto);
                }
                response.Success = true;
                response.Message = "Dados selecionados com sucesso.";
                response.Data = produtos;
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Erro no banco de dados, contate o suporte";
                return response;
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
