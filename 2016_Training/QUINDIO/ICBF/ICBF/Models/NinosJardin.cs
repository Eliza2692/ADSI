using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICBF.Models
{
    public class NinosJardin
    {

        public int ID { get; set; }

        public string Jardin { get; set; }

        public int Conta { get; set; }

        public NinosJardin()
        {

        }

        public NinosJardin(string jar, int cant)
        {
            this.Jardin = jar;
            this.Conta = cant;
        }

    }
}