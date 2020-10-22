using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Categorias
    {
        public Categorias()
        { }

        public Categorias(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }


        private int id;

        public int Id
        {
            get { return id; }
            set 
            {
                if (value<=0)
                    throw new Exception("Codigo Invalido");
                id = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Ingrese nombre");
                nombre = value; }
        }
        
        
    }
}
