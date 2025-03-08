using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OProjeto.App_Code.DAO
{
    public class ContatoDAO
    {
        SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pedro\source\repos\OProjeto\OProjeto\App_Data\Database1.mdf;Integrated Security=True");

        SqlCommand cmd;
        SqlDataReader dr;

        public ContatoDAO()
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

        public void InserirContato(string nome, string email, string telefone, string mensagem, DateTime dataEnvio)
        {
            try
            {
                string sql = "INSERT INTO Contato (Nome, Email, Telefone, Mensagem, DataEnvio) VALUES (@Nome, @Email, @Telefone, @Mensagem, @DataEnvio)";
                cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Telefone", telefone);
                cmd.Parameters.AddWithValue("@Mensagem", mensagem);
                cmd.Parameters.AddWithValue("@DataEnvio", dataEnvio);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        public SqlDataReader BuscarTodosContatos()
        {
            try
            {
                string sql = "SELECT * FROM Contato";
                cmd = new SqlCommand(sql, conexao);
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
            return dr;
        }
    }

}