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
    public class AutoresBLL:IAbstract<Autores,int>
    {
        string s;
        Conexion c = new Conexion();

        public void Add(Autores obj)
        {
            
            try
            {
                string f = string.Format("{0: MM/dd/yyyy}", obj.Fechanacimiento);
                s = "INSERT INTO autores (nombre, apellido, direccion, fechanacimiento,genero, foto) values ('{0}', '{1}', '{2}', '{3}','{4}','{5}')";
                s = string.Format(s, obj.Nombre, obj.Apellido, obj.Direccion,f, obj.Genero, obj.Foto);
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
                s = "UPDATE autores SET nombre='{0}', apellido='{1}', direccion='{2}', fechanacimiento='{3}', genero='{4}', foto='{5}' WHERE id='{6}'";
                s = string.Format(s, obj.Nombre, obj.Apellido, obj.Direccion, f, obj.Genero, obj.Foto, obj.Id);
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
                s = "DELETE FROM autores WHERE id={0}";
                s = string.Format(s, id);
                c.ExecuteNonQuery(s);
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

                s = "SELECT * FROM autores WHERE id={0}";
                s = string.Format(s, id);

                DataTable dt = new DataTable();
                Autores aut = new Autores();


                dt = c.ExecuteQuery(s);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {

                        aut.Id= Convert.ToInt32(row[0]);
                        aut.Nombre=row[1].ToString();
                        aut.Apellido=row[2].ToString();
                        aut.Direccion=row[3].ToString();
                        aut.Fechanacimiento=Convert.ToDateTime(row[4]);
                        aut.Genero=Convert.ToChar(row[5]);
                        aut.Foto=row[6].ToString();

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


        public DataTable GetAll()
        {
            try
            {

                s = "SELECT * FROM autores";

                DataTable dt = new DataTable();
                //List<Autores> ls = new List<Autores>();


                dt = c.ExecuteQuery(s);

                //if (dt.Rows.Count > 0)
                //{
                //    foreach (DataRow row in dt.Rows)
                //    {

                //        ls.Add(new Autores(Convert.ToInt32(row[0]), row[1].ToString(), row[2].ToString(), row[3].ToString(), Convert.ToDateTime(row[4]), Convert.ToChar(row[5]), row[6].ToString()));

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
