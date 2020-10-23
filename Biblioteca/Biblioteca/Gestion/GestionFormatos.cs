using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Biblioteca.Clases;

namespace Biblioteca.Gestion
{
    class GestionFormatos
    {
/////////////////CAMPOS

        private string ArchivoOriginal;
        private string ArchivoTemporal;
        private string directorio;

        StreamWriter sw;
        StreamReader sr;

        private List<Formatos> lst;

        public GestionFormatos()
        {
            ArchivoOriginal = @"c:\Biblioteca\formatos.txt";
            ArchivoTemporal = @"c:\Biblioteca\formatostmp.txt";
            directorio = @"c:\Biblioteca";

            if (!Directory.Exists(directorio))
                Directory.CreateDirectory(directorio);
            if (!File.Exists(ArchivoOriginal))
            {
                sw = new StreamWriter(ArchivoOriginal, true);
                sw.Close();
            }
            lst = new List<Formatos>();
        }


        /////////////////METODOS

        //Agregar formato
        public void Add(Formatos obj)
        {
            try
            {
                sw = new StreamWriter(ArchivoOriginal, true);
                sw.WriteLine(obj.Codigo);
                sw.WriteLine(obj.Nombre);
                sw.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Buscar por Codigo
        public Formatos GetById(string id)
        {
            try
            {
                Formatos obj;
                sr = new StreamReader(ArchivoOriginal, true);
                while (!sr.EndOfStream)
                {
                    obj = new Formatos();
                    obj.Codigo = sr.ReadLine();
                    obj.Nombre = sr.ReadLine();
                    if (obj.Codigo.Equals(id))
                    {
                        sr.Close();
                        return obj;
                    }
                }
                sr.Close();
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Borrar
        public void Delete(string id)
        {
            try
            {
                Formatos obj;
                sr = new StreamReader(ArchivoOriginal, true);
                sw = new StreamWriter(ArchivoTemporal, true);
                while (!sr.EndOfStream)
                {
                    obj = new Formatos();
                    obj.Codigo = sr.ReadLine();
                    obj.Nombre = sr.ReadLine();
                    if (!obj.Codigo.Equals(id))
                    {
                        sw.WriteLine(obj.Codigo);
                        sw.WriteLine(obj.Nombre);
                    }
                }
                sw.Close();
                sr.Close();
                File.Delete(ArchivoOriginal);
                File.Move(ArchivoTemporal, ArchivoOriginal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Actualizar
        public void Update(Formatos obj2)
        {
            try
            {
                Formatos obj;
                sr = new StreamReader(ArchivoOriginal, true);
                sw = new StreamWriter(ArchivoTemporal, true);
                while (!sr.EndOfStream)
                {
                    obj = new Formatos();
                    obj.Codigo = sr.ReadLine();
                    obj.Nombre = sr.ReadLine();
                    if (obj.Codigo.Equals(obj2.Codigo))
                    {
                        sw.WriteLine(obj2.Codigo);
                        sw.WriteLine(obj2.Nombre);
                    }
                    else
                    {
                        sw.WriteLine(obj.Codigo);
                        sw.WriteLine(obj.Nombre);
                    }
                }
                sw.Close();
                sr.Close();
                File.Delete(ArchivoOriginal);
                File.Move(ArchivoTemporal, ArchivoOriginal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //leer todo 
        public List<Formatos> GetAll()
        {
            try
            {
                Formatos obj;
                sr = new StreamReader(ArchivoOriginal, true);
                lst.Clear();
                while (!sr.EndOfStream)
                {
                    obj = new Formatos();
                    obj.Codigo = sr.ReadLine();
                    obj.Nombre = sr.ReadLine();
                    lst.Add(obj);
                }
                sr.Close();
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
