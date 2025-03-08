using OProjeto.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OProjeto.App_Code.DAL
{
    public class AssistenciaSocialDAL
    {
        private SqlConnection conexao;

        public AssistenciaSocialDAL(string connectionString)
        {
            conexao = new SqlConnection(connectionString);
            conexao.Open();
        }

        public void AdicionarAssistenciaSocial(AssistenciaSocial assistencia)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO AssistenciaSocial (Nome, TipoDeApoio, Endereco, Telefone) VALUES (@Nome, @TipoDeApoio, @Endereco, @Telefone)", conexao);
            cmd.Parameters.AddWithValue("@Nome", assistencia.Nome);
            cmd.Parameters.AddWithValue("@TipoDeApoio", assistencia.TipoDeApoio);
            cmd.Parameters.AddWithValue("@Endereco", assistencia.Endereco);
            cmd.Parameters.AddWithValue("@Telefone", assistencia.Telefone);
            cmd.ExecuteNonQuery();
        }

        public List<AssistenciaSocial> ObterTodasAssistencias()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM AssistenciaSocial", conexao);
            SqlDataReader reader = cmd.ExecuteReader();
            List<AssistenciaSocial> assistencias = new List<AssistenciaSocial>();
            while (reader.Read())
            {
                assistencias.Add(new AssistenciaSocial(
                    reader["Nome"].ToString(),
                    reader["TipoDeApoio"].ToString(),
                    reader["Endereco"].ToString(),
                    reader["Telefone"].ToString()
                ));
            }
            reader.Close();
            return assistencias;
        }

        public void FecharConexao()
        {
            conexao.Close();
        }
    }

}