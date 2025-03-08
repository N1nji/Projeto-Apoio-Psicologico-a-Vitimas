using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OProjeto.App_Code.DAO
{
    public class AssistenciaSocialDAO
    {
        SqlConnection conexao = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;User Instance=True");

        SqlCommand cmd;
        SqlDataReader dr;

        public AssistenciaSocialDAO()
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

        public void InserirAssistencia(string nome, string tipoDeApoio, string endereco, string telefone)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO AssistenciaSocial (Nome, TipoDeApoio, Endereco, Telefone) VALUES (@Nome, @TipoDeApoio, @Endereco, @Telefone)", conexao);
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@TipoDeApoio", tipoDeApoio);
                cmd.Parameters.AddWithValue("@Endereco", endereco);
                cmd.Parameters.AddWithValue("@Telefone", telefone);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }

}