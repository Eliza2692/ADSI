using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_Button_y_check_entrega
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List <Clientes> Contexto;

        /***********************************METODOS******************************************/

        //Activa y desactiva GroupBox//
        private void ActiveGroupBox(bool estado) 
        {
            GrupBoxTipodedocumento.Enabled = estado;
            GrupBoxGenero.Enabled = estado;
            GrupBoxSeguros.Enabled = estado;
        }

        //Activa y desactiva Botones//
        private void ActiveButtons(bool nuevo, bool almacenar, bool eliminar, bool cancelar)
        {
            BtnNuevo.Enabled = nuevo;
            BtnAlmacenar.Enabled = almacenar;
            BtnEliminar.Enabled = eliminar;
            BtnCancelar.Enabled = cancelar;
        }

        //Limpia caja de texto y checkbox y rabiobuttons//
        private void CleanText()
        {
            TxtCodigo.Clear();
            TxtDocumento.Clear();
            TxtNombres.Clear();
            TxtApellidos.Clear();
            TxtDireccion.Clear();
            TxtCorreo.Clear();
            TxtTelCasa.Clear();
            TxtTelOficina.Clear();
            RbtCC.Checked = true;
            RbtHombre.Checked = true;
            ChkSegAccidentes.Checked = false;
            ChkSegCesantias.Checked = false;
            ChkSegDesgravamen.Checked = false;
            ChkSegEscolaridad.Checked = false;
            ChkSegIncendio.Checked = false;
            ChkSegObligatorio.Checked = false;
            ChkSegRentas.Checked = false;
            ChkSegRobos.Checked = false;
            ChkSegSalud.Checked = false;
            ChkSegVida.Checked = false;
        }

        //Buscar si existe el cliente
        private Clientes GetById(string codigo)
        {

            foreach (Clientes p in Contexto)
            {
                if (p.Codigo == codigo)
                {
                    return p;
                }
            }
            return null;
        }
        
        //Busca los datos y llena el formulario
        private void FillData(string codigo)
        {
            Clientes ob = GetById(codigo);
            if (ob != null)
            {
                TxtCodigo.Text = ob.Codigo;
                TxtDocumento.Text = ob.Documento;
                TxtNombres.Text = ob.Nombre;
                TxtApellidos.Text = ob.Apellido;
                TxtDireccion.Text = ob.Direccion;
                TxtCorreo.Text = ob.Correo;
                TxtTelCasa.Text = ob.Telefonocasa;
                TxtTelOficina.Text = ob.Telefonooficina;
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
                ChkSegAccidentes.Checked = ob.Segaccidentes;
                ChkSegCesantias.Checked = ob.Segcesantias;
                ChkSegDesgravamen.Checked = ob.Segdesgravamen;
                ChkSegEscolaridad.Checked = ob.Segescolaridad;
                ChkSegIncendio.Checked = ob.Segincendios;
                ChkSegObligatorio.Checked = ob.Segobligatorio;
                ChkSegRentas.Checked = ob.Segrentas;
                ChkSegRobos.Checked = ob.Segrobos;
                ChkSegSalud.Checked = ob.Segsalud;
                ChkSegVida.Checked = ob.Segvida;
                ActiveButtons(false, true, true, false);
                ActiveGroupBox(true);
            }
        }

        /***********************************EVENTOS******************************************/

        //Activa el Formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            Contexto = new List<Clientes>();
            CleanText();
            ActiveGroupBox(false);
            ActiveButtons(true, false, false, false);
        }

        //Botón Nuevo
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            ActiveGroupBox(true);
            ActiveButtons(false, true, false, true);
            CleanText();
        }

        //Botón Almacenar
        private void BtnAlmacenar_Click(object sender, EventArgs e)
        {
                Clientes obj = new Clientes();
                obj.Codigo = TxtCodigo.Text;
                obj.Documento = TxtDocumento.Text;
                obj.Nombre = TxtNombres.Text;
                obj.Apellido = TxtApellidos.Text;
                obj.Direccion = TxtDireccion.Text;
                obj.Correo = TxtCorreo.Text;
                obj.Telefonocasa = TxtTelCasa.Text;
                obj.Telefonooficina = TxtTelOficina.Text;
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

                obj.Segaccidentes = ChkSegAccidentes.Checked;
                obj.Segcesantias = ChkSegCesantias.Checked;
                obj.Segdesgravamen = ChkSegDesgravamen.Checked;
                obj.Segescolaridad = ChkSegEscolaridad.Checked;
                obj.Segincendios = ChkSegIncendio.Checked;
                obj.Segobligatorio = ChkSegObligatorio.Checked;
                obj.Segrentas = ChkSegRentas.Checked;
                obj.Segrobos = ChkSegRobos.Checked;
                obj.Segsalud = ChkSegSalud.Checked;
                obj.Segvida = ChkSegVida.Checked;

                if (GetById(TxtCodigo.Text) == null)
                    Contexto.Add(obj);
                else
                {
                    for (int i = 0; i < Contexto.Count; i++)
                    {
                        if (obj.Codigo == Contexto[i].Codigo)
                        {
                            Contexto[i] = obj;
                            break;
                        }
                    }
                }
                ActiveGroupBox(false);
                ActiveButtons(true, false, false, false);
                CleanText();
                MessageBox.Show("Datos almacenados correctamente");
            
        }

        //Botón Eliminar
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            foreach (Clientes ob in Contexto)
            {
                if (ob.Codigo == TxtCodigo.Text)
                {
                    Contexto.Remove(ob);
                    break;
                }
            }
            CleanText();
            ActiveGroupBox(false);
            ActiveButtons(true, false, false, false);
        }

        //Botón Cancelar
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            CleanText();
            ActiveGroupBox(false);
            ActiveButtons(true, false, false, false);
        }

        //Botón Buscar
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FillData(TxtCodigo.Text);
        }

        // No se para que sirve ///// ---- Explicar en clase 
        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                FillData(TxtCodigo.Text);
        }
    }
}
