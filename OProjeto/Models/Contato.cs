using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OProjeto.Models
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Mensagem { get; set; }
        public DateTime DataEnvio { get; set; } = DateTime.Now;

        public Contato(string nome, string email, string telefone, string mensagem, DateTime dataEnvio)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Mensagem = mensagem;
            DataEnvio = dataEnvio;
        }

    }
}

