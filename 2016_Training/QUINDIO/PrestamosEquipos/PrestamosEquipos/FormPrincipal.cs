using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrestamosEquipos
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEstudiantes formE = new FormEstudiantes();
            formE.MdiParent = this;
            formE.Show();
        }

        private void equiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEquipos formE = new FormEquipos();
            formE.MdiParent = this;
            formE.Show();
        }

        

        private void solicitudDePrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrestamos formP = new FormPrestamos();
            formP.MdiParent = this;
            formP.Show();
        }
    }
}
