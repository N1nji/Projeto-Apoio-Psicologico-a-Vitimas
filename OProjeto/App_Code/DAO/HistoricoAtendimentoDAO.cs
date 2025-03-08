using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OProjeto.App_Code.DAO
{
    public class HistoricoDeAtendimentoDAO
    {
        SqlConnection conexao = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;User Instance=True");

        SqlCommand cmd;
        SqlDataReader dr;

        public HistoricoDeAtendimentoDAO()
        {
            try
            {
                conexao.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        public void InserirHistorico(DateTime dataDoAtendimento, string tipoDeAtendimento, int idVitima, int? idPsicologo, int? idCentro)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO HistoricoDeAtendimento (DataDoAtendimento, TipoDeAtendimento, ID_vitima, ID_psicologo, ID_centro) VALUES (@DataDoAtendimento, @TipoDeAtendimento, @ID_vitima, @ID_psicologo, @ID_centro)", conexao);
                cmd.Parameters.AddWithValue("@DataDoAtendimento", dataDoAtendimento);
                cmd.Parameters.AddWithValue("@TipoDeAtendimento", tipoDeAtendimento);
                cmd.Parameters.AddWithValue("@ID_vitima", idVitima);
                cmd.Parameters.AddWithValue("@ID_psicologo", idPsicologo.HasValue ? (object)idPsicologo.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@ID_centro", idCentro.HasValue ? (object)idCentro.Value : DBNull.Value);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }

}