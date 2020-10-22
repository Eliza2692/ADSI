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
using Misc;

namespace GUI.Gestion
{
    public partial class FormCiudades : Form
    {
        
        private CiudadesBLL ciuBll = new CiudadesBLL();

        #region MÉTODOS
        public void CleanText(bool est = false)
        {
            if (est)
            {
                txtId.Clear();
            }
            txtNombre.Clear();
            txtId.Focus();
        }

        public void FillGrid()
        {
            dgFormulario.DataSource = null;
            dgFormulario.DataSource = ciuBll.GetAll();
            dgFormulario.Refresh();
        }

        public void Search(int id)
        {
            CIUDADES ciu = new CIUDADES();
            ciu = ciuBll.GetById(new WInteger(id));

            if (ciu != null)
            {
                txtId.Text = ciu.IdCiudad.ToString();
                txtNombre.Text = ciu.NombreCiudad;
            }
            else
            {
                MessageBox.Show("REGISTRO NO ENCONTRADO");
            }

        }

        public void Save()
        {

            CIUDADES ciu = new CIUDADES();
            ciu.NombreCiudad = txtNombre.Text;

            if (!string.IsNullOrEmpty(ciu.NombreCiudad))
            {
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    ciu.IdCiudad = Convert.ToInt32(txtId.Text);
                }

                ciuBll.Save(ciu, new WInteger(ciu.IdCiudad));
                MessageBox.Show("REGISTRADO CORRECTAMENTE");
                CleanText(true);
                FillGrid();
            }
            else
            {
                MessageBox.Show("CAMPO NOMBRE NO ES VÁLIDO");
            }

            
        }

        public void Delete(int id)
        {
            CIUDADES ciu = new CIUDADES();
            ciu = ciuBll.GetById(new WInteger(id));

            if (ciu != null)
            {
                ciuBll.Delete(ciu);
                CleanText(true);
                FillGrid();
                MessageBox.Show("ELIMINADO CORRECTAMENTE");
            }
            else
            {
                MessageBox.Show("REGISTRO NO ENCONTRADO");
            }
            
        }
        
        #endregion

        #region EVENTOS
        public FormCiudades()
        {
            InitializeComponent();
            dgFormulario.AutoGenerateColumns = false;
        }

        private void FormCiudades_Load(object sender, EventArgs e)
        {
            try
            {
                ciuBll = new CiudadesBLL();
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CleanText(true);
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

        private void dgFormulario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    Search(Convert.ToInt32(dgFormulario[0, e.RowIndex].Value));
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgFormulario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    Search(Convert.ToInt32(dgFormulario[0, e.RowIndex].Value));
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
