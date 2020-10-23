using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace wmManejoArchivos.Clases
{
    class GestionEmpleados
    {
        //Campos

        private string ArchivoOriginal;
        private string ArchivoTemporal;
        private string directorio;
        StreamWriter sw;
        StreamReader sr;
        private List<Empleados> lst;

        //Constructor

        public GestionEmpleados()
        {
            ArchivoOriginal = @"c:\Empleados\empleados.txt";
            ArchivoTemporal = @"c:\Empleados\temporal.txt";
            directorio = @"c:\Empleados";
            if (!Directory.Exists(directorio))
                Directory.CreateDirectory(directorio);
            if (!File.Exists(ArchivoOriginal))
            {
                sw = new StreamWriter(ArchivoOriginal, true);
                sw.Close();
            }
            lst = new List<Empleados>();
        }

        //metodos
        public void Add(Empleados obj)
        {
            try
            {
                sw = new StreamWriter(ArchivoOriginal, true);
                sw.WriteLine(obj.Codigo);
                sw.WriteLine(obj.Nombre);
                sw.WriteLine(obj.Apellido);
                sw.WriteLine(obj.FechaIngreso);
                sw.WriteLine(obj.Foto);
                sw.WriteLine(obj.Cargo);
                sw.WriteLine(obj.Genero);
                sw.WriteLine(obj.Salario);
                sw.WriteLine(obj.Ciudad);
                sw.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Empleados GetById(string id)
        {
            try
            {
                Empleados obj;
                sr = new StreamReader(ArchivoOriginal, true);
                while (!sr.EndOfStream)
                {
                    obj = new Empleados();
                    obj.Codigo = sr.ReadLine();
                    obj.Nombre = sr.ReadLine();
                    obj.Apellido = sr.ReadLine();
                    obj.FechaIngreso = DateTime.Parse(sr.ReadLine());
                    obj.Foto = sr.ReadLine();
                    obj.Cargo = sr.ReadLine();
                    obj.Genero = sr.ReadLine();
                    obj.Salario = Double.Parse(sr.ReadLine());
                    obj.Ciudad = sr.ReadLine();
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

        public void Delete(string id)
        {
            try
            {
                Empleados obj;
                sr = new StreamReader(ArchivoOriginal, true);
                sw = new StreamWriter(ArchivoTemporal, true);
                while (!sr.EndOfStream)
                {
                    obj = new Empleados();
                    obj.Codigo = sr.ReadLine();
                    obj.Nombre = sr.ReadLine();
                    obj.Apellido = sr.ReadLine();
                    obj.FechaIngreso = DateTime.Parse(sr.ReadLine());
                    obj.Foto = sr.ReadLine();
                    obj.Cargo = sr.ReadLine();
                    obj.Genero = sr.ReadLine();
                    obj.Salario = Double.Parse(sr.ReadLine());
                    obj.Ciudad = sr.ReadLine();
                    if (obj.Codigo.Equals(id))
                    {
                        sw.WriteLine(obj.Codigo);
                        sw.WriteLine(obj.Nombre);
                        sw.WriteLine(obj.Apellido);
                        sw.WriteLine(obj.FechaIngreso);
                        sw.WriteLine(obj.Foto);
                        sw.WriteLine(obj.Cargo);
                        sw.WriteLine(obj.Genero);
                        sw.WriteLine(obj.Salario);
                        sw.WriteLine(obj.Ciudad);
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

        public void Update(Empleados obj2)
        {
            try
            {
                Empleados obj;
                sr = new StreamReader(ArchivoOriginal, true);
                sw = new StreamWriter(ArchivoTemporal, true);
                while (!sr.EndOfStream)
                {
                    obj = new Empleados();
                    obj.Codigo = sr.ReadLine();
                    obj.Nombre = sr.ReadLine();
                    obj.Apellido = sr.ReadLine();
                    obj.FechaIngreso = DateTime.Parse(sr.ReadLine());
                    obj.Foto = sr.ReadLine();
                    obj.Cargo = sr.ReadLine();
                    obj.Genero = sr.ReadLine();
                    obj.Salario = Double.Parse(sr.ReadLine());
                    obj.Ciudad = sr.ReadLine();
                    if (obj.Codigo.Equals(obj2.Codigo))
                    {
                        sw.WriteLine(obj2.Codigo);
                        sw.WriteLine(obj2.Nombre);
                        sw.WriteLine(obj2.Apellido);
                        sw.WriteLine(obj2.FechaIngreso);
                        sw.WriteLine(obj2.Foto);
                        sw.WriteLine(obj2.Cargo);
                        sw.WriteLine(obj2.Genero);
                        sw.WriteLine(obj2.Salario);
                        sw.WriteLine(obj2.Ciudad);
                    }
                    else 
                    {
                        sw.WriteLine(obj.Codigo);
                        sw.WriteLine(obj.Nombre);
                        sw.WriteLine(obj.Apellido);
                        sw.WriteLine(obj.FechaIngreso);
                        sw.WriteLine(obj.Foto);
                        sw.WriteLine(obj.Cargo);
                        sw.WriteLine(obj.Genero);
                        sw.WriteLine(obj.Salario);
                        sw.WriteLine(obj.Ciudad);
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

        public List<Empleados> GetAll()
        {
            try
            {
                Empleados obj;
                sr = new StreamReader(ArchivoOriginal, true);
                lst.Clear();
                while (!sr.EndOfStream)
                {
                    obj = new Empleados();
                    obj.Codigo = sr.ReadLine();
                    obj.Nombre = sr.ReadLine();
                    obj.Apellido = sr.ReadLine();
                    obj.FechaIngreso = DateTime.Parse(sr.ReadLine());
                    obj.Foto = sr.ReadLine();
                    obj.Cargo = sr.ReadLine();
                    obj.Genero = sr.ReadLine();
                    obj.Salario = Double.Parse(sr.ReadLine());
                    obj.Ciudad = sr.ReadLine();
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
