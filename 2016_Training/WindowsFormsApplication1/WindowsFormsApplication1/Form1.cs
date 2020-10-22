using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int[,] mat;
        int contBombas, contBanderas, num, columna, fila;
        Random r = new Random();
        bool finjuego;
        

        public void CreateControls(int tam)
        {
            int top = 20;
            int left = 20;

            pnlContenedor.Controls.Clear();
            pnlContenedor.Refresh();
            for(int i=0;i<tam; i++)
            {
                PictureBox p = new PictureBox();
                p.Location = new Point(top, left);
                p.Size = new Size(50,50);
                p.Name = "pic" + i.ToString();
                p.BorderStyle = BorderStyle.FixedSingle;
                p.Click +=p_Click;
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                //this.Controls.Add(p);
                
                pnlContenedor.Controls.Add(p);

                left = left + 55;
                if((i +1) % Math.Sqrt(tam) ==0)
                {
                    top += 55;
                    left = 20;
                }

            }
            pnlContenedor.Refresh();
        }

        public void CargarMatriz(int tam)
        {
            try
            {
                mat = new int[tam, tam];
                int num;
                contBombas = 0;
                int bombasMax = Convert.ToInt32(tam * tam * 0.4);
                for (int i = 0; i < tam; i++)
                {
                    for (int j = 0; j < tam; j++)
                    {
                        num = r.Next(0, 2);

                        if (contBombas < bombasMax)
                        {
                            if (num == 1)
                            {
                                contBombas += 1;
                            }
                            if (j % tam != 0)
                            {
                                mat[i,j]=num;
                            }
                            else
                            {
                                mat[i, j] = num;
                            }
                        }
                        else
                        {
                            if (j % tam != 0)
                            {
                                mat[i, j] = 0;
                            }
                            else
                            {
                                mat[i, j] = 0;
                            }
                        }
                        txtPrueba.Text += mat[i, j].ToString();
                        
                    }

                    txtPrueba.Text += "  #  ";

                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void Clean(bool est = false)
        {
            try
            {
                if (est)
                {
                    txtPuntuacion.Text = "0";

                }
            
                finjuego = false;                
                contBanderas = 0;
                txtPrueba.Clear();
                pnlContenedor.Controls.Clear();
                
            }
            catch (Exception)
            {
                
                throw;
            }


        }

        public void CargarImagen(PictureBox pic, int tam)
        {
            try
            {
                num = Convert.ToInt32(pic.Name.Substring(3, pic.Name.Length - 3));

                columna = Convert.ToInt32(num / tam);
                fila = num % tam;


                if (mat[fila, columna] == 0)
                {
                    pic.Image = Properties.Resources.bandera;
                    contBanderas++;
                    txtPuntuacion.Text = (10 + Convert.ToInt32(txtPuntuacion.Text)).ToString();
                    if (contBanderas == ((tam*tam) - contBombas))
                    {
                        finjuego = true;
                        MessageBox.Show("GANASTE");
                    }
                }
                else if (mat[fila, columna] == 1)
                {
                    pic.Image = Properties.Resources.bomba;
                    finjuego = true;

                    MessageBox.Show("PERDISTE");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void p_Click(object sender, EventArgs e)
        {
            if (!finjuego)
            {
                PictureBox ob = (PictureBox)sender;
                CargarImagen(ob, Convert.ToInt32(cbxTamanio.SelectedItem.ToString().Substring(0, 2)));
                ob.Enabled = false;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Clean(true);
                cbxTamanio.SelectedIndex = 0;
            }
            catch (Exception)
            {
                
                
            }

            
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            try
            {
                Clean();
                int tam = Convert.ToInt32(cbxTamanio.SelectedItem.ToString().Substring(0, 2));
                CreateControls(tam*tam);
                CargarMatriz(tam);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Clean(true);
        }

    }
}
