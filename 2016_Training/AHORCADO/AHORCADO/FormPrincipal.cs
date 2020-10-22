using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AHORCADO
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void editorDePalabrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditor formEditor = new FormEditor();
            formEditor.MdiParent = this;
            formEditor.Show();
        }

        private void jugarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormJuego formJuego = new FormJuego();
            formJuego.MdiParent = this;
            formJuego.Show();
        }
    }
}
