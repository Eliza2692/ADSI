using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Productos
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

        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set {
                if (value < 0)
                    throw new Exception("DEBE SER MAYOR O IGUAL QUE CERO");
                cantidad = value; 
            }
        }

        private int stockMinimo;

        public int StockMinimo
        {
            get { return stockMinimo; }
            set { 
                if(value<0)
                    throw new Exception("DEBE SER MAYOR O IGUAL QUE CERO");
                stockMinimo = value;
                    
            }
        }

        private DateTime fechaIngreso;

        public DateTime FechaIngreso
        {
            get { return fechaIngreso; }
            set {
                if (value > DateTime.Now)
                    throw new Exception("FECHA NO ES VALIDA");
                fechaIngreso = value;
            }
        }

        private int idProveedor;

        public int IdProveedor
        {
            get { return idProveedor; }
            set {
                if (value < 0)
                    throw new Exception("DEBE SER MAYOR O IGUAL QUE CERO");
                idProveedor = value; 
            }
        }

        private int idCategoria;

        public int IdCategoria
        {
            get { return idCategoria; }
            set {
                if (value < 0)
                    throw new Exception("DEBE SER MAYOR O IGUAL QUE CERO");
                idCategoria = value; 
            }
        }

        private Decimal precioVenta;

        public Decimal PrecioVenta
        {
            get { return precioVenta; }
            set {
                if (value < 0)
                    throw new Exception("PRECIO VENTA NO VALIDO");
                precioVenta = value; 
            }
        }

        private Decimal precioCompra;

        public Decimal PrecioCompra
        {
            get { return precioCompra; }
            set {
                if (value < 0)
                    throw new Exception("PRECIO COMPRA NO VALIDO");
                precioCompra = value; 
            }
        }

        private String imagen;

        public String Imagen
        {
            get { return imagen; }
            set {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("IMAGEN NO SELECCIONADA");
                imagen = value; 
            }
        }
        
    }
}
