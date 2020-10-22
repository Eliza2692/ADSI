namespace CUATROLINEAS
{
    partial class FormJuego
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
            this.components = new System.ComponentModel.Container();
            this.picAmarilla = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJug2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJug1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlTablero = new System.Windows.Forms.Panel();
            this.picRoja = new System.Windows.Forms.PictureBox();
            this.pic0 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic6 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picAmarilla)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRoja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).BeginInit();
            this.SuspendLayout();
            // 
            // picAmarilla
            // 
            this.picAmarilla.BackColor = System.Drawing.Color.Transparent;
            this.picAmarilla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picAmarilla.Image = global::CUATROLINEAS.Properties.Resources.modenaAmarilla;
            this.picAmarilla.Location = new System.Drawing.Point(25, 252);
            this.picAmarilla.Name = "picAmarilla";
            this.picAmarilla.Size = new System.Drawing.Size(65, 65);
            this.picAmarilla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAmarilla.TabIndex = 2;
            this.picAmarilla.TabStop = false;
            this.picAmarilla.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picAmarilla_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtJug2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtJug1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(715, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 473);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Puntuación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Jugador 2:";
            // 
            // txtJug2
            // 
            this.txtJug2.Location = new System.Drawing.Point(136, 252);
            this.txtJug2.Name = "txtJug2";
            this.txtJug2.ReadOnly = true;
            this.txtJug2.Size = new System.Drawing.Size(85, 29);
            this.txtJug2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Jugador 1:";
            // 
            // txtJug1
            // 
            this.txtJug1.Location = new System.Drawing.Point(136, 198);
            this.txtJug1.Name = "txtJug1";
            this.txtJug1.ReadOnly = true;
            this.txtJug1.Size = new System.Drawing.Size(85, 29);
            this.txtJug1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Partidas Ganadas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Nueva Partida";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlTablero
            // 
            this.pnlTablero.AllowDrop = true;
            this.pnlTablero.BackgroundImage = global::CUATROLINEAS.Properties.Resources.Raya_en_4;
            this.pnlTablero.Location = new System.Drawing.Point(120, 116);
            this.pnlTablero.Name = "pnlTablero";
            this.pnlTablero.Size = new System.Drawing.Size(536, 464);
            this.pnlTablero.TabIndex = 10;
            // 
            // picRoja
            // 
            this.picRoja.AllowDrop = true;
            this.picRoja.BackColor = System.Drawing.Color.Transparent;
            this.picRoja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRoja.Image = global::CUATROLINEAS.Properties.Resources.modenaRoja;
            this.picRoja.Location = new System.Drawing.Point(25, 143);
            this.picRoja.Name = "picRoja";
            this.picRoja.Size = new System.Drawing.Size(65, 65);
            this.picRoja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRoja.TabIndex = 1;
            this.picRoja.TabStop = false;
            this.picRoja.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picAmarilla_MouseDown);
            // 
            // pic0
            // 
            this.pic0.AllowDrop = true;
            this.pic0.BackColor = System.Drawing.Color.Transparent;
            this.pic0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic0.Location = new System.Drawing.Point(120, 37);
            this.pic0.Name = "pic0";
            this.pic0.Size = new System.Drawing.Size(76, 76);
            this.pic0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic0.TabIndex = 11;
            this.pic0.TabStop = false;
            this.pic0.DragDrop += new System.Windows.Forms.DragEventHandler(this.pic0_DragDrop);
            this.pic0.DragEnter += new System.Windows.Forms.DragEventHandler(this.pic0_DragEnter);
            // 
            // pic1
            // 
            this.pic1.AllowDrop = true;
            this.pic1.BackColor = System.Drawing.Color.Transparent;
            this.pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic1.Location = new System.Drawing.Point(196, 37);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(76, 76);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 12;
            this.pic1.TabStop = false;
            this.pic1.DragDrop += new System.Windows.Forms.DragEventHandler(this.pic0_DragDrop);
            this.pic1.DragEnter += new System.Windows.Forms.DragEventHandler(this.pic0_DragEnter);
            // 
            // pic2
            // 
            this.pic2.AllowDrop = true;
            this.pic2.BackColor = System.Drawing.Color.Transparent;
            this.pic2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic2.Location = new System.Drawing.Point(272, 37);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(76, 76);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 13;
            this.pic2.TabStop = false;
            this.pic2.DragDrop += new System.Windows.Forms.DragEventHandler(this.pic0_DragDrop);
            this.pic2.DragEnter += new System.Windows.Forms.DragEventHandler(this.pic0_DragEnter);
            // 
            // pic3
            // 
            this.pic3.AllowDrop = true;
            this.pic3.BackColor = System.Drawing.Color.Transparent;
            this.pic3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic3.Location = new System.Drawing.Point(348, 37);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(76, 76);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic3.TabIndex = 14;
            this.pic3.TabStop = false;
            this.pic3.DragDrop += new System.Windows.Forms.DragEventHandler(this.pic0_DragDrop);
            this.pic3.DragEnter += new System.Windows.Forms.DragEventHandler(this.pic0_DragEnter);
            // 
            // pic4
            // 
            this.pic4.AllowDrop = true;
            this.pic4.BackColor = System.Drawing.Color.Transparent;
            this.pic4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic4.Location = new System.Drawing.Point(424, 37);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(76, 76);
            this.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic4.TabIndex = 15;
            this.pic4.TabStop = false;
            this.pic4.DragDrop += new System.Windows.Forms.DragEventHandler(this.pic0_DragDrop);
            this.pic4.DragEnter += new System.Windows.Forms.DragEventHandler(this.pic0_DragEnter);
            // 
            // pic5
            // 
            this.pic5.AllowDrop = true;
            this.pic5.BackColor = System.Drawing.Color.Transparent;
            this.pic5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic5.Location = new System.Drawing.Point(500, 37);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(76, 76);
            this.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic5.TabIndex = 16;
            this.pic5.TabStop = false;
            this.pic5.DragDrop += new System.Windows.Forms.DragEventHandler(this.pic0_DragDrop);
            this.pic5.DragEnter += new System.Windows.Forms.DragEventHandler(this.pic0_DragEnter);
            // 
            // pic6
            // 
            this.pic6.AllowDrop = true;
            this.pic6.BackColor = System.Drawing.Color.Transparent;
            this.pic6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic6.Location = new System.Drawing.Point(576, 37);
            this.pic6.Name = "pic6";
            this.pic6.Size = new System.Drawing.Size(76, 76);
            this.pic6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic6.TabIndex = 17;
            this.pic6.TabStop = false;
            this.pic6.DragDrop += new System.Windows.Forms.DragEventHandler(this.pic0_DragDrop);
            this.pic6.DragEnter += new System.Windows.Forms.DragEventHandler(this.pic0_DragEnter);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 70;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FormJuego
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1067, 626);
            this.Controls.Add(this.pic6);
            this.Controls.Add(this.pic5);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.pic0);
            this.Controls.Add(this.picRoja);
            this.Controls.Add(this.picAmarilla);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlTablero);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormJuego";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAmarilla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRoja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picAmarilla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtJug1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJug2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlTablero;
        private System.Windows.Forms.PictureBox picRoja;
        private System.Windows.Forms.PictureBox pic0;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.PictureBox pic6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

