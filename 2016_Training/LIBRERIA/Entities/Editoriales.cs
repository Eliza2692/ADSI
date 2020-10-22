using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Editoriales
    {
        public Editoriales() { 
        
        }

        public Editoriales(int id, string nombre, string direccion, string telefono, string email) {

            Id = id;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
        
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
            {   nombre = value;
            }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set
            {

                direccion = value;

            }
        }

        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set
            {

                telefono = value;

            }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set
            {

                email = value;

            }
        }



        
        

    }
}
