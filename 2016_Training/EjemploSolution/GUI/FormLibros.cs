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
    public partial class FormLibros : Form
    {
        LibrosBLL lBll = new LibrosBLL();
        AutoresBLL aBll = new AutoresBLL();
        CategoriasBLL cBll = new CategoriasBLL();
        EditorialesBLL eBll = new EditorialesBLL();

        #region METODOS

        public void Save()
        {

            libros lib = new libros();

            if (!string.IsNullOrEmpty(txtId.Text))
            {
                lib.id = Convert.ToInt32(txtId.Text);
            }


            lib.isbn = txtIsbn.Text;
            lib.nombre = txtNombre.Text;
            lib.idcategoria = Convert.ToInt32(cbxCategorias.SelectedValue);
            lib.numeropaginas = Convert.ToInt32(numNumeroPaginas.Value);
            lib.ideditorial = Convert.ToInt32(cbxEditorial.SelectedValue);
            lib.idautor = Convert.ToInt32(cbxAutor.SelectedValue);

            lBll.Save(lib, lib.id);

            MessageBox.Show("REGISTRADO CORRECTAMENTE");
            FillGrid();
            CleanText(true);

        }

        public void Delete(int id)
        {
            libros lib = new libros();
            lib = lBll.GetById(id);

            if (lib != null)
            {
                lBll.Delete(lib);
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
                dgLibros.DataSource = null;
                dgLibros.DataSource = lBll.GetAll();
                dgLibros.Refresh();              
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
                txtIsbn.Clear();
                txtNombre.Clear();
                cbxEditorial.SelectedIndex = 0;
                numNumeroPaginas.Value = 0;
                cbxCategorias.SelectedIndex = 0;
                cbxAutor.SelectedIndex = 0;
                txtId.Focus();
            }
            catch (Exception)
            {
               
            }
            

        }

        public void Search(int id)
        {
            libros lib = new libros();
            lib = lBll.GetById(id);

            if (lib != null)
            {
                txtId.Text = lib.id.ToString();
                txtIsbn.Text = lib.isbn;
                txtNombre.Text = lib.nombre;
                cbxEditorial.SelectedValue = lib.ideditorial;
                numNumeroPaginas.Value = lib.numeropaginas;
                cbxCategorias.SelectedValue = lib.idcategoria;
                cbxAutor.SelectedValue = lib.idautor;
            }
            else
            {
                MessageBox.Show("REGISTRO NO ENCONTRADO");
                CleanText();
            }
        }

        public void FillComboBox(ComboBox cbx, IEnumerable<object> list)
        {
            try
            {
                cbx.DataSource = null;
                cbx.DataSource = list;
                cbx.DisplayMember = "nombre";
                cbx.ValueMember = "id";
                cbx.Refresh();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
        public FormLibros()
        {
            InitializeComponent();
        }

        private void FormLibros_Load(object sender, EventArgs e)
        {
            dgLibros.AutoGenerateColumns = false;
            CleanText(true);
            FillGrid();
            FillComboBox(cbxAutor, aBll.GetAll());
            FillComboBox(cbxCategorias, cBll.GetAll());
            FillComboBox(cbxEditorial, eBll.GetAll());
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
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgLibros_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex>-1)
                {
                    Search(Convert.ToInt32(dgLibros[0,e.RowIndex].Value));
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgLibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    Search(Convert.ToInt32(dgLibros[0, e.RowIndex].Value));
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    Search(Convert.ToInt32(dgLibros[0, e.RowIndex].Value));
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtIsbn_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Validations.IsDigit(e.KeyChar.ToString()) && (e.KeyChar != Convert.ToChar(8)) && (e.KeyChar != Convert.ToChar(45)))
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
