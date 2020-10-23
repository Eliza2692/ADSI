using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Clases;
using Biblioteca.Gestion;
using Biblioteca.Formularios;

namespace Biblioteca
{

    public partial class frmLogin : Form
    {
 ///////////////Metodos

        //Validar contraseña
        private void LoginSistema()
        {
            try
            {
                Usuarios us = new Usuarios();
                GestionUsuarios gUs = new GestionUsuarios();
                us = gUs.Login(txtCodigo.Text, txtContrasena.Text);
                if (us != null)
                {
                    frmMenuInicial f = new frmMenuInicial();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    intentos++;
                    MessageBox.Show("Código o Contraseña Invalida");
                }
                if (intentos >= MAXIMOINTENTOS)
                    this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

///////////////eventos

        private const int MAXIMOINTENTOS = 3;
        private int intentos;

        public frmLogin()
        {
            InitializeComponent();
        }

        //Boton Ingresar
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            LoginSistema();
        }

        //Cargar formulario
        private void frmLogin_Load(object sender, EventArgs e)
        {
            intentos = 0;
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                LoginSistema();
        }

    }
}
