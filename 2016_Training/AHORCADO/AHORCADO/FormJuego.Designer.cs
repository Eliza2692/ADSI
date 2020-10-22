namespace AHORCADO
{
    partial class FormJuego
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFallos = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPuntuacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNueva = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblUsadas = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblBorrador = new System.Windows.Forms.Label();
            this.lblPalabra = new System.Windows.Forms.Label();
            this.picAhorcado = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fallos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFallos
            // 
            this.txtFallos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFallos.Location = new System.Drawing.Point(407, 47);
            this.txtFallos.Name = "txtFallos";
            this.txtFallos.ReadOnly = true;
            this.txtFallos.Size = new System.Drawing.Size(100, 26);
            this.txtFallos.TabIndex = 1;
            this.txtFallos.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPuntuacion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnNueva);
            this.groupBox1.Controls.Add(this.txtFallos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(888, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ahorcado";
            // 
            // txtPuntuacion
            // 
            this.txtPuntuacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuntuacion.Location = new System.Drawing.Point(766, 47);
            this.txtPuntuacion.Name = "txtPuntuacion";
            this.txtPuntuacion.ReadOnly = true;
            this.txtPuntuacion.Size = new System.Drawing.Size(100, 26);
            this.txtPuntuacion.TabIndex = 3;
            this.txtPuntuacion.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(592, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Puntuación";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnNueva
            // 
            this.btnNueva.Location = new System.Drawing.Point(18, 34);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(168, 47);
            this.btnNueva.TabIndex = 0;
            this.btnNueva.Text = "Nueva Palabra";
            this.btnNueva.UseVisualStyleBackColor = true;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblUsadas);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 269);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Letras Utilizadas";
            // 
            // lblUsadas
            // 
            this.lblUsadas.AutoSize = true;
            this.lblUsadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsadas.Location = new System.Drawing.Point(13, 130);
            this.lblUsadas.Name = "lblUsadas";
            this.lblUsadas.Size = new System.Drawing.Size(0, 29);
            this.lblUsadas.TabIndex = 6;
            this.lblUsadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblBorrador);
            this.groupBox3.Controls.Add(this.lblPalabra);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(247, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(427, 269);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Palabra";
            // 
            // lblBorrador
            // 
            this.lblBorrador.AutoSize = true;
            this.lblBorrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrador.Location = new System.Drawing.Point(69, 186);
            this.lblBorrador.Name = "lblBorrador";
            this.lblBorrador.Size = new System.Drawing.Size(0, 29);
            this.lblBorrador.TabIndex = 5;
            this.lblBorrador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPalabra
            // 
            this.lblPalabra.AutoSize = true;
            this.lblPalabra.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalabra.Location = new System.Drawing.Point(69, 99);
            this.lblPalabra.Name = "lblPalabra";
            this.lblPalabra.Size = new System.Drawing.Size(0, 37);
            this.lblPalabra.TabIndex = 4;
            this.lblPalabra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPalabra.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.lblPalabra_PreviewKeyDown);
            // 
            // picAhorcado
            // 
            this.picAhorcado.Image = global::AHORCADO.Properties.Resources.img0;
            this.picAhorcado.Location = new System.Drawing.Point(680, 139);
            this.picAhorcado.Name = "picAhorcado";
            this.picAhorcado.Size = new System.Drawing.Size(220, 260);
            this.picAhorcado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAhorcado.TabIndex = 6;
            this.picAhorcado.TabStop = false;
            // 
            // FormJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 411);
            this.Controls.Add(this.picAhorcado);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormJuego";
            this.Text = "FormJuego";
            this.Load += new System.EventHandler(this.FormJuego_Load);
            this.Click += new System.EventHandler(this.label1_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFallos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.TextBox txtPuntuacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblPalabra;
        private System.Windows.Forms.Label lblBorrador;
        private System.Windows.Forms.PictureBox picAhorcado;
        private System.Windows.Forms.Label lblUsadas;
    }
}