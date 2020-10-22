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
    public class EditorialesBLL:IAbstract<Editoriales, int>
    {
        string s;
        Conexion c = new Conexion();

        public void Add(Editoriales obj)
        {
            try
            {
                s = "INSERT INTO editoriales (nombre,direccion,telefono,email) values ('{0}','{1}', '{2}','{3}')";
                s = string.Format(s, obj.Nombre, obj.Direccion, obj.Telefono, obj.Email);
                c.ExecuteNonQuery(s);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            
        }

        public void Update(Editoriales obj)
        {
            try
            {
                s = "UPDATE editoriales SET nombre='{0}', direccion='{1}', telefono='{2}', email='{3}' WHERE id={4}";
                s = string.Format(s, obj.Nombre, obj.Direccion, obj.Telefono, obj.Email, obj.Id);
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
                s = "DELETE FROM editoriales WHERE id='{0}'";
                s = string.Format(s, id);
                c.ExecuteNonQuery(s);

            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }


        public Editoriales GetById(int id)
        {
            try
            {
                s = "SELECT * FROM editoriales WHERE ID='{0}'";
                s = string.Format(s, id);

                DataTable dt = new DataTable();
                Editoriales edit = new Editoriales();

                dt = c.ExecuteQuery(s);

                if (dt.Rows.Count > 0)
                {

                    foreach (DataRow row in dt.Rows)
                    {
                        edit.Id = Convert.ToInt32(row[0]);
                        edit.Nombre = row[1].ToString();
                        edit.Direccion = row[2].ToString();
                        edit.Telefono=row[3].ToString();
                        edit.Email=row[4].ToString();
                    }
                    return edit;

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
                s = "SELECT * FROM editoriales";
                DataTable dt = new DataTable();
                dt = c.ExecuteQuery(s);
                return dt;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
