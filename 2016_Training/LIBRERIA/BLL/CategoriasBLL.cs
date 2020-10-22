using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
using System.Data;

namespace BLL
{
    public class CategoriasBLL:IAbstract<Categorias, int>
    {
        string s;
        Conexion c = new Conexion();

        public void Add(Categorias obj)
        {
            try
            {
                s="INSERT INTO categorias (nombre) values ('{0}')";
                s = string.Format(s, obj.Nombre);
                c.ExecuteNonQuery(s);

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

                s = "UPDATE categorias SET nombre = '{0}' WHERE ID = '{1}'";

                s = String.Format(s, obj.Nombre, obj.Id);

                c.ExecuteNonQuery(s);

            }
            catch (Exception ex)
            {
                
                throw ex;
            }

        }

        public void Delete(int id)
        {
            try
            {

                s = "DELETE FROM CATEGORIAS WHERE ID = '{0}'";

                s = String.Format(s, id);

                c.ExecuteNonQuery(s);

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
                s="SELECT * FROM categorias WHERE ID='{0}'";
                s = string.Format(s, id);

                DataTable dt = new DataTable();
                Categorias cat = new Categorias();

                dt = c.ExecuteQuery(s);

                if (dt.Rows.Count>0) 
                {

                    foreach (DataRow row in dt.Rows)
                    {
                        cat.Id = Convert.ToInt32(row[0]);
                        cat.Nombre = row[1].ToString();
                    }
                    return cat;
                
                }
                return null;

            }
            catch (Exception EX)
            {
                
                throw EX;
            }
        }


        public DataTable GetAll()
        {
            try
            {

                s = "SELECT * FROM CATEGORIAS";

                DataTable dt = new DataTable();
                
                //List<Categorias> ls = new List<Categorias>();
                dt = c.ExecuteQuery(s);

                //if (dt.Rows.Count > 0)
                //{
                //    foreach (DataRow row in dt.Rows)
                //    {

                //        ls.Add(new Categorias(Convert.ToInt32(row[0]), row[1].ToString()));

                //    }
                //    return ls;
                //}
                //return null;
                return dt;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
