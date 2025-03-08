using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OProjeto.App_Code.DAO
{
    public class VitimaDAO
    {
        SqlConnection conexao = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;User Instance=True");

        SqlCommand cmd;
        SqlDataReader dr;

        public VitimaDAO()
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

        public void InserirVitima(string nome, string cpf, int idade, string genero, string tipoDeAcidente, string telefone, string contatoEmergencia)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO Vitima (Nome, CPF, Idade, Genero, TipoDeAcidente, Telefone, ContatoDeEmergencia) VALUES (@Nome, @CPF, @Idade, @Genero, @TipoDeAcidente, @Telefone, @ContatoDeEmergencia)", conexao);
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@CPF", cpf);
                cmd.Parameters.AddWithValue("@Idade", idade);
                cmd.Parameters.AddWithValue("@Genero", genero);
                cmd.Parameters.AddWithValue("@TipoDeAcidente", tipoDeAcidente);
                cmd.Parameters.AddWithValue("@Telefone", telefone);
                cmd.Parameters.AddWithValue("@ContatoDeEmergencia", contatoEmergencia);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }

}