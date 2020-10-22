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

namespace AHORCADO
{
    public partial class FormEditor : Form
    {
        PalabrasBLL pBll = new PalabrasBLL();

        #region METODOS

        public void Save()
        {
            Palabras palabra = new Palabras();
            palabra.Palabra = txtPalabra.Text;

            if (string.IsNullOrEmpty(txtId.Text))
            {
                palabra.Palabra = txtPalabra.Text;
                pBll.Add(palabra);

                MessageBox.Show("REGISTRADO CORRECTAMENTE");

            }
            else
            {
                palabra.Id = Convert.ToInt32(txtId.Text);

                if (pBll.GetById(palabra.Id) == null)
                {
                    pBll.Add(palabra);
                    MessageBox.Show("REGISTRADO CORRECTAMENTE 2");
                }
                else
                {
                    pBll.Update(palabra);
                    MessageBox.Show("ACTUALIZADO CORRECTAMENTE");
                }
            }

            FillGrid();
            CleanText(true);


        }

        public void FillGrid()
        {

            try
            {
                dgPalabras.DataSource = null;
                dgPalabras.DataSource = pBll.GetAll();
                dgPalabras.Refresh();
            }
            catch (Exception)
            {
                
                throw;
            }

        }

        public void CleanText(bool est = false) 
        {
            if (est)
            {
                txtId.Clear();
            }
            txtPalabra.Clear();
            txtId.Focus();

        }

        public void Search(int id)
        {
            Palabras palabra = new Palabras();

            palabra = pBll.GetById(id);

            if (palabra != null)
            {
                txtId.Text = palabra.Id.ToString();
                txtPalabra.Text = palabra.Palabra;
            }
            else
            {
                CleanText();
                MessageBox.Show("REGISTRO NO ENCONTRADO");
            }

        }

        #endregion

        #region EVENTOS
        public FormEditor()
        {
            InitializeComponent();
        }

        private void FormEditor_Load(object sender, EventArgs e)
        {
            try
            {
                dgPalabras.AutoGenerateColumns = false;
                CleanText(true);
                FillGrid();
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CleanText(true);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgPalabras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    Search(Convert.ToInt32(dgPalabras[0, e.RowIndex].Value));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgPalabras_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    Search(Convert.ToInt32(dgPalabras[0, e.RowIndex].Value));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        #endregion
    }
}
