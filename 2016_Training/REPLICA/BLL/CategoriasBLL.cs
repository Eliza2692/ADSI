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
        private string s;
        Conexion c = new Conexion();

        public void Add(Categorias obj)
        {
            try
            {
                s = "INSERT INTO categorias (nombre) VALUES ('{0}')";
                s= string.Format(s,obj.Nombre);
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
                s = "UPDATE categorias SET nombre='{0}' WHERE ID='{1}'";
                s = string.Format(s, obj.Nombre, obj.Id);
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
                s = "DELETE FROM categorias WHERE id={0}";
                s = string.Format(s, id);
                c.ExecuteNonQuery(s);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            
        }

        public System.Data.DataTable GetAll()
        {
            try
            {
                s = "SELECT * FROM categorias";
                s = string.Format(s);            
                DataTable dt = new DataTable();
                return dt = c.ExecuteQuery(s);
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
                s = "SELECT * FROM categorias WHERE ID = '{0}' ";
                s = string.Format(s, id);
                DataTable dt = new DataTable();
                dt = c.ExecuteQuery(s);
                Categorias cat = new Categorias();
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
            catch (Exception ex)
            {                
                throw ex;
            }
                
        }
    }
}
