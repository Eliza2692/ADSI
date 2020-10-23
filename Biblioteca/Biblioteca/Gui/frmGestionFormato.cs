using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Biblioteca.Clases;
using Biblioteca.Gestion;

namespace Biblioteca.Formularios
{
    public partial class frmGestionFormato : Form
    {
        private static frmGestionFormato f;
        private GestionFormatos gf = new GestionFormatos();

/////////////////Metodos

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
            txtCodigo.Clear();
            txtNombre.Clear();
        }

        //copia lo del data grid view a los text box
        public void FillData(string id)
        {
            Formatos obj = gf.GetById(id);
            if (obj != null)
            {
                txtCodigo.Text = obj.Codigo;
                txtNombre.Text = obj.Nombre;
            }
            else
                ActivateControls(false, true, false, true, true);
        }

        //DataGrid
        public void FillGrid()
        {
            dgFormatos.DataSource = null;
            dgFormatos.DataSource = gf.GetAll();
            dgFormatos.Refresh();
        }

        //Singlenton
        public static frmGestionFormato GetIntances()
        {
            if (f == null)
                f = new frmGestionFormato();
            return f;
        }

        private void frmGestionFormato_FormClosed(object sender, FormClosedEventArgs e)
        {
            f = null;
        }

///////////////////////Eventos

        public frmGestionFormato()
        {
            InitializeComponent();
        }

        //Cargar formulario
        private void frmGestionFormato_Load(object sender, EventArgs e)
        {
            try
            {
                ActivateControls(true, false, false, false, false);
                FillGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Boton NUevoo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ActivateControls(false, true, false, true, true);
            CleanText();
            txtCodigo.Focus();
        }

        //Botón Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Formatos obj = new Formatos(txtCodigo.Text, txtNombre.Text);
                if (gf.GetById(obj.Codigo) == null)
                    gf.Add(obj);
                else
                    gf.Update(obj);
                CleanText();
                ActivateControls(false, true, false, true, true);
                FillGrid();
                MessageBox.Show("Datos Guardados Corecctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Botón Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gf.GetById(txtCodigo.Text) != null)
                {
                    gf.Delete(txtCodigo.Text);
                    FillGrid();
                    ActivateControls(true, false, false, false, false);
                    CleanText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Botón Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ActivateControls(true, false, false, false, false);
            CleanText();
        }

        //Doble click data grip view
        private void dgFormatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex;
            if (f > -1)
            {
                FillData(dgFormatos[0, f].Value.ToString());
                ActivateControls(false, true, true, true, true);
            }
        }

        private void dgFormatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex;
            if (f > -1)
            {
                FillData(dgFormatos[0, f].Value.ToString());
                ActivateControls(false, true, true, true, true);
            }
        }

        //Caja de texto
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                FillData(txtCodigo.Text);
                ActivateControls(false, true, true, true, true);
            }
        }
 
    }
}
