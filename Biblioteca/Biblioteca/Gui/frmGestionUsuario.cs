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

namespace Biblioteca.Formularios
{
    public partial class frmGestionUsuario : Form
    {

        private static frmGestionUsuario f;
        private GestionUsuarios gu = new GestionUsuarios();

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
            txtContrasena.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtCargo.Clear();
            txtFoto.Clear(); 
            picFoto.Image = null;
        }

        //copia lo del data grid view a los text box
        public void FillData(string id)
        {
            Usuarios obj = gu.GetById(id);
            if (obj != null)
            {
                txtCodigo.Text = obj.Codigo;
                txtContrasena.Text = obj.Contrasena;
                txtNombre.Text = obj.Nombre;
                txtApellido.Text = obj.Apellido;
                txtCorreo.Text = obj.Correo;
                txtTelefono.Text = obj.Telefono;
                txtDireccion.Text = obj.Direccion;
                txtCargo.Text = obj.Cargo;
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
            dgUsuario.DataSource = null;
            dgUsuario.DataSource = gu.GetAll();
            dgUsuario.Refresh();
        }

        //Singlenton
        public static frmGestionUsuario GetIntances()
        {
            if (f == null)
                f = new frmGestionUsuario();
            return f;
        }

        private void frmGestionUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            f = null;
        }

///////////////////////Eventos

        public frmGestionUsuario()
        {
            InitializeComponent();
        }

        //Cargar formulario
        private void frmGestionUsuario_Load(object sender, EventArgs e)
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

        //Botón Nuevo
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
                Usuarios obj = new Usuarios(txtCodigo.Text, txtContrasena.Text, txtNombre.Text, txtApellido.Text,
                                            txtCorreo.Text, txtTelefono.Text, txtDireccion.Text, txtCargo.Text,
                                            txtFoto.Text);
                if (gu.GetById(obj.Codigo) == null)
                    gu.Add(obj);
                else
                    gu.Update(obj);
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
                if (gu.GetById(txtCodigo.Text) != null)
                {
                    gu.Delete(txtCodigo.Text);
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

        //Botón Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ActivateControls(true, false, false, false, false);
            CleanText();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtFoto.Text = "";
            picFoto.Image = null;
        }

        //Doble click data grip view
        private void dgUsuario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex;
            if (f > -1)
            {
                FillData(dgUsuario[0, f].Value.ToString());
                ActivateControls(false, true, true, true, true);
            }
        }

        private void dgUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex;
            if (f > -1)
            {
                FillData(dgUsuario[0, f].Value.ToString());
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

    }
}
