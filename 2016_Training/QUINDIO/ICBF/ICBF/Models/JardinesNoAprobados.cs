using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICBF.Models
{
    public class JardinesNoAprobados
    {

        public int ID { get; set; }

        public string NombreJardin { get; set; }

        public JardinesNoAprobados()
        {

        }

        public JardinesNoAprobados(string nom)
        {
            this.NombreJardin = nom;
        }

    }
}