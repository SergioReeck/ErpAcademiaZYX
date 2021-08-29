using Entities;
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
    public class EntradaProdutoDAL : IEntradaProduto
    {
        public Response RegistrarEntrada(EntradaProduto entradaProduto)
        {
            SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO ENTRADA_PRODUTO (DATAENTRADA, CREDENCIAL, VALOR) VALUES (@DATAENTRADA, @CREDENCIAL, @VALOR); SELECT SCOPE_IDENTITY()";

            command.Parameters.AddWithValue("@DATAENTRADA", entradaProduto.DataEntrada);
            command.Parameters.AddWithValue("@CREDENCIAL", entradaProduto.Credencial);
            command.Parameters.AddWithValue("@VALOR", entradaProduto.Total);

            Response response = new Response();

            try
            {
                connection.Open();
                entradaProduto.ID = Convert.ToInt32(command.ExecuteScalar());
                response.Success = true; response.Message = "Entrada registrada com sucesso.";
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
              
                response.Message = "Erro no banco de dados, contate o suporte.";
                return response;
            }
            finally
            {
                connection.Close();
            }
        }



        public Response RegistrarItemEntrada(ItemEntrada itemEntrada)
        {
            SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO ITENS_ENTRADA_PRODUTO VALUES (@IDENTRADA, @IDPRODUTO, @QUANTIDADE, @VALOR";

            command.Parameters.AddWithValue("@IDENTRADA", itemEntrada.Entrada);
            command.Parameters.AddWithValue("@IDPRODUTO", itemEntrada.Produto);
            command.Parameters.AddWithValue("@QUANTIDADE", itemEntrada.Quantidade);
            command.Parameters.AddWithValue("@VALOR", itemEntrada.Valor);

            Response response = new Response();

            try
            {
                connection.Open();
                response.Success = true; response.Message = "Entrada registrada com sucesso.";
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;

                response.Message = "Erro no banco de dados, contate o suporte.";
                return response;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
