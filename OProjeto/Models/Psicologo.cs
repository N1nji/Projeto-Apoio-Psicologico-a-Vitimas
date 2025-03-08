using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OProjeto.Models
{
    public class Psicologo
    {
        public int ID_psicologo { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Especialidade { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string RegistroProfissional { get; set; }

        public Psicologo(string nome, string cpf, string especialidade, string telefone, string email, string registroprofissional)
        {
            Nome = nome;
            CPF = cpf;
            Especialidade = especialidade;
            Telefone = telefone;
            Email = email;
            RegistroProfissional = registroprofissional;
        }
    }
}

