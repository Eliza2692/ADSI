using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Biblioteca.Clases;

namespace Biblioteca.Gestion
{
    class GestionCategorias
    {

/////////////////CAMPOS

        private string ArchivoOriginal;
        private string ArchivoTemporal;
        private string directorio;

        StreamWriter sw;
        StreamReader sr;

        private List<Categorias> lst;

    //Crea las carpetas y los archivos
        public GestionCategorias()
        {
            ArchivoOriginal = @"c:\Biblioteca\categorias.txt";
            ArchivoTemporal = @"c:\Biblioteca\categoriastmp.txt";
            directorio = @"c:\Biblioteca";

            if (!Directory.Exists(directorio))
                Directory.CreateDirectory(directorio);

            if (!File.Exists(ArchivoOriginal))
            {
                sw = new StreamWriter(ArchivoOriginal, true);
                sw.Close();
            }
            lst = new List<Categorias>();
        }

/////////////////METODOS

        //Agregar categoria
        public void Add(Categorias obj)
        {
            try
            {
                sw = new StreamWriter(ArchivoOriginal, true);
                sw.WriteLine(obj.Codigo);
                sw.WriteLine(obj.Nombre);
                sw.WriteLine(obj.Descripcion);
                sw.WriteLine(obj.Logo);
                sw.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Buscar por Codigo
        public Categorias GetById(string id)
        {
            try
            {
                Categorias obj;
                sr = new StreamReader(ArchivoOriginal, true);
                while (!sr.EndOfStream)
                {
                    obj = new Categorias();
                    obj.Codigo = sr.ReadLine();
                    obj.Nombre = sr.ReadLine();
                    obj.Descripcion = sr.ReadLine();
                    obj.Logo = sr.ReadLine();
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
                Categorias obj;
                sr = new StreamReader(ArchivoOriginal, true);
                sw = new StreamWriter(ArchivoTemporal, true);
                while (!sr.EndOfStream)
                {
                    obj = new Categorias();
                    obj.Codigo = sr.ReadLine();
                    obj.Nombre = sr.ReadLine();
                    obj.Descripcion = sr.ReadLine();
                    obj.Logo = sr.ReadLine();

                    if (!obj.Codigo.Equals(id))
                    {
                        sw.WriteLine(obj.Codigo);
                        sw.WriteLine(obj.Nombre);
                        sw.WriteLine(obj.Descripcion);
                        sw.WriteLine(obj.Logo);
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
        public void Update(Categorias obj2)
        {
            try
            {
                Categorias obj;

                sr = new StreamReader(ArchivoOriginal, true);
                sw = new StreamWriter(ArchivoTemporal, true);
                while (!sr.EndOfStream)
                {
                    obj = new Categorias();
                    obj.Codigo = sr.ReadLine();
                    obj.Nombre = sr.ReadLine();
                    obj.Descripcion = sr.ReadLine();
                    obj.Logo = sr.ReadLine();
                    if (obj.Codigo.Equals(obj2.Codigo))
                    {
                        sw.WriteLine(obj2.Codigo);
                        sw.WriteLine(obj2.Nombre);
                        sw.WriteLine(obj2.Descripcion);
                        sw.WriteLine(obj2.Logo);
                    }
                    else
                    {
                        sw.WriteLine(obj.Codigo);
                        sw.WriteLine(obj.Nombre);
                        sw.WriteLine(obj.Descripcion);
                        sw.WriteLine(obj.Logo);
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
        public List<Categorias> GetAll()
        {
            try
            {
                Categorias obj;
                sr = new StreamReader(ArchivoOriginal, true);
                lst.Clear();
                while (!sr.EndOfStream)
                {
                    obj = new Categorias();
                    obj.Codigo = sr.ReadLine();
                    obj.Nombre = sr.ReadLine();
                    obj.Descripcion = sr.ReadLine();
                    obj.Logo = sr.ReadLine();
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

