using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Clases
{
    class Categorias
    {
//////////Campos
        private string codigo;
        private string nombre;
        private string descripcion;
        private string logo;
        
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

        public string Descripcion
        {
            get { return descripcion; }
            set
            {
                if (value.Trim() != "" && value != null)
                { descripcion = value; }
                else
                { throw new Exception("Digite la descripción de la categoría"); }
            }
        }

        public string Logo
        {
            get { return logo; }
            set { logo = value; }
        }

////////Constructor

        public Categorias()
        { }

        public Categorias(string codigo, string nombre, string descripcion, string logo)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Logo = logo;
        }
    }
}
