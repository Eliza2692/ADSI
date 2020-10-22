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

namespace GUI
{
    public partial class FormAutores : Form
    {
        AutoresBLL mngAut = new AutoresBLL();

        #region MÉTODOS

        public void Save() {

            try
            {
                Autores aut = new Autores();
                aut.Nombre = txtNombre.Text;
                aut.Apellido = txtApellido.Text;
                aut.Direccion = txtDireccion.Text;
                aut.Fechanacimiento = dtFechanacimiento.Value.Date;
                aut.Genero = cbxSexo.SelectedItem.Equals("Femenino") ? 'F' : 'M';                
                aut.Foto = txtFoto.Text;

                if (string.IsNullOrEmpty(txtId.Text))
                {
                    mngAut.Add(aut);
                    MessageBox.Show("REGISTRADO CORRECTAMENTE");
                    CleanText(true);
                }
                else { 
                    
                    if (mngAut.GetById(Convert.ToInt32(txtId.Text)) == null)
                    {
                        mngAut.Add(aut);
                        MessageBox.Show("REGISTRADO CORRECTAMENTE");
                        CleanText(true);
                    }
                    else                    
                    {
                        var resp = MessageBox.Show("¿Confirmar actualización?", "REGISTRO ENCONTRADO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (DialogResult.Yes == resp) {
                            aut.Id = Convert.ToInt32(txtId.Text);
                            mngAut.Update(aut);
                            MessageBox.Show("ACTUALIZADO CORRECTAMENTE");
                            CleanText(true);
                            
                        }else{

                            MessageBox.Show("NO SE REALIZARON CAMBIOS");
                        
                        }
                        
                    }

                    FillGrid();
                    
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
                if (mngAut.GetById(id) != null)
                {
                    var res = MessageBox.Show("¿Desea eliminar el registro?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        mngAut.Delete(id);
                        MessageBox.Show("ELIMINADO CORRECTAMENTE");
                        CleanText();
                        FillGrid();
                    }
                    else
                    {
                        MessageBox.Show("NO SE REALIZARON CAMBIOS");
                    }
                }
                else
                {
                    MessageBox.Show("REGISTRO NO ENCONTRADO");
                }

            }
            catch (Exception ex)
            {
                
                MessageBox.Show (ex.Message);
            }
        }

        public void Search(int id)
        {
            try
            {
                Autores aut = new Autores();
                aut = mngAut.GetById(id);
                if (aut != null)
                {
                    txtId.Text = aut.Id.ToString();
                    txtNombre.Text = aut.Nombre;
                    txtApellido.Text = aut.Apellido;
                    txtDireccion.Text = aut.Direccion;
                    dtFechanacimiento.Value = aut.Fechanacimiento;
                    cbxSexo.SelectedItem = aut.Genero == 'F' ? "Femenino" : "Masculino";
                    txtFoto.Text = aut.Foto;
                    pictureBox1.Image = Image.FromFile(aut.Foto);
                }
                else
                {
                    MessageBox.Show("REGISTRO INEXISTENTE");
                }

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        public void FillGrid() {
            dgAutores.DataSource = null;
            dgAutores.DataSource = mngAut.GetAll();
            dgAutores.Refresh();
        }

        public void CleanText(bool id = false) {

            try
            {
                if (id)
                {
                    txtId.Clear();
                }
                txtNombre.Clear();
                txtApellido.Clear();
                txtDireccion.Clear();
                dtFechanacimiento.Value = DateTime.Now;
                cbxSexo.SelectedItem = "Femenino";
                txtFoto.Clear();
                pictureBox1.Image = null;
                txtId.Focus();
            }
            catch (Exception)
            {
                
                throw;
            }

        }

        #endregion

        #region EVENTOS

        public FormAutores()
        {
            InitializeComponent();
        }

        private void FormAutores_Load(object sender, EventArgs e)
        {
            FillGrid();
            CleanText(true);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Delete(Convert.ToInt32(txtId.Text));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CleanText(true);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                txtFoto.Text = openFileDialog1.FileName.ToString();
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Search(Convert.ToInt32(txtId.Text));
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                Search(Convert.ToInt32(txtId.Text));
            }
        }

        private void dgAutores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>-1)
            {
                Search(Convert.ToInt32(dgAutores[0, e.RowIndex].Value));
            }
        }

        private void dgAutores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Search(Convert.ToInt32(dgAutores[0, e.RowIndex].Value));
            }
        }

        #endregion
    }
}
