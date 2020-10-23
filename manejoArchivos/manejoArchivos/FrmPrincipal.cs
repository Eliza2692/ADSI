using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manejoArchivos
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void gestionDeContactosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContactos f = FrmContactos.GetInstances();
            f.MdiParent = this;
            f.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
