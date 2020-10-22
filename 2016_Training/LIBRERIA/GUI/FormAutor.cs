using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entities;
using Security;

namespace GUI
{
    public partial class FormAutor : Form
    {


        AutoresBLL mngAut = new AutoresBLL();

        #region METODOS

        public void Save()
        {

            try
            {
                Autores aut = new Autores();
                aut.Nombre = txtNombre.Text;
                aut.Apellido = txtApellido.Text;
                aut.Direccion = txtDireccion.Text;
                aut.Fechanacimiento = dtFechaNacimiento.Value;                
                if (cbxGenero.SelectedItem.Equals("Femenino"))
                {
                    aut.Genero = 'F';
                }
                else
                {
                    aut.Genero = 'M';
                }
                aut.Foto = txtFoto.Text;

                if (String.IsNullOrEmpty(txtId.Text))
                {
                    mngAut.Add(aut);
                    MessageBox.Show("REGISTRADO");

                }
                else
                {

                    if (mngAut.GetById(Convert.ToInt32(txtId.Text)) == null)
                    {
                        mngAut.Add(aut);
                        MessageBox.Show("REGISTRADO CON ID: ");
                    }
                    else
                    {

                        var res = MessageBox.Show("¿ACTUALIZAR REGISTRO?", "REGISTRO ENCONTRADO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (res == DialogResult.Yes)
                        {
                            aut.Id = Convert.ToInt32(txtId.Text);
                            mngAut.Update(aut);
                            MessageBox.Show("ACTUALIZADO CORRECTAMENTE");
                        }
                        else
                        {
                            MessageBox.Show("NO SE REALIZARON CAMBIOS");
                        }

                    }
                }
                CleanText();
                FillGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void Search(int id)
        {
            try
            {
                Autores aut = new Autores();

                aut = mngAut.GetById(id);

                if (aut == null)
                {
                    CleanText();
                    MessageBox.Show("REGISTRO NO EXISTENTE");
                }
                else
                {
                    txtId.Text = aut.Id.ToString();
                    txtNombre.Text = aut.Nombre;
                    txtApellido.Text = aut.Apellido;
                    txtDireccion.Text = aut.Direccion;
                    dtFechaNacimiento.Value = aut.Fechanacimiento;
                    if (aut.Genero == 'F')
                    {
                        cbxGenero.SelectedItem = "Femenino";
                    }
                    else
                    {
                        cbxGenero.SelectedItem = "Masculino";
                    }
                    txtFoto.Text = aut.Foto;
                    picFoto.Image = Image.FromFile(aut.Foto);
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                if (mngAut.GetById(id)!=null)
                {
                    var resp = MessageBox.Show("Desea Eliminar el registro?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resp == DialogResult.Yes)
                    {
                        mngAut.Delete(id);
                        MessageBox.Show("ELIMINADO");
                        FillGrid();
                        CleanText(true);
                    }
                    else
                    {
                        MessageBox.Show("No se realizaron Cambios");
                    }
                }
                else
                {
                    MessageBox.Show("REGISTRO NO EXISTE");
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        public void FillGrid() {

            dgCategoria.DataSource = null;
            dgCategoria.DataSource = mngAut.GetAll();
            dgCategoria.Refresh();

        }

        public void CleanText(bool tId = false)
        {
            if (tId == true)
                txtId.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtFoto.Clear();
            dtFechaNacimiento.Value = DateTime.Now;
            cbxGenero.SelectedItem = "Femenino";
            picFoto.Image = null;
            txtId.Focus();
        }

        #endregion


        #region EVENTOS
        public FormAutor()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CleanText(true);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Search(Convert.ToInt32(txtId.Text));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Save();            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Delete(Convert.ToInt32(txtId.Text));
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void btnImage_Click(object sender, EventArgs e)
        {
          
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picFoto.Image = Image.FromFile(openFileDialog1.FileName);
                txtFoto.Text = openFileDialog1.FileName.ToString();
            }
        }

        private void FormAutor_Load(object sender, EventArgs e)
        {
            FillGrid();
            CleanText(true);
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==Convert.ToChar(13))
            {
                Search(Convert.ToInt32(txtId.Text));
            }
            else
            {
                if ((Validation.IsDigit(e.KeyChar.ToString())==false)&&(e.KeyChar!=Convert.ToChar(8)))
                {
                    e.Handled=true;
                }
            }
        }

        private void dgCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>-1)
            {
                Search(Convert.ToInt32(dgCategoria[0, e.RowIndex].Value));
            }
        }

        private void dgCategoria_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Search(Convert.ToInt32(dgCategoria[0, e.RowIndex].Value));
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Validation.IsText(e.KeyChar.ToString()) == false) && (e.KeyChar != Convert.ToChar(8)))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Validation.IsText(e.KeyChar.ToString()) == false) && (e.KeyChar != Convert.ToChar(8)))
            {
                e.Handled = true;
            }
        }
    }
}
