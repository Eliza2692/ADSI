using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Autores
    {
        public Autores() { }

        public Autores(int id, string nombre, string apellido, string direccion, DateTime fechanacimiento, char genero, string foto) 
        {
            Id=id;
            Nombre=nombre;
            Apellido = apellido;
            Direccion = direccion;
            Fechanacimiento = fechanacimiento;
            Genero = genero;
            Foto = foto;
        }

        private int id;

        public int Id
        {
            get { return id; }
            set
            {

                if (value <= 0)
                    throw new Exception("CÓDIGO INVALIDO");
                id = value;

            }
        }


        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set
            {

                if (String.IsNullOrEmpty(value))
                    throw new Exception("INGRESE NOMBRE");
                nombre = value;

            }
        }


        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set
            {

                //if (String.IsNullOrEmpty(value))
                //    throw new Exception("INGRESE APELLIDO");
                apellido = value;

            }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set
            {

                if (String.IsNullOrEmpty(value))
                    throw new Exception("INGRESE DIRECCION");
                direccion = value;

            }
        }

        private DateTime fechanacimiento;

        public DateTime Fechanacimiento
        {
            get { return fechanacimiento; }
            set {
                //if (value.Date > DateTime.Now)
                //    throw new Exception("FECHA INVALIDA");
                fechanacimiento = value; 
            }
        }

        private char genero;

        public char Genero
        {
            get { return genero; }
            set {
                if (value != 'M' && value != 'F')
                    throw new Exception("GENERO INVALIDO");
                genero = value; }
        }

        private string foto;

        public string Foto
        {
            get { return foto; }
            set
            {

                if (String.IsNullOrEmpty(value))
                    throw new Exception("INGRESE FOTO");
                foto = value;

            }
        }
        
        
    }
}
