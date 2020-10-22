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
    public partial class FormEditoriales : Form
    {

        EditorialesBLL mngEdi = new EditorialesBLL();

        #region MÉTODOS

        public void Save() {
            
            try
            {
                Editoriales edi = new Editoriales();

                edi.Nombre = txtNombre.Text;
                edi.Direccion = txtDireccion.Text;
                edi.Telefono = txtTelefono.Text;
                edi.Email = txtEmail.Text;

                if (String.IsNullOrEmpty(txtId.Text))                
                {
                    mngEdi.Add(edi);
                    MessageBox.Show("REGISTRADO CORRECTAMENTE");
                    CleanText(true);
                } else                
                {

                    if (mngEdi.GetById(Convert.ToInt32( txtId.Text)) == null) 
                    {
                        mngEdi.Add(edi);
                        MessageBox.Show("REGISTRADO CORRECTAMENTE");
                        CleanText(true);
                    }
                    else
                    {
                        var res = MessageBox.Show("¿Actualizar registro?", "REGISTRO ENCONTRADO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (res == DialogResult.Yes)
                        {
                            edi.Id = Convert.ToInt32(txtId.Text);
                            mngEdi.Update(edi);
                            CleanText(true);
                        }
                        else {
                            MessageBox.Show("NO SE REALIZARON CAMBIOS");
                        }                        

                    }

                }
                FillGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void CleanText(bool id = false) {
            if (id) {
                txtId.Clear();
            }
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
        }

        public void FillGrid()
        {
            dgEditoriales.DataSource = null;
            dgEditoriales.DataSource = mngEdi.GetAll();
            dgEditoriales.Refresh();
        }

        public void Delete(int id) {
            try
            {

                if (mngEdi.GetById(id) != null) 
                {
                    var res = MessageBox.Show("¿Desea eliminar el registro?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (res == DialogResult.Yes)
                    {
                        mngEdi.Delete(id);
                        MessageBox.Show("ELIMINADO CORRECTAMENTE");
                        FillGrid();
                        CleanText(true);
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
                MessageBox.Show(ex.Message);
            }
        }

        public void Search(int id)
        {
            try
            {
                if (mngEdi.GetById(id) != null)
                {

                    Editoriales edi = new Editoriales();

                    edi = mngEdi.GetById(id);

                    txtId.Text = edi.Id.ToString();
                    txtNombre.Text = edi.Nombre;
                    txtDireccion.Text = edi.Direccion;
                    txtTelefono.Text = edi.Telefono;
                    txtEmail.Text = edi.Email;

                }
                else
                {
                    MessageBox.Show("REGISTRO NO ENCONTRADO");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region EVENTOS

        public FormEditoriales()
        {
            InitializeComponent();
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CleanText(true);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgEditoriales_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) {
                Search(Convert.ToInt32(dgEditoriales[0,e.RowIndex].Value));
            }
        }

        private void dgEditoriales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Search(Convert.ToInt32(dgEditoriales[0, e.RowIndex].Value));
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13)) {
                Search(Convert.ToInt32(txtId.Text));
            }
        }

        private void FormEditoriales_Load(object sender, EventArgs e)
        {
            FillGrid();
            CleanText(true);
        }
        #endregion
    }
}
