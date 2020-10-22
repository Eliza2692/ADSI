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
    public partial class FormLibros : Form
    {

        LibrosBLL mngLib = new LibrosBLL();
        AutoresBLL mngAut = new AutoresBLL();
        CategoriasBLL mngCat = new CategoriasBLL();
        EditorialesBLL mngEdi = new EditorialesBLL();

        #region MÉTODOS

        public void FillGrid() {
            dgLibros.DataSource = null;
            dgLibros.DataSource = mngLib.GetAll();
            dgLibros.Refresh();
        }

        public void FillComboBox(ComboBox cbx, DataTable list) 
        {
            cbx.DataSource = null;
            cbx.DataSource = list;
            cbx.DisplayMember = "Nombre";
            cbx.ValueMember = "Id";
            cbx.Refresh();
        }

        public void CleanText(bool id = false) {

            try
            {
                if (id)
                {
                    txtId.Clear();
                }

                txtNombre.Clear();
                txtIsbn.Clear();
                cbxEditorial.SelectedIndex = 0;
                cbxCategoria.SelectedIndex = 0;
                cbxAutor.SelectedIndex = 0;
                numPaginas.Value = 0;
            }
            catch (Exception)
            {
                
                throw;
            }

        }

        public void Search(int id)
        {
            //try
            //{
            //    if (mngLib.GetById(id)!=null)
            //    {
            //        Libros lib = new Libros();

            //        lib = mngLib.GetById(id);

            //        txtId.Text = 

            //    }
            //    else
            //    {
            //        MessageBox.Show("REGISTRO NO ENCONTRADO");
            //    }
            //}
            //catch (Exception ex)
            //{
                
            //    MessageBox.Show(ex.Message);
            //}
        }

        #endregion

        #region EVENTOS

        public FormLibros()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CleanText(true);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLibros_Load(object sender, EventArgs e)
        {
            FillGrid();
            FillComboBox(cbxAutor, mngAut.GetAll());
            FillComboBox(cbxCategoria, mngCat.GetAll());
            FillComboBox(cbxEditorial, mngEdi.GetAll());
            CleanText(true);
        }

        private void dgLibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgLibros_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        #endregion
    }
}
