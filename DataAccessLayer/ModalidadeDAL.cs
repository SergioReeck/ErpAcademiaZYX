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
    public class ModalidadeDAL : IModalidade
    {
        private SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING);

        public DataResponse<Modalidade> GetAll()
        {
            SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM MODALIDADES ORDER BY ID";

            DataResponse<Modalidade> response = new DataResponse<Modalidade>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Modalidade> modalidades = new List<Modalidade>();
                while (reader.Read())
                {
                    Modalidade modalidade = new Modalidade();
                    modalidade.ID = Convert.ToInt32(reader["ID"]);
                    modalidade.Descricao = Convert.ToString(reader["DESCRICAO"]);
                    modalidade.Valor = Convert.ToDouble(reader["VALOR"]);
                    modalidades.Add(modalidade);
                }
                response.Success = true;
                response.Message = "Dados selecionados com sucesso.";
                response.Data = modalidades;
                return response;
            }
            catch (Exception)
            {
                response.Success = false; response.Message = "Erro no banco de dados contate o suporte.";
                response.Data = new List<Modalidade>();
                return response;
            }
        }

        public Response Insert(Modalidade modalidade)
        {
            SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO MODALIDADES (DESCRICAO, VALOR) VALUES (@DESCRICAO, @VALOR)";
            command.Parameters.AddWithValue("@DESCRICAO", modalidade.Descricao);
            command.Parameters.AddWithValue("@VALOR", modalidade.Valor);

            Response response = new Response();

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                response.Success = true; response.Message = "Modalidade cadastrada com sucesso.";
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                if (ex.Message.Contains("UQ__MODALIDADES"))
                {
                    response.Message = "Modalidade já cadastrada.";
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

        public Response Update(Modalidade modalidade)
        {
            SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "UPDATE MODALIDADES SET VALOR = @VALOR WHERE ID = @ID";
            command.Parameters.AddWithValue("@VALOR", modalidade.Valor);
            command.Parameters.AddWithValue("@ID", modalidade.ID);

            Response response = new Response();

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                response.Success = true; response.Message = "Modalidade editada com sucesso.";
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                if (ex.Message.Contains("UQ__MODALIDADES"))
                {
                    response.Message = "Modalidade já cadastrada!";
                    return response;
                }
                response.Message = "Erro no banco de dados, contate o suporte";
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
            command.CommandText = "DELETE FROM MODALIDADES WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", id);

            Response response = new Response();

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                response.Success = true; response.Message = "Modalidade deletada com sucesso.";
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;

                if (ex.Message.Contains("FK__MODALIDADES"))
                {
                    response.Message = "Modalidade não pode ser excluída pois está vincula a um aluno ou professor.";
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
    }
}
