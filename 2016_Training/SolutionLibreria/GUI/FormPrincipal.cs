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

        private void gestiónDeCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategorias Categorias = new FormCategorias();
            Categorias.MdiParent = this;
            Categorias.Show();
        }
    }
}
