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
    public partial class FormBuses : Form
    {
        private BusesBLL busBll = new BusesBLL();


        #region MÉTODOS

        public void CleanText(bool est = false)
        {
            if (est)
            {
                txtId.Clear();
            }
            txtPlaca.Clear();
            txtId.Focus();
        }

        public void FillGrid()
        {
            dgFormulario.DataSource = null;
            dgFormulario.DataSource = busBll.GetAll();
            dgFormulario.Refresh();
        }

        public void Search(string id)
        {
            BUSES bus = new BUSES();
            bus = busBll.GetById(id);

            if (bus != null)
            {
                txtId.Text = bus.IdBus.ToString();
                txtPlaca.Text = bus.PlacaBus;
            }
            else
            {
                MessageBox.Show("REGISTRO NO ENCONTRADO");
            }

        }

        public void Save()
        {

            BUSES bus = new BUSES();
            bus.PlacaBus = txtPlaca.Text;

            if (!string.IsNullOrEmpty(bus.PlacaBus))
            {
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    bus.IdBus = txtId.Text;
                }

                busBll.Save(bus, bus.IdBus);
                MessageBox.Show("REGISTRADO CORRECTAMENTE");
                CleanText(true);
                FillGrid();
            }
            else
            {
                MessageBox.Show("CAMPO NOMBRE NO ES VÁLIDO");
            }


        }

        public void Delete(string id)
        {
            BUSES bus = new BUSES();
            bus = busBll.GetById(id);

            if (bus != null)
            {
                busBll.Delete(bus);
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
        public FormBuses()
        {
            InitializeComponent();
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

        private void FormBuses_Load(object sender, EventArgs e)
        {
            dgFormulario.AutoGenerateColumns = false;
            FillGrid();
            CleanText();
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Search(txtId.Text);
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
                Delete(txtId.Text);
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
                    Search(txtId.Text);
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
                if (e.RowIndex>-1)
                {
                    Search(dgFormulario[0, e.RowIndex].Value.ToString());
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
                    Search(dgFormulario[0, e.RowIndex].Value.ToString());
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
