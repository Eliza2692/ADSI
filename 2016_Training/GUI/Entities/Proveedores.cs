using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Proveedores
    {
        private int id;

        public int Id
        {
            get { return id; }
            set {

                if (value <= 0)                
                    throw new Exception("CÓDIGO DEBE SER MAYOR QUE CERO");              
                id = value; 
            
            }
        }


        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { 
                
                if(String.IsNullOrEmpty(value))
                    throw new Exception("EL NOMBRE NO ES VALIDO");
                 nombre = value; 
            }
        }

        private String direccion;

        public String Direccion
        {
            get { return direccion; }
            set {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("LA DIRECCION NO ES VALIDA");
                direccion = value;
            }
        }

        private String telefono;

        public String Telefono
        {
            get { return telefono; }
            set {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("EL TELEFONO NO ES VALIDO");
                telefono = value; 
            }
        }

        private String email;

        public String Email
        {
            get { return email; }
            set {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("EL EMAIL NO ES VALIDO");
                email = value; 
            }
        }

        private bool estado;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        
    }
}
