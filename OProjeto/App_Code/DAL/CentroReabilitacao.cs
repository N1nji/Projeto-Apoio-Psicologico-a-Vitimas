using OProjeto.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OProjeto.App_Code.DAL
{
    public class CentroDeReabilitacaoDAL
    {
        private SqlConnection conexao;

        public CentroDeReabilitacaoDAL(string connectionString)
        {
            conexao = new SqlConnection(connectionString);
            conexao.Open();
        }

        public void AdicionarCentroDeReabilitacao(CentroDeReabilitacao centro)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO CentroDeReabilitacao (Nome, Endereco, TipoDeServicos, HorarioDeFuncionamento, CapacidadeDeAtendimento) VALUES (@Nome, @Endereco, @TipoDeServicos, @HorarioDeFuncionamento, @CapacidadeDeAtendimento)", conexao);
            cmd.Parameters.AddWithValue("@Nome", centro.Nome);
            cmd.Parameters.AddWithValue("@Endereco", centro.Endereco);
            cmd.Parameters.AddWithValue("@TipoDeServicos", centro.TipoDeServicos);
            cmd.Parameters.AddWithValue("@HorarioDeFuncionamento", centro.HorarioDeFuncionamento);
            cmd.Parameters.AddWithValue("@CapacidadeDeAtendimento", centro.CapacidadeDeAtendimento);
            cmd.ExecuteNonQuery();
        }

        public List<CentroDeReabilitacao> ObterTodosCentros()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM CentroDeReabilitacao", conexao);
            SqlDataReader reader = cmd.ExecuteReader();
            List<CentroDeReabilitacao> centros = new List<CentroDeReabilitacao>();
            while (reader.Read())
            {
                centros.Add(new CentroDeReabilitacao(
                    reader["Nome"].ToString(),
                    reader["Endereco"].ToString(),
                    reader["TipoDeServicos"].ToString(),
                    reader["HorarioDeFuncionamento"].ToString(),
                    reader["CapacidadeDeAtendimento"].ToString())
                );
            }
            reader.Close();
            return centros;
        }

        public void FecharConexao()
        {
            conexao.Close();
        }
    }

}