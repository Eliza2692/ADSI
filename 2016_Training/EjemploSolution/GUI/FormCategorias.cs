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
using BLL;
using SECURITY;

namespace GUI
{
    public partial class FormCategorias : Form
    {

        CategoriasBLL cBll = new CategoriasBLL();

        #region METODOS

        public void Save() 
        { 

            categorias cat = new categorias();
            
            if (!string.IsNullOrEmpty(txtId.Text)) 
            {
                cat.id = Convert.ToInt32(txtId.Text);    
            }            
            
            cat.nombre = txtNombre.Text;

            cBll.Save(cat, cat.id);

            MessageBox.Show("REGISTRADO CORRECTAMENTE");
            FillGrid();
            CleanText(true);

        }

        public void Delete(int id)
        { 
            categorias cat = new categorias();
            cat = cBll.GetById(id);

            if (cat != null)
            {
                cBll.Delete(cat);
                MessageBox.Show("ELIMINADO CORRECTAMENTE");
                FillGrid();
                CleanText(true);
            }
            else {
                MessageBox.Show("NO SE ENCONTRÓ");
            }


        }

        public void FillGrid()
        {
            try
            {
                dgCategorias.DataSource = null;
                dgCategorias.DataSource = cBll.GetAll();
                dgCategorias.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CleanText(bool tId=false)
        {

            if (tId)
                txtId.Clear();
            txtNombre.Clear();
            txtId.Focus();

        }

        public void Search(int id)
        {
            categorias cat = new categorias();
            cat = cBll.GetById(id);

            if (cat!=null)
            {
                txtId.Text = cat.id.ToString();
                txtNombre.Text = cat.nombre;
            }
            else
            {
                MessageBox.Show("REGISTRO NO ENCONTRADO");
                CleanText();
            }
        }

        #endregion

        #region EVENTOS

        public FormCategorias()
        {
            InitializeComponent();
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

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            dgCategorias.AutoGenerateColumns = false;
            FillGrid();
            CleanText(true);
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
                if (e.KeyChar==Convert.ToChar(13))
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

        private void dgCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex>-1)
                {
                   Search(Convert.ToInt32(dgCategorias[0, e.RowIndex].Value)); 
                } 
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgCategorias_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    Search(Convert.ToInt32(dgCategorias[0, e.RowIndex].Value));
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        #endregion

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
    }
}
