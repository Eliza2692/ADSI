namespace GUI.Ventas
{
    partial class FormVentas
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
            this.cbxHora = new System.Windows.Forms.ComboBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxDestino = new System.Windows.Forms.ComboBox();
            this.cbxOrigen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarClientes = new System.Windows.Forms.Button();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarPuestos = new System.Windows.Forms.Button();
            this.btnGenerarPasaje = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picOcupado = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picDisponible = new System.Windows.Forms.PictureBox();
            this.cbxBus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOcupado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisponible)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxHora
            // 
            this.cbxHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHora.FormattingEnabled = true;
            this.cbxHora.Location = new System.Drawing.Point(113, 149);
            this.cbxHora.Name = "cbxHora";
            this.cbxHora.Size = new System.Drawing.Size(251, 28);
            this.cbxHora.TabIndex = 66;
            this.cbxHora.SelectedIndexChanged += new System.EventHandler(this.cbxHora_SelectedIndexChanged);
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(113, 44);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(250, 26);
            this.dtFecha.TabIndex = 67;
            this.dtFecha.ValueChanged += new System.EventHandler(this.dtFecha_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 72;
            this.label5.Text = "HORARIO:";
            // 
            // cbxDestino
            // 
            this.cbxDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDestino.FormattingEnabled = true;
            this.cbxDestino.Location = new System.Drawing.Point(113, 115);
            this.cbxDestino.Name = "cbxDestino";
            this.cbxDestino.Size = new System.Drawing.Size(251, 28);
            this.cbxDestino.TabIndex = 65;
            this.cbxDestino.SelectedIndexChanged += new System.EventHandler(this.cbxDestino_SelectedIndexChanged);
            // 
            // cbxOrigen
            // 
            this.cbxOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOrigen.FormattingEnabled = true;
            this.cbxOrigen.Location = new System.Drawing.Point(113, 81);
            this.cbxOrigen.Name = "cbxOrigen";
            this.cbxOrigen.Size = new System.Drawing.Size(251, 28);
            this.cbxOrigen.TabIndex = 64;
            this.cbxOrigen.SelectedIndexChanged += new System.EventHandler(this.cbxOrigen_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "FECHA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "DESTINO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 69;
            this.label2.Text = "ORIGEN:";
            // 
            // btnBuscarClientes
            // 
            this.btnBuscarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarClientes.Location = new System.Drawing.Point(429, 42);
            this.btnBuscarClientes.Name = "btnBuscarClientes";
            this.btnBuscarClientes.Size = new System.Drawing.Size(103, 26);
            this.btnBuscarClientes.TabIndex = 62;
            this.btnBuscarClientes.Text = "BUSCAR";
            this.btnBuscarClientes.UseVisualStyleBackColor = true;
            this.btnBuscarClientes.Click += new System.EventHandler(this.btnBuscarClientes_Click);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(254, 54);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(181, 26);
            this.txtIdCliente.TabIndex = 61;
            this.txtIdCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdCliente_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "NUMERO DE DOCUMENTO:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(114, 88);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(284, 26);
            this.txtNombreCliente.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 75;
            this.label7.Text = "NOMBRE:";
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(513, 88);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(284, 26);
            this.txtApellidoCliente.TabIndex = 76;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(404, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 77;
            this.label8.Text = "APELLIDOS:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarClientes);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 124);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CLIENTE";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxBus);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnBuscarPuestos);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbxOrigen);
            this.groupBox2.Controls.Add(this.cbxHora);
            this.groupBox2.Controls.Add(this.cbxDestino);
            this.groupBox2.Controls.Add(this.dtFecha);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 283);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RUTA";
            // 
            // btnBuscarPuestos
            // 
            this.btnBuscarPuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPuestos.Location = new System.Drawing.Point(113, 251);
            this.btnBuscarPuestos.Name = "btnBuscarPuestos";
            this.btnBuscarPuestos.Size = new System.Drawing.Size(250, 26);
            this.btnBuscarPuestos.TabIndex = 63;
            this.btnBuscarPuestos.Text = "BUSCAR DISPONIBILIDAD";
            this.btnBuscarPuestos.UseVisualStyleBackColor = true;
            this.btnBuscarPuestos.Click += new System.EventHandler(this.btnBuscarPuestos_Click);
            // 
            // btnGenerarPasaje
            // 
            this.btnGenerarPasaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarPasaje.Location = new System.Drawing.Point(68, 446);
            this.btnGenerarPasaje.Name = "btnGenerarPasaje";
            this.btnGenerarPasaje.Size = new System.Drawing.Size(250, 26);
            this.btnGenerarPasaje.TabIndex = 73;
            this.btnGenerarPasaje.Text = "GENERAR PASAJE";
            this.btnGenerarPasaje.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.picOcupado);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.picDisponible);
            this.groupBox3.Location = new System.Drawing.Point(427, 157);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 353);
            this.groupBox3.TabIndex = 80;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PUESTOS";
            // 
            // picOcupado
            // 
            this.picOcupado.BackColor = System.Drawing.Color.Red;
            this.picOcupado.Location = new System.Drawing.Point(30, 173);
            this.picOcupado.Name = "picOcupado";
            this.picOcupado.Size = new System.Drawing.Size(40, 35);
            this.picOcupado.TabIndex = 75;
            this.picOcupado.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(102, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 294);
            this.panel1.TabIndex = 74;
            // 
            // picDisponible
            // 
            this.picDisponible.BackColor = System.Drawing.Color.Lime;
            this.picDisponible.Location = new System.Drawing.Point(30, 101);
            this.picDisponible.Name = "picDisponible";
            this.picDisponible.Size = new System.Drawing.Size(40, 35);
            this.picDisponible.TabIndex = 73;
            this.picDisponible.TabStop = false;
            this.picDisponible.Tag = "";
            // 
            // cbxBus
            // 
            this.cbxBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBus.FormattingEnabled = true;
            this.cbxBus.Location = new System.Drawing.Point(112, 183);
            this.cbxBus.Name = "cbxBus";
            this.cbxBus.Size = new System.Drawing.Size(251, 28);
            this.cbxBus.TabIndex = 73;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 74;
            this.label9.Text = "BUS:";
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 522);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnGenerarPasaje);
            this.Controls.Add(this.txtApellidoCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picOcupado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisponible)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxHora;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxDestino;
        private System.Windows.Forms.ComboBox cbxOrigen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarClientes;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarPuestos;
        private System.Windows.Forms.Button btnGenerarPasaje;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox picOcupado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picDisponible;
        private System.Windows.Forms.ComboBox cbxBus;
        private System.Windows.Forms.Label label9;
    }
}