using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OProjeto.App_Code.DAO
{
    public class CentroDeReabilitacaoDAO
    {
        SqlConnection conexao = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;User Instance=True");

        SqlCommand cmd;
        SqlDataReader dr;

        public CentroDeReabilitacaoDAO()
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

        public void InserirCentro(string nome, string endereco, string tipoDeServicos, string horarioDeFuncionamento, int capacidadeDeAtendimento)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO CentroDeReabilitacao (Nome, Endereco, TipoDeServicos, HorarioDeFuncionamento, CapacidadeDeAtendimento) VALUES (@Nome, @Endereco, @TipoDeServicos, @HorarioDeFuncionamento, @CapacidadeDeAtendimento)", conexao);
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Endereco", endereco);
                cmd.Parameters.AddWithValue("@TipoDeServicos", tipoDeServicos);
                cmd.Parameters.AddWithValue("@HorarioDeFuncionamento", horarioDeFuncionamento);
                cmd.Parameters.AddWithValue("@CapacidadeDeAtendimento", capacidadeDeAtendimento);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }

}