using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datagrid2
{
    public partial class Form1 : Form
    {
        //Contexto de listado de producto
        List<Productos> ctx = new List<Productos>();

        //METODOS ***************************************************

        //copia lo del data grid view a los text box
        private void FillData(string rf)
        {
            Productos obj = new Productos();
            obj = GetByID(rf);
            if (obj != null)
            {
                txtReferencia.Text = obj.Referencia;
                txtPrecioVenta.Text = obj.PrecioVenta.ToString();
                txtPrecioCompra.Text = obj.PrecioCompra.ToString();
                txtNombre.Text = obj.Nombre;
                txtCaracteristicas.Text = obj.Caracteristica;
                txtAlmacenamiento.Text = obj.LugarAlmacenamiento;
                txtFoto.Text = obj.Foto; 
                dtFechaIngreso.Value = obj.FechaIngreso;
                nmCantidad.Value = obj.Cantidad;
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

        //Buscar por ID
        private Productos GetByID (string referencia)
        {
            foreach (Productos p in ctx.ToList())
            {
                if (p.Referencia.Equals(referencia))
                {
                    return p;
                }
            }
            return null;
        }

        //Guardar
        public void Save()
        {
            Productos obj = new Productos();
            obj.Referencia = txtReferencia.Text;
            obj.Nombre = txtNombre.Text;
            obj.Caracteristica = txtCaracteristicas.Text;
            obj.LugarAlmacenamiento = txtAlmacenamiento.Text;
            obj.PrecioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
            obj.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
            obj.Cantidad = Convert.ToInt32(nmCantidad.Value);
            obj.FechaIngreso = dtFechaIngreso.Value;
            obj.Foto = txtFoto.Text;
            if (GetByID(obj.Referencia) == null)
            {
                ctx.Add(obj);
            }
            else 
            {
                foreach (Productos p in ctx.ToList())
                {
                    if (p.Referencia.Equals(obj.Referencia))
                    {
                        p.Referencia = obj.Referencia;
                        p.Nombre = obj.Nombre;
                        p.Caracteristica = obj.Caracteristica;
                        p.LugarAlmacenamiento = obj.LugarAlmacenamiento;
                        p.PrecioCompra = obj.PrecioCompra;
                        p.PrecioVenta = obj.PrecioVenta;
                        p.Cantidad = obj.Cantidad;
                        p.FechaIngreso = obj.FechaIngreso;
                        p.Foto = obj.Foto;
                        break;
                    }
                }
            }
        }


        //Activa y desactiva botones
        public void ActivateControls(bool bNuevo, bool bGuardar, bool bEliminar, bool bCancelar, bool bPanel)
        {
            btnNuevo.Enabled = bNuevo;
            btnGuardar.Enabled = bGuardar;
            btnEliminar.Enabled = bEliminar;
            btnCancelar.Enabled = bCancelar;
            panel1.Enabled = bPanel;
        }

        //Limpiar los textos en las cajas
        public void CleanText()
        {
            txtReferencia.Clear();
            txtPrecioVenta.Clear();
            txtPrecioCompra.Clear();
            txtNombre.Clear();
            txtAlmacenamiento.Clear();
            txtCaracteristicas.Clear();
            txtFoto.Clear();
            dtFechaIngreso.Value = DateTime.Now;
            nmCantidad.Value = 0;
            picFoto.Image = null;
        }

        //DataGrid
        public void FillGrid()
        {
            dgProducto.DataSource = ctx.ToList();
            dgProducto.Refresh();
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
            txtReferencia.Focus();
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

        //Boton Eliminar

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (Productos ob in ctx)
            {
                if (ob.Referencia == txtReferencia.Text)
                {
                    ctx.Remove(ob);
                    break;
                }                
            }
            CleanText();
            ActivateControls(true,false,false,false,false);
            FillGrid();
        }

        //Caja de texto
        private void txtReferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Productos obj = new Productos();
                obj = GetByID(txtReferencia.Text);
                if (obj != null)
                {
                    FillData(txtReferencia.Text);
                }
            }     
        }

        //Doble click data grip view

        private void dgProducto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos = e.RowIndex;
            if (pos > -1)
            {
                FillData(dgProducto[0, pos].Value.ToString());
            }
        }

        private void dgProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos = e.RowIndex;
            if (pos > -1)
            {
                FillData(dgProducto[0, pos].Value.ToString());
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
