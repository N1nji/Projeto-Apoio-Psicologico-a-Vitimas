using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OProjeto.Models
{
    public class AssistenciaSocial
    {
        public int ID_assistencia { get; set; }
        public string Nome { get; set; }
        public string TipoDeApoio { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public AssistenciaSocial(string nome, string tipodeapoio, string endereco, string telefone)
        {
            Nome = nome;
            Endereco = endereco;
            TipoDeApoio = tipodeapoio;
            Telefone = telefone;

        }
    }
}