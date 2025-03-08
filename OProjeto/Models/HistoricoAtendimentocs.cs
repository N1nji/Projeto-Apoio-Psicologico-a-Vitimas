using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OProjeto.Models
{
    public class HistoricoDeAtendimento
    {
        public int ID_atendimento { get; set; }
        public DateTime DataDoAtendimento { get; set; }
        public string TipoDeAtendimento { get; set; }
        public int ID_vitima { get; set; }
        public int ID_psicologo { get; set; }
        public int ID_centro { get; set; }
        public DateTime DateTime { get; }

        public HistoricoDeAtendimento(DateTime datadoatendimento, string tipodeatendimento, int id_vitima, int id_psicologo, int id_centro)
        {
            DateTime = datadoatendimento;
            TipoDeAtendimento = tipodeatendimento;
            ID_vitima = id_vitima;
            ID_psicologo = id_psicologo;
            ID_centro = id_centro;
        }
    }
}