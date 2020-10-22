﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Categorias
    {

        private int id;

        public int Id
        {
            get { return id; }
            set
            {

                if (value <= 0)
                    throw new Exception("CÓDIGO DEBE SER MAYOR QUE CERO");
                id = value;

            }
        }


        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set
            {

                if (String.IsNullOrEmpty(value))
                    throw new Exception("EL NOMBRE NO ES VALIDO");
                nombre = value;
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
