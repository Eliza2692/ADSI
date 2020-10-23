using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Biblioteca.Clases;

namespace Biblioteca.Gestion
{
    class GestionEjemplares
    {
/////////////////CAMPOS

        List<Ejemplares> Contexto = new List<Ejemplares>();
        private string ArchivoOriginal;
        private string ArchivoTemporal;
        private string directorio;

        StreamWriter sw;
        StreamReader sr;
        
        private List<Ejemplares> lst;

        //Crea las carpetas y los archivos
        public GestionEjemplares() 
        {
            ArchivoOriginal = @"c:\Biblioteca\Ejemplares.txt";
            ArchivoTemporal = @"c:\Biblioteca\Ejemplarestmp.txt";
            directorio = @"c:\Biblioteca";

            if (!Directory.Exists(directorio))
                Directory.CreateDirectory(directorio);
            if (!File.Exists(ArchivoOriginal))
            {
                sw = new StreamWriter(ArchivoOriginal, true);
                sw.Close();
            }
            lst = new List<Ejemplares>();
        }

/////////////////METODOS

        //Agregar Ejemplar
         public void Add(Ejemplares obj)
        {
            try
            {
                sw = new StreamWriter(ArchivoOriginal, true);
                sw.WriteLine(obj.Referencia);
                sw.WriteLine(obj.Nombre);
                sw.WriteLine(obj.Descripcion);
                sw.WriteLine(obj.Cantidad);
                sw.WriteLine(obj.Estado);
                sw.WriteLine(obj.Autor);
                sw.WriteLine(obj.Anio);
                sw.WriteLine(obj.Editorial);
                sw.WriteLine(obj.Categoria);
                sw.WriteLine(obj.Formato);
                sw.WriteLine(obj.Foto);
                sw.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

         //Buscar por Codigo
        public Ejemplares GetById(string id)
        {
            try
            {
                Ejemplares obj;
                sr = new StreamReader(ArchivoOriginal, true);
                while (!sr.EndOfStream)
                {
                    obj = new Ejemplares();
                    obj.Referencia = sr.ReadLine();
                    obj.Nombre = sr.ReadLine();
                    obj.Descripcion = sr.ReadLine();
                    obj.Cantidad = Convert.ToInt32(sr.ReadLine());
                    obj.Estado = sr.ReadLine();
                    obj.Autor = sr.ReadLine();
                    obj.Anio = Convert.ToInt32(sr.ReadLine());
                    obj.Editorial = sr.ReadLine();
                    obj.Categoria = sr.ReadLine();
                    obj.Formato = sr.ReadLine();
                    obj.Foto = sr.ReadLine();

                    if (obj.Referencia.Equals(id))
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

        //Buscar por Editorial
        public Ejemplares GetByEditorial(string Editorial)
        {
            foreach (Ejemplares e in Contexto)
            {
                if (e.Editorial.Contains(Editorial))
                    return e;                                
            }
            return null;
        }

        //Buscar por Autor
        public Ejemplares GetByAutor(string Autor)
        {
            foreach (Ejemplares e in Contexto)
            {
                if (e.Autor.Contains(Autor))
                    return e;
            }
            return null;
        }

        //Buscar por Categoria
        public Ejemplares GetByCategoria(string Categoria)
        {
            foreach (Ejemplares e in Contexto)
            {
                if (e.Categoria.Contains(Categoria))
                    return e;             
            }
            return null;
        }

        //Buscar por Formato
        public Ejemplares GetByFormatos(string Formatos)
        {
            foreach (Ejemplares e in Contexto)
            {
                if (e.Formato.Contains(Formatos))
                    return e;
            }
            return null;
        }

        //Buscar por Nombre
        public Ejemplares GetByNombre(string Nombre)
        {
            foreach (Ejemplares e in Contexto)
            {
                if (e.Nombre.Contains(Nombre))
                    return e;
            }
            return null;
        }

        //Borrar
        public void Delete(string id)
        {
            try
            {
                Ejemplares obj;
                sr = new StreamReader(ArchivoOriginal, true);
                sw = new StreamWriter(ArchivoTemporal, true);
                while (!sr.EndOfStream)
                {
                    obj = new Ejemplares();
                    obj.Referencia = sr.ReadLine();
                    obj.Nombre = sr.ReadLine();
                    obj.Descripcion = sr.ReadLine();
                    obj.Cantidad = Convert.ToInt32(sr.ReadLine());
                    obj.Estado = sr.ReadLine();
                    obj.Autor = sr.ReadLine();
                    obj.Anio = Convert.ToInt32(sr.ReadLine());
                    obj.Editorial = sr.ReadLine();
                    obj.Categoria = sr.ReadLine();
                    obj.Formato = sr.ReadLine();
                    obj.Foto = sr.ReadLine();

                    if (!obj.Referencia.Equals(id))
                    {
                        sw.WriteLine(obj.Referencia);
                        sw.WriteLine(obj.Nombre);
                        sw.WriteLine(obj.Descripcion);
                        sw.WriteLine(obj.Cantidad);
                        sw.WriteLine(obj.Estado);
                        sw.WriteLine(obj.Autor);
                        sw.WriteLine(obj.Anio);
                        sw.WriteLine(obj.Editorial);
                        sw.WriteLine(obj.Categoria);
                        sw.WriteLine(obj.Formato);
                        sw.WriteLine(obj.Foto);
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
        public void Update(Ejemplares obj2)
        {
            try
            {
                Ejemplares obj;

                sr = new StreamReader(ArchivoOriginal, true);
                sw = new StreamWriter(ArchivoTemporal, true);
                while (!sr.EndOfStream)
                {
                    obj = new Ejemplares();
                    obj.Referencia = sr.ReadLine();
                    obj.Nombre = sr.ReadLine();
                    obj.Descripcion = sr.ReadLine();
                    obj.Cantidad = Convert.ToInt32(sr.ReadLine());
                    obj.Estado = sr.ReadLine();
                    obj.Autor = sr.ReadLine();
                    obj.Anio = Convert.ToInt32(sr.ReadLine());
                    obj.Editorial = sr.ReadLine();
                    obj.Categoria = sr.ReadLine();
                    obj.Formato = sr.ReadLine();
                    obj.Foto = sr.ReadLine();

                    if (obj.Referencia.Equals(obj2.Referencia))
                    {
                        sw.WriteLine(obj2.Referencia);
                        sw.WriteLine(obj2.Nombre);
                        sw.WriteLine(obj2.Descripcion);
                        sw.WriteLine(obj2.Cantidad);
                        sw.WriteLine(obj2.Estado);
                        sw.WriteLine(obj2.Autor);
                        sw.WriteLine(obj2.Anio);
                        sw.WriteLine(obj2.Editorial);
                        sw.WriteLine(obj2.Categoria);
                        sw.WriteLine(obj2.Formato);
                        sw.WriteLine(obj2.Foto);
                    }

                    else
                    {
                        sw.WriteLine(obj.Referencia);
                        sw.WriteLine(obj.Nombre);
                        sw.WriteLine(obj.Descripcion);
                        sw.WriteLine(obj.Cantidad);
                        sw.WriteLine(obj.Estado);
                        sw.WriteLine(obj.Autor);
                        sw.WriteLine(obj.Anio);
                        sw.WriteLine(obj.Editorial);
                        sw.WriteLine(obj.Categoria);
                        sw.WriteLine(obj.Formato);
                        sw.WriteLine(obj.Foto);
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
        public List<Ejemplares> GetAll()
        {
            try
            {
                Ejemplares obj;
                sr = new StreamReader(ArchivoOriginal, true);
                lst.Clear();
                while (!sr.EndOfStream)
                {
                    obj = new Ejemplares();
                    obj.Referencia = sr.ReadLine();
                    obj.Nombre = sr.ReadLine();
                    obj.Descripcion = sr.ReadLine();
                    obj.Cantidad = Convert.ToInt32(sr.ReadLine());
                    obj.Estado = sr.ReadLine();
                    obj.Autor = sr.ReadLine();
                    obj.Anio = Convert.ToInt32(sr.ReadLine());
                    obj.Editorial = sr.ReadLine();
                    obj.Categoria = sr.ReadLine();
                    obj.Formato = sr.ReadLine();
                    obj.Foto = sr.ReadLine();
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
