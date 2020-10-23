using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoDataGridView
{
    public partial class Form1 : Form
    {
        private List<Paises> lst = new List<Paises>();

        /*****************Metodos***********************/

        //Metodo para llenar el gridview
        public void FillGrid()
        {
            dg1.DataSource = null;
            dg1.DataSource = lst;
            dg1.Refresh();
        }

        //carga el codigo encontrado a los cuadros de texto
        public void FillData(string cod)
        {
            foreach (Paises ob in lst)
            {
                if (ob.Codigo == cod)
                {
                    txtCodigo.Text = ob.Codigo;
                    txtNombre.Text = ob.Nombre;
                    txtBandera.Text = ob.Bandera;
                    if (ob.Bandera != "" && ob.Bandera != null)
                    {
                        picImage.Image = Image.FromFile(ob.Bandera);
                    }
                    break;
                }
            }
        }

        /***************************Eventos*****************************/

        public Form1()
        {
            InitializeComponent();
        }

        //cargar formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        //boton guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigo.Text.Trim() != "" && txtNombre.Text.Trim() != "")
                {
                    //construccion del objeto paises
                    Paises obj = new Paises();
                    obj.Codigo = txtCodigo.Text;
                    obj.Nombre = txtNombre.Text;
                    obj.Activo = chkActivo.Checked;
                    obj.Bandera = txtBandera.Text;
                    //agregra el objeto a la lista de paises
                    lst.Add(obj);
                    //se vuelve a llenar el grid
                    FillGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void picImage_Click(object sender, EventArgs e)
        {
            //muestra el cuadro para abrir archivos
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                txtBandera.Text = openFileDialog1.FileName;
                picImage.Image = Image.FromFile(txtBandera.Text);
            }
        }

        private void dg1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                FillData(dg1[0, e.RowIndex].Value.ToString());
            }
        }

        private void dg1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                FillData(dg1[0, e.RowIndex].Value.ToString());
            }
        }
    }
}
