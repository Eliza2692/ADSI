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


namespace GUI
{
    public partial class FormProveedores : Form
    {
        #region METODOS

        ManagementProveedores mngPro = new ManagementProveedores(@"C:\Inventario\proveedores.txt");

        public List<Proveedores> listaMostrar(bool est)
        {

            try
            {
                List<Proveedores> lsTemp = new List<Proveedores>();

                foreach (Proveedores pro in mngPro.ReadAll())
                {
                    if (pro.Estado == est)
                    {
                        lsTemp.Add(pro);
                    }
                }

                return lsTemp;

            }
            catch (Exception)
            {
                return null;
            }
        }

        public void FillGrid(List<Proveedores> lsMostrar)
        {

            try
            {
                dgProveedores.DataSource = null;
                dgProveedores.DataSource = lsMostrar;
                dgProveedores.Refresh();

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

                Proveedores pro = new Proveedores();

                pro.Id = Convert.ToInt32(txtId.Text);
                pro.Nombre = txtNombre.Text.ToString();
                pro.Direccion = txtDireccion.Text.ToString();
                pro.Telefono =txtTelefono.Text.ToString();
                pro.Email=txtEmail.Text.ToString();
                pro.Estado = true;

                if (mngPro.GetById(pro.Id) == null)
                {

                    mngPro.Insert(pro);
                    MessageBox.Show("REGISTRADO CORRECTAMENTE");

                }
                else
                {

                    var resp = MessageBox.Show("¿Actualizar registro?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resp == DialogResult.Yes)
                    {

                        mngPro.Update(pro);
                        MessageBox.Show("ACTUALIZADO CORRECTAMENTE");

                    }
                    else
                    {
                        MessageBox.Show("SIN CAMBIOS");
                    }

                }
                FillGrid(listaMostrar(true));

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

                    mngPro.Delete(mngPro.GetById(x));
                    MessageBox.Show("ELIMINADO CORRECTAMENTE");
                }
                else
                {
                    MessageBox.Show("SIN CAMBIOS");
                }
                FillGrid(listaMostrar(true));
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
                List<Proveedores> LsTemp = new List<Proveedores>();
                LsTemp = listaMostrar(true);

                int x = LsTemp.IndexOf(mngPro.GetById(id));

                if (x >= 0)
                {
                    Proveedores obj = new Proveedores();

                    obj = mngPro.GetById(id);

                    txtId.Text = obj.Id.ToString();
                    txtNombre.Text = obj.Nombre.ToString();
                    txtDireccion.Text = obj.Direccion.ToString();
                    txtTelefono.Text = obj.Telefono.ToString();
                    txtEmail.Text = obj.Email.ToString();
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
            if (tID)
                txtId.Clear();

            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtId.Focus();
        }
        #endregion

        #region EVENTOS

        public FormProveedores()
        {
            InitializeComponent();
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            FillGrid(listaMostrar(true));
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Delete();
            CleanText(true);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CleanText(true);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActivos_Click(object sender, EventArgs e)
        {
            FillGrid(listaMostrar(true));
        }

        private void btnEliminados_Click(object sender, EventArgs e)
        {
            FillGrid(listaMostrar(false));
        }

        #endregion

        private void dgProveedores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Search(Convert.ToInt32(dgProveedores[0, e.RowIndex].Value));
            }
        }

        private void dgProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Search(Convert.ToInt32(dgProveedores[0, e.RowIndex].Value));
            }
        }
    }
}
