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
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void ValidarIngreso(string nom, string pass)
        {
            try
            {
                if (nom.Equals("SenaSoft2016") && pass.Equals("SenaSoft2016"))
                {
                    this.Visible = false;
                    FormPrincipal formP = new FormPrincipal();
                    formP.Show();
                    
                }
                else
                {
                    MessageBox.Show("NOMBRE O USUARIO INVÁLIDO");
                }
            }
            catch (Exception)
            {                
                throw;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarIngreso(txtUsuario.Text, txtContrasena.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
    }
}
