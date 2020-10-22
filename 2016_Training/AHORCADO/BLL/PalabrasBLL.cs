using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using Entities;

namespace BLL
{
    public class PalabrasBLL
    {
        private string s;
        private Conexion c;

        public void Add(Palabras obj)
        {
            try
            {
                c = new Conexion();
                s = "INSERT INTO Palabra (Palabra) VALUES ('{0}')";
                s = string.Format(s, obj.Palabra);
                c.ExecuteNonQuery(s);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void Update(Palabras obj)
        {
            try
            {
                c = new Conexion();
                s = "UPDATE Palabra SET Palabra = '{0}' WHERE Id={1}";
                s = string.Format(s, obj.Palabra, obj.Id);
                c.ExecuteNonQuery(s);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable GetAll()
        {
            try
            {
                c = new Conexion();
                s = "SELECT * FROM Palabra";
                DataTable dt = new DataTable();
                return dt=c.ExecuteQuery(s);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Palabras GetById(int id)
        {
            try
            {
                c = new Conexion();
                s = "SELECT * FROM Palabra WHERE Id={0}";
                s = string.Format(s, id);
                
                DataTable dt = new DataTable();
                dt = c.ExecuteQuery(s);
                
                Palabras pal = new Palabras();
                
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        pal.Id = Convert.ToInt32(row[0]);
                        pal.Palabra = row[1].ToString();
                    }

                    return pal;
                }

                return null;
              
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int Count()
        {
            try
            {
                c = new Conexion();
                s = "SELECT COUNT(*) FROM PALABRA";

                int cant = 0;

                DataTable dt = new DataTable();
                dt = c.ExecuteQuery(s);

                foreach (DataRow row in dt.Rows)
                {
                    cant = Convert.ToInt32(row[0]);
                }

                return cant;

            }
            catch (Exception)
            {

                throw;
            }
        }
        
    }
}
