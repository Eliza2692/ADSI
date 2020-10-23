using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wmManejoArchivos.Clases;

namespace wmManejoArchivos
{
    public partial class Form1 : Form
    {
        //CAMPOS
        GestionEmpleados ge = new GestionEmpleados();

        //METODOS

        //cargar data grid
        public void FillGrid()
        {
            dgEmpleados.DataSource = null;
            dgEmpleados.DataSource = ge.GetAll();
            dgEmpleados.Refresh();
        }
        
        //limpiar cajas
        public void CleanText()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtSalario.Clear();
            dtFechaIngreso.Value = DateTime.Now;
            picFoto.Image = null;
            cbxCargo.Text="";
            cbxCiudad.Text = "";
            cbxGenero.Text = "";
        }

        //activar botones
        public void ActiveButtons(bool bNuevo, bool bGuardar, bool bEliminar, bool bCancelar, bool bPanel)
        {
            btnNuevo.Enabled = bNuevo;
            btnGuardar.Enabled = bGuardar;
            btnEliminar.Enabled = bEliminar;
            btnCancelar.Enabled = bCancelar;
            panel1.Enabled = bPanel;
        }

        public void FillData(string id)
        {
            Empleados obj = ge.GetById(id);
            if (obj != null)
            {
                txtCodigo.Text = obj.Codigo;
                txtNombre.Text = obj.Nombre;
                txtApellido.Text = obj.Apellido;
                txtSalario.Text = obj.Salario.ToString();
                dtFechaIngreso.Value = obj.FechaIngreso;
                picFoto.Image = null;
                cbxCargo.Text = obj.Cargo;
                cbxCiudad.Text = obj.Ciudad;
                cbxGenero.Text = obj.Genero;
            }
            else
                CleanText();            
        }


        //EVENTOS

        public Form1()
        {
            InitializeComponent();
        }

        //cargar formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ActiveButtons(true, false, false, false, false);
                FillGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //boton nuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ActiveButtons(false, true, false, true, true);
            CleanText();
        }

        //boton guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Empleados obj = new Empleados(txtCodigo.Text, txtNombre.Text, txtApellido.Text, dtFechaIngreso.Value,
                                              "", cbxCargo.Text, cbxGenero.Text, double.Parse(txtSalario.Text),
                                              cbxCiudad.Text);
                if (ge.GetById(obj.Codigo) == null)
                    ge.Add(obj);
                else
                    ge.Update(obj);
                FillGrid();
                CleanText();
                ActiveButtons(true, false, false, false, false);
                MessageBox.Show("Datos almacenados correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // boton eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try 
            {
                if (ge.GetById(txtCodigo.Text) != null)
                {
                    ge.Delete(txtCodigo.Text);
                    FillGrid();
                    ActiveButtons(true, false, false, false, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //boton cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ActiveButtons(true,false,false,false,false);
            CleanText();
        }

        //doble click en el data grid
        private void dgEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex;
            if (f > -1)
            {
                FillData(dgEmpleados[0, f].Value.ToString());
                ActiveButtons(false, true, true, true, true);
            }
        }

        private void dgEmpleados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex;
            if (f > -1)
            {
                FillData(dgEmpleados[0, f].Value.ToString());
                ActiveButtons(false, true, true, true, true);
            }
        }

        //buscar caja de texto codigo
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                FillData(txtCodigo.Text);
                ActiveButtons(false, true, true, true, true);
            }
        }

        private void picFoto_Click(object sender, EventArgs e)
        {

        }
  
    }
}
