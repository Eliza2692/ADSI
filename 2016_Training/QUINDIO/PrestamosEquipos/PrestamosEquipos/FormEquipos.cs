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
using BLL;

namespace PrestamosEquipos
{
    public partial class FormEquipos : Form
    {
        private DispositivosBLL estBll = new DispositivosBLL();

        public FormEquipos()
        {
            InitializeComponent();
        }

        #region MÉTODOS

        public void Search(string id)
        {
            Dispositivos est;

            est = estBll.GetById(id);

            if (est != null)
            {
                txtCodigo.Text = est.Codigo;
                cbxTipo.SelectedItem = est.TipoDispositivo;
                cbxEstado.SelectedItem = est.Estado;
                dtFechaIngreso.Value = est.FechaIngreso.Date;
            }
            else
            {
                MessageBox.Show("NO REGISTRADO");
                CleanText(false);
            }


        }

        public void Save()
        {

            Dispositivos est;

            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                if (estBll.GetById(txtCodigo.Text) == null)
                {
                    est = new Dispositivos();

                    est.Codigo = txtCodigo.Text;
                    est.TipoDispositivo = cbxTipo.SelectedItem.ToString();
                    est.Estado = cbxEstado.SelectedItem.ToString();
                    est.FechaIngreso = dtFechaIngreso.Value.Date;
                    est.EstadoInventario = "INVENTARIO";

                    estBll.Add(est);
                    MessageBox.Show("REGISTRADO CORRECTAMENTE");
                    CleanText(true);
                    FillGrid();
                }
                else
                {
                    est = estBll.GetById(txtCodigo.Text);

                    est.TipoDispositivo = cbxTipo.SelectedItem.ToString();
                    est.Estado = cbxEstado.SelectedItem.ToString();
                    est.FechaIngreso = dtFechaIngreso.Value.Date;
                    
                    var resp = MessageBox.Show("¿DESEA ACTUALIZAR?", "REGISTRO ENCONTRADO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resp == System.Windows.Forms.DialogResult.Yes)
                    {
                        estBll.Update(est);
                        MessageBox.Show("ACTUALIZADO CORRECTAMENTE");
                        CleanText(true);
                        FillGrid();
                    }
                    else
                    {
                        MessageBox.Show("NO SE REALIZARON CAMBIOS");
                    }


                }

            }
            else
            {
                MessageBox.Show("CAMPO CÓDIGO NO PUEDE SER VACÍO");
            }

        }

        public void Delete(string id)
        {
            if (estBll.GetById(txtCodigo.Text) != null)
            {
                var resp = MessageBox.Show("¿DESEA ELIMINAR?", "REGISTRO ENCONTRADO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resp == System.Windows.Forms.DialogResult.Yes)
                {
                    estBll.Delete(estBll.GetById(id));
                    MessageBox.Show("ELIMINADO CORRECTAMENTE");
                    CleanText(true);
                    FillGrid();
                }
                else
                {
                    MessageBox.Show("NO SE REALIZARON CAMBIOS");
                }

            }
            else
            {
                MessageBox.Show("REGISTRO NO ENCONTRADO");
            }
        }

        public void CleanText(bool est = false)
        {
            try
            {
                if (est)
                {
                    txtCodigo.Clear();
                }

                cbxEstado.SelectedIndex = 0;
                cbxTipo.SelectedIndex = 0;
                dtFechaIngreso.Value = DateTime.Now;

                txtCodigo.Focus();
            }
            catch (Exception)
            {
                ;
            }
        }

        public void FillGrid()
        {
            try
            {
                dgFormulario.DataSource = null;
                dgFormulario.DataSource = estBll.GetAll();
                dgFormulario.Refresh();
            }
            catch (Exception)
            {

            }
        }
        #endregion

        #region EVENTOS

        private void FormEquipos_Load(object sender, EventArgs e)
        {
            try
            {
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
                if (!string.IsNullOrEmpty(txtCodigo.Text))
                {
                    Search(txtCodigo.Text);
                }
                else
                {
                    MessageBox.Show("CAMPO CÓDIGO ESTÁ VACÍO");
                }

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
                Delete(txtCodigo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CleanText(true);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
