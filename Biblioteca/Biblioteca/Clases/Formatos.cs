using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Clases
{
    class Formatos
    {

//////////Campos
        private string codigo;
        private string nombre;
        
//////////Propiedades publicas de mi clase
        public string Codigo
        {
            get { return codigo; }
            set
            {
                if (value.Trim() != "" && value != null)
                { codigo = value; }
                else
                { throw new Exception("Digite el codigo de la categoría"); }
            }
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (value.Trim() != "" && value != null)
                { nombre = value; }
                else
                { throw new Exception("Digite el nombre de la categoria"); }
            }
        }

////////Constructor

        public Formatos()
        { }

        public Formatos(string codigo, string nombre)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;

        }
    }
}
