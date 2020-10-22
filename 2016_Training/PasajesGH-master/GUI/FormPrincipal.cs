using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void ciudadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frm = this.MdiChildren.OfType<Form>().Where(x => x.Name == "FormCiudades").FirstOrDefault();

            if (frm == null)
            {
                Gestion.FormCiudades formCiudades = new Gestion.FormCiudades();
                formCiudades.MdiParent = this;
                formCiudades.Show();    
            }

        }

        private void busesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.OfType<Form>().Where(x => x.Name.Equals("FormBuses")).FirstOrDefault();

            if (frm == null)
            {
                Gestion.FormBuses formBuses = new Gestion.FormBuses();
                formBuses.MdiParent = this;
                formBuses.Show();
            }

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.OfType<Form>().Where(x => x.Name.Equals("FormClientes")).FirstOrDefault();

            if (frm == null)
            {
                Gestion.FormCliente formCliente = new Gestion.FormCliente();
                formCliente.MdiParent = this;
                formCliente.Show();
            }
        }

        private void rutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.OfType<Form>().Where(x => x.Name.Equals("FormRutas")).FirstOrDefault();

            if (frm == null)
            {
                Gestion.FormRutas formRutas = new Gestion.FormRutas();
                formRutas.MdiParent = this;
                formRutas.Show();
            }
        }
    }
}
