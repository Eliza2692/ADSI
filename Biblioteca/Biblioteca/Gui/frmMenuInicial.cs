using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Clases;
using Biblioteca.Gestion;
using Biblioteca.Formularios;


namespace Biblioteca.Formularios
{
    public partial class frmMenuInicial : Form
    {
        public frmMenuInicial()
        {
            InitializeComponent();
        }


////////////////Metodos
 
       //formulario de categorias
        private void callCategorias()
        {
            frmGestionCategorias f = frmGestionCategorias.GetIntances();
            f.MdiParent = this;
            f.Show();
        }

        //formulario de Ejemplares
        private void callEjemplares()
        {
            frmGestionEjemplares f = frmGestionEjemplares.GetIntances();
            f.MdiParent = this;
            f.Show();
        }

        //formulario de Formato
        private void callFormatos()
        {
            frmGestionFormato f = frmGestionFormato.GetIntances();
            f.MdiParent = this;
            f.Show();
        }

        //formulario de Usuario
        private void callUsuario()
        {
            frmGestionUsuario f = frmGestionUsuario.GetIntances();
            f.MdiParent = this;
            f.Show();
        }

        //formulario de Busqueda
        private void callBusqueda()
        {
            frmBusqueda f = frmBusqueda.GetIntances();
            f.MdiParent = this;
            f.Show();
        }

//////////////////Eventos

        private void frmMenuInicial_Load(object sender, EventArgs e)
        {

        }

       //Cargar formulario Categorias
        private void tsbCategorias_Click(object sender, EventArgs e)
        {
            callCategorias();
        } 

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            callCategorias();
        }

        //Cargar formulario Ejemplares
        private void tsbEjemplares_Click(object sender, EventArgs e)
        {
            callEjemplares();
        }

        private void ejemplaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            callEjemplares();
        }

        //Cargar formulario Formatos
        private void tsbFormato_Click(object sender, EventArgs e)
        {
            callFormatos();
        }

        private void formatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            callFormatos();
        }

        //Cargar formulario Usuario
        private void tsbUsuario_Click(object sender, EventArgs e)
        {
            callUsuario();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            callUsuario();
        }

        //Cargar formulario Busqueda
        private void tsbBusqueda_Click(object sender, EventArgs e)
        {
            callBusqueda();
        }

        private void busquedaBásicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            callBusqueda();
        }

        //Salir
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir?", "Salida", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                Close();
                Application.Exit();
            }
            switch (result)
            {
                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void frmMenuInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
                Application.Exit();
        }


    }
}
