namespace GUIClientes
{
    partial class IngresarCredito
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
            this.textBoxIDCredito = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIDCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMontoTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFechaInicio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFechaVencimiento = new System.Windows.Forms.TextBox();
            this.BotonIngresar = new System.Windows.Forms.Button();
            this.textBoxSalida = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Credito: ";
            // 
            // textBoxIDCredito
            // 
            this.textBoxIDCredito.Location = new System.Drawing.Point(124, 38);
            this.textBoxIDCredito.Name = "textBoxIDCredito";
            this.textBoxIDCredito.Size = new System.Drawing.Size(206, 20);
            this.textBoxIDCredito.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id cliente: ";
            // 
            // textBoxIDCliente
            // 
            this.textBoxIDCliente.Location = new System.Drawing.Point(133, 90);
            this.textBoxIDCliente.Name = "textBoxIDCliente";
            this.textBoxIDCliente.Size = new System.Drawing.Size(139, 20);
            this.textBoxIDCliente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Monto Total: ";
            // 
            // textBoxMontoTotal
            // 
            this.textBoxMontoTotal.Location = new System.Drawing.Point(133, 148);
            this.textBoxMontoTotal.Name = "textBoxMontoTotal";
            this.textBoxMontoTotal.Size = new System.Drawing.Size(139, 20);
            this.textBoxMontoTotal.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de Inicio: ";
            // 
            // textBoxFechaInicio
            // 
            this.textBoxFechaInicio.Location = new System.Drawing.Point(155, 198);
            this.textBoxFechaInicio.Name = "textBoxFechaInicio";
            this.textBoxFechaInicio.Size = new System.Drawing.Size(100, 20);
            this.textBoxFechaInicio.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha de Vencimiento: ";
            // 
            // textBoxFechaVencimiento
            // 
            this.textBoxFechaVencimiento.Location = new System.Drawing.Point(190, 254);
            this.textBoxFechaVencimiento.Name = "textBoxFechaVencimiento";
            this.textBoxFechaVencimiento.Size = new System.Drawing.Size(100, 20);
            this.textBoxFechaVencimiento.TabIndex = 9;
            // 
            // BotonIngresar
            // 
            this.BotonIngresar.Location = new System.Drawing.Point(485, 38);
            this.BotonIngresar.Name = "BotonIngresar";
            this.BotonIngresar.Size = new System.Drawing.Size(100, 47);
            this.BotonIngresar.TabIndex = 10;
            this.BotonIngresar.Text = "Ingresar";
            this.BotonIngresar.UseVisualStyleBackColor = true;
            this.BotonIngresar.Click += new System.EventHandler(this.BotonIngresar_Click);
            // 
            // textBoxSalida
            // 
            this.textBoxSalida.Location = new System.Drawing.Point(476, 166);
            this.textBoxSalida.Multiline = true;
            this.textBoxSalida.Name = "textBoxSalida";
            this.textBoxSalida.Size = new System.Drawing.Size(279, 232);
            this.textBoxSalida.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Estado: ";
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.Location = new System.Drawing.Point(124, 310);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.Size = new System.Drawing.Size(100, 20);
            this.textBoxEstado.TabIndex = 15;
            // 
            // IngresarCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxSalida);
            this.Controls.Add(this.BotonIngresar);
            this.Controls.Add(this.textBoxFechaVencimiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFechaInicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMontoTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxIDCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIDCredito);
            this.Controls.Add(this.label1);
            this.Name = "IngresarCredito";
            this.Text = "IngresarCredito";
            this.Load += new System.EventHandler(this.IngresarCredito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIDCredito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIDCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMontoTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFechaInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFechaVencimiento;
        private System.Windows.Forms.Button BotonIngresar;
        private System.Windows.Forms.TextBox textBoxSalida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxEstado;
    }
}