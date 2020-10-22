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
    public partial class FormPrestamos : Form
    {

        private PrestamosBLL presBll = new PrestamosBLL();
        private EstudiantesBLL estBll = new EstudiantesBLL();
        private DispositivosBLL disBll = new DispositivosBLL();

        public FormPrestamos()
        {
            InitializeComponent();
        }


        public void FillComboBox(string cat)
        {
            if (disBll.GetByIdDis(cat).Count() >0)
            {
                cbxCodigoEqui.DataSource = null;
                cbxCodigoEqui.DataSource = disBll.GetByIdDis(cat);
                cbxCodigoEqui.DisplayMember = "Codigo";
                cbxCodigoEqui.ValueMember = "ID";
                cbxCodigoEqui.Refresh();
            }
            else
            {
                MessageBox.Show("NO HAY EQUIPOS DISPONIBLES");
                cbxCodigoEqui.DataSource = null;
                cbxCodigoEqui.DataSource = disBll.GetByIdDis(cat);
                cbxCodigoEqui.DisplayMember = "Codigo";
                cbxCodigoEqui.ValueMember = "ID";
                cbxCodigoEqui.Refresh();
            }

            
        }

        public void Search(int id)
        {
            Prestamos pres;

            pres = presBll.GetById(id);

            if (pres != null)
            {

                dtFechaPrestamo.Value = pres.FechaPrestamos;

                dtHoraPrestamo.Value = new DateTime(1900,10,10,pres.HoraPrestamos.Hours,pres.HoraPrestamos.Minutes,00);
                dtHoraEntrega.Value = new DateTime(1900, 10, 10, pres.HoraEntrega.Hours, pres.HoraEntrega.Minutes, 00);

                txtCodigoEst.Text = estBll.GetById2(pres.CodEstudiante).Codigo;
                txtNombreEst.Text = estBll.GetById2(pres.CodEstudiante).Nombre;

                cbxTipoEquipo.SelectedItem = disBll.GetById2(pres.CodDispositivo).TipoDispositivo;
                cbxCodigoEqui.SelectedValue = pres.CodDispositivo;

                txtEstado.Text = pres.Estado;
                

            }
            else
            {
                MessageBox.Show("NO REGISTRADO");
                //CleanText(false);
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

                dtFechaPrestamo.Value = DateTime.Now.Date;
                txtEstado.Clear();
                txtCodigoEst.Clear();
                txtNombreEst.Clear();
                cbxTipoEquipo.SelectedText = "";
                cbxCodigoEqui.SelectedIndex = 0;
                lblSancion.Text = "";
                dtHoraEntrega.Value = dtHoraPrestamo.Value.AddHours(3);

                txtCodigo.Focus();
            }
            catch (Exception)
            {
                ;
            }
        }
        
        public void Save()
        {

            Prestamos pres;

            if (presBll.GetById(Convert.ToInt32(txtCodigo.Text)) == null)
            {
                pres = new Prestamos();

                Estudiantes estu = estBll.GetById(txtCodigoEst.Text);
                Dispositivos dispo = disBll.GetById2(Convert.ToInt32(cbxCodigoEqui.SelectedValue));

                pres.FechaPrestamos = dtFechaPrestamo.Value.Date;

                if ((pres.FechaPrestamos.Day-2)>DateTime.Now.Day)
                {
                    if (new TimeSpan(dtHoraPrestamo.Value.Hour,dtHoraPrestamo.Value.Minute,00 ) >= new TimeSpan(06,00,00))
                    {
                        if (new TimeSpan(dtHoraPrestamo.Value.Hour, dtHoraPrestamo.Value.Minute, 00) <= new TimeSpan(19, 00, 00))
                        {
                            pres.CodEstudiante = estu.ID;

                            if (estu.Sancion.Equals("NO"))
                            {

                                
                                
                                    pres.CodDispositivo = dispo.ID;
                                    pres.HoraPrestamos = new TimeSpan(dtHoraPrestamo.Value.Hour, dtHoraPrestamo.Value.Minute, 00);
                                    pres.HoraEntrega = new TimeSpan(dtHoraEntrega.Value.Hour, dtHoraEntrega.Value.Minute, 00);
                                    pres.Estado = "ACTIVO";
                                
                                

                            presBll.Add(pres);
                            MessageBox.Show("REGISTRADO CORRECTAMENTE");
                            CleanText(true); 
                            }
                            else
                            {
                                lblSancion.Text = "El estudiante presenta sanción";
                                MessageBox.Show("EL ESTUDIANTE NO PUEDE REALIZAR PRÉSTAMOS");
                            }
                                
                        }
                        else
                        {
                            MessageBox.Show("HORA MÁXIMA 7:00 PM");
                        }

                    }
                    else
                    {
                        MessageBox.Show("HORA MÍNIMA 6:00 AM");
                    }


                }
                else
                {
                    MessageBox.Show("LOS PRÉSTAMOS SE REALIZAN CON DOS DÍAS DE ANTICIPACIÓN");
                }

                
            }
            else
            {
                pres = presBll.GetById(Convert.ToInt32(txtCodigo.Text));

                //

                

                //

                var resp = MessageBox.Show("¿DESEA ACTUALIZAR?", "REGISTRO ENCONTRADO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resp == System.Windows.Forms.DialogResult.Yes)
                {
                    Estudiantes estu = estBll.GetById(txtCodigoEst.Text);
                    Dispositivos dispo = disBll.GetById2(Convert.ToInt32(cbxCodigoEqui.SelectedValue));

                    pres.FechaPrestamos = dtFechaPrestamo.Value.Date;

                    if ((pres.FechaPrestamos.Day - 2) > DateTime.Now.Day)
                    {
                        if (new TimeSpan(dtHoraPrestamo.Value.Hour, dtHoraPrestamo.Value.Minute, 00) >= new TimeSpan(06, 00, 00))
                        {
                            if (new TimeSpan(dtHoraPrestamo.Value.Hour, dtHoraPrestamo.Value.Minute, 00) <= new TimeSpan(19, 00, 00))
                            {
                                pres.CodEstudiante = estu.ID;

                                if (estu.Sancion.Equals("NO"))
                                {



                                    pres.CodDispositivo = dispo.ID;
                                    pres.HoraPrestamos = new TimeSpan(dtHoraPrestamo.Value.Hour, dtHoraPrestamo.Value.Minute, 00);
                                    pres.HoraEntrega = new TimeSpan(dtHoraEntrega.Value.Hour, dtHoraEntrega.Value.Minute, 00);
                                    pres.Estado = "ACTIVO";

                                    presBll.Update(pres);
                                    MessageBox.Show("ACTUALIZADO CORRECTAMENTE");
                                    CleanText(true);

                                }
                                else
                                {
                                    lblSancion.Text = "El estudiante presenta sanción";
                                    MessageBox.Show("EL ESTUDIANTE NO PUEDE REALIZAR PRÉSTAMOS");
                                }

                            }
                            else
                            {
                                MessageBox.Show("HORA MÁXIMA 7:00 PM");
                            }

                        }
                        else
                        {
                            MessageBox.Show("HORA MÍNIMA 6:00 AM");
                        }


                    }
                    else
                    {
                        MessageBox.Show("LOS PRÉSTAMOS SE REALIZAN CON DOS DÍAS DE ANTICIPACIÓN");
                    }

                    
                    
                }
                else
                {
                    MessageBox.Show("NO SE REALIZARON CAMBIOS");
                }


            }

        }
          

        /*
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

      */
        
        private void FormPrestamos_Load(object sender, EventArgs e)
        {
            try
            {
                CleanText(true);
                FillComboBox(cbxTipoEquipo.SelectedItem.ToString());
            }
            catch (Exception)
            {

                ;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Search(Convert.ToInt32(txtCodigo.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscarEst_Click(object sender, EventArgs e)
        {
            try
            {
                Estudiantes estu =  estBll.GetById(txtCodigoEst.Text);
                if (estu!=null)
                {
                    txtNombreEst.Text = estu.Nombre;
                    if (estu.Sancion.Equals("SI"))
                    {
                        lblSancion.Text = "El estudiante presenta sanción";
                    }
                }
                else
                {
                    MessageBox.Show("NO ENCONTRADO");
                }
            }
            catch (Exception)
            {

                ;
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
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                CleanText(true);
            }
            catch (Exception)
            {

                ;
            }
        }

        private void cbxTipoEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FillComboBox(cbxTipoEquipo.SelectedItem.ToString());
            }
            catch (Exception)
            {

                ;
            }
        }

        private void dtHoraPrestamo_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtHoraEntrega.Value = dtHoraPrestamo.Value.AddHours(3);
            }
            catch (Exception)
            {
                
            }
        }


      
    }
}
