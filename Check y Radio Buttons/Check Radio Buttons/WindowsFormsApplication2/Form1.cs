using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Persona> Contexto;

        /**********************METODOS***********************/

        private void ActiveGroupBox(bool estado)
        {  
            GrupBoxTipodedocumento.Enabled = estado;
            GrupBoxGenero.Enabled = estado;
            GrupBoxIdiomas.Enabled = estado;
            GrupBoxEstudios.Enabled = estado;
        }

        private void ActiveButtons(bool nuevo, bool almacenar, bool eliminar, bool cancelar)
        {
            BtnNuevo.Enabled = nuevo;
            BtnAlmacenar.Enabled = almacenar;
            BtnEliminar.Enabled = eliminar;
            BtnCancelar.Enabled = cancelar;
        }

        private void CleanText()
        {
            TxtDocumento.Text = "";
            TxtNombres.Clear();
            TxtApellidos.Clear();
            TxtTelefono.Clear();
            TxtDireccion.Clear();
            RbtCC.Checked = true;
            RbtHombre.Checked = true;
            ChkBachiller.Checked = false;
            ChkTecnico.Checked = false;
            ChkTecnólogo.Checked = false;
            ChkProfesional.Checked = false;
            ChkEspecializacion.Checked = false;
            ChkMaestria.Checked = false;
            ChkIngles.Checked = false;
            ChkFrancés.Checked = false;
            ChkPortugués.Checked = false;
            ChkItaliano.Checked = false;
            ChkGriego.Checked = false;
            ChkJapones.Checked = false;
            ChkRuso.Checked = false;
            ChkAleman.Checked = false;
            ChkChino.Checked = false;
        }

        private Persona GetById(string documento)
        {
            
                foreach (Persona p in Contexto)
                {
                    if (p.Documento == documento)
                    {
                        return p;
                    }
                }
            
            return null;
        }

        private void FillData (string documento)
        {
            Persona ob = GetById(documento);
            if (ob != null)
            {
                TxtDocumento.Text = ob.Documento;
                TxtNombres.Text = ob.Nombre;
                TxtApellidos.Text = ob.Apellido;
                TxtTelefono.Text = ob.Telefono;
                TxtDireccion.Text = ob.Direccion;
                if (ob.Genero == "H")
                    RbtHombre.Checked = true;
                else
                    RbtMujer.Checked = true;
                switch (ob.Tipodocumento)
                {
                    case "Cedula de ciudadania":
                        RbtCC.Checked = true;
                        break;
                    case "Cedula de extranjeria":
                        RbtCE.Checked = true;
                        break;
                    case "Tarjeta de identidad":
                        RbtTI.Checked = true;
                        break;
                    case "Pasaporte":
                        RbtPs.Checked = true;
                        break;
                }
                ChkBachiller.Checked = ob.Bachiller;
                ChkTecnico.Checked =ob.Tecnico;
                ChkTecnólogo.Checked = ob.Tecnologo;
                ChkProfesional.Checked = ob.Profesional;
                ChkEspecializacion.Checked = ob.Especializacion;
                ChkMaestria.Checked = ob.Maestria;
                
                ChkIngles.Checked = ob.Ingles;
                ChkFrancés.Checked = ob.Frances;
                ChkPortugués.Checked = ob.Portugues;
                ChkItaliano.Checked = ob.Italiano;
                ChkGriego.Checked = ob.Griego;
                ChkJapones.Checked = ob.Japones;
                ChkRuso.Checked = ob.Ruso;
                ChkAleman.Checked = ob.Aleman;
                ChkChino.Checked = ob.Chino;
                ActiveButtons(false, true, true, false);
                ActiveGroupBox(true);
            }
        }

        /************************EVENTOS*******************/

        private void Form1_load(object sender, EventArgs e)
        {
            Contexto = new List<Persona>();
            CleanText();
            ActiveGroupBox(false);
            ActiveButtons(true, false, false, false);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            ActiveGroupBox(true);
            ActiveButtons(false, true, false, true);
            CleanText();
        }

        private void BtnAlmacenar_Click(object sender, EventArgs e)
        {
            Persona obj = new Persona();
            obj.Documento = TxtDocumento.Text;
            obj.Nombre = TxtNombres.Text;
            obj.Apellido = TxtApellidos.Text;
            obj.Direccion = TxtDireccion.Text;
            obj.Telefono = TxtTelefono.Text;
            if (RbtCC.Checked)
                obj.Tipodocumento = "Cedula de ciudadania";
            else if (RbtCE.Checked)
                obj.Tipodocumento = "Cedula de extranjeria";
            else if (RbtTI.Checked)
                obj.Tipodocumento = "Tarjeta de identidad";
            else if (RbtPs.Checked)
                obj.Tipodocumento = "Pasaporte";
            
            if (RbtHombre.Checked)
                obj.Genero = "H";
            else
                obj.Genero = "M";

            obj.Bachiller = ChkBachiller.Checked;
            obj.Tecnico = ChkTecnico.Checked;
            obj.Tecnologo = ChkTecnólogo.Checked;
            obj.Profesional=ChkProfesional.Checked;
            obj.Especializacion = ChkEspecializacion.Checked;
            obj.Maestria = ChkMaestria.Checked;

            obj.Ingles = ChkIngles.Checked;
            obj.Frances = ChkFrancés.Checked;
            obj.Portugues = ChkPortugués.Checked;
            obj.Italiano = ChkItaliano.Checked;
            obj.Griego = ChkGriego.Checked;
            obj.Japones = ChkJapones.Checked;
            obj.Ruso = ChkRuso.Checked;
            obj.Aleman = ChkAleman.Checked;
            obj.Chino = ChkChino.Checked;

            if (GetById(TxtDocumento.Text) == null)
                Contexto.Add(obj);
            else
            {
                for (int i = 0; i < Contexto.Count; i++)
                {
                    if (obj.Documento == Contexto[i].Documento)
                    {
                        Contexto[i] = obj;
                        break;
                    }
                }
            }
            ActiveGroupBox(false);
            ActiveButtons (true,false,false,false);
            CleanText();
            MessageBox.Show("Datos almacenados correctamente");
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            foreach (Persona ob in Contexto)
            {
                if (ob.Documento == TxtDocumento.Text)
                {
                    Contexto.Remove(ob);
                    break;
                }
            }
            CleanText();
            ActiveGroupBox(false);
            ActiveButtons(true, false, false, false);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            CleanText();
            ActiveGroupBox(false);
            ActiveButtons(true, false, false, false);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FillData(TxtDocumento.Text);
        }

        private void TxtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                FillData(TxtDocumento.Text);
        }

    }
}
