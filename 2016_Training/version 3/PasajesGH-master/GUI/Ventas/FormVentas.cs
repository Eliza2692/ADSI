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
using BLL.Extensions;
using GUI.Gestion;

namespace GUI.Ventas
{
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
        }

        ClientesBLL cliBll = new ClientesBLL();
        DetalleFacturaBLL deFaBll = new DetalleFacturaBLL();

        public void FillComboBox(ComboBox cbx, IEnumerable<object> ls)
        {
            cbx.DataSource = null;
            cbx.DataSource = ls;
            cbx.ValueMember = "IdCiudad";
            cbx.DisplayMember = "NombreCiudad";
            cbx.Refresh();
        }

        public void FillCbxHorarios(int idOrigen, int idDestino, DateTime fecha)
        {
            cbxHora.DataSource = null;
            cbxHora.DataSource = deFaBll.GetAllHorario(idOrigen, idDestino, fecha);
            cbxHora.ValueMember = "IdHorario";
            cbxHora.DisplayMember = "Hora";
        }

        //public void FillGrid()
        //{
        //    dgFormulario.DataSource = null;
        //    dgFormulario.DataSource = buRuBll.GetAll2();
        //    dgFormulario.Refresh();
        //}

        
        //public void CleanText(bool est = false)
        //{
        //    try
        //    {
        //        if (est)
        //        {
        //            txtId.Clear();
        //        }

        //        cbxBus.SelectedIndex = 0;
        //        cbxOrigen.SelectedIndex = 0;
        //        cbxDestino.SelectedIndex = 0;
        //        cbxHora.SelectedIndex = 0;
        //        dtFecha.Value = DateTime.Now;
        //        txtId.Focus();

        //    }
        //    catch (Exception)
        //    {
        //    }
        //}


        public void SearchCliente(string id)
        {
            CLIENTES cli = new CLIENTES();
            cli = cliBll.GetById(id);

            if (cli != null)
            {
                txtNombreCliente.Text = cli.NombresCliente;
                txtApellidoCliente.Text = cli.ApellidosCliente;
            }
            else
            {
                MessageBox.Show("CLIENTE NO REGISTRADO");
                FormCliente formCliente = new FormCliente();
                formCliente.MdiParent = this.MdiParent;
                formCliente.Show();
            }


        }

        private void btnBuscarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtIdCliente.Text))
                {
                    SearchCliente(txtIdCliente.Text);    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtIdCliente.Text) && (e.KeyChar == Convert.ToChar(13)))
                {
                    SearchCliente(txtIdCliente.Text);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            try
            {
                FillComboBox(cbxOrigen, deFaBll.GetAllOrigen(dtFecha.Value.Date));
                FillComboBox(cbxDestino, deFaBll.GetAllDestino(Convert.ToInt32(cbxOrigen.SelectedValue), dtFecha.Value.Date));
                FillCbxHorarios(Convert.ToInt32(cbxOrigen.SelectedValue), Convert.ToInt32(cbxDestino.SelectedValue), dtFecha.Value.Date);
            }
            catch (Exception)
            {         
            }
        }

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                FillComboBox(cbxOrigen, deFaBll.GetAllOrigen(dtFecha.Value.Date));
            }
            catch (Exception)
            {
            }
        }

        private void cbxOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FillComboBox(cbxDestino, deFaBll.GetAllDestino(Convert.ToInt32(cbxOrigen.SelectedValue), dtFecha.Value.Date));
            }
            catch (Exception)
            {
            }
        }

        private void cbxDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FillCbxHorarios(Convert.ToInt32(cbxOrigen.SelectedValue), Convert.ToInt32(cbxDestino.SelectedValue), dtFecha.Value.Date);
            }
            catch (Exception)
            {
            }
        }
    
    }
}
