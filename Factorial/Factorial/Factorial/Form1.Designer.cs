namespace Factorial
{
    partial class Fibonacci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fibonacci));
            this.LblFactorial = new System.Windows.Forms.Label();
            this.LblNumero = new System.Windows.Forms.Label();
            this.LblResultado = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblFactorial
            // 
            this.LblFactorial.AutoSize = true;
            this.LblFactorial.BackColor = System.Drawing.Color.Transparent;
            this.LblFactorial.Font = new System.Drawing.Font("Buxton Sketch", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFactorial.ForeColor = System.Drawing.Color.Firebrick;
            this.LblFactorial.Location = new System.Drawing.Point(77, 23);
            this.LblFactorial.Name = "LblFactorial";
            this.LblFactorial.Size = new System.Drawing.Size(135, 36);
            this.LblFactorial.TabIndex = 0;
            this.LblFactorial.Text = "FIBONACCI";
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LblNumero.Location = new System.Drawing.Point(12, 90);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(78, 29);
            this.LblNumero.TabIndex = 1;
            this.LblNumero.Text = "Número";
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LblResultado.Location = new System.Drawing.Point(12, 155);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(99, 29);
            this.LblResultado.TabIndex = 2;
            this.LblResultado.Text = "Resultado";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BtnCalcular.Location = new System.Drawing.Point(69, 208);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(155, 38);
            this.BtnCalcular.TabIndex = 3;
            this.BtnCalcular.Text = "CALCULAR";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(290, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // TxtNumero
            // 
            this.TxtNumero.BackColor = System.Drawing.Color.Ivory;
            this.TxtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNumero.Font = new System.Drawing.Font("Buxton Sketch", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumero.ForeColor = System.Drawing.Color.SaddleBrown;
            this.TxtNumero.Location = new System.Drawing.Point(124, 82);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(145, 41);
            this.TxtNumero.TabIndex = 5;
            // 
            // TxtResultado
            // 
            this.TxtResultado.BackColor = System.Drawing.Color.Ivory;
            this.TxtResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtResultado.Font = new System.Drawing.Font("Buxton Sketch", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResultado.ForeColor = System.Drawing.Color.SaddleBrown;
            this.TxtResultado.Location = new System.Drawing.Point(124, 147);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(145, 41);
            this.TxtResultado.TabIndex = 6;
            // 
            // Fibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(411, 267);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.LblNumero);
            this.Controls.Add(this.LblFactorial);
            this.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Fibonacci";
            this.Text = "FIBONACCI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFactorial;
        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.TextBox TxtResultado;
    }
}

