using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICBF.Models
{
    public class NinosEnfermos
    {

        public int ID { get; set; }

        public string NombreNino { get; set; }

        public NinosEnfermos()
        {

        }

        public NinosEnfermos(string nom)
        {
            this.NombreNino = nom;
        }

    }
}