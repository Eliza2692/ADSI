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

            Form frm = this.MdiChildren.OfType<Form>().Where(x => x.Name == "FormCategorias").FirstOrDefault();

            if (frm == null){
                FormCategorias formCat = new FormCategorias();
                formCat.MdiParent = this;
                formCat.Show();
            }


        }

        private void gestiónProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.OfType<Form>().Where(x => x.Name == "FormProveedores").FirstOrDefault();

            if (frm == null)
            {
                FormProveedores formProv = new FormProveedores();
                formProv.MdiParent = this;
                formProv.Show();
            }
        }

        private void gestiónProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.OfType<Form>().Where(x => x.Name == "FormProductos").FirstOrDefault();

            if (frm == null)
            {
                FormProductos formProd = new FormProductos();
                formProd.MdiParent = this;
                formProd.Show();
            }
        }
    }
}
