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
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeAutoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeEditorialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(527, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDeAutoresToolStripMenuItem,
            this.gestiónDeCategoriasToolStripMenuItem,
            this.gestiónDeEditorialesToolStripMenuItem,
            this.gestiónDeLibrosToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // gestiónDeAutoresToolStripMenuItem
            // 
            this.gestiónDeAutoresToolStripMenuItem.Name = "gestiónDeAutoresToolStripMenuItem";
            this.gestiónDeAutoresToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.gestiónDeAutoresToolStripMenuItem.Text = "Gestión de Autores";
            // 
            // gestiónDeCategoriasToolStripMenuItem
            // 
            this.gestiónDeCategoriasToolStripMenuItem.Name = "gestiónDeCategoriasToolStripMenuItem";
            this.gestiónDeCategoriasToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.gestiónDeCategoriasToolStripMenuItem.Text = "Gestión de Categorias";
            this.gestiónDeCategoriasToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeCategoriasToolStripMenuItem_Click);
            // 
            // gestiónDeEditorialesToolStripMenuItem
            // 
            this.gestiónDeEditorialesToolStripMenuItem.Name = "gestiónDeEditorialesToolStripMenuItem";
            this.gestiónDeEditorialesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.gestiónDeEditorialesToolStripMenuItem.Text = "Gestión de Editoriales";
            // 
            // gestiónDeLibrosToolStripMenuItem
            // 
            this.gestiónDeLibrosToolStripMenuItem.Name = "gestiónDeLibrosToolStripMenuItem";
            this.gestiónDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.gestiónDeLibrosToolStripMenuItem.Text = "Gestión de Libros";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 404);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeAutoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeCategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeEditorialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeLibrosToolStripMenuItem;
    }
}

