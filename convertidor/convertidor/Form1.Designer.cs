namespace convertidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxDE = new System.Windows.Forms.ComboBox();
            this.comboBoxA = new System.Windows.Forms.ComboBox();
            this.TxtDE = new System.Windows.Forms.TextBox();
            this.TxtA = new System.Windows.Forms.TextBox();
            this.BtnConvertir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxDE
            // 
            this.comboBoxDE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDE.FormattingEnabled = true;
            this.comboBoxDE.Items.AddRange(new object[] {
            "Binario",
            "Decimal",
            "Hexadecimal",
            "Octal"});
            this.comboBoxDE.Location = new System.Drawing.Point(64, 127);
            this.comboBoxDE.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.comboBoxDE.Name = "comboBoxDE";
            this.comboBoxDE.Size = new System.Drawing.Size(151, 26);
            this.comboBoxDE.Sorted = true;
            this.comboBoxDE.TabIndex = 0;
            // 
            // comboBoxA
            // 
            this.comboBoxA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxA.FormattingEnabled = true;
            this.comboBoxA.Items.AddRange(new object[] {
            "Binario",
            "Decimal",
            "Hexadecimal",
            "Octal"});
            this.comboBoxA.Location = new System.Drawing.Point(252, 127);
            this.comboBoxA.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.comboBoxA.Name = "comboBoxA";
            this.comboBoxA.Size = new System.Drawing.Size(148, 26);
            this.comboBoxA.Sorted = true;
            this.comboBoxA.TabIndex = 1;
            // 
            // TxtDE
            // 
            this.TxtDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDE.Location = new System.Drawing.Point(31, 76);
            this.TxtDE.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtDE.Name = "TxtDE";
            this.TxtDE.Size = new System.Drawing.Size(369, 29);
            this.TxtDE.TabIndex = 2;
            this.TxtDE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtA
            // 
            this.TxtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtA.Location = new System.Drawing.Point(31, 242);
            this.TxtA.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtA.Name = "TxtA";
            this.TxtA.Size = new System.Drawing.Size(369, 29);
            this.TxtA.TabIndex = 3;
            this.TxtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnConvertir
            // 
            this.BtnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConvertir.Location = new System.Drawing.Point(121, 182);
            this.BtnConvertir.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BtnConvertir.Name = "BtnConvertir";
            this.BtnConvertir.Size = new System.Drawing.Size(174, 39);
            this.BtnConvertir.TabIndex = 4;
            this.BtnConvertir.Text = "Convertir";
            this.BtnConvertir.UseVisualStyleBackColor = true;
            this.BtnConvertir.Click += new System.EventHandler(this.BtnConvertir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(115, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "CONVERTIR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(27, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "De";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(223, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "a";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(433, 300);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnConvertir);
            this.Controls.Add(this.TxtA);
            this.Controls.Add(this.TxtDE);
            this.Controls.Add(this.comboBoxA);
            this.Controls.Add(this.comboBoxDE);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Convertir";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDE;
        private System.Windows.Forms.ComboBox comboBoxA;
        private System.Windows.Forms.TextBox TxtDE;
        private System.Windows.Forms.TextBox TxtA;
        private System.Windows.Forms.Button BtnConvertir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

