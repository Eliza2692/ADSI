using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajandocondatagridview
{
    public partial class Form1 : Form
    {
        //Contexto de listado de producto
        List<Trabajador> ctx = new List<Trabajador>();

        //METODOS ***************************************************

        //Activa y desactiva botones
        public void ActivateControls(bool bNuevo, bool bGuardar, bool bEliminar, bool bCancelar, bool bPanel)
        {
            btnNuevo.Enabled = bNuevo;
            btnGuardar.Enabled = bGuardar;
            btnEliminar.Enabled = bEliminar;
            btnCancelar.Enabled = bCancelar;
            panel1.Enabled = bPanel;
        }

        //Buscar por ID
        private Trabajador GetByID(string cod)
        {
            foreach (Trabajador p in ctx.ToList())
            {
                if (p.Codigo.Equals(cod))
                {
                    return p;
                }
            }
            return null;
        }

        //copia lo del data grid view a los text box
        private void FillData(string rf)
        {
            Trabajador obj = new Trabajador();
            obj = GetByID(rf);
            if (obj != null)
            {
                txtCodigo.Text = obj.Codigo;
                txtNombre.Text = obj.Nombre;
                txtApellido.Text = obj.Apellido;
                dtFechaNacimiento.Value = obj.FechaNacimiento;
                txtCargo.Text = obj.Cargo;
                txtSalario.Text = obj.Salario.ToString();
                txtDependencia.Text = obj.Dependencia;
                dtFechaIngreso.Value = obj.FechaIngreso;
                txtFoto.Text = obj.Foto;
                if (txtFoto.Text != "")
                    picFoto.Image = Image.FromFile(txtFoto.Text);
                else
                    picFoto.Image = null;
                ActivateControls(false, true, true, true, true);
            }
            else
            {
                ActivateControls(false, true, false, true, true);
            }
        }

        //Limpiar los textos en las cajas
        public void CleanText()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            dtFechaNacimiento.Value = DateTime.Now;
            txtCargo.Clear();
            txtSalario.Clear();
            txtDependencia.Clear();
            dtFechaIngreso.Value = DateTime.Now;
            txtFoto.Clear();
            picFoto.Image = null;
        }

        //DataGrid
        public void FillGrid()
        {
            dgEmpleado.DataSource = ctx.ToList();
            dgEmpleado.Refresh();
        }

        //Guardar
        public void Save()
        {
            Trabajador obj = new Trabajador();

            obj.Codigo=txtCodigo.Text ;
            obj.Nombre=txtNombre.Text ;
            obj.Apellido=txtApellido.Text;
            obj.FechaNacimiento = dtFechaNacimiento.Value;
            obj.Cargo=txtCargo.Text;
            obj.Salario= Convert.ToDecimal(txtSalario.Text);
            obj.Dependencia=txtDependencia.Text;
            obj.FechaIngreso = dtFechaIngreso.Value;
            obj.Foto = txtFoto.Text;
            if (GetByID(obj.Codigo) == null)
            {
                ctx.Add(obj);
            }
            else
            {
                foreach (Trabajador p in ctx.ToList())
                {
                    if (p.Codigo.Equals(obj.Codigo))
                    {
                        p.Codigo = obj.Codigo;
                        p.Nombre = obj.Nombre;
                        p.Apellido = obj.Apellido;
                        p.FechaNacimiento= obj.FechaNacimiento;
                        p.Cargo = obj.Cargo;
                        p.Salario = obj.Salario;
                        p.Dependencia = obj.Dependencia;
                        p.FechaIngreso = obj.FechaIngreso;
                        p.Foto = obj.Foto;
                        break;
                    }
                }
            }
        }

        //EVENTOS **************************************************

        public Form1()
        {
            InitializeComponent();
        }

        //Cargar el formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            ActivateControls(true, false, false, false, false);
            FillGrid();
        }

        //Boton nuevo 
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ActivateControls(false, true, false, true, true);
            CleanText();
            txtCodigo.Focus();
        }

        //Boton Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ActivateControls(true, false, false, false, false);
            CleanText();
        }

        //Boton Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Save();
                CleanText();
                ActivateControls(false, true, false, true, true);
                FillGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //boton eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (Trabajador ob in ctx)
            {
                if (ob.Codigo == txtCodigo.Text)
                {
                    ctx.Remove(ob);
                    break;
                }
            }
            CleanText();
            ActivateControls(true, false, false, false, false);
            FillGrid();
        }

        //caja de texto
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Trabajador obj = new Trabajador();
                obj = GetByID(txtCodigo.Text);
                if (obj != null)
                {
                    FillData(txtCodigo.Text);
                }
            }  
        }

        //Doble click data grip view 1
        private void dgEmpleado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos = e.RowIndex;
            if (pos > -1)
            {
                FillData(dgEmpleado[0, pos].Value.ToString());
            }
        }

        //Doble click data grip view 2
        private void dgEmpleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos = e.RowIndex;
            if (pos > -1)
            {
                FillData(dgEmpleado[0, pos].Value.ToString());
            }
        }

        //Cargar imagen
        private void picBuscarFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                txtFoto.Text = openFileDialog1.FileName;
                picFoto.Image = Image.FromFile(txtFoto.Text);
            }
        }

        //eliminar Imagen
        private void picQuitarFoto_Click(object sender, EventArgs e)
        {
            txtFoto.Text = "";
            picFoto.Image = null;
        }

        //Boton salir del formulario
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea salir", "Salir", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
                Close();
            switch (result)
            {
                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }
                    
    }
}
