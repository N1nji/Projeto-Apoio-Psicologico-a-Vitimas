using OProjeto.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OProjeto.App_Code.DAL
{
    public class VitimaDAL
    {
        private SqlConnection conexao;

        public VitimaDAL(string connectionString)
        {
            conexao = new SqlConnection(connectionString);
            conexao.Open();
        }

        public void AdicionarVitima(Vitima vitima)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Vitima (Nome, CPF, Idade, Genero, TipoDeAcidente, Telefone, ContatoDeEmergencia) VALUES (@Nome, @CPF, @Idade, @Genero, @TipoDeAcidente, @Telefone, @ContatoDeEmergencia)", conexao);
            cmd.Parameters.AddWithValue("@Nome", vitima.Nome);
            cmd.Parameters.AddWithValue("@CPF", vitima.CPF);
            cmd.Parameters.AddWithValue("@Idade", vitima.Idade);
            cmd.Parameters.AddWithValue("@Genero", vitima.Genero);
            cmd.Parameters.AddWithValue("@TipoDeAcidente", vitima.TipoDeAcidente);
            cmd.Parameters.AddWithValue("@Telefone", vitima.Telefone);
            cmd.Parameters.AddWithValue("@ContatoDeEmergencia", vitima.ContatoDeEmergencia);
            cmd.ExecuteNonQuery();
        }

        public List<Vitima> ObterTodasAsVitimais()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Vitima", conexao);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Vitima> vitimas = new List<Vitima>();
            while (reader.Read())
            {
                vitimas.Add(new Vitima(
                    reader["Nome"].ToString(),
                    reader["CPF"].ToString(),
                    int.Parse(reader["Idade"].ToString()),
                    reader["Genero"].ToString(),
                    reader["TipoDeAcidente"].ToString(),
                    reader["Telefone"].ToString(),
                    reader["ContatoDeEmergencia"].ToString()
                ));
            }
            reader.Close();
            return vitimas;
        }

        public void FecharConexao()
        {
            conexao.Close();
        }
    }

}