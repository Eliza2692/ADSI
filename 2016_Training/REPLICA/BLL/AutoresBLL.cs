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
    public class AutoresBLL:IAbstract<Autores, int>
    {
        private string s;
        Conexion c = new Conexion();

        public void Add(Autores obj)
        {
            try
            {

                string f = string.Format("{0: MM/dd/yyyy}",obj.Fechanacimiento);

                s = "INSERT INTO AUTORES (NOMBRE, apellido, direccion, fechanacimiento, genero, foto) VALUES ('{0}','{1}', '{2}', '{3}', '{4}', '{5}')";
                s= string.Format(s, obj.Nombre, obj.Apellido, obj.Direccion, f, obj.Genero, obj.Foto);
                c.ExecuteNonQuery(s);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public void Update(Autores obj)
        {
            try
            {
                string f = string.Format("{0: MM/dd/yyyy}", obj.Fechanacimiento);
                s = "UPDATE AUTORES SET nombre='{0}', apellido='{1}', direccion='{2}', fechanacimiento = '{3}', genero = '{4}', foto = '{5}' where id = {6}";
                s = string.Format(s,obj.Nombre, obj.Apellido,obj.Direccion,f,obj.Genero,obj.Foto,obj.Id);
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
                s = "DELETE FROM AUTORES WHERE ID = {0}";
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
                s = "SELECT * FROM autores";
                s = string.Format(s);            
                DataTable dt = new DataTable();
                return dt = c.ExecuteQuery(s);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            
        }

        public Autores GetById(int id)
        {
            try
            {
                s = "SELECT * FROM autores WHERE ID = {0}";
                s = string.Format(s, id);
                DataTable dt = new DataTable();
                dt = c.ExecuteQuery(s);
                Autores aut = new Autores();
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        aut.Id = Convert.ToInt32(row[0]);
                        aut.Nombre = row[1].ToString();
                        aut.Apellido = row[2].ToString();
                        aut.Direccion = row[3].ToString();
                        aut.Fechanacimiento = Convert.ToDateTime(row[4]);
                        aut.Genero = Convert.ToChar(row[5]);
                        aut.Foto = row[6].ToString();
                    }
                    return aut;
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
