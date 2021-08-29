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
    public class AlunoDAL : IAluno
    {
        private SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING);

        public DataResponse<Aluno> GetAll()
        {
            SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM ALUNOS ORDER BY ID";

            DataResponse<Aluno> response = new DataResponse<Aluno>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Aluno> alunos = new List<Aluno>();
                while (reader.Read())
                {
                    Aluno aluno = new Aluno();
                    aluno.ID = Convert.ToInt32(reader["ID"]);
                    aluno.Nome = Convert.ToString(reader["NOME"]);
                    aluno.CPF = Convert.ToString(reader["CPF"]);
                    aluno.RG = Convert.ToString(reader["RG"]);
                    aluno.Email = Convert.ToString(reader["EMAIL"]);
                    aluno.DataNascimento = Convert.ToDateTime(reader["DATANASCIMENTO"]);
                    aluno.DataMatricula = Convert.ToDateTime(reader["DATAMATRICULA"]);
                    aluno.Rua = Convert.ToString(reader["RUA"]);
                    aluno.Numero = Convert.ToString(reader["NUMERO"]);
                    aluno.Bairro = Convert.ToString(reader["BAIRRO"]);
                    aluno.Cidade = Convert.ToString(reader["CIDADE"]);
                    aluno.Complemento = Convert.ToString(reader["COMPLEMENTO"]);
                    aluno.CEP = Convert.ToString(reader["CEP"]);
                    aluno.UF = Convert.ToString(reader["UF"]);
                    aluno.Telefone1 = Convert.ToString(reader["TELEFONE1"]);
                    aluno.Telefone2 = Convert.ToString(reader["TELEFONE2"]);
                    alunos.Add(aluno);
                }
                response.Success = true;
                response.Message = "Dados selecionados com sucesso.";
                response.Data = alunos;
                return response;
            }
            catch (Exception)
            {
                response.Success = false; response.Message = "Erro no banco de dados contate o suporte.";
                response.Data = new List<Aluno>();
                return response;
            }
        }
        public Response Insert(Aluno aluno)
        {
            SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO ALUNOS (NOME, CPF, RG, EMAIL, DATADASCIMENTO, DATADATRICULA, RUA, NUMERO, BAIRRO, CIDADE, CEP, " +
                                                        "UF, COMPLEMENTO, TELEFONE1, TELEFONE2) VALUES (@NOME, @CPF, @RG, @EMAIL, @DATADENASCIMENTO, " +
                                                        "@DATADAMATRICULA, @RUA, @NUMERO, @BAIRRO, @CIDADE, @CEP, @UF, @COMPLEMENTO, @TELEFONE1, @TELEFONE2)";
            command.Parameters.AddWithValue("@NOME", aluno.Nome);
            command.Parameters.AddWithValue("@CPF", aluno.CPF);
            command.Parameters.AddWithValue("@RG", aluno.RG);
            command.Parameters.AddWithValue("@EMAIL", aluno.Email);
            command.Parameters.AddWithValue("@DATADENASCIMENTO", aluno.DataNascimento);
            command.Parameters.AddWithValue("@DATADAMATRICULA", aluno.DataMatricula);
            command.Parameters.AddWithValue("@RUA", aluno.Rua);
            command.Parameters.AddWithValue("@NUMERO", aluno.Numero);
            command.Parameters.AddWithValue("@BAIRRO", aluno.Bairro);
            command.Parameters.AddWithValue("@CIDADE", aluno.Cidade);
            command.Parameters.AddWithValue("@CEP", aluno.CEP);
            command.Parameters.AddWithValue("@UF", aluno.UF);
            command.Parameters.AddWithValue("@COMPLEMENTO", aluno.Complemento);
            command.Parameters.AddWithValue("@TELEFONE1", aluno.Telefone1);
            command.Parameters.AddWithValue("@TELEFONE2", aluno.Telefone2);

            Response response = new Response();

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                response.Success = true; response.Message = "Aluno cadastrado com sucesso.";
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                if (ex.Message.Contains("UQ__ALUNOS"))
                {
                    response.Message = "Aluno já cadastrado.";
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

        public Response Update(Aluno aluno)
        {
            SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "UPDATE ALUNOS SET NOME = @NOME, EMAIL = @EMAIL, RUA = @RUA, NUMERO = @NUMERO, BAIRRO = @BAIRRO, CIDADE = @CIDADE, CEP = @CEP," +
                                                       "COMPLEMENTO = @COMPLEMENTO, UF = @UF, TELEFONE1 = @TELEFONE1, TELEFONE2 = @TELEFONE2 WHERE ID = @ID";
            command.Parameters.AddWithValue("@NOME", aluno.Nome);
            command.Parameters.AddWithValue("@EMAIL", aluno.Email);
            command.Parameters.AddWithValue("@RUA", aluno.Rua);
            command.Parameters.AddWithValue("@NUMERO", aluno.Numero);
            command.Parameters.AddWithValue("@BAIRRO", aluno.Bairro);
            command.Parameters.AddWithValue("@CIDADE", aluno.Cidade);
            command.Parameters.AddWithValue("@CEP", aluno.CEP);
            command.Parameters.AddWithValue("@COMPLEMENTO", aluno.Complemento);
            command.Parameters.AddWithValue("@UF", aluno.UF);
            command.Parameters.AddWithValue("@TELEFONE1", aluno.Telefone1);
            command.Parameters.AddWithValue("@TELEFONE2", aluno.Telefone2);
            command.Parameters.AddWithValue("@ID", aluno.ID);

            Response response = new Response();

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                response.Success = true; response.Message = "Cliente editado com sucesso.";
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                if (ex.Message.Contains("UQ__CLIENTES"))
                {
                    response.Message = "Cliente já cadastrado.";
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

        public DataResponse<Aluno> PesquisarAluno(Aluno aluno)
        {
            SqlConnection connection = new SqlConnection(SqlUtils.CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM ALUNOS WHERE NOME LIKE '%" + aluno.Nome + "%'";
            DataResponse<Aluno> response = new DataResponse<Aluno>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Aluno> alunos = new List<Aluno>();

                while (reader.Read())
                {
                    aluno.ID = Convert.ToInt32(reader["ID"]);
                    aluno.Nome = Convert.ToString(reader["NOME"]);
                    aluno.CPF = Convert.ToString(reader["CPF"]);
                    aluno.RG = Convert.ToString(reader["RG"]);
                    aluno.Email = Convert.ToString(reader["EMAIL"]);
                    aluno.DataNascimento = Convert.ToDateTime(reader["DATANASCIMENTO"]);
                    aluno.DataMatricula = Convert.ToDateTime(reader["DATAMATRICULA"]);
                    aluno.Rua = Convert.ToString(reader["RUA"]);
                    aluno.Numero = Convert.ToString(reader["NUMERO"]);
                    aluno.Bairro = Convert.ToString(reader["BAIRRO"]);
                    aluno.Cidade = Convert.ToString(reader["CIDADE"]);
                    aluno.Complemento = Convert.ToString(reader["COMPLEMENTO"]);
                    aluno.CEP = Convert.ToString(reader["CEP"]);
                    aluno.UF = Convert.ToString(reader["UF"]);
                    aluno.Telefone1 = Convert.ToString(reader["TELEFONE1"]);
                    aluno.Telefone2 = Convert.ToString(reader["TELEFONE2"]);
                    alunos.Add(aluno);
                }
                response.Success = true;
                response.Message = "Dados selecionados com sucesso.";
                response.Data = alunos;
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
