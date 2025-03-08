using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OProjeto.Models
{
    public class Vitima_Assistencia
    {
        public int ID_vitima { get; set; }
        public int ID_assistencia { get; set; }

        public Vitima_Assistencia(int id_vitima, int id_assistencia)
        {
            ID_vitima = id_vitima;
            ID_assistencia = id_assistencia;

        }
    }
}