namespace Biblioteca
{
    partial class frmGestionEjemplares
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionEjemplares));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAutores = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgGestionEjemplares = new System.Windows.Forms.DataGridView();
            this.nmAnio = new System.Windows.Forms.NumericUpDown();
            this.nmCantidad = new System.Windows.Forms.NumericUpDown();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxFormato = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picGuardar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGestionEjemplares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuardar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(644, 257);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FloralWhite;
            this.txtNombre.Location = new System.Drawing.Point(110, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(507, 29);
            this.txtNombre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre :";
            // 
            // txtReferencia
            // 
            this.txtReferencia.BackColor = System.Drawing.Color.FloralWhite;
            this.txtReferencia.Location = new System.Drawing.Point(110, 23);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(198, 29);
            this.txtReferencia.TabIndex = 0;
            this.txtReferencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReferencia_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Referencia :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "GESTIÓN DE EJEMPLARES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cantidad :";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FloralWhite;
            this.txtDescripcion.Location = new System.Drawing.Point(110, 274);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(507, 29);
            this.txtDescripcion.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Descripción :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 22);
            this.label6.TabIndex = 22;
            this.label6.Text = "Año de publicación :";
            // 
            // txtAutores
            // 
            this.txtAutores.BackColor = System.Drawing.Color.FloralWhite;
            this.txtAutores.Location = new System.Drawing.Point(110, 233);
            this.txtAutores.Name = "txtAutores";
            this.txtAutores.Size = new System.Drawing.Size(507, 29);
            this.txtAutores.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "Autor(es) :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(317, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = "Estado :";
            // 
            // txtEditorial
            // 
            this.txtEditorial.BackColor = System.Drawing.Color.FloralWhite;
            this.txtEditorial.Location = new System.Drawing.Point(110, 191);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(507, 29);
            this.txtEditorial.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 22);
            this.label10.TabIndex = 25;
            this.label10.Text = "Editorial :";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Wheat;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Location = new System.Drawing.Point(18, 346);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(129, 30);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Wheat;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Location = new System.Drawing.Point(177, 346);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(129, 30);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Wheat;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Location = new System.Drawing.Point(336, 346);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(129, 30);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Wheat;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(495, 346);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 30);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgGestionEjemplares
            // 
            this.dgGestionEjemplares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGestionEjemplares.Location = new System.Drawing.Point(18, 392);
            this.dgGestionEjemplares.Name = "dgGestionEjemplares";
            this.dgGestionEjemplares.Size = new System.Drawing.Size(824, 150);
            this.dgGestionEjemplares.TabIndex = 6;
            this.dgGestionEjemplares.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGestionEjemplares_CellContentDoubleClick);
            this.dgGestionEjemplares.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGestionEjemplares_CellDoubleClick);
            // 
            // nmAnio
            // 
            this.nmAnio.Location = new System.Drawing.Point(472, 148);
            this.nmAnio.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nmAnio.Name = "nmAnio";
            this.nmAnio.Size = new System.Drawing.Size(145, 29);
            this.nmAnio.TabIndex = 6;
            // 
            // nmCantidad
            // 
            this.nmCantidad.Location = new System.Drawing.Point(110, 106);
            this.nmCantidad.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nmCantidad.Name = "nmCantidad";
            this.nmCantidad.Size = new System.Drawing.Size(198, 29);
            this.nmCantidad.TabIndex = 3;
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Disponible",
            "No Disponible"});
            this.cbxEstado.Location = new System.Drawing.Point(408, 103);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(209, 30);
            this.cbxEstado.TabIndex = 4;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(110, 148);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(198, 30);
            this.cbxCategoria.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 22);
            this.label11.TabIndex = 61;
            this.label11.Text = "Categoría :";
            // 
            // txtFoto
            // 
            this.txtFoto.BackColor = System.Drawing.Color.FloralWhite;
            this.txtFoto.Location = new System.Drawing.Point(667, 141);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(146, 29);
            this.txtFoto.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(317, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 22);
            this.label8.TabIndex = 63;
            this.label8.Text = "Formato :";
            // 
            // cbxFormato
            // 
            this.cbxFormato.FormattingEnabled = true;
            this.cbxFormato.Location = new System.Drawing.Point(408, 20);
            this.cbxFormato.Name = "cbxFormato";
            this.cbxFormato.Size = new System.Drawing.Size(209, 30);
            this.cbxFormato.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FloralWhite;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(798, 183);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 69;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // picGuardar
            // 
            this.picGuardar.BackColor = System.Drawing.Color.FloralWhite;
            this.picGuardar.Image = ((System.Drawing.Image)(resources.GetObject("picGuardar.Image")));
            this.picGuardar.Location = new System.Drawing.Point(762, 183);
            this.picGuardar.Name = "picGuardar";
            this.picGuardar.Size = new System.Drawing.Size(30, 30);
            this.picGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGuardar.TabIndex = 68;
            this.picGuardar.TabStop = false;
            this.picGuardar.Click += new System.EventHandler(this.picGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.picGuardar);
            this.panel1.Controls.Add(this.cbxFormato);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbxCategoria);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cbxEstado);
            this.panel1.Controls.Add(this.nmCantidad);
            this.panel1.Controls.Add(this.nmAnio);
            this.panel1.Controls.Add(this.txtEditorial);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.picFoto);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtAutores);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtFoto);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtReferencia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(6, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 315);
            this.panel1.TabIndex = 1;
            // 
            // picFoto
            // 
            this.picFoto.BackColor = System.Drawing.Color.FloralWhite;
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFoto.Location = new System.Drawing.Point(638, 23);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(198, 197);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 24;
            this.picFoto.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmGestionEjemplares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(854, 553);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgGestionEjemplares);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGestionEjemplares";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca Esperanza - Gestión de Ejemplares";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGestionEjemplares_FormClosed);
            this.Load += new System.EventHandler(this.frmGestionEjemplares_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGestionEjemplares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuardar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAutores;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgGestionEjemplares;
        private System.Windows.Forms.NumericUpDown nmAnio;
        private System.Windows.Forms.NumericUpDown nmCantidad;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFoto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxFormato;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox picGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}