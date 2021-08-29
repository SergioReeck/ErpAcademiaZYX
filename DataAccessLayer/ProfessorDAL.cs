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
    public class ProfessorDAL : IProfessor
    {
        private SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING);

        public DataResponse<Professor> GetAll()
        {
            SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM PROFESSOR ORDER BY ID";

            DataResponse<Professor> response = new DataResponse<Professor>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Professor> professores = new List<Professor>();
                while (reader.Read())
                {
                    Professor professor = new Professor();

                    professor.ID = Convert.ToInt32(reader["ID"]);
                    professor.Nome = Convert.ToString(reader["NOME"]);
                    professor.CPF = Convert.ToString(reader["CPF"]);
                    professor.RG = Convert.ToString(reader["RG"]);
                    professor.Email = Convert.ToString(reader["EMAIL"]);
                    professor.DataNascimento = Convert.ToDateTime (reader["DATANASCIMENTO"]);
                    professor.Rua = Convert.ToString(reader["RUA"]);
                    professor.Numero = Convert.ToString(reader["NUMERO"]);
                    professor.Bairro = Convert.ToString(reader["BAIRRO"]);
                    professor.Cidade = Convert.ToString(reader["CIDADE"]);
                    professor.Complemento = Convert.ToString(reader["COMPLEMENTO"]);
                    professor.CEP = Convert.ToString(reader["CEP"]);
                    professor.UF = Convert.ToString(reader["UF"]);
                    professor.Telefone = Convert.ToString(reader["TELEFONE"]);
                    professor.Salario = Convert.ToDouble(reader["SALARIO"]);
                    professor.Comissao = Convert.ToDouble(reader["COMISSAO"]);
                    professores.Add(professor);
                }
                response.Success = true;
                response.Message = "Dados selecionados com sucesso.";
                response.Data = professores;
                return response;
            }
            catch (Exception)
            {
                response.Success = false; response.Message = "Erro no banco de dados contate o suporte.";
                response.Data = new List<Professor>();
                return response;
            }
        }

        public Response Insert(Professor professor)
        {
            SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO PROFESSORES (NOME, CPF, RG, EMAIL, DATANASCIMENTO, RUA, NUMERO, BAIRRO, CIDADE, CEP, COMPLEMENTO, UF, " +
                                                            "TELEFONE, SALARIO, COMISSAO) VALUES (@NOME, @CPF, @RG, @EMAIL, @DATANASCIMENTO, @RUA," +
                                                            "@NUMERO, @BAIRRO, @CIDADE, @CEP, @COMPLEMENTO, @UF, @TELEFONE, @SALARIO, @COMISSAO)"; 
            command.Parameters.AddWithValue("@NOME", professor.Nome);
            command.Parameters.AddWithValue("@CPF", professor.CPF);
            command.Parameters.AddWithValue("@RG", professor.RG);
            command.Parameters.AddWithValue("@EMAIL", professor.Email);
            command.Parameters.AddWithValue("@DATANASCIMENTO", professor.DataNascimento);
            command.Parameters.AddWithValue("@RUA", professor.Rua);
            command.Parameters.AddWithValue("@NUMERO", professor.Numero);
            command.Parameters.AddWithValue("@BAIRRO", professor.Bairro);
            command.Parameters.AddWithValue("@CIDADE", professor.Cidade);
            command.Parameters.AddWithValue("@CEP", professor.CEP);
            command.Parameters.AddWithValue("@COMPLEMENTO", professor.Complemento);
            command.Parameters.AddWithValue("@UF", professor.UF);
            command.Parameters.AddWithValue("@TELEFONE", professor.Telefone);
            command.Parameters.AddWithValue("@SALARIO", professor.Salario);
            command.Parameters.AddWithValue("@COMISSAO", professor.Comissao);

            Response response = new Response();

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                response.Success = true; response.Message = "Professor cadastrado com sucesso.";
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                if (ex.Message.Contains("UQ__PROFESSORES"))
                {
                    response.Message = "Professor já cadastrado.";
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

        public Response Update(Professor professor)
        {
            SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "UPDATE PROFESSORES SET NOME = @NOME, EMAIL = @EMAIL, RUA = @RUA, NUMERO = @NUMERO, BAIRRO = @BAIRRO, CIDADE = @CIDADE, CEP = @CEP," +
                                                           "COMPLEMENTO = @COMPLEMENTO, UF = @UF, TELEFONE = @TELEFONE, SALARIO = @SALARIO, COMISSAO = @COMISSAO WHERE ID = @ID";
            command.Parameters.AddWithValue("@NOME", professor.Nome);
            command.Parameters.AddWithValue("@EMAIL", professor.Email);
            command.Parameters.AddWithValue("@RUA", professor.Rua);
            command.Parameters.AddWithValue("@NUMERO", professor.Numero);
            command.Parameters.AddWithValue("@BAIRRO", professor.Bairro);
            command.Parameters.AddWithValue("@CIDADE", professor.Cidade);
            command.Parameters.AddWithValue("@CEP", professor.CEP);
            command.Parameters.AddWithValue("@COMPLEMENTO", professor.Complemento);
            command.Parameters.AddWithValue("@UF", professor.UF);
            command.Parameters.AddWithValue("@TELEFONE", professor.Telefone);
            command.Parameters.AddWithValue("@SALARIO", professor.Salario);
            command.Parameters.AddWithValue("@COMISSAO", professor.Comissao);
            command.Parameters.AddWithValue("@ID", professor.ID);

            Response response = new Response();

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                response.Success = true; response.Message = "Professor editado com sucesso.";
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                if (ex.Message.Contains("UQ__PROFESSORES"))
                {
                    response.Message = "Professor já cadastrado.";
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

        public DataResponse<Professor> PesquisarProfessor(Professor professor)
        {
            SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM PROFESSORES WHERE NOME LIKE '%" + professor.Nome + "%'";
            DataResponse<Professor> response = new DataResponse<Professor>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Professor> professores = new List<Professor>();

                while (reader.Read())
                {
                    professor.ID = Convert.ToInt32(reader["ID"]);
                    professor.Nome = Convert.ToString(reader["NOME"]);
                    professor.CPF = Convert.ToString(reader["CPF"]);
                    professor.RG = Convert.ToString(reader["RG"]);
                    professor.Email = Convert.ToString(reader["EMAIL"]);
                    professor.DataNascimento = Convert.ToDateTime(reader["DATANASCIMENTO"]);
                    professor.Rua = Convert.ToString(reader["RUA"]);
                    professor.Numero = Convert.ToString(reader["NUMERO"]);
                    professor.Bairro = Convert.ToString(reader["BAIRRO"]);
                    professor.Cidade = Convert.ToString(reader["CIDADE"]);
                    professor.Complemento = Convert.ToString(reader["COMPLEMENTO"]);
                    professor.CEP = Convert.ToString(reader["CEP"]);
                    professor.UF = Convert.ToString(reader["UF"]);
                    professor.Telefone = Convert.ToString(reader["TELEFONE"]);
                    professor.Salario = Convert.ToDouble(reader["SALARIO"]);
                    professor.Comissao = Convert.ToDouble(reader["COMISSAO"]);
                    professores.Add(professor);
                }
                response.Success = true;
                response.Message = "Dados selecionados com sucesso.";
                response.Data = professores;
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
