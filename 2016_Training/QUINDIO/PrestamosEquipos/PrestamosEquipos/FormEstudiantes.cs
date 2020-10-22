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
    public partial class FormEstudiantes : Form
    {

        private EstudiantesBLL estBll = new EstudiantesBLL();

        public FormEstudiantes()
        {
            InitializeComponent();
        }

        #region MÉTODOS
        public void Search(string id)
        {
            Estudiantes est;

            est = estBll.GetById(id);

            if (est != null)
            {
                txtCodigo.Text = est.Codigo;
                txtNombre.Text = est.Nombre;
                txtCarrerra.Text = est.Carrera;
                txtTelefono.Text = est.Telefono;
            }
            else
            {
                MessageBox.Show("NO REGISTRADO");
                CleanText(false);
            }


        }

        public void Save()
        {

            Estudiantes est;


            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                if (estBll.GetById(txtCodigo.Text) == null)
                {
                    est = new Estudiantes();
                    est.Nombre = txtNombre.Text;
                    est.Telefono = txtTelefono.Text;
                    est.Carrera = txtCarrerra.Text;
                    est.Codigo = txtCodigo.Text;
                    est.Sancion = "NO";
                    estBll.Add(est);
                    MessageBox.Show("REGISTRADO CORRECTAMENTE");
                    CleanText(true);
                    FillGrid();
                }
                else
                {
                    est = estBll.GetById(txtCodigo.Text);
                    est.Nombre = txtNombre.Text;
                    est.Telefono = txtTelefono.Text;
                    est.Carrera = txtCarrerra.Text;                   

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

                txtNombre.Clear();
                txtCarrerra.Clear();

                txtTelefono.Clear();
                txtCodigo.Focus();
            }
            catch (Exception)
            {

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
        private void FormEstudiantes_Load(object sender, EventArgs e)
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
