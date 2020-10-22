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
using BLL.DTO;
using Misc;

namespace GUI.Gestion
{
    public partial class FormBusesRutas : Form
    {
        public FormBusesRutas()
        {
            InitializeComponent();
        }

        BusesBLL busBll = new BusesBLL();
        BusesRutasBLL buRuBll = new BusesRutasBLL();

        #region MÉTODOS
        public void FillComboBox(ComboBox cbx, IEnumerable<object> ls)
        {
            cbx.DataSource = null;
            cbx.DataSource = ls;
            cbx.ValueMember = "IdCiudad";
            cbx.DisplayMember = "NombreCiudad";
            cbx.Refresh();
        }

        public void FillCbxBuses(ComboBox cbx, IEnumerable<object> ls)
        {
            cbx.DataSource = null;
            cbx.DataSource = ls;
            cbx.ValueMember = "IdBus";
            cbx.DisplayMember = "IdBus";
            cbx.Refresh();
        }

        public void FillCbxHorarios(int idOrigen, int idDestino)
        {
            cbxHora.DataSource = null;
            cbxHora.DataSource = buRuBll.GetAllHorario(idOrigen, idDestino);
            cbxHora.ValueMember = "IdHorario";
            cbxHora.DisplayMember = "Hora";
        }

        public void FillGrid()
        {
            dgFormulario.DataSource = null;
            dgFormulario.DataSource = buRuBll.GetAll2();
            dgFormulario.Refresh();
        }

        public void Save()
        {
            BUSES_RUTAS busRut = new BUSES_RUTAS();

            if (!string.IsNullOrEmpty(txtId.Text))
            {
                busRut.IdBusRuta = Convert.ToInt32(txtId.Text);
            }

            busRut.idBus = cbxBus.SelectedValue.ToString();
            busRut.IdHorario = Convert.ToInt32(cbxHora.SelectedValue);
            busRut.FechaRuta = dtFecha.Value.Date;

            buRuBll.Save(busRut, new WInteger(busRut.IdBusRuta));

            MessageBox.Show("REGISTRADO CORRECTAMENTE");
            CleanText(true);
            FillGrid();

        }

        public void CleanText(bool est = false)
        {
            try
            {
                if (est)
                {
                    txtId.Clear();
                }

                cbxBus.SelectedIndex = 0;
                cbxOrigen.SelectedIndex = 0;
                cbxDestino.SelectedIndex = 0;
                cbxHora.SelectedIndex = 0;
                dtFecha.Value = DateTime.Now;
                txtId.Focus();

            }
            catch (Exception)
            {
            }
        }

        public void Search(int id)
        {
            BUSES_RUTAS busRut = new BUSES_RUTAS();
            busRut = buRuBll.GetById(new WInteger(id));

            if (busRut == null)
            {
                MessageBox.Show("REGISTRO NO ENCONTRADO");
            }
            else
            {
                HorarioDTO hor = new HorarioDTO();
                List<HorarioDTO> ls = new List<HorarioDTO>();
                RutasBLL rutBll = new RutasBLL();

                ls = rutBll.GetAll2();
                hor = ls.Where(r => r.IdHorario == busRut.IdHorario).SingleOrDefault();

                txtId.Text = busRut.IdBusRuta.ToString();
                cbxBus.SelectedValue = busRut.idBus;
                cbxOrigen.SelectedValue = hor.IdOrigen;
                cbxDestino.SelectedValue = hor.IdDestino;
                cbxHora.SelectedValue = busRut.IdHorario;
                dtFecha.Value = busRut.FechaRuta;
            }

        }

        public void Delete(int id)
        {
            BUSES_RUTAS busRut = new BUSES_RUTAS();
            busRut = buRuBll.GetById(new WInteger(id));

            if (busRut != null)
            {
                buRuBll.Delete(busRut);
                MessageBox.Show("ELIMINADO CORRECTAMENTE");
                CleanText(true);
                FillGrid();
            }
            else
            {
                MessageBox.Show("REGISTRO NO ENCONTRADO");
            }

        }
        
        #endregion

        #region EVENTOS
        private void FormBusesRutas_Load(object sender, EventArgs e)
        {
            try
            {
                FillCbxBuses(cbxBus, busBll.GetAll());
                FillComboBox(cbxOrigen, buRuBll.GetAllOrigen());
                FillComboBox(cbxDestino, buRuBll.GetAllDestino(Convert.ToInt32(cbxOrigen.SelectedValue)));
                FillCbxHorarios(Convert.ToInt32(cbxOrigen.SelectedValue), Convert.ToInt32(cbxDestino.SelectedValue));
                FillGrid();
                CleanText(true);
            }
            catch (Exception)
            {

                ;
            }

        }

        private void cbxOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FillComboBox(cbxDestino, buRuBll.GetAllDestino(Convert.ToInt32(cbxOrigen.SelectedValue)));
                FillCbxHorarios(Convert.ToInt32(cbxOrigen.SelectedValue), Convert.ToInt32(cbxDestino.SelectedValue));
            }
            catch (Exception)
            {

                ;
            }
        }

        private void cbxDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FillCbxHorarios(Convert.ToInt32(cbxOrigen.SelectedValue), Convert.ToInt32(cbxDestino.SelectedValue));
            }
            catch (Exception)
            {
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void dgFormulario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex>-1)
                {
                    Search(Convert.ToInt32(dgFormulario[0,e.RowIndex].Value));
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

        #endregion

    }
}
