using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manejoArchivos
{
    public class Contactos
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Genero { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public Contactos()
        { }

        public Contactos(string codigo, string nombre,
                        string apellido, string genero,
                        string correo, string telefono)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Genero = genero;
            this.Correo = correo;
            this.Telefono = telefono;
        }
    }
}
