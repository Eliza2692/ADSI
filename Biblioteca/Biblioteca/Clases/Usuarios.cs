using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Biblioteca.Clases
{
    class Usuarios
    {

//////////Campos
        private string codigo;
        private string contrasena;
        private string nombre;
        private string apellido;
        private string correo;
        private string telefono;
        private string direccion;
        private string cargo;
        private string foto;

//////////Propiedades publicas de mi clase
        public string Codigo
        {
            get { return codigo; }
            set
            {
                if (value.Trim() != "" && value != null)
                { codigo = value; }
                else
                { throw new Exception("Digite el codigo del usuario"); }
            }
        }

        public string Contrasena
        {
            get { return contrasena; }
            set
            {
                if (value.Trim() != "" && value != null)
                { contrasena = value; }
                else
                { throw new Exception("Digite la contrasena del usuario"); }
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
                { throw new Exception("Digite el nombre del usuario"); }
            }
        }

        public string Apellido
        {
            get { return apellido; }
            set
            {
                if (value.Trim() != "" && value != null)
                { apellido = value; }
                else
                { throw new Exception("Digite el apellido del usuario"); }
            }
        }

       public string Correo
        {
            get { return correo; }
            set {correo = value;}
        }

        public string Telefono
        {
            get { return telefono; }
            set
            {
                if (value.Trim() != "" && value != null)
                { telefono = value; }
                else
                { throw new Exception("Digite el telefono del usuario"); }
            }
        }

        public string Direccion
        {
            get { return direccion; }
            set
            {
                if (value.Trim() != "" && value != null)
                { direccion = value; }
                else
                { throw new Exception("Digite la direccion del usuario"); }
            }
        }

        public string Cargo
        {
            get { return cargo; }
            set
            {
                if (value.Trim() != "" && value != null)
                { cargo = value; }
                else
                { throw new Exception("Digite el cargo del usuario"); }
            }
        }
        
        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }

////////Constructor

        public Usuarios()
        { }

        public Usuarios(string codigo, string contrasena, string nombre, string apellido, string correo,
                        string telefono, string direccion, string cargo, string foto)
        {
            this.Codigo = codigo;
            this.Contrasena = contrasena;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Correo = correo;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.Cargo = cargo;
            this.Foto = foto;
        }
    }
}
