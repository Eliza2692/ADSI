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
using BLL.Extensions;
using Misc;
using BLL.DTO;

namespace GUI.Gestion
{
    public partial class FormRutas : Form
    {

        private RutasBLL rutBll = new RutasBLL();
        private CiudadesBLL ciuBll = new CiudadesBLL();        
        
        #region MÉTODOS
        public void CleanText(bool est = false)
        {
            try
            {
                if (est)
                {
                    txtId.Clear();
                }
                cbxOrigen.SelectedIndex = 0;
                cbxDestino.SelectedIndex = 0;
                txtValor.Clear();
                dtHorario.Value = DateTime.Now;
                txtId.Focus();
            }
            catch (Exception)
            {
                ;                
            }

        }

        public void FillComboBox(ComboBox cbx, IEnumerable<object> ls)
        {
            cbx.DataSource = null;
            cbx.DataSource = ls;
            cbx.ValueMember = "IdCiudad";
            cbx.DisplayMember = "NombreCiudad";
            cbx.Refresh();
        }

        public void FillGrid()
        {
            dgFormulario.DataSource = null;
            dgFormulario.DataSource = rutBll.GetAll2();
            dgFormulario.Refresh();
        }

        public void Search(int id)
        {
            HorarioDTO hor = new HorarioDTO();
            List<HorarioDTO> ls = new List<HorarioDTO>();

            ls = rutBll.GetAll2();

            hor = ls.Where(r => r.IdHorario == id).SingleOrDefault();

            if (hor != null)
            {
                txtId.Text = hor.IdHorario.ToString();
                cbxOrigen.SelectedValue = hor.IdOrigen;
                cbxDestino.SelectedValue = hor.IdDestino;
                dtHorario.Text =hor.Hora.ToString();
                txtValor.Text = hor.Valor.ToString();
            }
            else
            {
                MessageBox.Show("REGISTRO NO ENCONTRADO");
            }

        }

        public void Save()
        {
            RUTAS rut = new RUTAS();
            rut.CiudadOrigen = Convert.ToInt32(cbxOrigen.SelectedValue);
            rut.CiudadDestino = Convert.ToInt32(cbxDestino.SelectedValue);
            rut.Valor = Convert.ToDecimal(txtValor.Text);
            
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                rut.IdRuta = Convert.ToInt32(txtId.Text);
            }

            if (rutBll.GetByCity(rut.CiudadOrigen, rut.CiudadDestino) == null)
            {

                rutBll.Save(rut, new WInteger(rut.IdRuta));
                                              
            }
            
            RUTAS ruta = new RUTAS();
            ruta = rutBll.GetByCity(rut.CiudadOrigen, rut.CiudadDestino);

            HORARIOS hor = new HORARIOS();
            hor.IdRuta = ruta.IdRuta;
            hor.Hora = dtHorario.Value.TimeOfDay;

            rutBll.AddHorario(hor);
            MessageBox.Show("REGISTRADO CORRECTAMENTE");
            CleanText(true);
            FillGrid();  
            

        }

        public void Delete(int id)
        {
            RUTAS rut = new RUTAS();
            rut = rutBll.GetById(new WInteger(id));

            if (rut != null)
            {
                rutBll.Delete(rut);
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
        public FormRutas()
        {
            InitializeComponent();
        }

        private void FormRutas_Load(object sender, EventArgs e)
        {
            try
            {                
                dgFormulario.AutoGenerateColumns = false;
                FillComboBox(cbxOrigen, ciuBll.GetAll());
                FillComboBox(cbxDestino, rutBll.GetAllId(new WInteger(Convert.ToInt32(cbxOrigen.SelectedValue))));
                CleanText(true);                
                FillGrid();                
            }
            catch (Exception)
            {
                
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
            try
            {
                CleanText(true);                
            }
            catch (Exception)
            {
                ;
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

        private void cbxOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FillComboBox(cbxDestino, rutBll.GetAllId(new WInteger(Convert.ToInt32(cbxOrigen.SelectedValue))));
            }
            catch (Exception)
            {
                ;
            }
            
        }

        #endregion

        private void cbxDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}

