namespace GUIClientes
{
    partial class CambiarDatosCreditos
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
            this.textBoxCodigoCredito = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCodigoCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMontoTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFechaInicio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFechaVencimiento = new System.Windows.Forms.TextBox();
            this.BotonConsultar = new System.Windows.Forms.Button();
            this.textBoxSalida = new System.Windows.Forms.TextBox();
            this.BotonModificar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Credito: ";
            // 
            // textBoxCodigoCredito
            // 
            this.textBoxCodigoCredito.Location = new System.Drawing.Point(147, 35);
            this.textBoxCodigoCredito.Name = "textBoxCodigoCredito";
            this.textBoxCodigoCredito.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoCredito.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo Cliente: ";
            // 
            // textBoxCodigoCliente
            // 
            this.textBoxCodigoCliente.Location = new System.Drawing.Point(156, 82);
            this.textBoxCodigoCliente.Name = "textBoxCodigoCliente";
            this.textBoxCodigoCliente.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoCliente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Monto Total: ";
            // 
            // textBoxMontoTotal
            // 
            this.textBoxMontoTotal.Location = new System.Drawing.Point(147, 131);
            this.textBoxMontoTotal.Name = "textBoxMontoTotal";
            this.textBoxMontoTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxMontoTotal.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de inicio(YYYY-MM-DD): ";
            // 
            // textBoxFechaInicio
            // 
            this.textBoxFechaInicio.Location = new System.Drawing.Point(205, 179);
            this.textBoxFechaInicio.Name = "textBoxFechaInicio";
            this.textBoxFechaInicio.Size = new System.Drawing.Size(100, 20);
            this.textBoxFechaInicio.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha de Vencimiento(YYYY-MM-DD): ";
            // 
            // textBoxFechaVencimiento
            // 
            this.textBoxFechaVencimiento.Location = new System.Drawing.Point(239, 240);
            this.textBoxFechaVencimiento.Name = "textBoxFechaVencimiento";
            this.textBoxFechaVencimiento.Size = new System.Drawing.Size(100, 20);
            this.textBoxFechaVencimiento.TabIndex = 9;
            // 
            // BotonConsultar
            // 
            this.BotonConsultar.Location = new System.Drawing.Point(585, 35);
            this.BotonConsultar.Name = "BotonConsultar";
            this.BotonConsultar.Size = new System.Drawing.Size(96, 67);
            this.BotonConsultar.TabIndex = 10;
            this.BotonConsultar.Text = "Consultar";
            this.BotonConsultar.UseVisualStyleBackColor = true;
            this.BotonConsultar.Click += new System.EventHandler(this.BotonConsultar_Click);
            // 
            // textBoxSalida
            // 
            this.textBoxSalida.Location = new System.Drawing.Point(372, 288);
            this.textBoxSalida.Multiline = true;
            this.textBoxSalida.Name = "textBoxSalida";
            this.textBoxSalida.Size = new System.Drawing.Size(273, 119);
            this.textBoxSalida.TabIndex = 11;
            // 
            // BotonModificar
            // 
            this.BotonModificar.Enabled = false;
            this.BotonModificar.Location = new System.Drawing.Point(585, 151);
            this.BotonModificar.Name = "BotonModificar";
            this.BotonModificar.Size = new System.Drawing.Size(96, 69);
            this.BotonModificar.TabIndex = 12;
            this.BotonModificar.Text = "Modificar";
            this.BotonModificar.UseVisualStyleBackColor = true;
            this.BotonModificar.Click += new System.EventHandler(this.BotonModificar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Estado: ";
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.Location = new System.Drawing.Point(124, 338);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.Size = new System.Drawing.Size(100, 20);
            this.textBoxEstado.TabIndex = 16;
            this.textBoxEstado.Text = "Activo";
            // 
            // CambiarDatosCreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BotonModificar);
            this.Controls.Add(this.textBoxSalida);
            this.Controls.Add(this.BotonConsultar);
            this.Controls.Add(this.textBoxFechaVencimiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFechaInicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMontoTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCodigoCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCodigoCredito);
            this.Controls.Add(this.label1);
            this.Name = "CambiarDatosCreditos";
            this.Text = "CambiarDatosCreditos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodigoCredito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCodigoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMontoTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFechaInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFechaVencimiento;
        private System.Windows.Forms.Button BotonConsultar;
        private System.Windows.Forms.TextBox textBoxSalida;
        private System.Windows.Forms.Button BotonModificar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxEstado;
    }
}