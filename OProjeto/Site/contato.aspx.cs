using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Configuration;

namespace OProjeto.Site
{
    public partial class Contato : System.Web.UI.Page
    {
        string connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    // Teste de conexão com o banco
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        conn.Open();
                        Response.Write("<script>alert('Conexão com banco bem-sucedida!');</script>");
                       
                    }
                    CarregarContatos();
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('Erro ao carregar contatos: " + ex.Message + "');</script>");
                }
            }
        }

        protected void CarregarContatos()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = "SELECT * FROM Contato"; // Substitua "Contato" pelo nome correto da sua tabela
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Erro ao carregar dados: " + ex.Message + "');</script>");
            }
        }

        protected void EnviarFormulario(object sender, EventArgs e)
        {
            try
            {
                // Capturar valores dos campos
                string nomeValue = nome.Value;
                string emailValue = email.Value;
                string telefoneValue = telefone.Value;
                string mensagemValue = mensagem.Value;

                Response.Write($"<script>console.log('Nome: {nomeValue}, Email: {emailValue}, Telefone: {telefoneValue}, Mensagem: {mensagemValue}');</script>");

                // Salvar os dados no banco
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    Response.Write("<script>alert('Conexão com banco bem-sucedida!');</script>");

                    string query = "INSERT INTO Contato (Nome, Email, Telefone, Mensagem) VALUES (@Nome, @Email, @Telefone, @Mensagem)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", nomeValue);
                        cmd.Parameters.AddWithValue("@Email", emailValue);
                        cmd.Parameters.AddWithValue("@Telefone", telefoneValue);
                        cmd.Parameters.AddWithValue("@Mensagem", mensagemValue);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                // Atualizar o GridView para mostrar o novo registro
                CarregarContatos();

                // Mensagem de sucesso
                Response.Write("<script>alert('Formulário enviado com sucesso!');</script>");

                // Limpar os campos no HTML (opcional)

                nome.Value = "";
                email.Value = "";
                telefone.Value = "";
                mensagem.Value = "";
            }
            catch (Exception ex)
            {
                // Mostrar mensagem de erro
                Response.Write("<script>alert('Erro ao enviar formulário: " + ex.Message + "');</script>");
            }
        }
    }
}