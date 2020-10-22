using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Entities;
using DAL.Extensions;

namespace GUI
{
    public partial class FormProductos : Form
    {

        #region METODOS

        ManagementCategorias mngCat = new ManagementCategorias(@"C:\Inventario\categorias.txt");
        ManagementProductos mngProd = new ManagementProductos(@"C:\Inventario\productos.txt");
        ManagementProveedores mngProv = new ManagementProveedores(@"C:\Inventario\proveedores.txt");

        public void FillGrid(List<Productos> lsMostrar)
        {

            try
            {
                dgProductos.DataSource = null;
                dgProductos.DataSource = lsMostrar;
                dgProductos.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void Save()
        {

            try
            {

                Productos prod = new Productos();

                prod.Id = Convert.ToInt32(txtId.Text);
                prod.Nombre = txtNombre.Text.ToString();
                prod.Cantidad = Convert.ToInt32(txtCantidad.Text);
                prod.StockMinimo = Convert.ToInt32(txtStock.Text);
                prod.FechaIngreso = Convert.ToDateTime(dtFechaIngreso.Value.Date);
                prod.IdProveedor = Convert.ToInt32(cbxProveedor.SelectedValue);
                prod.IdCategoria = Convert.ToInt32(cbxCategoria.SelectedValue);
                prod.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
                prod.PrecioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
                prod.Imagen = txtImagen.Text.ToString();
                prod.Estado = true;

                if (mngProd.GetById(prod.Id) == null)
                {

                    mngProd.Insert(prod);
                    MessageBox.Show("REGISTRADO CORRECTAMENTE");

                }
                else
                {

                    var resp = MessageBox.Show("¿Actualizar registro?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resp == DialogResult.Yes)
                    {

                        mngProd.Update(prod);
                        MessageBox.Show("ACTUALIZADO CORRECTAMENTE");

                    }
                    else
                    {
                        MessageBox.Show("SIN CAMBIOS");
                    }

                }
                FillGrid(mngProd.ShowList(true));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void Delete()
        {
            try
            {
                int x = Convert.ToInt32(txtId.Text);

                var resp = MessageBox.Show("¿Eliminar registro?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resp == DialogResult.Yes)
                {

                    mngProd.Delete(mngProd.GetById(x));
                    MessageBox.Show("ELIMINADO CORRECTAMENTE");
                }
                else
                {
                    MessageBox.Show("SIN CAMBIOS");
                }
                FillGrid(mngProd.ShowList(true));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void Search(int id)
        {
            try
            {
                List<Productos> LsTemp = new List<Productos>();
                LsTemp = mngProd.ShowList(true);

                int x = LsTemp.IndexOf(mngProd.GetById(id));

                if (x >= 0)
                {
                    Productos obj = new Productos();

                    obj = mngProd.GetById(id);

                    txtId.Text = obj.Id.ToString();
                    txtNombre.Text = obj.Nombre.ToString();
                    txtCantidad.Text = obj.Cantidad.ToString();
                    txtStock.Text = obj.StockMinimo.ToString();
                    dtFechaIngreso.Value = obj.FechaIngreso;
                    cbxProveedor.SelectedValue = obj.IdProveedor;
                    cbxCategoria.SelectedValue = obj.IdCategoria;
                    txtPrecioVenta.Text = obj.PrecioVenta.ToString();
                    txtPrecioCompra.Text = obj.PrecioCompra.ToString();
                    txtImagen.Text = obj.Imagen.ToString();

                }
                else
                {
                    MessageBox.Show("No se encontró");
                    CleanText(true);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void CleanText(bool tID = false)
        {
            try
            {
                if (tID)
                    txtId.Clear();

                txtId.Focus();
                txtNombre.Clear();
                txtCantidad.Clear();
                txtStock.Clear();
                dtFechaIngreso.Value = DateTime.Now;
                cbxProveedor.SelectedIndex = 0;
                cbxCategoria.SelectedIndex = 0;
                txtPrecioVenta.Clear();
                txtPrecioCompra.Clear();
                txtImagen.Clear();
                cbxBusqueda.SelectedIndex = 0;
            }
            catch (Exception)
            {
                
                throw;
            }

        }

        public void FillCombo(ComboBox cbx, IEnumerable<Object> ls) {

            cbx.DataSource = null;
            cbx.ValueMember = "Id";
            cbx.DisplayMember = "Nombre";
            cbx.DataSource = ls;
            cbx.Refresh();

        }

        #endregion

        #region EVENTOS

        public FormProductos()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Search(Convert.ToInt32(txtId.Text));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Save();
            CleanText(true);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CleanText(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Delete();
            CleanText(true);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminados_Click(object sender, EventArgs e)
        {
            FillGrid(mngProd.ShowList(false));
        }

        private void btnActivos_Click(object sender, EventArgs e)
        {
            FillGrid(mngProd.ShowList(true));
        }

        private void dgProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Search(Convert.ToInt32(dgProductos[0, e.RowIndex].Value));
            }
        }

        private void dgProveedores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Search(Convert.ToInt32(dgProductos[0, e.RowIndex].Value));
            }
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            FillGrid(mngProd.ShowList(true));
            FillCombo(cbxCategoria, mngCat.ShowList(true));
            FillCombo(cbxProveedor, mngProv.ShowList(true));
            CleanText(true);
            
        }

        #endregion EVENTOS

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                int opc = cbxBusqueda.SelectedIndex;

                ExtensionProductos extProd = new ExtensionProductos();

                switch (opc)
                {
                    case 0:
                        FillGrid(extProd.SearchByCategoria(txtBusqueda.Text.ToString()));

                        break;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
    }
}
