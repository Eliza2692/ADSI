using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Biblioteca.Clases;

namespace Biblioteca.Gestion
{
    class GestionUsuarios
    {

/////////////////CAMPOS

        private string ArchivoOriginal;
        private string ArchivoTemporal;
        private string directorio;
        StreamWriter sw;
        StreamReader sr;
        private List<Usuarios> lst;

        //GENERAR ARHIVOS*****************************************************************************************

        public GestionUsuarios()
        {
            ArchivoOriginal = @"c:\Biblioteca\usuarios.txt";
            ArchivoTemporal = @"c:\Biblioteca\usuariostmp.txt";
            directorio = @"c:\Biblioteca";

            if (!Directory.Exists(directorio))         
                Directory.CreateDirectory(directorio);
            if (!File.Exists(ArchivoOriginal))
            {
                sw = new StreamWriter(ArchivoOriginal, true);
                sw.Close();
            }
            lst = new List<Usuarios>();
        }

        /////////////////METODOS

        //Agregar usuario
        public void Add(Usuarios obj)
        {
            try
            {
                sw = new StreamWriter(ArchivoOriginal, true);
                sw.WriteLine(obj.Codigo);
                sw.WriteLine(obj.Contrasena);
                sw.WriteLine(obj.Nombre);
                sw.WriteLine(obj.Apellido);
                sw.WriteLine(obj.Correo);
                sw.WriteLine(obj.Telefono);
                sw.WriteLine(obj.Direccion);
                sw.WriteLine(obj.Cargo);
                sw.WriteLine(obj.Foto);
                sw.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Buscar por Codigo
        public Usuarios GetById(string id)
        {
            try
            {
                Usuarios obj;
                sr = new StreamReader(ArchivoOriginal, true);
                while (!sr.EndOfStream)
                {
                    obj = new Usuarios();
                    obj.Codigo = sr.ReadLine();
                    obj.Contrasena = sr.ReadLine();
                    obj.Nombre = sr.ReadLine();
                    obj.Apellido = sr.ReadLine();
                    obj.Correo = sr.ReadLine();
                    obj.Telefono = sr.ReadLine();
                    obj.Direccion = sr.ReadLine();
                    obj.Cargo = sr.ReadLine();
                    obj.Foto = sr.ReadLine();

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

        //Validar usuario y contraseña
        public Usuarios Login(string id, string pass)
        {
            try
            {
                Usuarios obj;
                sr = new StreamReader(ArchivoOriginal, true);
                while (!sr.EndOfStream)
                {
                    obj = new Usuarios();
                    obj.Codigo = sr.ReadLine();
                    obj.Contrasena = sr.ReadLine();
                    obj.Nombre = sr.ReadLine();
                    obj.Apellido = sr.ReadLine();
                    obj.Correo = sr.ReadLine();
                    obj.Telefono = sr.ReadLine();
                    obj.Direccion = sr.ReadLine();
                    obj.Cargo = sr.ReadLine();
                    obj.Foto = sr.ReadLine();

                    if (obj.Codigo.Trim() == id && obj.Contrasena.Trim() == pass)
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
                Usuarios obj;
                sr = new StreamReader(ArchivoOriginal, true);
                sw = new StreamWriter(ArchivoTemporal, true);
                while (!sr.EndOfStream)
                {
                    obj = new Usuarios();
                    obj.Codigo =sr.ReadLine();
                    obj.Contrasena = sr.ReadLine();
                    obj.Nombre = sr.ReadLine();
                    obj.Apellido = sr.ReadLine();
                    obj.Correo = sr.ReadLine();
                    obj.Telefono = sr.ReadLine();
                    obj.Direccion = sr.ReadLine();
                    obj.Cargo = sr.ReadLine();
                    obj.Foto = sr.ReadLine();

                    if (!obj.Codigo.Equals(id))
                    {
                        sw.WriteLine(obj.Codigo);
                        sw.WriteLine(obj.Contrasena);
                        sw.WriteLine(obj.Nombre);
                        sw.WriteLine(obj.Apellido);
                        sw.WriteLine(obj.Correo);
                        sw.WriteLine(obj.Telefono);
                        sw.WriteLine(obj.Direccion);
                        sw.WriteLine(obj.Cargo);
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
        public void Update(Usuarios obj2)
        {
            try
            {
                Usuarios obj;

                sr = new StreamReader(ArchivoOriginal, true);
                sw = new StreamWriter(ArchivoTemporal, true);
                while (!sr.EndOfStream)
                {
                    obj = new Usuarios();
                    obj.Codigo = sr.ReadLine();
                    obj.Contrasena = sr.ReadLine();
                    obj.Nombre = sr.ReadLine();
                    obj.Apellido = sr.ReadLine();
                    obj.Correo = sr.ReadLine();
                    obj.Telefono = sr.ReadLine();
                    obj.Direccion = sr.ReadLine();
                    obj.Cargo = sr.ReadLine();
                    obj.Foto = sr.ReadLine();

                    if (obj.Codigo.Equals(obj2.Codigo))
                    {
                        sw.WriteLine(obj2.Codigo);
                        sw.WriteLine(obj2.Contrasena);
                        sw.WriteLine(obj2.Nombre);
                        sw.WriteLine(obj2.Apellido);
                        sw.WriteLine(obj2.Correo);
                        sw.WriteLine(obj2.Telefono);
                        sw.WriteLine(obj2.Direccion);
                        sw.WriteLine(obj2.Cargo);
                        sw.WriteLine(obj2.Foto);
                    }
                    else
                    {
                        sw.WriteLine(obj.Codigo);
                        sw.WriteLine(obj.Contrasena);
                        sw.WriteLine(obj.Nombre);
                        sw.WriteLine(obj.Apellido);
                        sw.WriteLine(obj.Correo);
                        sw.WriteLine(obj.Telefono);
                        sw.WriteLine(obj.Direccion);
                        sw.WriteLine(obj.Cargo);
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
        public List<Usuarios> GetAll()
        {
            try
            {
                Usuarios obj;
                sr = new StreamReader(ArchivoOriginal, true);
                lst.Clear();
                while (!sr.EndOfStream)
                {
                    obj = new Usuarios();
                    obj.Codigo = sr.ReadLine();
                    obj.Contrasena = sr.ReadLine();
                    obj.Nombre = sr.ReadLine();
                    obj.Apellido = sr.ReadLine();
                    obj.Correo = sr.ReadLine();
                    obj.Telefono = sr.ReadLine();
                    obj.Direccion = sr.ReadLine();
                    obj.Cargo = sr.ReadLine();
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
