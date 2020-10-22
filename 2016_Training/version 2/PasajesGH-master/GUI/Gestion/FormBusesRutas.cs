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

        public void FillGrid()
        {
            dgFormulario.DataSource = null;
            //dgFormulario.DataSource = rutBll.GetAll2();
            dgFormulario.Refresh();
        }

        private void FormBusesRutas_Load(object sender, EventArgs e)
        {
            try 
	        {	        
		        FillCbxBuses(cbxBus, busBll.GetAll());
                FillComboBox(cbxOrigen, buRuBll.GetAllOrigen());
                FillComboBox(cbxDestino, buRuBll.GetAllDestino(Convert.ToInt32(cbxOrigen.SelectedValue)));
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
            }
            catch (Exception)
            {

                ;
            }
        }
    }
}
