using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Libros
    {

        public Libros() { }

        public Libros(int id, string isbn, string nombre,
            int ideditorial, int numeropaginas, int idcategoria, int idautor) {

                Id = id;
                Isbn = isbn;
                Nombre = nombre;
                Ideditorial = ideditorial;
                Numeropaginas = numeropaginas;
                Idcategoria = idcategoria;
                Idautor = idautor;

        }

        private int id;

        public int Id
        {
            get { return id; }
            set {

                if (value <= 0)
                    throw new Exception("CÓDIGO INVALIDO");
                id = value; 
            
            }
        }

        private string isbn;

        public string Isbn
        {
            get { return isbn; }
            set {

                if (String.IsNullOrEmpty(value))
                    throw new Exception("INGRESE ISBN");
                isbn = value; 
            
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

        private int ideditorial;

        public int Ideditorial
        {
            get { return ideditorial; }
            set
            {

                if (value <= 0)
                    throw new Exception("CÓDIGO EDITORIAL INVALIDO");
                ideditorial = value;

            }
        }

        private int numeropaginas;

        public int Numeropaginas
        {
            get { return numeropaginas; }
            set
            {

                if (value <= 0)
                    throw new Exception("NÚMERO PÁGINAS INVALIDO");
                numeropaginas = value;

            }
        }

        private int idcategoria;

        public int Idcategoria
        {
            get { return idcategoria; }
            set
            {

                if (value <= 0)
                    throw new Exception("CATEGORIA INVALIDA");
                idcategoria = value;

            }
        }

        private int idautor;

        public int Idautor
        {
            get { return idautor; }
            set
            {

                if (value <= 0)
                    throw new Exception("AUTOR INVALIDO");
                idautor = value;

            }
        }
    
    }

}
