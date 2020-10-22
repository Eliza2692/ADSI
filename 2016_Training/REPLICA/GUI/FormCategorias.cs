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
    public partial class FormCategorias : Form
    {
        CategoriasBLL mngCat = new CategoriasBLL();

        #region METODOS

        public void Search(int id) {
            try
            {
                Categorias cat = new Categorias();
                cat = mngCat.GetById(id);

                if (cat != null)
                {
                    txtId.Text = cat.Id.ToString();
                    txtNombre.Text = cat.Nombre;
                    
                }
                else {
                    MessageBox.Show("NO SE ENCONTRÓ");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
        public void FillGrid()
        {
            dgCategorias.DataSource=null;
            dgCategorias.DataSource=mngCat.GetAll();
            dgCategorias.Refresh();
        }

        public void CleanText(bool id = false) {
            if (id)
                txtId.Clear();
            txtNombre.Clear();
            txtId.Focus();
        }

        public void Save() {
            try
            {
                Categorias cat = new Categorias();
                cat.Nombre = txtNombre.Text;

                if (String.IsNullOrEmpty(txtId.Text))
                {
                    mngCat.Add(cat);
                    MessageBox.Show("REGISTRADO CORRECTAMENTE");
                    CleanText(true);
                }
                else
                {
                    if (mngCat.GetById(Convert.ToInt32(txtId.Text)) == null)
                    {
                        mngCat.Add(cat);
                        MessageBox.Show("REGISTRADO CORRECTAMENTE");
                        CleanText(true);
                    }
                    else
                    {
                        cat.Id = Convert.ToInt32(txtId.Text);
                        var res = MessageBox.Show("¿Confirmar actualización?", "REGISTRO ENCONTRADO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res == DialogResult.Yes)
                        {
                            mngCat.Update(cat);
                            MessageBox.Show("ACTUALIZADO CORRECTAMENTE");
                            CleanText(true);
                        }
                        else
                        {
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

        public void Delete(int id) {

            try
            {
                if (mngCat.GetById(id) != null) {

                    var res = MessageBox.Show("¿Desea eliminar el registro?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(res == DialogResult.Yes){
                        mngCat.Delete(id);
                        MessageBox.Show("ELIMINADO CORRECTAMENTE");
                    }else{
                        MessageBox.Show("NO SE REALIZARON CAMBIOS");
                    }

                }else{
                    MessageBox.Show("REGISTRO NO ENCONTRADO");
                }
                CleanText();
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
            FillGrid();
            CleanText();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                Search(Convert.ToInt32(txtId.Text));
            }
        }

        private void dgCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>-1)
            {
                Search(Convert.ToInt32(dgCategorias[0, e.RowIndex].Value));
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
