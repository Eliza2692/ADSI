using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.IO;

namespace DAL
{
    public class ManagementProveedores:IAbstract<Proveedores, int>
    {
        StreamWriter sw;
        StreamReader sr;
        List<Proveedores> ls = new List<Proveedores>();
        String f, directory = @"C:\Inventario";  

        public ManagementProveedores(String file) {
            this.f = file;
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
        }

        public void Insert(Proveedores obj)
        {
            try
            {
                sw = new StreamWriter(f, true);

                sw.WriteLine(obj.Id);
                sw.WriteLine(obj.Nombre);
                sw.WriteLine(obj.Direccion);
                sw.WriteLine(obj.Telefono);
                sw.WriteLine(obj.Email);
                sw.WriteLine(obj.Estado);

                sw.Close();

                ls.Add(obj);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Proveedores obj)
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

        public void Delete(Proveedores obj)
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

        public Proveedores GetById(int id)
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

        public List<Proveedores> ReadAll()
        {
            try
            {
                if (!File.Exists(f))
                    return null;

                sr = new StreamReader(f, true);
                ls = new List<Proveedores>();

                while (!sr.EndOfStream)
                {
                    Proveedores pro = new Proveedores();
                    pro.Id = Convert.ToInt32(sr.ReadLine());
                    pro.Nombre = sr.ReadLine().ToString();
                    pro.Direccion = sr.ReadLine().ToString();
                    pro.Telefono = sr.ReadLine().ToString();
                    pro.Email = sr.ReadLine().ToString();
                    pro.Estado = Convert.ToBoolean(sr.ReadLine());

                    ls.Add(pro);

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

                List<Proveedores> lsTemp = new List<Proveedores>();

                lsTemp.AddRange(ls);

                ls.Clear();
                File.Delete(f);

                foreach (Proveedores pro in lsTemp)
                {
                    Insert(pro);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<Proveedores> ShowList(bool est)
        {
            try
            {
                List<Proveedores> lsTemp = new List<Proveedores>();

                foreach (Proveedores prov in ReadAll())
                {
                    if (prov.Estado == est)
                    {
                        lsTemp.Add(prov);
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
