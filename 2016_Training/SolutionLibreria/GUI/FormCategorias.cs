using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Concrete;
using DAL.Model;

namespace GUI
{
    public partial class FormCategorias : Form
    {
        CategoriasBLL mngCat = new CategoriasBLL();

        #region METODOS

        public void FillGrid()
        {
            dgCategorias.DataSource = null;
            dgCategorias.DataSource = mngCat.GetAll();
            dgCategorias.Refresh();
        }

        public void CleanText(bool tId = false)
        {
            if (tId)
            {
                txtId.Clear();
            }
            txtNombre.Clear();
            txtId.Focus();
        }

        public void Save() {
            try
            {
                categorias cat = new categorias();
                cat.nombre = txtNombre.Text;

                if (txtId.Text.Trim() != "")
                { 
                    cat.id = Convert.ToInt32(txtId.Text); 
                }
                mngCat.Save(cat, cat.id);
                FillGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }
        }

        public void Search(int id)
        {
            try
            {
                categorias cat = new categorias();
                cat = mngCat.GetById(id);

                if (cat !=null)
                {
                    txtId.Text = cat.id.ToString();
                    txtNombre.Text = cat.nombre;
                }
                else
                {
                    MessageBox.Show("REGISTRO NO ENCONTRADO");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }
        }

        public void Delete(int id) {
            
            try
            {
                if (mngCat.GetById(id) != null)
                {
                    var res = MessageBox.Show("¿ELIMINAR REGISTRO?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (res == DialogResult.Yes)
                    {
                        mngCat.Delete(mngCat.GetById(id));
                        MessageBox.Show("ELIMINADO CORRECTAMENTE");
                        CleanText(true);
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
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region EVENTOS
        public FormCategorias()
        {
            InitializeComponent();
        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            try
            {
                dgCategorias.AutoGenerateColumns = false;
                CleanText();
                FillGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==Convert.ToChar(13))
            {
                Search(Convert.ToInt32(txtId.Text));
            }
        }

        private void dgCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>-1)
            {
                Search(Convert.ToInt32(dgCategorias[0,e.RowIndex].Value));
            }
        }

        private void dgCategorias_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Search(Convert.ToInt32(dgCategorias[0, e.RowIndex].Value));
            }
        }
        #endregion
    }
}
