namespace calclucladorafinal
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
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.btnigual = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btnmultiplicacion = new System.Windows.Forms.Button();
            this.btndivision = new System.Windows.Forms.Button();
            this.btnborrartodo = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btndecimal = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnsigno = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnCosecante = new System.Windows.Forms.Button();
            this.btnSecante = new System.Windows.Forms.Button();
            this.btnCotangente = new System.Windows.Forms.Button();
            this.btnTangente = new System.Windows.Forms.Button();
            this.btnCoseno = new System.Windows.Forms.Button();
            this.btnSeno = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnlognatural = new System.Windows.Forms.Button();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.btnCubo = new System.Windows.Forms.Button();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.btnHexa = new System.Windows.Forms.Button();
            this.btnOctal = new System.Windows.Forms.Button();
            this.btnBin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDisplay.Location = new System.Drawing.Point(15, 15);
            this.TxtDisplay.Margin = new System.Windows.Forms.Padding(6);
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.Size = new System.Drawing.Size(546, 31);
            this.TxtDisplay.TabIndex = 39;
            this.TxtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnigual
            // 
            this.btnigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnigual.Location = new System.Drawing.Point(201, 254);
            this.btnigual.Margin = new System.Windows.Forms.Padding(6);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(112, 50);
            this.btnigual.TabIndex = 38;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = true;
            this.btnigual.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // btnresta
            // 
            this.btnresta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresta.Location = new System.Drawing.Point(263, 192);
            this.btnresta.Margin = new System.Windows.Forms.Padding(6);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(50, 50);
            this.btnresta.TabIndex = 37;
            this.btnresta.Text = "-";
            this.btnresta.UseVisualStyleBackColor = true;
            this.btnresta.Click += new System.EventHandler(this.btnmultiplicacion_Click);
            // 
            // btnsuma
            // 
            this.btnsuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuma.Location = new System.Drawing.Point(201, 192);
            this.btnsuma.Margin = new System.Windows.Forms.Padding(6);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(50, 50);
            this.btnsuma.TabIndex = 36;
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.btnmultiplicacion_Click);
            // 
            // btnmultiplicacion
            // 
            this.btnmultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmultiplicacion.Location = new System.Drawing.Point(201, 130);
            this.btnmultiplicacion.Margin = new System.Windows.Forms.Padding(6);
            this.btnmultiplicacion.Name = "btnmultiplicacion";
            this.btnmultiplicacion.Size = new System.Drawing.Size(50, 50);
            this.btnmultiplicacion.TabIndex = 35;
            this.btnmultiplicacion.Text = "*";
            this.btnmultiplicacion.UseVisualStyleBackColor = true;
            this.btnmultiplicacion.Click += new System.EventHandler(this.btnmultiplicacion_Click);
            // 
            // btndivision
            // 
            this.btndivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndivision.Location = new System.Drawing.Point(263, 130);
            this.btndivision.Margin = new System.Windows.Forms.Padding(6);
            this.btndivision.Name = "btndivision";
            this.btndivision.Size = new System.Drawing.Size(50, 50);
            this.btndivision.TabIndex = 34;
            this.btndivision.Text = "/";
            this.btndivision.UseVisualStyleBackColor = true;
            this.btndivision.Click += new System.EventHandler(this.btnmultiplicacion_Click);
            // 
            // btnborrartodo
            // 
            this.btnborrartodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrartodo.Location = new System.Drawing.Point(263, 68);
            this.btnborrartodo.Margin = new System.Windows.Forms.Padding(6);
            this.btnborrartodo.Name = "btnborrartodo";
            this.btnborrartodo.Size = new System.Drawing.Size(50, 50);
            this.btnborrartodo.TabIndex = 33;
            this.btnborrartodo.Text = "AC";
            this.btnborrartodo.UseVisualStyleBackColor = true;
            this.btnborrartodo.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.Location = new System.Drawing.Point(201, 68);
            this.btnborrar.Margin = new System.Windows.Forms.Padding(6);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(50, 50);
            this.btnborrar.TabIndex = 32;
            this.btnborrar.Text = "<<";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btndecimal
            // 
            this.btndecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndecimal.Location = new System.Drawing.Point(15, 254);
            this.btndecimal.Margin = new System.Windows.Forms.Padding(6);
            this.btndecimal.Name = "btndecimal";
            this.btndecimal.Size = new System.Drawing.Size(50, 50);
            this.btndecimal.TabIndex = 31;
            this.btndecimal.Text = ",";
            this.btndecimal.UseVisualStyleBackColor = true;
            this.btndecimal.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(77, 254);
            this.btn0.Margin = new System.Windows.Forms.Padding(6);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(50, 50);
            this.btn0.TabIndex = 30;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnsigno
            // 
            this.btnsigno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsigno.Location = new System.Drawing.Point(139, 254);
            this.btnsigno.Margin = new System.Windows.Forms.Padding(6);
            this.btnsigno.Name = "btnsigno";
            this.btnsigno.Size = new System.Drawing.Size(50, 50);
            this.btnsigno.TabIndex = 29;
            this.btnsigno.Text = "+/-";
            this.btnsigno.UseVisualStyleBackColor = true;
            this.btnsigno.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(139, 192);
            this.btn9.Margin = new System.Windows.Forms.Padding(6);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(50, 50);
            this.btn9.TabIndex = 28;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(77, 192);
            this.btn8.Margin = new System.Windows.Forms.Padding(6);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(50, 50);
            this.btn8.TabIndex = 27;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(15, 192);
            this.btn7.Margin = new System.Windows.Forms.Padding(6);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(50, 50);
            this.btn7.TabIndex = 26;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(15, 130);
            this.btn4.Margin = new System.Windows.Forms.Padding(6);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(50, 50);
            this.btn4.TabIndex = 25;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(77, 130);
            this.btn5.Margin = new System.Windows.Forms.Padding(6);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(50, 50);
            this.btn5.TabIndex = 24;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(139, 130);
            this.btn6.Margin = new System.Windows.Forms.Padding(6);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(50, 50);
            this.btn6.TabIndex = 23;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(139, 68);
            this.btn3.Margin = new System.Windows.Forms.Padding(6);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(50, 50);
            this.btn3.TabIndex = 22;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(77, 68);
            this.btn2.Margin = new System.Windows.Forms.Padding(6);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(50, 50);
            this.btn2.TabIndex = 21;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(15, 68);
            this.btn1.Margin = new System.Windows.Forms.Padding(6);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(50, 50);
            this.btn1.TabIndex = 20;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnCosecante
            // 
            this.btnCosecante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCosecante.Location = new System.Drawing.Point(325, 254);
            this.btnCosecante.Margin = new System.Windows.Forms.Padding(6);
            this.btnCosecante.Name = "btnCosecante";
            this.btnCosecante.Size = new System.Drawing.Size(50, 50);
            this.btnCosecante.TabIndex = 51;
            this.btnCosecante.Text = "CSC";
            this.btnCosecante.UseVisualStyleBackColor = true;
            // 
            // btnSecante
            // 
            this.btnSecante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecante.Location = new System.Drawing.Point(387, 254);
            this.btnSecante.Margin = new System.Windows.Forms.Padding(6);
            this.btnSecante.Name = "btnSecante";
            this.btnSecante.Size = new System.Drawing.Size(50, 50);
            this.btnSecante.TabIndex = 50;
            this.btnSecante.Text = "SEC";
            this.btnSecante.UseVisualStyleBackColor = true;
            // 
            // btnCotangente
            // 
            this.btnCotangente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotangente.Location = new System.Drawing.Point(449, 254);
            this.btnCotangente.Margin = new System.Windows.Forms.Padding(6);
            this.btnCotangente.Name = "btnCotangente";
            this.btnCotangente.Size = new System.Drawing.Size(50, 50);
            this.btnCotangente.TabIndex = 49;
            this.btnCotangente.Text = "CTan";
            this.btnCotangente.UseVisualStyleBackColor = true;
            // 
            // btnTangente
            // 
            this.btnTangente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTangente.Location = new System.Drawing.Point(449, 192);
            this.btnTangente.Margin = new System.Windows.Forms.Padding(6);
            this.btnTangente.Name = "btnTangente";
            this.btnTangente.Size = new System.Drawing.Size(50, 50);
            this.btnTangente.TabIndex = 48;
            this.btnTangente.Text = "Tan";
            this.btnTangente.UseVisualStyleBackColor = true;
            // 
            // btnCoseno
            // 
            this.btnCoseno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoseno.Location = new System.Drawing.Point(387, 192);
            this.btnCoseno.Margin = new System.Windows.Forms.Padding(6);
            this.btnCoseno.Name = "btnCoseno";
            this.btnCoseno.Size = new System.Drawing.Size(50, 50);
            this.btnCoseno.TabIndex = 47;
            this.btnCoseno.Text = "Cos";
            this.btnCoseno.UseVisualStyleBackColor = true;
            // 
            // btnSeno
            // 
            this.btnSeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeno.Location = new System.Drawing.Point(325, 192);
            this.btnSeno.Margin = new System.Windows.Forms.Padding(6);
            this.btnSeno.Name = "btnSeno";
            this.btnSeno.Size = new System.Drawing.Size(50, 50);
            this.btnSeno.TabIndex = 46;
            this.btnSeno.Text = "Sen";
            this.btnSeno.UseVisualStyleBackColor = true;
            // 
            // btnRaiz
            // 
            this.btnRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.Location = new System.Drawing.Point(511, 70);
            this.btnRaiz.Margin = new System.Windows.Forms.Padding(6);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(50, 50);
            this.btnRaiz.TabIndex = 45;
            this.btnRaiz.Text = "^(1/2)";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.btnCuadrado_Click);
            // 
            // btnFactorial
            // 
            this.btnFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactorial.Location = new System.Drawing.Point(325, 130);
            this.btnFactorial.Margin = new System.Windows.Forms.Padding(6);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(50, 50);
            this.btnFactorial.TabIndex = 44;
            this.btnFactorial.Text = "!";
            this.btnFactorial.UseVisualStyleBackColor = true;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // btnlognatural
            // 
            this.btnlognatural.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlognatural.Location = new System.Drawing.Point(387, 130);
            this.btnlognatural.Margin = new System.Windows.Forms.Padding(6);
            this.btnlognatural.Name = "btnlognatural";
            this.btnlognatural.Size = new System.Drawing.Size(50, 50);
            this.btnlognatural.TabIndex = 43;
            this.btnlognatural.Text = "Ln";
            this.btnlognatural.UseVisualStyleBackColor = true;
            // 
            // btnPotencia
            // 
            this.btnPotencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotencia.Location = new System.Drawing.Point(449, 68);
            this.btnPotencia.Margin = new System.Windows.Forms.Padding(6);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(50, 112);
            this.btnPotencia.TabIndex = 42;
            this.btnPotencia.Text = "^n";
            this.btnPotencia.UseVisualStyleBackColor = true;
            // 
            // btnCubo
            // 
            this.btnCubo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCubo.Location = new System.Drawing.Point(387, 68);
            this.btnCubo.Margin = new System.Windows.Forms.Padding(6);
            this.btnCubo.Name = "btnCubo";
            this.btnCubo.Size = new System.Drawing.Size(50, 50);
            this.btnCubo.TabIndex = 41;
            this.btnCubo.Text = "^3";
            this.btnCubo.UseVisualStyleBackColor = true;
            this.btnCubo.Click += new System.EventHandler(this.btnCuadrado_Click);
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuadrado.Location = new System.Drawing.Point(325, 68);
            this.btnCuadrado.Margin = new System.Windows.Forms.Padding(6);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(50, 50);
            this.btnCuadrado.TabIndex = 40;
            this.btnCuadrado.Text = "^2";
            this.btnCuadrado.UseVisualStyleBackColor = true;
            this.btnCuadrado.Click += new System.EventHandler(this.btnCuadrado_Click);
            // 
            // btnHexa
            // 
            this.btnHexa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHexa.Location = new System.Drawing.Point(511, 254);
            this.btnHexa.Margin = new System.Windows.Forms.Padding(6);
            this.btnHexa.Name = "btnHexa";
            this.btnHexa.Size = new System.Drawing.Size(50, 50);
            this.btnHexa.TabIndex = 54;
            this.btnHexa.Text = "Hex";
            this.btnHexa.UseVisualStyleBackColor = true;
            this.btnHexa.Click += new System.EventHandler(this.btnBin_Click);
            // 
            // btnOctal
            // 
            this.btnOctal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOctal.Location = new System.Drawing.Point(511, 192);
            this.btnOctal.Margin = new System.Windows.Forms.Padding(6);
            this.btnOctal.Name = "btnOctal";
            this.btnOctal.Size = new System.Drawing.Size(50, 50);
            this.btnOctal.TabIndex = 53;
            this.btnOctal.Text = "Oct";
            this.btnOctal.UseVisualStyleBackColor = true;
            this.btnOctal.Click += new System.EventHandler(this.btnBin_Click);
            // 
            // btnBin
            // 
            this.btnBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBin.Location = new System.Drawing.Point(511, 130);
            this.btnBin.Margin = new System.Windows.Forms.Padding(6);
            this.btnBin.Name = "btnBin";
            this.btnBin.Size = new System.Drawing.Size(50, 50);
            this.btnBin.TabIndex = 52;
            this.btnBin.Text = "Bin";
            this.btnBin.UseVisualStyleBackColor = true;
            this.btnBin.Click += new System.EventHandler(this.btnBin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 322);
            this.Controls.Add(this.btnHexa);
            this.Controls.Add(this.btnOctal);
            this.Controls.Add(this.btnBin);
            this.Controls.Add(this.btnCosecante);
            this.Controls.Add(this.btnSecante);
            this.Controls.Add(this.btnCotangente);
            this.Controls.Add(this.btnTangente);
            this.Controls.Add(this.btnCoseno);
            this.Controls.Add(this.btnSeno);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnFactorial);
            this.Controls.Add(this.btnlognatural);
            this.Controls.Add(this.btnPotencia);
            this.Controls.Add(this.btnCubo);
            this.Controls.Add(this.btnCuadrado);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.btnigual);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.btnmultiplicacion);
            this.Controls.Add(this.btndivision);
            this.Controls.Add(this.btnborrartodo);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btndecimal);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnsigno);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDisplay;
        private System.Windows.Forms.Button btnigual;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btnmultiplicacion;
        private System.Windows.Forms.Button btndivision;
        private System.Windows.Forms.Button btnborrartodo;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btndecimal;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnsigno;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnCosecante;
        private System.Windows.Forms.Button btnSecante;
        private System.Windows.Forms.Button btnCotangente;
        private System.Windows.Forms.Button btnTangente;
        private System.Windows.Forms.Button btnCoseno;
        private System.Windows.Forms.Button btnSeno;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Button btnlognatural;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Button btnCubo;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Button btnHexa;
        private System.Windows.Forms.Button btnOctal;
        private System.Windows.Forms.Button btnBin;
    }
}

