using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datagrid2
{
    class Productos
    {
        //Campos
        private string _referencia;
        private string _nombre;
        private decimal _precioCompra;
        private decimal _precioVenta;
        private int _cantidad;
        private string _foto;
        private DateTime _fechaIngreso;
        private string _lugarAlmacenamiento;
        private string _caracteristica;

        //Propiedades publicas de mi clase
        public string Referencia
        {
            get { return _referencia; }
            set 
            {
                if (value.Trim() != "" && value != null)
                {  _referencia = value; }
                else
                { throw new Exception("Digite la referencia del producto"); }
            }
        }

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (value.Trim() != "" && value != null)
                { _nombre = value; }
                else
                { throw new Exception("Digite el nombre del producto"); }
            }
        }

        public decimal PrecioCompra
        {
            get { return _precioCompra; }
            set
            {
                if (value > 0)
                { _precioCompra = value; }
                else
                { throw new Exception("El precio de compra no debe ser inferior a cero"); }
            }
        }

        public decimal PrecioVenta
        {
            get { return _precioVenta; }
            set
            {
                if (value > 0)
                { _precioVenta = value; }
                else
                { throw new Exception("El precio de venta no debe ser inferior a cero"); }
            }
        }

        public int Cantidad
        {
            get { return _cantidad; }
            set 
            {
                if (value > 0)
                { _cantidad = value; }
                else
                { throw new Exception("La cantidad no debe ser inferior a cero"); }
            }
        }

        public string Foto
        { 
            get{return _foto;}
            set{ _foto = value; } 
        }

        public DateTime FechaIngreso
        {
            get {return _fechaIngreso;}
            set 
            {
                if (value <= DateTime.Now)
                { _fechaIngreso = value; }
                else
                { throw new Exception("La fecha no debe ser mayor a hoy"); }
            }
        }

        public string LugarAlmacenamiento
        {
            get { return _lugarAlmacenamiento; }
            set 
            {
                if (value.Trim() != "" && value != null)
                { _lugarAlmacenamiento = value; }
                else
                { throw new Exception("Digite el lugar de almacenamiento del producto"); }
            }
        }

        public string Caracteristica
        {
            get { return _caracteristica; }
            set 
            {
                if (value.Trim() != "" && value != null)
                { _caracteristica = value; }
                else
                { throw new Exception("Digite las caracteristicas del producto"); }
            }
        }
    }
}
