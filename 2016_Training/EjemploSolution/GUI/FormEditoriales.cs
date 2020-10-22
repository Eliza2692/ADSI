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
using BLL;
using BLL.Concrete;
using SECURITY;

namespace GUI
{
    public partial class FormEditoriales : Form
    {
        EditorialesBLL eBll = new EditorialesBLL();

        #region METODOS


        public void Save()
        {

            editoriales edit = new editoriales();

            if (Validations.IsEmail(txtEmail.Text))
            { 
                if (!string.IsNullOrEmpty(txtNombre.Text))
	            {
                    if (!string.IsNullOrEmpty(txtId.Text))
                    {
                        edit.id = Convert.ToInt32(txtId.Text);
                    }

                    edit.nombre = txtNombre.Text;
                    edit.direccion = txtDireccion.Text;
                    edit.telefono = txtTelefono.Text;
                    edit.email = txtEmail.Text;

                    eBll.Save(edit, edit.id);

                    MessageBox.Show("REGISTRADO CORRECTAMENTE");
                    FillGrid();
                    CleanText(true);
                }else
	            {
                    MessageBox.Show("INGRESE NOMBRE");
	            }
            }
            else
	        {
                MessageBox.Show("MAIL NO VALIDO");
	        }

        }

        public void Delete(int id)
        {
            editoriales edit = new editoriales();
            edit = eBll.GetById(id);

            if (edit != null)
            {
                eBll.Delete(edit);
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
                dgEditoriales.DataSource = null;
                dgEditoriales.DataSource = eBll.GetAll();
                dgEditoriales.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CleanText(bool tId = false)
        {

            if (tId)
                txtId.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtId.Focus();

        }

        public void Search(int id)
        {
            editoriales edit = new editoriales();
            edit = eBll.GetById(id);

            if (edit != null)
            {
                txtId.Text = edit.id.ToString();
                txtNombre.Text = edit.nombre;
                txtDireccion.Text = edit.direccion;
                txtTelefono.Text = edit.telefono;
                txtEmail.Text = edit.email;
            }
            else
            {
                MessageBox.Show("REGISTRO NO ENCONTRADO");
                CleanText();
            }
        }

        #endregion

        public FormEditoriales()
        {
            InitializeComponent();
        }

        private void FormEditoriales_Load(object sender, EventArgs e)
        {
            dgEditoriales.AutoGenerateColumns = false;
            FillGrid();
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(13))
                {
                    Search(Convert.ToInt32(txtId.Text));
                }                
                if (!Validations.IsDigit(e.KeyChar.ToString()) && (e.KeyChar != Convert.ToChar(8)))
                {
                    e.Handled = true;
                }               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgEditorial_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    Search(Convert.ToInt32(dgEditoriales[0,e.RowIndex].Value));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgEditorial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    Search(Convert.ToInt32(dgEditoriales[0, e.RowIndex].Value));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Validations.IsText(e.KeyChar.ToString()) && (e.KeyChar != Convert.ToChar(8)) && (e.KeyChar != Convert.ToChar(32)))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Validations.IsDigit(e.KeyChar.ToString()) && (e.KeyChar != Convert.ToChar(8)))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

    }
}
