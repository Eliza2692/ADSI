namespace Biblioteca.Formularios
{
    partial class frmMenuInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuInicial));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemplaresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaBásicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbEjemplares = new System.Windows.Forms.ToolStripButton();
            this.tsbCategorias = new System.Windows.Forms.ToolStripButton();
            this.tsbFormato = new System.Windows.Forms.ToolStripButton();
            this.tsbUsuario = new System.Windows.Forms.ToolStripButton();
            this.tsbBusqueda = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónToolStripMenuItem,
            this.busquedaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(586, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestiónToolStripMenuItem
            // 
            this.gestiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejemplaresToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.formatosToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.gestiónToolStripMenuItem.Name = "gestiónToolStripMenuItem";
            this.gestiónToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gestiónToolStripMenuItem.Text = "Gestión";
            // 
            // ejemplaresToolStripMenuItem
            // 
            this.ejemplaresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ejemplaresToolStripMenuItem.Image")));
            this.ejemplaresToolStripMenuItem.Name = "ejemplaresToolStripMenuItem";
            this.ejemplaresToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.ejemplaresToolStripMenuItem.Text = "Ejemplares";
            this.ejemplaresToolStripMenuItem.Click += new System.EventHandler(this.ejemplaresToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("categoriasToolStripMenuItem.Image")));
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.categoriasToolStripMenuItem.Text = "Categorías";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // formatosToolStripMenuItem
            // 
            this.formatosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("formatosToolStripMenuItem.Image")));
            this.formatosToolStripMenuItem.Name = "formatosToolStripMenuItem";
            this.formatosToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.formatosToolStripMenuItem.Text = "Formatos";
            this.formatosToolStripMenuItem.Click += new System.EventHandler(this.formatosToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuariosToolStripMenuItem.Image")));
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // busquedaToolStripMenuItem
            // 
            this.busquedaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.busquedaBásicaToolStripMenuItem});
            this.busquedaToolStripMenuItem.Name = "busquedaToolStripMenuItem";
            this.busquedaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.busquedaToolStripMenuItem.Text = "Busqueda";
            // 
            // busquedaBásicaToolStripMenuItem
            // 
            this.busquedaBásicaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("busquedaBásicaToolStripMenuItem.Image")));
            this.busquedaBásicaToolStripMenuItem.Name = "busquedaBásicaToolStripMenuItem";
            this.busquedaBásicaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.busquedaBásicaToolStripMenuItem.Text = "Busqueda Básica";
            this.busquedaBásicaToolStripMenuItem.Click += new System.EventHandler(this.busquedaBásicaToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEjemplares,
            this.tsbCategorias,
            this.tsbFormato,
            this.tsbUsuario,
            this.tsbBusqueda});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(586, 57);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbEjemplares
            // 
            this.tsbEjemplares.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEjemplares.Image = ((System.Drawing.Image)(resources.GetObject("tsbEjemplares.Image")));
            this.tsbEjemplares.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEjemplares.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEjemplares.Name = "tsbEjemplares";
            this.tsbEjemplares.Size = new System.Drawing.Size(54, 54);
            this.tsbEjemplares.Text = "Gestión de Ejemplares";
            this.tsbEjemplares.Click += new System.EventHandler(this.tsbEjemplares_Click);
            // 
            // tsbCategorias
            // 
            this.tsbCategorias.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCategorias.Image = ((System.Drawing.Image)(resources.GetObject("tsbCategorias.Image")));
            this.tsbCategorias.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCategorias.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCategorias.Name = "tsbCategorias";
            this.tsbCategorias.Size = new System.Drawing.Size(54, 54);
            this.tsbCategorias.Text = "Gestion de Categoría";
            this.tsbCategorias.Click += new System.EventHandler(this.tsbCategorias_Click);
            // 
            // tsbFormato
            // 
            this.tsbFormato.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFormato.Image = ((System.Drawing.Image)(resources.GetObject("tsbFormato.Image")));
            this.tsbFormato.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbFormato.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFormato.Name = "tsbFormato";
            this.tsbFormato.Size = new System.Drawing.Size(54, 54);
            this.tsbFormato.Text = "Gestión de Formato";
            this.tsbFormato.Click += new System.EventHandler(this.tsbFormato_Click);
            // 
            // tsbUsuario
            // 
            this.tsbUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUsuario.Image = ((System.Drawing.Image)(resources.GetObject("tsbUsuario.Image")));
            this.tsbUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUsuario.Name = "tsbUsuario";
            this.tsbUsuario.Size = new System.Drawing.Size(54, 54);
            this.tsbUsuario.Text = "Gestión de Usuario";
            this.tsbUsuario.Click += new System.EventHandler(this.tsbUsuario_Click);
            // 
            // tsbBusqueda
            // 
            this.tsbBusqueda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBusqueda.Image = ((System.Drawing.Image)(resources.GetObject("tsbBusqueda.Image")));
            this.tsbBusqueda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbBusqueda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBusqueda.Name = "tsbBusqueda";
            this.tsbBusqueda.Size = new System.Drawing.Size(54, 54);
            this.tsbBusqueda.Text = "Busqueda Básica";
            this.tsbBusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbBusqueda.Click += new System.EventHandler(this.tsbBusqueda_Click);
            // 
            // frmMenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(586, 443);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMenuInicial";
            this.Text = "Biblioteca Esperanza - MenuInicial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenuInicial_FormClosing);
            this.Load += new System.EventHandler(this.frmMenuInicial_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejemplaresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaBásicaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbEjemplares;
        private System.Windows.Forms.ToolStripButton tsbCategorias;
        private System.Windows.Forms.ToolStripButton tsbFormato;
        private System.Windows.Forms.ToolStripButton tsbUsuario;
        private System.Windows.Forms.ToolStripButton tsbBusqueda;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}