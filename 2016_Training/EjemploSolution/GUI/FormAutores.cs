using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Model;
using BLL.Concrete;

namespace GUI
{
    public partial class FormAutores : Form
    {

        AutoresBLL aBll = new AutoresBLL();

        #region METODOS

        public void Save()
        {

            autores aut = new autores();

            if (!string.IsNullOrEmpty(txtId.Text))
            {
                aut.id = Convert.ToInt32(txtId.Text);
            }

            aut.nombre = txtNombre.Text;
            aut.apellido = txtApellido.Text;
            aut.direccion = txtDireccion.Text;
            aut.fechanacimiento = dtFechaNacimiento.Value.Date;
            aut.genero = cbxGenero.SelectedItem.Equals("Femenino") ? "F" : "M";
            aut.foto = txtFoto.Text;

            aBll.Save(aut, aut.id);

            MessageBox.Show("REGISTRADO CORRECTAMENTE");
            FillGrid();
            CleanText(true);

        }

        public void Delete(int id)
        {
            autores aut = new autores();
            aut = aBll.GetById(id);

            if (aut != null)
            {
                aBll.Delete(aut);
                MessageBox.Show("ELIMINADO CORRECTAMENTE");
                FillGrid();
                CleanText(true);
            }
            else
            {
                MessageBox.Show("NO SE ENCONTRÓ");
            }


        }

        public void FillGrid()
        {
            try
            {
                dgAutores.DataSource = null;
                dgAutores.DataSource = aBll.GetAll();
                dgAutores.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CleanText(bool tId = false)
        {
            try
            {
                if (tId)
                    txtId.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                txtDireccion.Clear();
                dtFechaNacimiento.Value = DateTime.Now;
                cbxGenero.SelectedIndex = 0;
                txtFoto.Clear();
                picFoto.Image = null;
                txtId.Focus();
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        public void Search(int id)
        {
            autores aut = new autores();
            aut = aBll.GetById(id);

            if (aut != null)
            {
                txtId.Text = aut.id.ToString();
                txtNombre.Text = aut.nombre;
                txtApellido.Text = aut.apellido;
                txtDireccion.Text = aut.direccion;
                dtFechaNacimiento.Value = aut.fechanacimiento.Value;
                cbxGenero.SelectedItem = aut.genero == "F" ? "Femenino" : "Masculino";
                txtFoto.Text = aut.foto;
                picFoto.Image = Image.FromFile(aut.foto);
                
            }
            else
            {
                MessageBox.Show("REGISTRO NO ENCONTRADO");
                CleanText();
            }
        }

        #endregion
        public FormAutores()
        {
            InitializeComponent();
        }

        private void FormAutores_Load(object sender, EventArgs e)
        {
            dgAutores.AutoGenerateColumns = false;
            FillGrid();
            CleanText(true);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (dlgAbrirFoto.ShowDialog() ==DialogResult.OK)
                {
                    txtFoto.Text = dlgAbrirFoto.FileName.ToString();
                    picFoto.Image = Image.FromFile(txtFoto.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Delete(Convert.ToInt32(txtId.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CleanText(true);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Search(Convert.ToInt32(txtId.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(13))
                {
                    Search(Convert.ToInt32(txtId.Text));
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgAutores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    Search(Convert.ToInt32(dgAutores[0, e.RowIndex].Value));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgAutores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    Search(Convert.ToInt32(dgAutores[0, e.RowIndex].Value));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
