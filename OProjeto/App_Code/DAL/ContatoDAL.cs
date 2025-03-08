using System.Collections.Generic;
using System.Data.SqlClient;
using System;
using OProjeto.Models;

public class ContatoDAL
{
    private SqlConnection conexao;

    public ContatoDAL(string connectionString)
    {
        conexao = new SqlConnection(connectionString);
        conexao.Open();
    }

    public void AdicionarContato(Contato contato)
    {
        SqlCommand cmd = new SqlCommand("INSERT INTO Contato (Nome, Email, Telefone, Mensagem, DataEnvio) VALUES (@Nome, @Email, @Telefone, @Mensagem, @DataEnvio)", conexao);
        cmd.Parameters.AddWithValue("@Nome", contato.Nome);
        cmd.Parameters.AddWithValue("@Email", contato.Email);
        cmd.Parameters.AddWithValue("@Telefone", contato.Telefone);
        cmd.Parameters.AddWithValue("@Mensagem", contato.Mensagem);
        cmd.Parameters.AddWithValue("@DataEnvio", contato.DataEnvio);
        cmd.ExecuteNonQuery();
    }

    public List<Contato> ObterTodosContatos()
    {
        SqlCommand cmd = new SqlCommand("SELECT * FROM Contato", conexao);
        SqlDataReader reader = cmd.ExecuteReader();
        List<Contato> contatos = new List<Contato>();
        while (reader.Read())
        {
            contatos.Add(new Contato(
                reader["Nome"].ToString(),
                reader["Email"].ToString(),
                reader["Telefone"].ToString(),
                reader["Mensagem"].ToString(),
                DateTime.Parse(reader["DataEnvio"].ToString())
            ));
        }
        reader.Close();
        return contatos;
    }

    public void FecharConexao()
    {
        conexao.Close();
    }
}


