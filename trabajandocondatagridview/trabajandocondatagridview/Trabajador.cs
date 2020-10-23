using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajandocondatagridview
{
    class Trabajador
    {
        //Propiedades publicas de mi clase

        //Codigo del empleado
        private string _codigo;

        public string Codigo
        {
            get { return _codigo; }
            set
            {
                if (value.Trim() != "" && value != null)
                { _codigo = value; }
                else
                { throw new Exception("Digite la codigo del empleado"); }
            }
        }

        //Nombre del empleado
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (value.Trim() != "" && value != null)
                { _nombre = value; }
                else
                { throw new Exception("Digite el nombre del empleado"); }
            }
        }

        //Apellido del empleado
        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set
            {
                if (value.Trim() != "" && value != null)
                { _apellido = value; }
                else
                { throw new Exception("Digite el apellido del empleado"); }
            }
        }

        //Fecha de nacimiento del empleado
        private DateTime _fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set
            {
                if (value <= DateTime.Now)
                { _fechaNacimiento = value; }
                else
                { throw new Exception("La fecha no debe ser mayor a hoy"); }
            }
        }

        //Cargo del empleado
        private string _cargo;

        public string Cargo
        {
            get { return _cargo; }
            set
            {
                if (value.Trim() != "" && value != null)
                { _cargo = value; }
                else
                { throw new Exception("Digite el cargo del empleado"); }
            }
        }

        //Salario del empleado
        private decimal _salario;

        public decimal Salario
        {
            get { return _salario; }
            set
            {
                if (value > 0)
                { _salario = value; }
                else
                { throw new Exception("El salario debe ser mayor que cero"); }
            }
        }

        //Dependencia
        private string _dependencia;

        public string Dependencia
        {
            get { return _dependencia; }
            set
            {
                if (value.Trim() != "" && value != null)
                { _dependencia = value; }
                else
                { throw new Exception("Digite la dependencia del empleado"); }
            }
        }

        //Fecha de ingreso del empleado
        private DateTime _fechaIngreso;

        public DateTime FechaIngreso
        {
            get { return _fechaIngreso; }
            set { _fechaIngreso = value; }
        }

        //foto del empelado
        private string _foto;
        public string Foto
        {
            get { return _foto; }
            set { _foto = value; }
        }
        
    }
}
