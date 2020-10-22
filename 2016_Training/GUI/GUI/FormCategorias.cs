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
    public partial class FormCategorias : Form
    {
        #region MÉTODOS

        ManagementCategorias mngCat = new ManagementCategorias(@"C:\Inventario\categorias.txt");

        public List<Categorias> listaMostrar(bool est) {

            try
            {
                List<Categorias> lsTemp = new List<Categorias>();

                foreach (Categorias cat in mngCat.ReadAll())
                {
                    if (cat.Estado == est) { 
                        lsTemp.Add(cat);
                    }
                }

                return lsTemp;
                
            }
            catch (Exception)
            {
                return null;                
            }


        }

        public void FillGrid(List<Categorias> lsMostrar){

            try
            {
                dgCategorias.DataSource = null;
                dgCategorias.DataSource = lsMostrar;
                dgCategorias.Refresh();

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

                Categorias cat = new Categorias();

                cat.Id = Convert.ToInt32(txtId.Text);
                cat.Nombre = txtNombre.Text.ToString();
                cat.Estado = true;

                if (mngCat.GetById(cat.Id) == null) {

                    mngCat.Insert(cat);
                    MessageBox.Show("REGISTRADO CORRECTAMENTE");

                } else {

                    var resp = MessageBox.Show("¿Actualizar registro?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resp == DialogResult.Yes) {

                        mngCat.Update(cat);
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

        public void Delete() {
            try
            {
                int x = Convert.ToInt32(txtId.Text);

                var resp = MessageBox.Show("¿Eliminar registro?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resp == DialogResult.Yes) {

                    mngCat.Delete(mngCat.GetById(x));
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
                List<Categorias> LsTemp = new List<Categorias>();
                LsTemp = listaMostrar(true);

                int x = LsTemp.IndexOf(mngCat.GetById(id));

                if (x >= 0)
                {
                    Categorias obj = new Categorias();
                    
                    obj = mngCat.GetById(id);

                    txtId.Text = obj.Id.ToString();
                    txtNombre.Text = obj.Nombre.ToString();
                }
                else { 
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
            txtId.Focus();
        }

        #endregion

        #region EVENTOS
        public FormCategorias()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Save();
            CleanText(true);
        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            FillGrid(listaMostrar(true));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Delete();
            CleanText(true);
        }


        private void btnEliminados_Click(object sender, EventArgs e)
        {
            FillGrid(listaMostrar(false));
        }

        private void btnActivos_Click(object sender, EventArgs e)
        {
            FillGrid(listaMostrar(true));
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CleanText(true);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Search(Convert.ToInt32(txtId.Text));
        }

        private void dgCategorias_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Search(Convert.ToInt32(dgCategorias[0, e.RowIndex].Value));
            }
        }

        private void dgCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Search(Convert.ToInt32(dgCategorias[0, e.RowIndex].Value));
            }
        }
        #endregion

        

    }
}
