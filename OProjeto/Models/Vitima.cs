using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OProjeto.Models
{
    public class Vitima
    {
        public int ID_vitima { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }
        public string Genero { get; set; }
        public string TipoDeAcidente { get; set; }
        public string Telefone { get; set; }
        public string ContatoDeEmergencia { get; set; }

        public Vitima(string nome, string cpf, int idade, string genero, string tipoDeAcidente, string telefone, string contatoDeEmergencia)
        {
            Nome = nome;
            CPF = cpf;
            Idade = idade;
            Genero = genero;
            TipoDeAcidente = tipoDeAcidente;
            Telefone = telefone;
            ContatoDeEmergencia = contatoDeEmergencia;
        }
    }
}
    

