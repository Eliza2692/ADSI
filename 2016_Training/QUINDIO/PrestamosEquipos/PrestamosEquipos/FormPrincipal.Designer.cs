namespace PrestamosEquipos
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudDePrestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDePrestamosYoDevolucionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposMàsUtilizadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiantesQueMásSolicitanEquiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposDañadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeAlertasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresosToolStripMenuItem,
            this.prestamosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(546, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudiantesToolStripMenuItem,
            this.equiposToolStripMenuItem});
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ingresosToolStripMenuItem.Text = "Ingresos";
            // 
            // estudiantesToolStripMenuItem
            // 
            this.estudiantesToolStripMenuItem.Name = "estudiantesToolStripMenuItem";
            this.estudiantesToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.estudiantesToolStripMenuItem.Text = "Estudiantes";
            this.estudiantesToolStripMenuItem.Click += new System.EventHandler(this.estudiantesToolStripMenuItem_Click);
            // 
            // equiposToolStripMenuItem
            // 
            this.equiposToolStripMenuItem.Name = "equiposToolStripMenuItem";
            this.equiposToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.equiposToolStripMenuItem.Text = "Equipos";
            this.equiposToolStripMenuItem.Click += new System.EventHandler(this.equiposToolStripMenuItem_Click);
            // 
            // prestamosToolStripMenuItem
            // 
            this.prestamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solicitudDePrestamosToolStripMenuItem,
            this.registroDePrestamosYoDevolucionesToolStripMenuItem});
            this.prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            this.prestamosToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.prestamosToolStripMenuItem.Text = "Préstamos";            
            // 
            // solicitudDePrestamosToolStripMenuItem
            // 
            this.solicitudDePrestamosToolStripMenuItem.Name = "solicitudDePrestamosToolStripMenuItem";
            this.solicitudDePrestamosToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.solicitudDePrestamosToolStripMenuItem.Text = "Solicitud de préstamos";
            this.solicitudDePrestamosToolStripMenuItem.Click += new System.EventHandler(this.solicitudDePrestamosToolStripMenuItem_Click);
            // 
            // registroDePrestamosYoDevolucionesToolStripMenuItem
            // 
            this.registroDePrestamosYoDevolucionesToolStripMenuItem.Name = "registroDePrestamosYoDevolucionesToolStripMenuItem";
            this.registroDePrestamosYoDevolucionesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.registroDePrestamosYoDevolucionesToolStripMenuItem.Text = "Devoluciones";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equiposMàsUtilizadosToolStripMenuItem,
            this.estudiantesQueMásSolicitanEquiposToolStripMenuItem,
            this.equiposDañadosToolStripMenuItem,
            this.reportesDeAlertasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // equiposMàsUtilizadosToolStripMenuItem
            // 
            this.equiposMàsUtilizadosToolStripMenuItem.Name = "equiposMàsUtilizadosToolStripMenuItem";
            this.equiposMàsUtilizadosToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.equiposMàsUtilizadosToolStripMenuItem.Text = "Equipos màs utilizados";
            // 
            // estudiantesQueMásSolicitanEquiposToolStripMenuItem
            // 
            this.estudiantesQueMásSolicitanEquiposToolStripMenuItem.Name = "estudiantesQueMásSolicitanEquiposToolStripMenuItem";
            this.estudiantesQueMásSolicitanEquiposToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.estudiantesQueMásSolicitanEquiposToolStripMenuItem.Text = "Estudiantes que más solicitan equipos";
            // 
            // equiposDañadosToolStripMenuItem
            // 
            this.equiposDañadosToolStripMenuItem.Name = "equiposDañadosToolStripMenuItem";
            this.equiposDañadosToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.equiposDañadosToolStripMenuItem.Text = "Equipos Dañados";
            // 
            // reportesDeAlertasToolStripMenuItem
            // 
            this.reportesDeAlertasToolStripMenuItem.Name = "reportesDeAlertasToolStripMenuItem";
            this.reportesDeAlertasToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.reportesDeAlertasToolStripMenuItem.Text = "Reportes de alertas";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 380);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.Text = "Prestamo de equipos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitudDePrestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDePrestamosYoDevolucionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equiposMàsUtilizadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudiantesQueMásSolicitanEquiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equiposDañadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesDeAlertasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}