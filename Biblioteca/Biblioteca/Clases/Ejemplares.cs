using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Clases
{
    class Ejemplares
    {
//////////Campos
        private string referencia;
        private string nombre;
        private string descripcion;
        private int cantidad;
        private string estado;
        private string autor;
        private int anio;
        private string editorial;
        private string categoria;
        private string formato;
        private string foto;

//////////Propiedades publicas de mi clase
        public string Referencia
        {
            get { return referencia; }
            set
            {
                if (value.Trim() != "" && value != null)
                { referencia = value; }
                else
                { throw new Exception("Digite la referencia del ejemplar"); }
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
                { throw new Exception("Digite el nombre del ejemplar"); }
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
                { throw new Exception("Digite la descripción del ejemplar"); }
            }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set
            {
                if (value > 0)
                { cantidad = value; }
                else
                { throw new Exception("La cantidad de ejemplares debe ser mayor que cero"); }
            }
        }

        public string Estado
        {
            get { return estado; }
            set
            {
                if (value.Trim() != "" && value != null)
                { estado = value; }
                else
                { throw new Exception("Seleccione el estado del ejemplar"); }
            }
        }

        public string Autor
        {
            get { return autor; }
            set
            {
                if (value.Trim() != "" && value != null)
                { autor = value; }
                else
                { throw new Exception("Digite el autor o autores del ejemplar"); }
            }
        }

        public int Anio
        {
            get { return anio; }
            set
            {
                if (value > 0)
                { anio = value; }
                else
                { throw new Exception("El año de publicación del ejemplar debe ser mayor que cero"); }
            }
        }

        public string Editorial
        {
            get { return editorial; }
            set
            {
                if (value.Trim() != "" && value != null)
                { editorial = value; }
                else
                { throw new Exception("Digite la editorial del ejemplar"); }
            }
        }

        public string Categoria
        {
            get { return categoria; }
            set
            {
                if (value.Trim() != "" && value != null)
                { categoria = value; }
                else
                { throw new Exception("Seleccione la categoria del ejemplar"); }
            }
        }

        public string Formato
        {
            get { return formato; }
            set
            {
                if (value.Trim() != "" && value != null)
                { formato = value; }
                else
                { throw new Exception("Seleccione el formato del ejemplar"); }
            }
        }

        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }

////////Constructor

        public Ejemplares()
        { }

        public Ejemplares(string referencia, string nombre, string descripcion, int cantidad,
                          string estado, string autor, int anio, string editorial, string categoria,
                          string formato, string foto)
        {
            this.Referencia = referencia;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Cantidad = cantidad;
            this.Estado = estado;
            this.Autor = autor;
            this.Anio = anio;
            this.Editorial = editorial;
            this.Categoria = categoria;
            this.Formato = formato;
            this.Foto = Foto;
        }

    }
}
