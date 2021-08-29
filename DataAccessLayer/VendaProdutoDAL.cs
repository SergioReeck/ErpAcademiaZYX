using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class VendaProdutoDAL
    {
        public Response RegistrarVenda(VendaProduto vendaProduto)
        {
            SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO VENDA_DE_PRODUTO (DATAVENDA, CREDENCIAL, VALOR, CLIENTE) VALUES (@DATAVENDA, @CREDENCIAL, @VALOR, @CLIENTE); SELECT SCOPE_IDENTITY()";

            command.Parameters.AddWithValue("@DATAVENDA", vendaProduto.DataVenda);
            command.Parameters.AddWithValue("@CREDENCIAL", vendaProduto.Credencial);
            command.Parameters.AddWithValue("@VALOR", vendaProduto.Total);
            command.Parameters.AddWithValue("@CLIENTE", vendaProduto.Cliente);

            Response response = new Response();

            try
            {
                connection.Open();
                vendaProduto.ID = Convert.ToInt32(command.ExecuteScalar());
                response.Success = true; response.Message = "Venda registrada com sucesso.";
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

        public Response RegistrarItemVenda(ItemVenda itemVenda)
        {
            SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO ITENS_VENDAS_PRODUTO VALUES (@IDVENDA, @IDPRODUTO, @QUANTIDADE, @VALOR";

            command.Parameters.AddWithValue("@IDENTRADA", itemVenda.Venda);
            command.Parameters.AddWithValue("@IDPRODUTO", itemVenda.Produto);
            command.Parameters.AddWithValue("@QUANTIDADE", itemVenda.Quantidade);
            command.Parameters.AddWithValue("@VALOR", itemVenda.Valor);

            Response response = new Response();

            try
            {
                connection.Open();
                response.Success = true; response.Message = "Venda registrada com sucesso.";
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
