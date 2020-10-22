using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entities;
using SECURITY;

namespace AHORCADO
{
    public partial class FormJuego : Form
    {

        PalabrasBLL pBll = new PalabrasBLL();
        Palabras palabra;
        int tamanio;
        bool finjuego = false;
        string cadena="";
        
        //char[] vec = new char[100];
        List<char> vec = new List<char>();

        public void DibujarGuiones()
        {

            try
            {
                CleanText();

                int num;
                Random r = new Random();
                palabra = new Palabras();

                num = r.Next(1, pBll.Count() + 1);

                palabra = pBll.GetById(num);

                tamanio = palabra.Palabra.Length;

                for (int i = 0; i < tamanio; i++)
                {
                    cadena += "-";
                }
                lblPalabra.Text = cadena;
                lblBorrador.Text = palabra.Palabra.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void CleanText()
        {

            txtFallos.Text = "0";
            txtPuntuacion.Text = "0";
            lblPalabra.Text = "";
            lblUsadas.Text = "";
            cadena = "";
            vec.Clear();
            picAhorcado.Image = Properties.Resources.img0;
            lblPalabra.Focus();
            finjuego = false;

        }

        public bool BuscarLetra(char letra)
        {

            int cant = vec.Count();
            int i;

            if (Validations.IsText(letra.ToString()))
            {
                i = 0;

                while (i < cant)
                {
                    if (vec[i] == letra)
                    {
                        return true;
                    }
                    else
                    {
                        i++;
                    }
                }

                vec.Add(letra);
                return false; 
            }
            else
            {
                return true;
            }

        }

        public void ValidarLetra(string letra)
        {

            try
            {
                
                string aux = lblPalabra.Text;
                int conta = 0, guion=0;
                lblPalabra.Text = "";
                cadena = "";
                string usadas = lblUsadas.Text;

                    for (int i = 0; i < tamanio; i++)
                    {

                        if (letra == palabra.Palabra.Substring(i,1))
                        {
                            cadena += letra;
                            conta++;
                    
                        }
                        else if (aux.Substring(i, 1) != "-")
                        {                    
                            cadena += aux.Substring(i, 1);
                        }
                        else
                        {
                            cadena += "-";
                            guion++;
                        }
                    }

                    if (conta != 0)
                    {
                        txtPuntuacion.Text = (Convert.ToInt32(txtPuntuacion.Text) + 10).ToString();
                        if (guion==0)
                        {
                            MessageBox.Show("FELICITACIONES!");
                            finjuego = true;
                        }
                    }
                    else
                    {
                        txtFallos.Text = (Convert.ToInt32(txtFallos.Text) + 1).ToString();
                        usadas += " " + letra;
                        int imagen = Convert.ToInt32(txtFallos.Text);

                        switch (imagen)
                        {
                            case 1:
                                picAhorcado.Image = Properties.Resources.img1;
                                break;
                            case 2:
                                picAhorcado.Image = Properties.Resources.img2;
                                break;
                            case 3:
                                picAhorcado.Image = Properties.Resources.img3;
                                break;
                            case 4:
                                picAhorcado.Image = Properties.Resources.img4;
                                break;
                            case 5:
                                picAhorcado.Image = Properties.Resources.img5;
                                break;
                            
                        }

                        if (Convert.ToInt32(txtFallos.Text)==5)
                        {
                            MessageBox.Show("PERDISTE. La Palabra correcta es: "+palabra.Palabra);
                            finjuego = true;
                        }
                    }

                    lblUsadas.Text = usadas;
                lblPalabra.Text = cadena;
            }
            catch (Exception)
            {
                
                throw;
            }

        }

        public FormJuego()
        {
            InitializeComponent();
        }

        private void FormJuego_Load(object sender, EventArgs e)
        {
            CleanText();
            lblPalabra.Focus();
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            try
            {
                DibujarGuiones();
                lblPalabra.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }


        }

        private void lblPalabra_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (BuscarLetra(Convert.ToChar(e.KeyCode)) == false && finjuego==false)
            {
               ValidarLetra(Convert.ToChar(e.KeyCode).ToString()); 
            }         
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lblPalabra.Focus();
        }

        

    }
}
