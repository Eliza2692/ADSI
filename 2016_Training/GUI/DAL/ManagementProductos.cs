using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.IO;

namespace DAL
{
    public class ManagementProductos:IAbstract<Productos,int>
    {
        StreamWriter sw;
        StreamReader sr;
        List<Productos> ls = new List<Productos>();
        String f, directory = @"C:\Inventario";        

        public ManagementProductos(String file) {
            this.f = file;
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
        }

        public void Insert(Productos obj)
        {
            try
            {
                sw = new StreamWriter(f, true);

                sw.WriteLine(obj.Id);
                sw.WriteLine(obj.Nombre);
                sw.WriteLine(obj.Cantidad);
                sw.WriteLine(obj.StockMinimo);
                sw.WriteLine(obj.FechaIngreso);
                sw.WriteLine(obj.IdProveedor);
                sw.WriteLine(obj.IdCategoria);
                sw.WriteLine(obj.PrecioVenta);
                sw.WriteLine(obj.PrecioCompra);
                sw.WriteLine(obj.Imagen);
                sw.WriteLine(obj.Estado);

                sw.Close();

                ls.Add(obj);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Productos obj)
        {
            try
            {
                int x = ls.IndexOf(GetById(obj.Id));

                ls.RemoveAt(x);

                ls.Insert(x, obj);

                ReWrite();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Delete(Productos obj)
        {
            try
            {
                obj.Estado = false;

                Update(obj);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Productos GetById(int id)
        {
            try
            {
                return ls.Where(R => R.Id.Equals(id)).SingleOrDefault();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Productos> ReadAll()
        {
            try
            {
                if (!File.Exists(f))
                    return null;

                sr = new StreamReader(f, true);
                ls = new List<Productos>();

                while (!sr.EndOfStream)
                {
                    Productos prod = new Productos();
                    prod.Id = Convert.ToInt32(sr.ReadLine());
                    prod.Nombre = sr.ReadLine().ToString();
                    prod.Cantidad = Convert.ToInt32(sr.ReadLine());
                    prod.StockMinimo = Convert.ToInt32(sr.ReadLine());
                    prod.FechaIngreso = Convert.ToDateTime(sr.ReadLine());
                    prod.IdProveedor = Convert.ToInt32(sr.ReadLine());
                    prod.IdCategoria = Convert.ToInt32(sr.ReadLine());
                    prod.PrecioVenta = Convert.ToDecimal(sr.ReadLine());
                    prod.PrecioCompra = Convert.ToDecimal(sr.ReadLine());
                    prod.Imagen = sr.ReadLine().ToString();
                    prod.Estado = Convert.ToBoolean(sr.ReadLine());

                    ls.Add(prod);

                }
                sr.Close();
                return ls;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ReWrite()
        {
            try
            {

                List<Productos> lsTemp = new List<Productos>();

                lsTemp.AddRange(ls);

                ls.Clear();
                File.Delete(f);

                foreach (Productos prod in lsTemp)
                {
                    Insert(prod);
                }

            }
            catch (Exception ex)
            {                
                throw ex;
            }
        
        }


        public List<Productos> ShowList(bool est)
        {
            try
            {
                List<Productos> lsTemp = new List<Productos>();

                foreach (Productos prod in ReadAll())
                {
                    if (prod.Estado == est)
                    {
                        lsTemp.Add(prod);
                    }
                }

                return lsTemp;

            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
