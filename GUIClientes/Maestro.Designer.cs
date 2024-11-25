namespace GUIClientes
{
    partial class Maestro
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
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCodigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreAcreedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarCreditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retirarCreditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarDatosCreditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarPagoDeCuotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vistaWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem,
            this.actualizaciónToolStripMenuItem,
            this.novedadesToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.consultaWebToolStripMenuItem,
            this.vistaWebToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porCodigoToolStripMenuItem,
            this.nombreAcreedoresToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // porCodigoToolStripMenuItem
            // 
            this.porCodigoToolStripMenuItem.Name = "porCodigoToolStripMenuItem";
            this.porCodigoToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.porCodigoToolStripMenuItem.Text = "Por Codigo";
            this.porCodigoToolStripMenuItem.Click += new System.EventHandler(this.porCodigoToolStripMenuItem_Click);
            // 
            // nombreAcreedoresToolStripMenuItem
            // 
            this.nombreAcreedoresToolStripMenuItem.Name = "nombreAcreedoresToolStripMenuItem";
            this.nombreAcreedoresToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.nombreAcreedoresToolStripMenuItem.Text = "Nombre Acreedores";
            this.nombreAcreedoresToolStripMenuItem.Click += new System.EventHandler(this.nombreAcreedoresToolStripMenuItem_Click);
            // 
            // actualizaciónToolStripMenuItem
            // 
            this.actualizaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarCreditoToolStripMenuItem,
            this.retirarCreditoToolStripMenuItem,
            this.cambiarDatosCreditoToolStripMenuItem});
            this.actualizaciónToolStripMenuItem.Name = "actualizaciónToolStripMenuItem";
            this.actualizaciónToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.actualizaciónToolStripMenuItem.Text = "Actualización";
            // 
            // ingresarCreditoToolStripMenuItem
            // 
            this.ingresarCreditoToolStripMenuItem.Name = "ingresarCreditoToolStripMenuItem";
            this.ingresarCreditoToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.ingresarCreditoToolStripMenuItem.Text = "Ingresar Credito";
            this.ingresarCreditoToolStripMenuItem.Click += new System.EventHandler(this.ingresarCreditoToolStripMenuItem_Click);
            // 
            // retirarCreditoToolStripMenuItem
            // 
            this.retirarCreditoToolStripMenuItem.Name = "retirarCreditoToolStripMenuItem";
            this.retirarCreditoToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.retirarCreditoToolStripMenuItem.Text = "Retirar Credito";
            this.retirarCreditoToolStripMenuItem.Click += new System.EventHandler(this.retirarCreditoToolStripMenuItem_Click);
            // 
            // cambiarDatosCreditoToolStripMenuItem
            // 
            this.cambiarDatosCreditoToolStripMenuItem.Name = "cambiarDatosCreditoToolStripMenuItem";
            this.cambiarDatosCreditoToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.cambiarDatosCreditoToolStripMenuItem.Text = "Cambiar Datos Credito";
            this.cambiarDatosCreditoToolStripMenuItem.Click += new System.EventHandler(this.cambiarDatosCreditoToolStripMenuItem_Click);
            // 
            // novedadesToolStripMenuItem
            // 
            this.novedadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarPagoDeCuotaToolStripMenuItem});
            this.novedadesToolStripMenuItem.Name = "novedadesToolStripMenuItem";
            this.novedadesToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.novedadesToolStripMenuItem.Text = "Novedades";
            // 
            // realizarPagoDeCuotaToolStripMenuItem
            // 
            this.realizarPagoDeCuotaToolStripMenuItem.Name = "realizarPagoDeCuotaToolStripMenuItem";
            this.realizarPagoDeCuotaToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.realizarPagoDeCuotaToolStripMenuItem.Text = "Realizar pago de cuota";
            this.realizarPagoDeCuotaToolStripMenuItem.Click += new System.EventHandler(this.realizarPagoDeCuotaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // consultaWebToolStripMenuItem
            // 
            this.consultaWebToolStripMenuItem.Name = "consultaWebToolStripMenuItem";
            this.consultaWebToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.consultaWebToolStripMenuItem.Text = "Maestro-Detalle Web";
            this.consultaWebToolStripMenuItem.Click += new System.EventHandler(this.consultaWebToolStripMenuItem_Click);
            // 
            // vistaWebToolStripMenuItem
            // 
            this.vistaWebToolStripMenuItem.Name = "vistaWebToolStripMenuItem";
            this.vistaWebToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.vistaWebToolStripMenuItem.Text = "Vista Web";
            this.vistaWebToolStripMenuItem.Click += new System.EventHandler(this.vistaWebToolStripMenuItem_Click);
            // 
            // Maestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Maestro";
            this.Text = "Maestro";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem porCodigoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem nombreAcreedoresToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem actualizaciónToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ingresarCreditoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem retirarCreditoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem cambiarDatosCreditoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem novedadesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem realizarPagoDeCuotaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem consultaWebToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem vistaWebToolStripMenuItem;
    }
}