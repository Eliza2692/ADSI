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
    
    public class LibrosBLL:IAbstract<Libros,int>
    {

        private string s;
        private Conexion c=new Conexion();

        public void Add(Libros obj)
        {
            try
            {
                s = "INSERT INTO LIBROS (ISBN, nombre, ideditorial, numeropaginas, idcategoria, idautor) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')";
                s= string.Format(s, obj.Isbn, obj.Nombre, obj.Ideditorial, obj.Numeropaginas, obj.Idcategoria, obj.Idautor);
                c.ExecuteNonQuery(s);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }        }

        public void Update(Libros obj)
        {
            try
            {
                s = "UPDATE LIBROS SET ISBN = '{0}', NOMBRE = '{1}', ideditorial = '{2}', numeropaginas = '{3}', idcategoria = '{4}', idautor = '{5}' where id = '{6}'";
                s = string.Format(s, obj.Isbn, obj.Nombre, obj.Ideditorial, obj.Numeropaginas, obj.Idcategoria, obj.Idautor, obj.Id);
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
                s = "delete from libros where id = '{0}'";
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
                s = "SELECT L.id, L.isbn, L.nombre, E.nombre AS Editorial, L.numeropaginas, C.nombre AS Categoria,A.nombre AS Autor FROM  LIBROS L " +
                        "INNER JOIN editoriales E ON L.ideditorial=E.id " +
                        "INNER JOIN categorias C ON L.idcategoria=C.id " +
                        "INNER JOIN autores A ON L.idautor=A.id";
                s = string.Format(s);
                DataTable dt = new DataTable();
                return dt = c.ExecuteQuery(s);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Libros GetById(int id)
        {
            try
            {
                s = "SELECT * FROM LIBROS where id = '{0}'";
                s = string.Format(s, id);
                DataTable dt = new DataTable();
                dt = c.ExecuteQuery(s);
                Libros lib = new Libros();
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        lib.Id = Convert.ToInt32(row[0]);
                        lib.Isbn = row[1].ToString();
                        lib.Nombre = row[2].ToString();
                        lib.Ideditorial = Convert.ToInt32(row[3]);
                        lib.Numeropaginas = Convert.ToInt32(row[4]);
                        lib.Idcategoria = Convert.ToInt32(row[5]);
                        lib.Idautor = Convert.ToInt32(row[6]);

                    }
                    return lib;
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
