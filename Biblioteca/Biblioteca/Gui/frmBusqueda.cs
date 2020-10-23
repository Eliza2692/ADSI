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
using Biblioteca.Clases;
using Biblioteca.Gestion;

namespace Biblioteca.Formularios
{
    public partial class frmBusqueda : Form
    {
        private static frmBusqueda f;
        private GestionEjemplares ge = new GestionEjemplares();

        public frmBusqueda()
        {
            InitializeComponent();
        }

        private void frmBusqueda_Load(object sender, EventArgs e)
        {
            
        }

        ///////////////////////////Metodos

        //Singlenton
        public static frmBusqueda GetIntances()
        {
            if (f == null)
                f = new frmBusqueda();
            return f;
        }

        private void frmBusqueda_FormClosed(object sender, FormClosedEventArgs e)
        {
            f = null;
        }

        //Buscar
        private void Buscar()
        {
            if (txtPalabraClave.Text != "" && cbxBuscar.Text != "")
            {
                switch (cbxBuscar.Text)
                {
                    case "Referencia":
                        dgBusqueda.DataSource = null;
                        dgBusqueda.DataSource = ge.GetById(txtPalabraClave.Text);
                        dgBusqueda.Refresh();
                        break;
                    case "Nombre":
                        dgBusqueda.DataSource = null;
                        dgBusqueda.DataSource = ge.GetByNombre(txtPalabraClave.Text);
                        dgBusqueda.Refresh();
                        break;
                    case "Autor":
                        dgBusqueda.DataSource = null;
                        dgBusqueda.DataSource = ge.GetByAutor(txtPalabraClave.Text);
                        dgBusqueda.Refresh();
                        break;
                    case "Editorial":
                        dgBusqueda.DataSource = null;
                        dgBusqueda.DataSource = ge.GetByEditorial(txtPalabraClave.Text);
                        dgBusqueda.Refresh();
                        break;
                    case "Categoria":
                        dgBusqueda.DataSource = null;
                        dgBusqueda.DataSource = ge.GetByCategoria(txtPalabraClave.Text);
                        dgBusqueda.Refresh();
                        break;
                    case "Formato":
                        dgBusqueda.DataSource = null;
                        dgBusqueda.DataSource = ge.GetByFormatos(txtPalabraClave.Text);
                        dgBusqueda.Refresh();
                        break;
                }
            }
            else
            {
                if (txtPalabraClave.Text != "" && cbxBuscar.Text == "")
                    MessageBox.Show("Seleccione el Criterio de Busqueda");
                else
                {
                    if (txtPalabraClave.Text == "" && cbxBuscar.Text != "")
                        MessageBox.Show("Digite el texto a buscar");
                    else
                        MessageBox.Show("Digite el texto a buscar y Seleccione el Criterio de Busqueda");
                }
            }

        }

        /////////////////Eventos

        //Boton buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        //Enter Palabra Clave
        private void txtPalabraClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                Buscar();
        }

        //Enter Buscar por
        private void cbxBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                Buscar();
        }

    }
}
    




