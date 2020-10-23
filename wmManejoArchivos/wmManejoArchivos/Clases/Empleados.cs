using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wmManejoArchivos
{
    class Empleados
    {
        private string codigo;

        public string Codigo
        {
            get { return codigo;}
            set
            {
                if (value.Trim() != "" && value != null)
                { codigo = value; }
                else
                { throw new Exception("Código obligatorio"); }
            }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (value.Trim() != "" && value != null)
                {nombre = value; }
                else
                { throw new Exception("Digite el Nombre"); }
            }
        }

        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set
            {
                if (value.Trim() != "" && value != null)
                { apellido = value; }
                else
                { throw new Exception("Digite el Apellido"); }
            }
        }

        private DateTime fechaIngreso;

        public DateTime FechaIngreso
        {
            get { return fechaIngreso; }
            set
            {
                if (value <= DateTime.Now)
                { fechaIngreso = value; }
                else
                { throw new Exception("La fecha no debe ser mayor a hoy"); }
            }
        }

        private string foto;

        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        private string cargo;

        public string Cargo
        {
            get { return cargo; }
            set
            {
                if (value.Trim() != "" && value != null)
                { cargo = value; }
                else
                { throw new Exception("Seleccione un cargo"); }
            }
        }

        private string genero;

        public string Genero
        {
            get { return genero; }
            set
            {
                if (value.Trim() != "" && value != null)
                {genero = value; }
                else
                { throw new Exception("Seleccione el género"); }
            }
        }

        private double salario;

        public double Salario
        {
            get { return salario; }
            set 
            { 
                if (value > 0)
                { salario = value; }
                else
                { throw new Exception("El valor del salario debe ser mayor que 0"); }
            }
        }

        private string ciudad;

        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        //Constructores

        public Empleados()
        { }

        public Empleados(string codigo, string nombre, string apellido, DateTime fechaIngreso,
                         string foto, string cargo, string genero, double salario, string ciudad)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaIngreso = fechaIngreso;
            this.Foto = foto;
            this.Cargo = cargo;
            this.Genero = genero;
            this.Salario = salario;
            this.Ciudad = ciudad;
        }
    }
}
