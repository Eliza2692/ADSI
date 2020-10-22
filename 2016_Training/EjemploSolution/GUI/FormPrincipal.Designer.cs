namespace GUI
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestiónAutoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónAutoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónCategoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónEditorialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónAutoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(701, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestiónAutoresToolStripMenuItem
            // 
            this.gestiónAutoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónAutoresToolStripMenuItem1,
            this.gestiónCategoríasToolStripMenuItem,
            this.gestiónEditorialesToolStripMenuItem,
            this.gestiónLibrosToolStripMenuItem});
            this.gestiónAutoresToolStripMenuItem.Name = "gestiónAutoresToolStripMenuItem";
            this.gestiónAutoresToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.gestiónAutoresToolStripMenuItem.Text = "Opciones";
            // 
            // gestiónAutoresToolStripMenuItem1
            // 
            this.gestiónAutoresToolStripMenuItem1.Name = "gestiónAutoresToolStripMenuItem1";
            this.gestiónAutoresToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.gestiónAutoresToolStripMenuItem1.Text = "Gestión Autores";
            this.gestiónAutoresToolStripMenuItem1.Click += new System.EventHandler(this.gestiónAutoresToolStripMenuItem1_Click);
            // 
            // gestiónCategoríasToolStripMenuItem
            // 
            this.gestiónCategoríasToolStripMenuItem.Name = "gestiónCategoríasToolStripMenuItem";
            this.gestiónCategoríasToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.gestiónCategoríasToolStripMenuItem.Text = "Gestión Categorías";
            this.gestiónCategoríasToolStripMenuItem.Click += new System.EventHandler(this.gestiónCategoríasToolStripMenuItem_Click);
            // 
            // gestiónEditorialesToolStripMenuItem
            // 
            this.gestiónEditorialesToolStripMenuItem.Name = "gestiónEditorialesToolStripMenuItem";
            this.gestiónEditorialesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.gestiónEditorialesToolStripMenuItem.Text = "Gestión Editoriales";
            this.gestiónEditorialesToolStripMenuItem.Click += new System.EventHandler(this.gestiónEditorialesToolStripMenuItem_Click);
            // 
            // gestiónLibrosToolStripMenuItem
            // 
            this.gestiónLibrosToolStripMenuItem.Name = "gestiónLibrosToolStripMenuItem";
            this.gestiónLibrosToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.gestiónLibrosToolStripMenuItem.Text = "Gestión Libros";
            this.gestiónLibrosToolStripMenuItem.Click += new System.EventHandler(this.gestiónLibrosToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 510);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Formulario Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestiónAutoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónAutoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestiónCategoríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónEditorialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónLibrosToolStripMenuItem;
    }
}

