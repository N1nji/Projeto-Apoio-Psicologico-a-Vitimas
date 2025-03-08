using OProjeto.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OProjeto.App_Code.DAL
{
    public class HistoricoDeAtendimentoDAL
    {
        private SqlConnection conexao;

        public HistoricoDeAtendimentoDAL(string connectionString)
        {
            conexao = new SqlConnection(connectionString);
            conexao.Open();
        }

        public void AdicionarHistoricoDeAtendimento(HistoricoDeAtendimento historico)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO HistoricoDeAtendimento (DataDoAtendimento, TipoDeAtendimento, ID_vitima, ID_psicologo, ID_centro) VALUES (@DataDoAtendimento, @TipoDeAtendimento, @ID_vitima, @ID_psicologo, @ID_centro)", conexao);
            cmd.Parameters.AddWithValue("@DataDoAtendimento", historico.DataDoAtendimento);
            cmd.Parameters.AddWithValue("@TipoDeAtendimento", historico.TipoDeAtendimento);
            cmd.Parameters.AddWithValue("@ID_vitima", historico.ID_vitima);
            cmd.Parameters.AddWithValue("@ID_psicologo", historico.ID_psicologo);
            cmd.Parameters.AddWithValue("@ID_centro", historico.ID_centro);
            cmd.ExecuteNonQuery();
        }

        public List<HistoricoDeAtendimento> ObterTodosHistoricos()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HistoricoDeAtendimento", conexao);
            SqlDataReader reader = cmd.ExecuteReader();
            List<HistoricoDeAtendimento> historicos = new List<HistoricoDeAtendimento>();
            while (reader.Read())
            {
                historicos.Add(new HistoricoDeAtendimento(
                    DateTime.Parse(reader["DataDoAtendimento"].ToString()),
                    reader["TipoDeAtendimento"].ToString(),
                   int.Parse(reader["ID_vitima"].ToString()),
                   int.Parse(reader["ID_psicologo"].ToString()),
                   int.Parse(reader["ID_centro"].ToString())
                ));
            }
            reader.Close();
            return historicos;
        }

        public void FecharConexao()
        {
            conexao.Close();
        }
    }

}