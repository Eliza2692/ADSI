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
    public partial class FormLibro : Form
    {

        LibrosBLL mngLibro = new LibrosBLL();
        CategoriasBLL mngCategoria = new CategoriasBLL();
        AutoresBLL mngAutor = new AutoresBLL();
        EditorialesBLL mngEditorial = new EditorialesBLL();

        #region METODOS

        public void FillCombox(ComboBox cbx, DataTable dt)
        {
            cbx.DataSource = null;
            cbx.DataSource = dt;
            cbx.DisplayMember = "Nombre";
            cbx.ValueMember = "Id";
            cbx.Refresh();
        }

        public void FillGrid()
        {
            dgLibro.DataSource = null;
            dgLibro.DataSource = mngLibro.GetAll();
            dgLibro.Refresh();
        }

        public void Search(int id)
        {
            try
            {
                Libros lib = new Libros();
                lib =mngLibro.GetById(id);

                if (lib!=null)
                {
                    txtId.Text = lib.Id.ToString();
                    txtIsbn.Text = lib.Isbn.ToString();
                    txtNombre.Text = lib.Nombre.ToString();
                    cbxEditorial.SelectedValue = lib.Ideditorial;
                    numNumeroPaginas.Value = lib.Numeropaginas;
                    cbxCategorias.SelectedValue = lib.Idcategoria;
                    cbxAutor.SelectedValue = lib.Idautor;
                }
                else
                {
                    MessageBox.Show("Registro no encontrado");
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        public void Delete()
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                if (mngLibro.GetById(id) != null)
                {
                    var resp = MessageBox.Show("Desea eliminar registro?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resp == DialogResult.Yes)
                    {
                        mngLibro.Delete(id);
                        CleanText(true);
                        FillGrid();
                    }
                    else
                    {
                        MessageBox.Show("No se realizaron cambios");
                    }
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

        public void CleanText(bool tId = false)
        {
            if (tId==true)
            {
                txtId.Clear();
            }
            txtIsbn.Clear();
            txtNombre.Clear();
            cbxEditorial.SelectedValue = 0;
            numNumeroPaginas.Value = 0;
            cbxCategorias.SelectedValue = 0;
            cbxAutor.SelectedValue = 0;
        }

        public void Save()
        {
            try
            {
                Libros lib = new Libros();

                lib.Isbn = txtIsbn.Text;
                lib.Nombre = txtNombre.Text;
                lib.Ideditorial = Convert.ToInt32(cbxEditorial.SelectedValue);
                lib.Numeropaginas = Convert.ToInt32(numNumeroPaginas.Value);
                lib.Idcategoria = Convert.ToInt32(cbxCategorias.SelectedValue);
                lib.Idautor = Convert.ToInt32(cbxAutor.SelectedValue);

                if (string.IsNullOrEmpty(txtId.Text))
                {
                    mngLibro.Add(lib);
                    MessageBox.Show("Guardado");
                    CleanText(true);
                }
                else
                {
                    if (mngLibro.GetById(Convert.ToInt32(txtId.Text))==null)
                    {
                        mngLibro.Add(lib);
                        MessageBox.Show("Guardado");
                        CleanText(true);
                    }
                    else
                    {
                        var resp = MessageBox.Show("Desea actualizar registro?", "ACTUALIZACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resp == DialogResult.Yes)
                        {
                            lib.Id=Convert.ToInt32(txtId.Text);
                            mngLibro.Update(lib);
                            MessageBox.Show("Actualizado");
                            CleanText(true);
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
        #endregion

        #region EVENTOS
        public FormLibro()
        {
            InitializeComponent();
        }

        private void FormLibro_Load(object sender, EventArgs e)
        {
            FillGrid();
            FillCombox(cbxEditorial, mngEditorial.GetAll());
            FillCombox(cbxCategorias, mngCategoria.GetAll());
            FillCombox(cbxAutor, mngAutor.GetAll());
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
            Delete();
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

        private void dgLibro_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>-1)
            {
                Search(Convert.ToInt32(dgLibro[0,e.RowIndex].Value));
            }
        }

        private void dgLibro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Search(Convert.ToInt32(dgLibro[0, e.RowIndex].Value));
            }
        }
        #endregion
    }
}
