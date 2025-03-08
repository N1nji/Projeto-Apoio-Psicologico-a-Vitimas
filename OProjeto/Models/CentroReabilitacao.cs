using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OProjeto.Models
{
    public class CentroDeReabilitacao
    {
        public int ID_centro { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string TipoDeServicos { get; set; }
        public string HorarioDeFuncionamento { get; set; }
        public string CapacidadeDeAtendimento { get; set; }

        public CentroDeReabilitacao(string nome, string endereco, string tipodeservicos, string horariodefuncionamento, string capacidadededeatendimento)
        {
            Nome = nome;
            Endereco = endereco;
            TipoDeServicos = tipodeservicos;
            HorarioDeFuncionamento = horariodefuncionamento;
            CapacidadeDeAtendimento = capacidadededeatendimento;

        }
    }
}