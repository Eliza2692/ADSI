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

namespace Biblioteca
{
    public partial class frmGestionCategorias : Form
    {
        private static frmGestionCategorias f;
        private GestionCategorias gc = new GestionCategorias();
        

/////////////////Metodos

        //Activa y desactiva botones
        public void ActivateControls(bool bNuevo, bool bGuardar, bool bEliminar, bool bCancelar, bool bPanel)
        {
            btnNuevo.Enabled = bNuevo;
            btnGuardar.Enabled = bGuardar;
            btnEliminar.Enabled = bEliminar;
            btnCancelar.Enabled = bCancelar;
            panel1.Enabled = bPanel;
        }

        //Limpiar los textos en las cajas
        public void CleanText()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtLogo.Clear();
            picLogo.Image = null;
        }

        //copia lo del data grid view a los text box
        public void FillData(string id)
        {
            Categorias obj = gc.GetById(id);
            if (obj != null)
            {
                txtCodigo.Text = obj.Codigo;
                txtNombre.Text = obj.Nombre;
                txtDescripcion.Text = obj.Descripcion;
                txtLogo.Text = obj.Logo;
                if (txtLogo.Text != "")
                    picLogo.Image = Image.FromFile(txtLogo.Text);
                else
                    picLogo.Image = null;
                ActivateControls(false, true, true, true, true);
            }
            else
                ActivateControls(false, true, false, true, true);
        }

        //DataGrid
        public void FillGrid()
        {
            dgCategorias.DataSource = null;
            dgCategorias.DataSource = gc.GetAll();
            dgCategorias.Refresh();
        }

        //Singlenton
        public static frmGestionCategorias GetIntances()
        {
            if (f == null)
                f = new frmGestionCategorias();
            return f;
        }

        private void frmGestionCategorias_FormClosed(object sender, FormClosedEventArgs e)
        {
            f = null;
        }

///////////////////////Eventos

        public frmGestionCategorias()
        {
            InitializeComponent();
        }

        //Cargar formulario
        private void frmGestionCategorias_Load(object sender, EventArgs e)
        {            
            try
            {
                ActivateControls(true, false, false, false, false);              
                FillGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Boton Nuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ActivateControls(false, true, false, true, true);
            CleanText();
            txtCodigo.Focus();
        }

        //Boton Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Categorias obj = new Categorias(txtCodigo.Text, txtNombre.Text, txtDescripcion.Text,txtLogo.Text);
                if (gc.GetById(obj.Codigo) == null)
                    gc.Add(obj);
                else
                    gc.Update(obj);
                CleanText();
                ActivateControls(false, true, false, true, true);
                FillGrid();
                MessageBox.Show("Datos Guardados Corecctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Boton Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gc.GetById(txtCodigo.Text) != null)
                {
                    gc.Delete(txtCodigo.Text);
                    FillGrid();
                    ActivateControls(true, false, false, false, false);
                    CleanText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Boton Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ActivateControls(true, false, false, false, false);
            CleanText();
        }

        //Doble click data grip view
        private void dgCategorias_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex;
            if (f > -1)
            {
                FillData(dgCategorias[0, f].Value.ToString());
                ActivateControls(false, true, true, true, true);
            }
        }

        private void dgCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex;
            if (f > -1)
            {
                FillData(dgCategorias[0, f].Value.ToString());
                ActivateControls(false, true, true, true, true);
            }
        }

        //Caja de texto
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                FillData(txtCodigo.Text);
                ActivateControls(false, true, true, true, true);
            }
        }

        //Cargar Imagen
        private void picGuardar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Bitmap files (*.bmp)|*.bmp|Gif files (*.gif)|*.gif|JGP files (*.jpg)|*.jpg|All (*.*)|*.* |PNG (*.patito)|*.png ";
            openFileDialog1.FilterIndex = 3;
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                txtLogo.Text = openFileDialog1.FileName;
                picLogo.Image = Image.FromFile(txtLogo.Text);
            }
        }

        //Boton Eliminar
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtLogo.Text = "";
            picLogo.Image = null;
        }

    }
}
