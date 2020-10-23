namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.GrupBoxDatospersonales = new System.Windows.Forms.GroupBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GrupBoxGenero = new System.Windows.Forms.GroupBox();
            this.RbtMujer = new System.Windows.Forms.RadioButton();
            this.RbtHombre = new System.Windows.Forms.RadioButton();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GrupBoxTipodedocumento = new System.Windows.Forms.GroupBox();
            this.RbtCE = new System.Windows.Forms.RadioButton();
            this.RbtPs = new System.Windows.Forms.RadioButton();
            this.RbtCC = new System.Windows.Forms.RadioButton();
            this.RbtTI = new System.Windows.Forms.RadioButton();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnAlmacenar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.GrupBoxEstudios = new System.Windows.Forms.GroupBox();
            this.ChkMaestria = new System.Windows.Forms.CheckBox();
            this.ChkEspecializacion = new System.Windows.Forms.CheckBox();
            this.ChkProfesional = new System.Windows.Forms.CheckBox();
            this.ChkTecnólogo = new System.Windows.Forms.CheckBox();
            this.ChkTecnico = new System.Windows.Forms.CheckBox();
            this.ChkBachiller = new System.Windows.Forms.CheckBox();
            this.GrupBoxIdiomas = new System.Windows.Forms.GroupBox();
            this.ChkGriego = new System.Windows.Forms.CheckBox();
            this.ChkRuso = new System.Windows.Forms.CheckBox();
            this.ChkJapones = new System.Windows.Forms.CheckBox();
            this.ChkItaliano = new System.Windows.Forms.CheckBox();
            this.ChkIngles = new System.Windows.Forms.CheckBox();
            this.ChkAleman = new System.Windows.Forms.CheckBox();
            this.ChkFrancés = new System.Windows.Forms.CheckBox();
            this.ChkChino = new System.Windows.Forms.CheckBox();
            this.ChkPortugués = new System.Windows.Forms.CheckBox();
            this.GrupBoxDatospersonales.SuspendLayout();
            this.GrupBoxGenero.SuspendLayout();
            this.GrupBoxTipodedocumento.SuspendLayout();
            this.GrupBoxEstudios.SuspendLayout();
            this.GrupBoxIdiomas.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrupBoxDatospersonales
            // 
            this.GrupBoxDatospersonales.Controls.Add(this.BtnBuscar);
            this.GrupBoxDatospersonales.Controls.Add(this.TxtDireccion);
            this.GrupBoxDatospersonales.Controls.Add(this.label5);
            this.GrupBoxDatospersonales.Controls.Add(this.TxtTelefono);
            this.GrupBoxDatospersonales.Controls.Add(this.label4);
            this.GrupBoxDatospersonales.Controls.Add(this.GrupBoxGenero);
            this.GrupBoxDatospersonales.Controls.Add(this.TxtApellidos);
            this.GrupBoxDatospersonales.Controls.Add(this.label3);
            this.GrupBoxDatospersonales.Controls.Add(this.TxtNombres);
            this.GrupBoxDatospersonales.Controls.Add(this.label2);
            this.GrupBoxDatospersonales.Controls.Add(this.GrupBoxTipodedocumento);
            this.GrupBoxDatospersonales.Controls.Add(this.TxtDocumento);
            this.GrupBoxDatospersonales.Controls.Add(this.label1);
            this.GrupBoxDatospersonales.Location = new System.Drawing.Point(12, 12);
            this.GrupBoxDatospersonales.Name = "GrupBoxDatospersonales";
            this.GrupBoxDatospersonales.Size = new System.Drawing.Size(283, 247);
            this.GrupBoxDatospersonales.TabIndex = 0;
            this.GrupBoxDatospersonales.TabStop = false;
            this.GrupBoxDatospersonales.Text = "Datos Personales : ";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(115, 39);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 18;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(9, 219);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(266, 20);
            this.TxtDireccion.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dirección :";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(145, 174);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(130, 20);
            this.TxtTelefono.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Teléfono : ";
            // 
            // GrupBoxGenero
            // 
            this.GrupBoxGenero.Controls.Add(this.RbtMujer);
            this.GrupBoxGenero.Controls.Add(this.RbtHombre);
            this.GrupBoxGenero.Location = new System.Drawing.Point(9, 155);
            this.GrupBoxGenero.Name = "GrupBoxGenero";
            this.GrupBoxGenero.Size = new System.Drawing.Size(130, 45);
            this.GrupBoxGenero.TabIndex = 4;
            this.GrupBoxGenero.TabStop = false;
            this.GrupBoxGenero.Text = "Género : ";
            // 
            // RbtMujer
            // 
            this.RbtMujer.AutoSize = true;
            this.RbtMujer.Location = new System.Drawing.Point(74, 18);
            this.RbtMujer.Name = "RbtMujer";
            this.RbtMujer.Size = new System.Drawing.Size(51, 17);
            this.RbtMujer.TabIndex = 3;
            this.RbtMujer.TabStop = true;
            this.RbtMujer.Text = "Mujer";
            this.RbtMujer.UseVisualStyleBackColor = true;
            // 
            // RbtHombre
            // 
            this.RbtHombre.AutoSize = true;
            this.RbtHombre.Location = new System.Drawing.Point(6, 18);
            this.RbtHombre.Name = "RbtHombre";
            this.RbtHombre.Size = new System.Drawing.Size(62, 17);
            this.RbtHombre.TabIndex = 1;
            this.RbtHombre.TabStop = true;
            this.RbtHombre.Text = "Hombre";
            this.RbtHombre.UseVisualStyleBackColor = true;
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Location = new System.Drawing.Point(145, 129);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(130, 20);
            this.TxtApellidos.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellidos :";
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(9, 129);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(130, 20);
            this.TxtNombres.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombres :";
            // 
            // GrupBoxTipodedocumento
            // 
            this.GrupBoxTipodedocumento.Controls.Add(this.RbtCE);
            this.GrupBoxTipodedocumento.Controls.Add(this.RbtPs);
            this.GrupBoxTipodedocumento.Controls.Add(this.RbtCC);
            this.GrupBoxTipodedocumento.Controls.Add(this.RbtTI);
            this.GrupBoxTipodedocumento.Location = new System.Drawing.Point(9, 68);
            this.GrupBoxTipodedocumento.Name = "GrupBoxTipodedocumento";
            this.GrupBoxTipodedocumento.Size = new System.Drawing.Size(266, 42);
            this.GrupBoxTipodedocumento.TabIndex = 3;
            this.GrupBoxTipodedocumento.TabStop = false;
            this.GrupBoxTipodedocumento.Text = "Tipo de documento : ";
            // 
            // RbtCE
            // 
            this.RbtCE.AutoSize = true;
            this.RbtCE.Location = new System.Drawing.Point(104, 17);
            this.RbtCE.Name = "RbtCE";
            this.RbtCE.Size = new System.Drawing.Size(45, 17);
            this.RbtCE.TabIndex = 3;
            this.RbtCE.TabStop = true;
            this.RbtCE.Text = "C.E.";
            this.RbtCE.UseVisualStyleBackColor = true;
            // 
            // RbtPs
            // 
            this.RbtPs.AutoSize = true;
            this.RbtPs.Location = new System.Drawing.Point(155, 17);
            this.RbtPs.Name = "RbtPs";
            this.RbtPs.Size = new System.Drawing.Size(37, 17);
            this.RbtPs.TabIndex = 2;
            this.RbtPs.TabStop = true;
            this.RbtPs.Text = "Ps";
            this.RbtPs.UseVisualStyleBackColor = true;
            // 
            // RbtCC
            // 
            this.RbtCC.AutoSize = true;
            this.RbtCC.Location = new System.Drawing.Point(6, 17);
            this.RbtCC.Name = "RbtCC";
            this.RbtCC.Size = new System.Drawing.Size(45, 17);
            this.RbtCC.TabIndex = 1;
            this.RbtCC.TabStop = true;
            this.RbtCC.Text = "C.C.";
            this.RbtCC.UseVisualStyleBackColor = true;
            // 
            // RbtTI
            // 
            this.RbtTI.AutoSize = true;
            this.RbtTI.Location = new System.Drawing.Point(57, 17);
            this.RbtTI.Name = "RbtTI";
            this.RbtTI.Size = new System.Drawing.Size(41, 17);
            this.RbtTI.TabIndex = 0;
            this.RbtTI.TabStop = true;
            this.RbtTI.Text = "T.I.";
            this.RbtTI.UseVisualStyleBackColor = true;
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Location = new System.Drawing.Point(9, 39);
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(100, 20);
            this.TxtDocumento.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Documento:";
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(12, 265);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtnNuevo.TabIndex = 12;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnAlmacenar
            // 
            this.BtnAlmacenar.Location = new System.Drawing.Point(93, 265);
            this.BtnAlmacenar.Name = "BtnAlmacenar";
            this.BtnAlmacenar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlmacenar.TabIndex = 13;
            this.BtnAlmacenar.Text = "Almacenar";
            this.BtnAlmacenar.UseVisualStyleBackColor = true;
            this.BtnAlmacenar.Click += new System.EventHandler(this.BtnAlmacenar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(174, 265);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 14;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(255, 265);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 15;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // GrupBoxEstudios
            // 
            this.GrupBoxEstudios.Controls.Add(this.ChkMaestria);
            this.GrupBoxEstudios.Controls.Add(this.ChkEspecializacion);
            this.GrupBoxEstudios.Controls.Add(this.ChkProfesional);
            this.GrupBoxEstudios.Controls.Add(this.ChkTecnólogo);
            this.GrupBoxEstudios.Controls.Add(this.ChkTecnico);
            this.GrupBoxEstudios.Controls.Add(this.ChkBachiller);
            this.GrupBoxEstudios.Location = new System.Drawing.Point(301, 12);
            this.GrupBoxEstudios.Name = "GrupBoxEstudios";
            this.GrupBoxEstudios.Size = new System.Drawing.Size(283, 121);
            this.GrupBoxEstudios.TabIndex = 16;
            this.GrupBoxEstudios.TabStop = false;
            this.GrupBoxEstudios.Text = "Estudios Realizados : ";
            // 
            // ChkMaestria
            // 
            this.ChkMaestria.AutoSize = true;
            this.ChkMaestria.Location = new System.Drawing.Point(171, 96);
            this.ChkMaestria.Name = "ChkMaestria";
            this.ChkMaestria.Size = new System.Drawing.Size(68, 17);
            this.ChkMaestria.TabIndex = 5;
            this.ChkMaestria.Text = "Maestría";
            this.ChkMaestria.UseVisualStyleBackColor = true;
            // 
            // ChkEspecializacion
            // 
            this.ChkEspecializacion.AutoSize = true;
            this.ChkEspecializacion.Location = new System.Drawing.Point(37, 96);
            this.ChkEspecializacion.Name = "ChkEspecializacion";
            this.ChkEspecializacion.Size = new System.Drawing.Size(99, 17);
            this.ChkEspecializacion.TabIndex = 4;
            this.ChkEspecializacion.Text = "Especialización";
            this.ChkEspecializacion.UseVisualStyleBackColor = true;
            // 
            // ChkProfesional
            // 
            this.ChkProfesional.AutoSize = true;
            this.ChkProfesional.Location = new System.Drawing.Point(171, 64);
            this.ChkProfesional.Name = "ChkProfesional";
            this.ChkProfesional.Size = new System.Drawing.Size(78, 17);
            this.ChkProfesional.TabIndex = 3;
            this.ChkProfesional.Text = "Profesional";
            this.ChkProfesional.UseVisualStyleBackColor = true;
            // 
            // ChkTecnólogo
            // 
            this.ChkTecnólogo.AutoSize = true;
            this.ChkTecnólogo.Location = new System.Drawing.Point(37, 64);
            this.ChkTecnólogo.Name = "ChkTecnólogo";
            this.ChkTecnólogo.Size = new System.Drawing.Size(77, 17);
            this.ChkTecnólogo.TabIndex = 2;
            this.ChkTecnólogo.Text = "Tecnólogo";
            this.ChkTecnólogo.UseVisualStyleBackColor = true;
            // 
            // ChkTecnico
            // 
            this.ChkTecnico.AutoSize = true;
            this.ChkTecnico.Location = new System.Drawing.Point(171, 30);
            this.ChkTecnico.Name = "ChkTecnico";
            this.ChkTecnico.Size = new System.Drawing.Size(65, 17);
            this.ChkTecnico.TabIndex = 1;
            this.ChkTecnico.Text = "Técnico";
            this.ChkTecnico.UseVisualStyleBackColor = true;
            // 
            // ChkBachiller
            // 
            this.ChkBachiller.AutoSize = true;
            this.ChkBachiller.Location = new System.Drawing.Point(37, 30);
            this.ChkBachiller.Name = "ChkBachiller";
            this.ChkBachiller.Size = new System.Drawing.Size(66, 17);
            this.ChkBachiller.TabIndex = 0;
            this.ChkBachiller.Text = "Bachiller";
            this.ChkBachiller.UseVisualStyleBackColor = true;
            // 
            // GrupBoxIdiomas
            // 
            this.GrupBoxIdiomas.Controls.Add(this.ChkGriego);
            this.GrupBoxIdiomas.Controls.Add(this.ChkRuso);
            this.GrupBoxIdiomas.Controls.Add(this.ChkJapones);
            this.GrupBoxIdiomas.Controls.Add(this.ChkItaliano);
            this.GrupBoxIdiomas.Controls.Add(this.ChkIngles);
            this.GrupBoxIdiomas.Controls.Add(this.ChkAleman);
            this.GrupBoxIdiomas.Controls.Add(this.ChkFrancés);
            this.GrupBoxIdiomas.Controls.Add(this.ChkChino);
            this.GrupBoxIdiomas.Controls.Add(this.ChkPortugués);
            this.GrupBoxIdiomas.Location = new System.Drawing.Point(301, 138);
            this.GrupBoxIdiomas.Name = "GrupBoxIdiomas";
            this.GrupBoxIdiomas.Size = new System.Drawing.Size(283, 121);
            this.GrupBoxIdiomas.TabIndex = 17;
            this.GrupBoxIdiomas.TabStop = false;
            this.GrupBoxIdiomas.Text = "Idiomas que habla : ";
            // 
            // ChkGriego
            // 
            this.ChkGriego.AutoSize = true;
            this.ChkGriego.Location = new System.Drawing.Point(193, 90);
            this.ChkGriego.Name = "ChkGriego";
            this.ChkGriego.Size = new System.Drawing.Size(57, 17);
            this.ChkGriego.TabIndex = 14;
            this.ChkGriego.Text = "Griego";
            this.ChkGriego.UseVisualStyleBackColor = true;
            // 
            // ChkRuso
            // 
            this.ChkRuso.AutoSize = true;
            this.ChkRuso.Location = new System.Drawing.Point(193, 24);
            this.ChkRuso.Name = "ChkRuso";
            this.ChkRuso.Size = new System.Drawing.Size(51, 17);
            this.ChkRuso.TabIndex = 12;
            this.ChkRuso.Text = "Ruso";
            this.ChkRuso.UseVisualStyleBackColor = true;
            // 
            // ChkJapones
            // 
            this.ChkJapones.AutoSize = true;
            this.ChkJapones.Location = new System.Drawing.Point(193, 57);
            this.ChkJapones.Name = "ChkJapones";
            this.ChkJapones.Size = new System.Drawing.Size(66, 17);
            this.ChkJapones.TabIndex = 13;
            this.ChkJapones.Text = "Japonés";
            this.ChkJapones.UseVisualStyleBackColor = true;
            // 
            // ChkItaliano
            // 
            this.ChkItaliano.AutoSize = true;
            this.ChkItaliano.Location = new System.Drawing.Point(101, 89);
            this.ChkItaliano.Name = "ChkItaliano";
            this.ChkItaliano.Size = new System.Drawing.Size(60, 17);
            this.ChkItaliano.TabIndex = 11;
            this.ChkItaliano.Text = "Italiano";
            this.ChkItaliano.UseVisualStyleBackColor = true;
            // 
            // ChkIngles
            // 
            this.ChkIngles.AutoSize = true;
            this.ChkIngles.Location = new System.Drawing.Point(9, 24);
            this.ChkIngles.Name = "ChkIngles";
            this.ChkIngles.Size = new System.Drawing.Size(54, 17);
            this.ChkIngles.TabIndex = 6;
            this.ChkIngles.Text = "Inglés";
            this.ChkIngles.UseVisualStyleBackColor = true;
            // 
            // ChkAleman
            // 
            this.ChkAleman.AutoSize = true;
            this.ChkAleman.Location = new System.Drawing.Point(9, 89);
            this.ChkAleman.Name = "ChkAleman";
            this.ChkAleman.Size = new System.Drawing.Size(61, 17);
            this.ChkAleman.TabIndex = 10;
            this.ChkAleman.Text = "Alemán";
            this.ChkAleman.UseVisualStyleBackColor = true;
            // 
            // ChkFrancés
            // 
            this.ChkFrancés.AutoSize = true;
            this.ChkFrancés.Location = new System.Drawing.Point(101, 23);
            this.ChkFrancés.Name = "ChkFrancés";
            this.ChkFrancés.Size = new System.Drawing.Size(64, 17);
            this.ChkFrancés.TabIndex = 7;
            this.ChkFrancés.Text = "Francés";
            this.ChkFrancés.UseVisualStyleBackColor = true;
            // 
            // ChkChino
            // 
            this.ChkChino.AutoSize = true;
            this.ChkChino.Location = new System.Drawing.Point(101, 56);
            this.ChkChino.Name = "ChkChino";
            this.ChkChino.Size = new System.Drawing.Size(53, 17);
            this.ChkChino.TabIndex = 9;
            this.ChkChino.Text = "Chino";
            this.ChkChino.UseVisualStyleBackColor = true;
            // 
            // ChkPortugués
            // 
            this.ChkPortugués.AutoSize = true;
            this.ChkPortugués.Location = new System.Drawing.Point(9, 58);
            this.ChkPortugués.Name = "ChkPortugués";
            this.ChkPortugués.Size = new System.Drawing.Size(74, 17);
            this.ChkPortugués.TabIndex = 8;
            this.ChkPortugués.Text = "Portugués";
            this.ChkPortugués.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 297);
            this.Controls.Add(this.GrupBoxIdiomas);
            this.Controls.Add(this.GrupBoxEstudios);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAlmacenar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.GrupBoxDatospersonales);
            this.Name = "Form1";
            this.Text = "Manejo de Check y Radio Buttons";
            this.Load += new System.EventHandler(this.Form1_load);
            this.GrupBoxDatospersonales.ResumeLayout(false);
            this.GrupBoxDatospersonales.PerformLayout();
            this.GrupBoxGenero.ResumeLayout(false);
            this.GrupBoxGenero.PerformLayout();
            this.GrupBoxTipodedocumento.ResumeLayout(false);
            this.GrupBoxTipodedocumento.PerformLayout();
            this.GrupBoxEstudios.ResumeLayout(false);
            this.GrupBoxEstudios.PerformLayout();
            this.GrupBoxIdiomas.ResumeLayout(false);
            this.GrupBoxIdiomas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrupBoxDatospersonales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.GroupBox GrupBoxTipodedocumento;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GrupBoxGenero;
        private System.Windows.Forms.RadioButton RbtMujer;
        private System.Windows.Forms.RadioButton RbtHombre;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RbtCE;
        private System.Windows.Forms.RadioButton RbtPs;
        private System.Windows.Forms.RadioButton RbtCC;
        private System.Windows.Forms.RadioButton RbtTI;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnAlmacenar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.GroupBox GrupBoxEstudios;
        private System.Windows.Forms.GroupBox GrupBoxIdiomas;
        private System.Windows.Forms.CheckBox ChkMaestria;
        private System.Windows.Forms.CheckBox ChkEspecializacion;
        private System.Windows.Forms.CheckBox ChkProfesional;
        private System.Windows.Forms.CheckBox ChkTecnólogo;
        private System.Windows.Forms.CheckBox ChkTecnico;
        private System.Windows.Forms.CheckBox ChkBachiller;
        private System.Windows.Forms.CheckBox ChkItaliano;
        private System.Windows.Forms.CheckBox ChkIngles;
        private System.Windows.Forms.CheckBox ChkAleman;
        private System.Windows.Forms.CheckBox ChkFrancés;
        private System.Windows.Forms.CheckBox ChkChino;
        private System.Windows.Forms.CheckBox ChkPortugués;
        private System.Windows.Forms.CheckBox ChkGriego;
        private System.Windows.Forms.CheckBox ChkRuso;
        private System.Windows.Forms.CheckBox ChkJapones;
        private System.Windows.Forms.Button BtnBuscar;

    }
}

