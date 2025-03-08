using OProjeto.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OProjeto.App_Code.DAL
{
    public class Vitima_AssistenciaDAL
    {
        private SqlConnection conexao;

        public Vitima_AssistenciaDAL(string connectionString)
        {
            conexao = new SqlConnection(connectionString);
            conexao.Open();
        }

        public void AdicionarVitima_Assistencia(int idVitima, int idAssistencia)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Vitima_Assistencia (ID_vitima, ID_assistencia) VALUES (@ID_vitima, @ID_assistencia)", conexao);
            cmd.Parameters.AddWithValue("@ID_vitima", idVitima);
            cmd.Parameters.AddWithValue("@ID_assistencia", idAssistencia);
            cmd.ExecuteNonQuery();
        }

        public List<Vitima_Assistencia> ObterTodosRelacionamentos()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Vitima_Assistencia", conexao);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Vitima_Assistencia> relacionamentos = new List<Vitima_Assistencia>();
            while (reader.Read())
            {
                relacionamentos.Add(new Vitima_Assistencia(
                    int.Parse(reader["ID_vitima"].ToString()),
                    int.Parse(reader["ID_assistencia"].ToString())
                ));
            }
            reader.Close();
            return relacionamentos;
        }

        public void FecharConexao()
        {
            conexao.Close();
        }
    }

}