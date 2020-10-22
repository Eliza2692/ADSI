using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entities;
using BLL;

namespace GUI
{
    public partial class FormEditorial : Form
    {

        EditorialesBLL mngEditorial = new EditorialesBLL();


        #region METODOS

        public void CleanText(bool tId = false)
        {
            if (tId == true)
                txtId.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtId.Focus();
        }

        public void fillGrid()
        {
            dgEditorial.DataSource = null;
            dgEditorial.DataSource = mngEditorial.GetAll();
            dgEditorial.Refresh();
        }

        public void Search(int id)
        {
            try
            {
                Editoriales edit = new Editoriales();

                edit = mngEditorial.GetById(id);

                if (edit!=null)
                {
                    txtId.Text = edit.Id.ToString();
                    txtNombre.Text = edit.Nombre;
                    txtDireccion.Text = edit.Direccion;
                    txtTelefono.Text = edit.Telefono;
                    txtEmail.Text = edit.Email;
                }
                else
                {
                    MessageBox.Show("Registro no existente");
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }    

        }

        public void Save()
        {
            try
            {
                Editoriales edit = new Editoriales();
                edit.Nombre = txtNombre.Text;
                edit.Direccion = txtDireccion.Text;
                edit.Telefono = txtTelefono.Text;
                edit.Email = txtEmail.Text;

                if (string.IsNullOrEmpty(txtId.Text))
                {
                    mngEditorial.Add(edit);
                    MessageBox.Show("GUARDADO");
                    CleanText(true);
                }
                else
                {
                    if (mngEditorial.GetById(Convert.ToInt32(txtId.Text))==null)
                    {
                        mngEditorial.Add(edit);
                        MessageBox.Show("GUARDADO");
                        CleanText(true);
                    }
                    else
                    {
                        var resp = MessageBox.Show("Desea actualizar el registro?", "ACTULIZAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resp == DialogResult.Yes)
                        {
                            edit.Id = Convert.ToInt32(txtId.Text);
                            mngEditorial.Update(edit);
                            MessageBox.Show("ACTUALIZADO");
                            CleanText(true);
                        }
                        else
                        {
                            MessageBox.Show("No cambios");
                        }
                    }
                }
                fillGrid();
            }
            catch (Exception ex)
            {               
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region EVENTOS

        public FormEditorial()
        {
            InitializeComponent();
        }

        private void FormEditorial_Load(object sender, EventArgs e)
        {
            fillGrid();
            CleanText(true);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id=Convert.ToInt32(txtId.Text);
                if (mngEditorial.GetById(id)!=null)
                {
                    var resp = MessageBox.Show("Desea eliminar registro", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resp==DialogResult.Yes)
                    {
                        mngEditorial.Delete(id);
                        CleanText(true);
                        fillGrid();
                    }
                    else
                    {
                        MessageBox.Show("NO SE REALIZARON CAMBIO");
                    }
                }
                else
                {
                    MessageBox.Show("registro no existente");
                }
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
            Search(Convert.ToInt32(txtId.Text));
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                Search(Convert.ToInt32(txtId.Text));
            }
        }

        private void dgEditorial_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Search(Convert.ToInt32(dgEditorial[0, e.RowIndex].Value));
            }
        }

        private void dgEditorial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Search(Convert.ToInt32(dgEditorial[0, e.RowIndex].Value));
            }
        }
    #endregion

    }
}
