using OProjeto.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OProjeto.App_Code.DAL
{
    public class PsicologoDAL
    {
        private SqlConnection conexao;

        public PsicologoDAL(string connectionString)
        {
            conexao = new SqlConnection(connectionString);
            conexao.Open();
        }

        public void AdicionarPsicologo(Psicologo psicologo)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Psicologo (Nome, CPF, Especialidade, Telefone, Email, RegistroProfissional) VALUES (@Nome, @CPF, @Especialidade, @Telefone, @Email, @RegistroProfissional)", conexao);
            cmd.Parameters.AddWithValue("@Nome", psicologo.Nome);
            cmd.Parameters.AddWithValue("@CPF", psicologo.CPF);
            cmd.Parameters.AddWithValue("@Especialidade", psicologo.Especialidade);
            cmd.Parameters.AddWithValue("@Telefone", psicologo.Telefone);
            cmd.Parameters.AddWithValue("@Email", psicologo.Email);
            cmd.Parameters.AddWithValue("@RegistroProfissional", psicologo.RegistroProfissional);
            cmd.ExecuteNonQuery();
        }

        public List<Psicologo> ObterTodosPsicologos()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Psicologo", conexao);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Psicologo> psicologos = new List<Psicologo>();
            while (reader.Read())
            {
                psicologos.Add(new Psicologo(
                    reader["Nome"].ToString(),
                    reader["CPF"].ToString(),
                    reader["Especialidade"].ToString(),
                    reader["Telefone"].ToString(),
                    reader["Email"].ToString(),
                    reader["RegistroProfissional"].ToString()
                ));
            }
            reader.Close();
            return psicologos;
        }

        public void FecharConexao()
        {
            conexao.Close();
        }
    }

}