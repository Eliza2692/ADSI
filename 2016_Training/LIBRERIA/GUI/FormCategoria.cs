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
    public partial class FormCategoria : Form
    {

        CategoriasBLL mngCat = new CategoriasBLL();

        #region METODOS

        public void FillGrid()
        {
            dgCategoria.DataSource = null;
            dgCategoria.DataSource = mngCat.GetAll();
            dgCategoria.Refresh();
        }

        public void CleanText(bool tId=false)    
        {
            if (tId==true)
                txtId.Clear();
            txtNombre.Clear();
            txtId.Focus();
        }
        public void Save()
        {
            try
            {
                Categorias cat = new Categorias();
                cat.Nombre = txtNombre.Text.ToString();

                if (String.IsNullOrEmpty(txtId.Text)) //VAMO A GUALDALO
                {
                    //cat.Nombre = txtNombre.Text.ToString();
                    mngCat.Add(cat);
                    MessageBox.Show("GUARDADO");
                    CleanText(true);
                }
                else                
                { 
                    if (mngCat.GetById(Convert.ToInt32(txtId.Text)) == null)
                    {
                        //cat.Nombre = txtNombre.Text.ToString();
                        mngCat.Add(cat);
                        MessageBox.Show("GUARDADO ID: ");
                    }else
                    {
                        var res =MessageBox.Show("Desea Actualizar el registro", "Categoria Existente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (DialogResult.Yes == res)
                        {
                            cat.Id = Convert.ToInt32(txtId.Text);
                            mngCat.Update(cat);
                            MessageBox.Show("ACTUALIZADO ID: ");
                            CleanText(true);
                        }
                        else { MessageBox.Show("NO SE REALIZARON CAMBIOS"); }
                    }
                    
                }
                FillGrid();

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
                if (mngCat.GetById(Convert.ToInt32(txtId.Text)) != null)
                {
                    var res = MessageBox.Show("Desea Eliminar el registro", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == res)
                    {
                        mngCat.Delete(Convert.ToInt32(txtId.Text));
                        MessageBox.Show("ELIMINADO CORRECTAMENTE");
                    }
                    else { MessageBox.Show("NO SE REALIZARON CAMBIOS"); }
                }
                else {
                    MessageBox.Show("NO ENCONTRADO");
                }
                FillGrid();
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
                Categorias cat = new Categorias();

                cat = mngCat.GetById(id);

                if (cat == null)
                {
                    MessageBox.Show("NO EXISTE");
                    CleanText();
                }
                else
                {
                    txtId.Text = cat.Id.ToString();
                    txtNombre.Text = cat.Nombre;
    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region EVENTOS
        public FormCategoria()
        {
            InitializeComponent();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(13))
            {
                Search(Convert.ToInt32(txtId.Text));
            }
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            FillGrid();
            CleanText(true);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Search(Convert.ToInt32(txtId.Text));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Delete();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Save();           
        }

        private void dgCategoria_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Search(Convert.ToInt32(dgCategoria[0,e.RowIndex].Value));
            }
        }

        private void dgCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Search(Convert.ToInt32(dgCategoria[0, e.RowIndex].Value));
            }
        }

        #endregion

    }
}
