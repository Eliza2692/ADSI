using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDataGridView
{
    class Paises
    {
        private string _codigo;
        public string Codigo
        {
            get { return _codigo; }
            set
            {
                if (value.Trim() != "" && value != null)
                { _codigo = value; }
                else
                { throw new Exception("El campo es obligatorio"); }
            }
        }

        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (value.Trim() != "" && value != null)
                { _nombre = value; }
                else
                { throw new Exception("El campo es obligatorio"); }
            }
        }

        private string _bandera;
        public string Bandera
        {
            get { return _bandera; }
            set{_bandera = value;}
        }

        private bool _activo;
        public bool Activo
        {
            get { return _activo; }
            set { _activo = value; }
        }
    }
}
