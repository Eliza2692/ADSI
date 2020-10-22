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

        private void gestiónCategoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormCategorias formCat = new FormCategorias();
            formCat.MdiParent = this;
            formCat.Show();

        }

        private void gestiónEditorialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditoriales formEdi = new FormEditoriales();
            formEdi.MdiParent = this;
            formEdi.Show();
        }

        private void gestiónAutoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAutores formAut = new FormAutores();
            formAut.MdiParent = this;
            formAut.Show();
        }

        private void gestiónLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLibros formLib = new FormLibros();
            formLib.MdiParent = this;
            formLib.Show();
        }
    }
}
