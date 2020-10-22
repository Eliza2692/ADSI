using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.IO;

namespace DAL
{
    public class ManagementCategorias:IAbstract<Categorias, int>
    {
        StreamWriter sw;
        StreamReader sr;
        List<Categorias> ls = new List<Categorias>();
        String f, directory = @"C:\Inventario";        

        public ManagementCategorias(String file) {
            this.f = file;
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
        }

        public void Insert(Categorias obj)
        {
            try
            {
                sw = new StreamWriter(f, true);

                sw.WriteLine(obj.Id);
                sw.WriteLine(obj.Nombre);
                sw.WriteLine(obj.Estado);

                sw.Close();

                ls.Add(obj);

            }
            catch (Exception ex)
            {                
                throw ex; 
            }    


        }

        public void Update(Categorias obj)
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

        public void Delete(Categorias obj)
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

        public Categorias GetById(int id)
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

        public List<Categorias> ReadAll()
        {
            try
            {
                if (!File.Exists(f))
                    return null;

                sr = new StreamReader(f, true);
                ls = new List<Categorias>();

                while (!sr.EndOfStream)
                {
                    Categorias cat = new Categorias();
                    cat.Id = Convert.ToInt32(sr.ReadLine());
                    cat.Nombre = sr.ReadLine().ToString();
                    cat.Estado = Convert.ToBoolean(sr.ReadLine());

                    ls.Add(cat);

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

                List<Categorias> lsTemp = new List<Categorias>();

                lsTemp.AddRange(ls);

                ls.Clear();
                File.Delete(f);

                foreach (Categorias cat in lsTemp)
                {
                    Insert(cat);
                }

            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }

        public List<Categorias> ShowList(bool est)
        {
            try
            {
                List<Categorias> lsTemp = new List<Categorias>();

                foreach (Categorias cat in ReadAll())
                {
                    if (cat.Estado == est)
                    {
                        lsTemp.Add(cat);
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
