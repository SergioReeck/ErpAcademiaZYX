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
    public class CredencialDAL : ICredencial
    {
        private SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING);

        public SingleResponse<Credencial> Authenticate(string email, string senha)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM CREDENCIAIS WHERE EMAIL = @EMAIL AND SENHA = @SENHA";
            command.Parameters.AddWithValue("@EMAIL", email);
            command.Parameters.AddWithValue("@SENHA", senha);

            command.Connection = connection;

            SingleResponse<Credencial> response = new SingleResponse<Credencial>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Credencial cl = new Credencial();
                    cl.ID = Convert.ToInt32(reader["ID"]);
                    cl.Nome = Convert.ToString(reader["NOME"]);
                    cl.Email = Convert.ToString(reader["EMAIL"]);
                    cl.TipoCredencial = (TipoCredencial)reader["TIPOCREDENCIAL"];

                    response.Success = true;
                    response.Message = "Autenticação realizada com sucesso.";
                    response.Item = cl;
                    return response;
                }
                response.Success = false;
                response.Message = "Usuário e/ou senha inválidos.";
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

        public DataResponse<Credencial> GetAll()
        {
            SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM CREDENCIAIS ORDER BY ID";

            DataResponse<Credencial> response = new DataResponse<Credencial>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Credencial> credenciais = new List<Credencial>();
                while (reader.Read())
                {
                    Credencial credencial = new Credencial();
                    credencial.ID = Convert.ToInt32(reader["ID"]);
                    credencial.Nome = Convert.ToString(reader["NOME"]);
                    credencial.Email = Convert.ToString(reader["EMAIL"]);
                    credencial.Senha = Convert.ToString(reader["SENHA"]);
                    credencial.TipoCredencial = (TipoCredencial)Convert.ToInt32(reader["TIPOCREDENCIAL"]);
                    credenciais.Add(credencial);
                }
                response.Success = true;
                response.Message = "Dados selecionados com sucesso.";
                response.Data = credenciais;
                return response;
            }
            catch (Exception)
            {
                response.Success = false; response.Message = "Erro no banco de dados contate o suporte.";
                response.Data = new List<Credencial>();
                return response;
            }
        }

        public Response Insert(Credencial credencial)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO CREDENCIAIS (NOME, EMAIL, SENHA, TIPOCREDENCIAL) " +
                                                           "VALUES (@NOME, @EMAIL, @SENHA, @TIPOCREDENCIAL)";
            command.Parameters.AddWithValue("@NOME", credencial.Nome);
            command.Parameters.AddWithValue("@EMAIL", credencial.Email);
            command.Parameters.AddWithValue("@SENHA", credencial.Senha);
            command.Parameters.AddWithValue("@TIPOCREDENCIAL", credencial.TipoCredencial);

            Response response = new Response();

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                response.Success = true; response.Message = "Credencial cadastrada com sucesso.";
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;

                if (ex.Message.Contains("UQ__CREDENCIAIS"))
                {
                    response.Message = "Credencial já cadastrada.";
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

        public Response Update(Credencial credencial)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "UPDATE CREDENCIAIS SET NOME = @NOME, SENHA = @SENHA WHERE ID = @ID";
            command.Parameters.AddWithValue("@NOME", credencial.Nome);
            command.Parameters.AddWithValue("@SENHA", credencial.Senha);
            command.Parameters.AddWithValue("@ID", credencial.ID);

            Response response = new Response();

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                response.Success = true; response.Message = "Credencial editada com sucesso.";
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                if (ex.Message.Contains("UQ__CREDENCIAIS"))
                {
                    response.Message = "Credencial já cadastrada.";
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
