using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL.Extensions
{
    public class ExtensionProductos
    {

        ManagementCategorias mngCat = new ManagementCategorias(@"C:\Inventario\categorias.txt");
        ManagementProductos mngProd = new ManagementProductos(@"C:\Inventario\productos.txt");
        ManagementProveedores mngProv = new ManagementProveedores(@"C:\Inventario\proveedores.txt");

        public List<Productos> SearchByCategoria(String cat) {

            try
            {
                List<Productos> listaProd = new List<Productos>();
                List<Productos> listaRes = new List<Productos>();
                listaProd = mngProd.ShowList(true);

                foreach (Productos prod in listaProd)
                {

                    if (prod.Nombre.Equals(cat)) {
                        listaRes.Add(prod);
                    }

                }
                return listaRes;

            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            
        }

    }
}
