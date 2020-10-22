using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Model;
using BLL.Concrete;
using BLL.Extensions;
using GUI.Gestion;

namespace GUI.Ventas
{
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
        }

        ClientesBLL cliBll = new ClientesBLL();
        DetalleFacturaBLL deFaBll = new DetalleFacturaBLL();
        FacturasBLL facBll = new FacturasBLL();
        PuestosBLL puesBll = new PuestosBLL();
        private int numPuesto;

        public void DibujarPuestos2(List<PUESTOS> ls)
        {
            try
            {
                int top = 24;
                int left = 24;

                panel1.Controls.Clear();

                for (int i = 0; i < 20; i++)
                {
                    PictureBox p = new PictureBox();
                    p.Location = new System.Drawing.Point(left, top);
                    p.Name = (i + 1).ToString();
                    p.Size = new System.Drawing.Size(40, 35);                                       
                    if (ls.Where(r => r.NumeroPuesto == (i+1)).SingleOrDefault()!=null)                    
                    {
                        p.BackColor = System.Drawing.Color.Red;                      
                    }
                    else
                    {
                        p.BackColor = System.Drawing.Color.Lime;
                        p.AllowDrop = true;
                        p.DragDrop += p_DragDrop;
                        p.DragEnter += p_DragEnter;
                    }

                    panel1.Controls.Add(p);

                    Label l = new Label();
                    l.Location = new System.Drawing.Point(left + 7, top + 8);
                    l.Name = "lbl" + (i+1);
                    l.Size = new System.Drawing.Size(27, 20);
                    l.Text = (i + 1).ToString();
                    l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                                        
                    if (ls.Where(r => r.NumeroPuesto == (i + 1)).SingleOrDefault() != null)
                    {
                        l.BackColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        l.BackColor = System.Drawing.Color.Lime;
                        l.AllowDrop = true;
                        l.DragEnter += p_DragEnter;
                        l.DragDrop += l_DragDrop;
                    }

                    panel1.Controls.Add(l);

                    l.BringToFront();
                    l.BackColor = p.BackColor;
                                    

                    left = left + 61;

                    if ((i + 1) % 4 == 0)
                    {
                        left = 24;
                        top = top + 55;
                    }

                }

            }
            catch (Exception)
            {
            }
        }
                    
        public void FillComboBox(ComboBox cbx, IEnumerable<object> ls)
        {
            cbx.DataSource = null;
            cbx.DataSource = ls;
            cbx.ValueMember = "IdCiudad";
            cbx.DisplayMember = "NombreCiudad";
            cbx.Refresh();
        }

        public void FillCbxHorarios(int idOrigen, int idDestino, DateTime fecha)
        {
            cbxHora.DataSource = null;
            cbxHora.DataSource = deFaBll.GetAllHorario(idOrigen, idDestino, fecha);
            cbxHora.ValueMember = "IdHorario";
            cbxHora.DisplayMember = "Hora";
        }

        public void FillCbxBuses(int idOrigen, int idDestino, DateTime fecha)
        {
            cbxBus.DataSource = null;
            cbxBus.DataSource = deFaBll.GetAllHorario(idOrigen, idDestino, fecha);
            cbxBus.ValueMember = "IdBusRuta";
            cbxBus.DisplayMember = "IdBus";
        }

        public void SearchCliente(string id)
        {
            CLIENTES cli = new CLIENTES();
            cli = cliBll.GetById(id);

            if (cli != null)
            {
                txtNombreCliente.Text = cli.NombresCliente;
                txtApellidoCliente.Text = cli.ApellidosCliente;
            }
            else
            {
                MessageBox.Show("CLIENTE NO REGISTRADO");
                FormCliente formCliente = new FormCliente();
                formCliente.MdiParent = this.MdiParent;
                formCliente.Show();
            }


        }

        private void btnBuscarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtIdCliente.Text))
                {
                    SearchCliente(txtIdCliente.Text);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtIdCliente.Text) && (e.KeyChar == Convert.ToChar(13)))
                {
                    SearchCliente(txtIdCliente.Text);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            try
            {
                FillComboBox(cbxOrigen, deFaBll.GetAllOrigen(dtFecha.Value.Date));
                FillComboBox(cbxDestino, deFaBll.GetAllDestino(Convert.ToInt32(cbxOrigen.SelectedValue), dtFecha.Value.Date));
                FillCbxHorarios(Convert.ToInt32(cbxOrigen.SelectedValue), Convert.ToInt32(cbxDestino.SelectedValue), dtFecha.Value.Date);
                FillCbxBuses(Convert.ToInt32(cbxOrigen.SelectedValue), Convert.ToInt32(cbxDestino.SelectedValue), dtFecha.Value.Date);
            }
            catch (Exception)
            {
            }
        }

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                FillComboBox(cbxOrigen, deFaBll.GetAllOrigen(dtFecha.Value.Date));
            }
            catch (Exception)
            {
            }
        }

        private void cbxOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FillComboBox(cbxDestino, deFaBll.GetAllDestino(Convert.ToInt32(cbxOrigen.SelectedValue), dtFecha.Value.Date));
            }
            catch (Exception)
            {
            }
        }

        private void cbxDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FillCbxHorarios(Convert.ToInt32(cbxOrigen.SelectedValue), Convert.ToInt32(cbxDestino.SelectedValue), dtFecha.Value.Date);
            }
            catch (Exception)
            {
            }
        }

        private void btnBuscarPuestos_Click(object sender, EventArgs e)
        {            
            List<PUESTOS> ls = new List<PUESTOS>();
            ls = deFaBll.GetAllPuestos(Convert.ToInt32(cbxBus.SelectedValue));

            DibujarPuestos2(ls);
        }

        private void cbxHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FillCbxBuses(Convert.ToInt32(cbxOrigen.SelectedValue), Convert.ToInt32(cbxDestino.SelectedValue), dtFecha.Value.Date);
            }
            catch (Exception)
            {
            }
        }

        //Efecto arrastre
        private void picDisponible_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.DoDragDrop(pic.Name, DragDropEffects.Copy);
        }

        //PERMITIR ARRASTRAR OBJETOS EN ËL
        void p_DragEnter(object sender, DragEventArgs e)
        {
            try
            {
                e.Effect = DragDropEffects.Copy;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            } 
        }

        //CUANDO SE SUELTA EL ARRASTRE
        void p_DragDrop(object sender, DragEventArgs e)
        {
            try
            {                                
                string nomPic = e.Data.GetData(DataFormats.StringFormat).ToString();

                PictureBox pic = (PictureBox)sender;              
                string nomlbl = "lbl" + pic.Name;

                Label label = new Label();
                label = panel1.Controls.OfType<Label>().Where(x => x.Name.Equals(nomlbl)).FirstOrDefault();

                if (nomPic.Equals("picDisponible"))
                {                    
                    pic.BackColor=System.Drawing.Color.Lime;
                    label.BackColor = System.Drawing.Color.Lime;
                    numPuesto = 0;
                }
                else
                {
                    numPuesto = Convert.ToInt32(pic.Name);
                    pic.BackColor = System.Drawing.Color.Red;
                    label.BackColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        void l_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                Label lbl = (Label)sender;
                
                string nomPic = e.Data.GetData(DataFormats.StringFormat).ToString();
                
                string picRecibe = lbl.Name.Substring(3,lbl.Name.Length-3);

                PictureBox picture = new PictureBox();
                picture = panel1.Controls.OfType<PictureBox>().Where(r => r.Name.Equals(picRecibe)).FirstOrDefault();                

                if (nomPic.Equals("picDisponible"))
                {
                    picture.BackColor = System.Drawing.Color.Lime;
                    lbl.BackColor = System.Drawing.Color.Lime;
                    numPuesto = 0;
                }
                else
                {
                    numPuesto = Convert.ToInt32(picRecibe);
                    picture.BackColor = System.Drawing.Color.Red;
                    lbl.BackColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnGenerarPasaje_Click(object sender, EventArgs e)
        {
            try
            {                
                if (numPuesto != 0)
                {
                    // INSERTAR EN TABLA PUESTOS
                    PUESTOS pues = new PUESTOS();
                    pues.IdBusRuta = Convert.ToInt32(cbxBus.SelectedValue);
                    pues.NumeroPuesto = numPuesto;
                    puesBll.Add(pues); 
                    
                    // INSERTAR EN TABLA FACTURAS
                    FACTURAS fac = new FACTURAS();
                    fac.FechaFactura = DateTime.Now.Date;
                    fac.IdCliente = txtIdCliente.Text;
                    facBll.Add(fac);
                    
                    // INSERTAR EN TABLA DETALLE_FACTURA
                    DETALLE_FACTURA detFac = new DETALLE_FACTURA();
                    detFac.IdDetalleFactura = 2;
                    detFac.IdFactura = deFaBll.GetLastIdFactura();                    
                    detFac.Valor = Convert.ToDecimal(15000); // MÉTODO
                    detFac.IdBusesRuta = pues.IdBusRuta;
                    deFaBll.Add(detFac);

                    MessageBox.Show("FACTURA GENERADA");
                    List<PUESTOS> ls = new List<PUESTOS>();
                    ls = deFaBll.GetAllPuestos(Convert.ToInt32(cbxBus.SelectedValue));

                    DibujarPuestos2(ls);
                }
                else
                {
                    MessageBox.Show("SELECCIONE PUESTO");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
