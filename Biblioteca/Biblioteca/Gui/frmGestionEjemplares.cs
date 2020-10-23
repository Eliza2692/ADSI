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
using Biblioteca.Gestion;
using Biblioteca.Clases;

namespace Biblioteca
{
    public partial class frmGestionEjemplares : Form
    {
        private static frmGestionEjemplares f;
        private GestionCategorias gc = new GestionCategorias();
        private GestionFormatos gf = new GestionFormatos();
        private GestionEjemplares ge = new GestionEjemplares();
        
/////////////////////Metodos

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
            txtReferencia.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            nmCantidad.Value = 0;
            cbxEstado.Text = "";
            txtAutores.Clear();
            nmAnio.Value = 1990;
            txtEditorial.Clear();
            cbxCategoria.Text = "";
            cbxFormato.Text = "";
            picFoto.Image = null;
            txtFoto.Clear();
        }

        //copia lo del data grid view a los text box
        public void FillData(string id)
        {
            Ejemplares obj = ge.GetById(id);
            if (obj != null)
            {
                txtReferencia.Text = obj.Referencia;
                txtNombre.Text = obj.Nombre;
                txtDescripcion.Text = obj.Descripcion;
                nmCantidad.Value = obj.Cantidad;
                cbxEstado.Text = obj.Estado;
                txtAutores.Text = obj.Autor;
                nmAnio.Value = obj.Anio;
                txtEditorial.Text = obj.Editorial;
                cbxCategoria.Text = obj.Categoria;
                cbxFormato.Text = obj.Formato;
                txtFoto.Text = obj.Foto;
                if (txtFoto.Text != "")
                    picFoto.Image = Image.FromFile(txtFoto.Text);
                else
                    picFoto.Image = null;
                ActivateControls(false, true, true, true, true);
            }
            else
                ActivateControls(false, true, false, true, true);
        }

        //DataGrid
        public void FillGrid()
        {
            dgGestionEjemplares.DataSource = null;
            dgGestionEjemplares.DataSource = ge.GetAll();
            dgGestionEjemplares.Refresh();
        }

        //Singlenton
        public static frmGestionEjemplares GetIntances()
        {
            if (f == null)
                f = new frmGestionEjemplares();
            return f;
        }

        private void frmGestionEjemplares_FormClosed(object sender, FormClosedEventArgs e)
        {
            f = null;
        }

        //Cargar comboboxformatos
        public void FillCbxFormatos()
        {
            cbxFormato.DataSource = null;
            cbxFormato.DataSource = gf.GetAll();
            cbxFormato.DisplayMember = "Nombre";
            cbxFormato.ValueMember = "Codigo";
        }

        //Cargar comboboxCategorias
        public void FillCbxCategorias()
        {
            cbxCategoria.DataSource = null;
            cbxCategoria.DataSource = gc.GetAll();
            cbxCategoria.DisplayMember = "Nombre";
            cbxCategoria.ValueMember = "Codigo";
        }       

////////////////////////Metodos

        public frmGestionEjemplares()
        {
            InitializeComponent();
        }

        //Cargar formulario
        private void frmGestionEjemplares_Load(object sender, EventArgs e)
        {
            try
            {
                ActivateControls(true, false, false, false, false);
                FillGrid();
                FillCbxFormatos();
                FillCbxCategorias();
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
            txtReferencia.Focus();
        }

        //Boton Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Ejemplares obj = new Ejemplares(txtReferencia.Text, txtNombre.Text, txtDescripcion.Text, Convert.ToInt32(nmCantidad.Value),
                                                cbxEstado.Text, txtAutores.Text, Convert.ToInt32(nmAnio.Value), txtEditorial.Text, cbxCategoria.Text,
                                                cbxFormato.Text,txtFoto.Text);
                if (ge.GetById(obj.Referencia) == null)
                    ge.Add(obj);
                else
                    ge.Update(obj);
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
                if (ge.GetById(txtReferencia.Text) != null)
                {
                    ge.Delete(txtReferencia.Text);
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

        //Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ActivateControls(true, false, false, false, false);
            CleanText();
        }

        //Doble click data grip view
        private void dgGestionEjemplares_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex;
            if (f > -1)
            {
                FillData(dgGestionEjemplares[0, f].Value.ToString());
                ActivateControls(false, true, true, true, true);
            }
        }

        private void dgGestionEjemplares_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex;
            if (f > -1)
            {
                FillData(dgGestionEjemplares[0, f].Value.ToString());
                ActivateControls(false, true, true, true, true);
            }
        }

        //Caja de texto
        private void txtReferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                FillData(txtReferencia.Text);
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
                txtFoto.Text = openFileDialog1.FileName;
                picFoto.Image = Image.FromFile(txtFoto.Text);
            }
        }

        //Eliminar Imagen
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtFoto.Text = "";
            picFoto.Image = null;
        }

    }
}
