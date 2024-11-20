namespace GUIClientes
{
    partial class RetirarCredito
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
            this.BotonConsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIDCredito = new System.Windows.Forms.TextBox();
            this.EliminarCredito = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIDCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMontoTotal = new System.Windows.Forms.TextBox();
            this.textBoxSalida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BotonConsultar
            // 
            this.BotonConsultar.Location = new System.Drawing.Point(581, 57);
            this.BotonConsultar.Name = "BotonConsultar";
            this.BotonConsultar.Size = new System.Drawing.Size(81, 32);
            this.BotonConsultar.TabIndex = 0;
            this.BotonConsultar.Text = "Consultar";
            this.BotonConsultar.UseVisualStyleBackColor = true;
            this.BotonConsultar.Click += new System.EventHandler(this.BotonConsultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id del credito: ";
            // 
            // textBoxIDCredito
            // 
            this.textBoxIDCredito.Location = new System.Drawing.Point(161, 31);
            this.textBoxIDCredito.Name = "textBoxIDCredito";
            this.textBoxIDCredito.Size = new System.Drawing.Size(100, 20);
            this.textBoxIDCredito.TabIndex = 2;
            // 
            // EliminarCredito
            // 
            this.EliminarCredito.Enabled = false;
            this.EliminarCredito.Location = new System.Drawing.Point(581, 111);
            this.EliminarCredito.Name = "EliminarCredito";
            this.EliminarCredito.Size = new System.Drawing.Size(81, 32);
            this.EliminarCredito.TabIndex = 3;
            this.EliminarCredito.Text = "Eliminar";
            this.EliminarCredito.UseVisualStyleBackColor = true;
            this.EliminarCredito.Click += new System.EventHandler(this.EliminarCredito_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID del cliente: ";
            // 
            // textBoxIDCliente
            // 
            this.textBoxIDCliente.Location = new System.Drawing.Point(161, 75);
            this.textBoxIDCliente.Name = "textBoxIDCliente";
            this.textBoxIDCliente.Size = new System.Drawing.Size(100, 20);
            this.textBoxIDCliente.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Monto Total: ";
            // 
            // textBoxMontoTotal
            // 
            this.textBoxMontoTotal.Location = new System.Drawing.Point(142, 135);
            this.textBoxMontoTotal.Name = "textBoxMontoTotal";
            this.textBoxMontoTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxMontoTotal.TabIndex = 7;
            // 
            // textBoxSalida
            // 
            this.textBoxSalida.Location = new System.Drawing.Point(319, 229);
            this.textBoxSalida.Multiline = true;
            this.textBoxSalida.Name = "textBoxSalida";
            this.textBoxSalida.Size = new System.Drawing.Size(243, 133);
            this.textBoxSalida.TabIndex = 8;
            // 
            // RetirarCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxSalida);
            this.Controls.Add(this.textBoxMontoTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxIDCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EliminarCredito);
            this.Controls.Add(this.textBoxIDCredito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotonConsultar);
            this.Name = "RetirarCredito";
            this.Text = "RetirarCredito";
            this.Load += new System.EventHandler(this.RetirarCredito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIDCredito;
        private System.Windows.Forms.Button EliminarCredito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIDCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMontoTotal;
        private System.Windows.Forms.TextBox textBoxSalida;
    }
}