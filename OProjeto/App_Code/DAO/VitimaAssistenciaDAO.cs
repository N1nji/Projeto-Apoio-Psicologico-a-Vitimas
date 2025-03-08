using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OProjeto.App_Code.DAO
{
    public class VitimaAssistenciaDAO
    {
        SqlConnection conexao = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;User Instance=True");

        SqlCommand cmd;
        SqlDataReader dr;

        public VitimaAssistenciaDAO()
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

        public void InserirRelacaoVitimaAssistencia(int idVitima, int idAssistencia)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO Vitima_Assistencia (ID_vitima, ID_assistencia) VALUES (@ID_vitima, @ID_assistencia)", conexao);
                cmd.Parameters.AddWithValue("@ID_vitima", idVitima);
                cmd.Parameters.AddWithValue("@ID_assistencia", idAssistencia);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }

}