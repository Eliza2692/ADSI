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

namespace GUI.Gestion
{
    public partial class FormCliente : Form
    {

        ClientesBLL cliBll = new ClientesBLL();

        #region MÉTODOS
        public void CleanText(bool est = false)
        {
            if (est)
            {
                txtId.Clear();
            }
            txtNombres.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtId.Focus();
        }

        public void FillGrid()
        {
            dgFormulario.DataSource = null;
            dgFormulario.DataSource = cliBll.GetAll();
            dgFormulario.Refresh();
        }

        public void Search(string id)
        {
            CLIENTES cli = new CLIENTES();
            cli = cliBll.GetById(id);

            if (cli != null)
            {
                txtId.Text = cli.IdCliente;
                txtNombres.Text = cli.NombresCliente;
                txtApellidos.Text = cli.ApellidosCliente;
                txtTelefono.Text = cli.TelefonoCliente;
                txtEmail.Text = cli.CorreoCliente;
            }
            else
            {
                MessageBox.Show("REGISTRO NO ENCONTRADO");
            }

        }

        public void Save()
        {

            CLIENTES cli = new CLIENTES();
            
            cli.NombresCliente = txtNombres.Text;
            cli.ApellidosCliente = txtApellidos.Text;
            cli.TelefonoCliente = txtTelefono.Text;
            cli.CorreoCliente = txtEmail.Text;

            if (!string.IsNullOrEmpty(txtNombres.Text) && !string.IsNullOrEmpty(txtApellidos.Text))
            {
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    cli.IdCliente = txtId.Text;
                }

                cliBll.Save(cli, cli.IdCliente);
                MessageBox.Show("REGISTRADO CORRECTAMENTE");
                CleanText(true);
                FillGrid();
            }
            else
            {
                MessageBox.Show("CAMPOS NOMBRE Y APELLIDO SON OBLIGATORIOS");
            }

        }

        public void Delete(string id)
        {
            CLIENTES cli = new CLIENTES();
            cli = cliBll.GetById(id);

            if (cli != null)
            {
                cliBll.Delete(cli);
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


        public FormCliente()
        {
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            dgFormulario.AutoGenerateColumns = false;
            FillGrid();
            CleanText(true);
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

        private void dgFormulario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
