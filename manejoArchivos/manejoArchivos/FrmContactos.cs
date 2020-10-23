using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace manejoArchivos
{
    public partial class FrmContactos : Form
    {
        //campos .....................
        static private FrmContactos f;

        private string ArchivoOriginal = @"C:\Carpeta1\MisContactos.txt";
        private string Temporal = @"c:\Carpeta1\tmp.txt";
        private List<Contactos> lst= new List<Contactos>();
        //metodos ....................
        
        //patron singlenton (instacia un formulario a la vez)
        static public FrmContactos GetInstances()
        {
            if (f == null)
            { f = new FrmContactos(); }

            return f;
        }

        public void FillGrid()
        {
            try
            {
                Contactos c;
                lst = new List<Contactos>();
                StreamReader sw = new StreamReader(ArchivoOriginal, true);
                while (!sw.EndOfStream)
                {
                    c = new Contactos(
                        sw.ReadLine(), sw.ReadLine(),
                        sw.ReadLine(), sw.ReadLine(),
                        sw.ReadLine(), sw.ReadLine());
                    lst.Add(c);
                }
                sw.Close();

                dgContacto.DataSource = null;
                dgContacto.DataSource = lst;
                dgContacto.Refresh();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Contactos ExistsContact(string cod)
        {
            foreach(Contactos ct in lst)
            {
                if (ct.Codigo == cod)
                { return ct; }
            }
            return null;
        }

        public void Update()
        {
            StreamReader sr = new StreamReader(ArchivoOriginal, true);
            StreamWriter sw = new StreamWriter(Temporal, true);
            while (!sr.EndOfStream)
            {
                Contactos c = new Contactos();
                c.Codigo = sr.ReadLine();
                c.Nombre = sr.ReadLine();
                c.Apellido = sr.ReadLine();
                c.Genero = sr.ReadLine();
                c.Correo= sr.ReadLine();
                c.Telefono = sr.ReadLine();
                if (c.Codigo.Equals(txtCodigo.Text))
                {
                    sw.WriteLine(txtCodigo.Text);
                    sw.WriteLine(txtNombre.Text);
                    sw.WriteLine(txtApellido.Text);
                    sw.WriteLine(cbxGenero.Text);
                    sw.WriteLine(txtCorreo.Text);
                    sw.WriteLine(txtTelefono.Text);
                }
                else
                {
                    sw.WriteLine(c.Codigo);
                    sw.WriteLine(c.Nombre);
                    sw.WriteLine(c.Apellido);
                    sw.WriteLine(c.Genero);
                    sw.WriteLine(c.Correo);
                    sw.WriteLine(c.Telefono);
                }

            }
            sw.Close();
            sr.Close();

            File.Delete(ArchivoOriginal);
            File.Move(Temporal, ArchivoOriginal);

            FillGrid();
        }

        //eventos.....................
        public FrmContactos()
        {
            InitializeComponent();
        }

        private void FrmContactos_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FrmContactos_FormClosed(object sender, FormClosedEventArgs e)
        {
            f = null;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
               
            try
            {

                if (ExistsContact(txtCodigo.Text) == null)
                {
                    StreamWriter sw = new StreamWriter(ArchivoOriginal, true);
           
                    sw.WriteLine(txtCodigo.Text);
                    sw.WriteLine(txtNombre.Text);
                    sw.WriteLine(txtApellido.Text);
                    sw.WriteLine(cbxGenero.Text);
                    sw.WriteLine(txtCorreo.Text);
                    sw.WriteLine(txtTelefono.Text);
                    sw.Close();

                    Contactos C = new Contactos(
                        txtCodigo.Text, txtNombre.Text,
                        txtApellido.Text, cbxGenero.Text,
                        txtCorreo.Text, txtTelefono.Text);
                    lst.Add(C);
                    dgContacto.DataSource = null;
                    dgContacto.DataSource = lst;
                    dgContacto.Refresh();
                }
                else
                {
                    Update();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
