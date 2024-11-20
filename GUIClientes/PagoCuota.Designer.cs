namespace GUIClientes
{
    partial class PagoCuota
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
            this.textBoxIdCredito = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPagoID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFechaPago = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMontoPagado = new System.Windows.Forms.TextBox();
            this.BotonConfirmar = new System.Windows.Forms.Button();
            this.textBoxSalida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id del credito: ";
            // 
            // textBoxIdCredito
            // 
            this.textBoxIdCredito.Location = new System.Drawing.Point(146, 28);
            this.textBoxIdCredito.Name = "textBoxIdCredito";
            this.textBoxIdCredito.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdCredito.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id del pago: ";
            // 
            // textBoxPagoID
            // 
            this.textBoxPagoID.Location = new System.Drawing.Point(146, 82);
            this.textBoxPagoID.Name = "textBoxPagoID";
            this.textBoxPagoID.Size = new System.Drawing.Size(100, 20);
            this.textBoxPagoID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha del pago: ";
            // 
            // textBoxFechaPago
            // 
            this.textBoxFechaPago.Location = new System.Drawing.Point(146, 140);
            this.textBoxFechaPago.Name = "textBoxFechaPago";
            this.textBoxFechaPago.Size = new System.Drawing.Size(100, 20);
            this.textBoxFechaPago.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Monto Pagado: ";
            // 
            // textBoxMontoPagado
            // 
            this.textBoxMontoPagado.Location = new System.Drawing.Point(157, 198);
            this.textBoxMontoPagado.Name = "textBoxMontoPagado";
            this.textBoxMontoPagado.Size = new System.Drawing.Size(100, 20);
            this.textBoxMontoPagado.TabIndex = 7;
            // 
            // BotonConfirmar
            // 
            this.BotonConfirmar.Location = new System.Drawing.Point(482, 41);
            this.BotonConfirmar.Name = "BotonConfirmar";
            this.BotonConfirmar.Size = new System.Drawing.Size(102, 54);
            this.BotonConfirmar.TabIndex = 8;
            this.BotonConfirmar.Text = "Confirmar Pago";
            this.BotonConfirmar.UseVisualStyleBackColor = true;
            this.BotonConfirmar.Click += new System.EventHandler(this.BotonConfirmar_Click);
            // 
            // textBoxSalida
            // 
            this.textBoxSalida.Location = new System.Drawing.Point(452, 167);
            this.textBoxSalida.Multiline = true;
            this.textBoxSalida.Name = "textBoxSalida";
            this.textBoxSalida.Size = new System.Drawing.Size(277, 241);
            this.textBoxSalida.TabIndex = 9;
            // 
            // PagoCuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxSalida);
            this.Controls.Add(this.BotonConfirmar);
            this.Controls.Add(this.textBoxMontoPagado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFechaPago);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPagoID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIdCredito);
            this.Controls.Add(this.label1);
            this.Name = "PagoCuota";
            this.Text = "PagoCuota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdCredito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPagoID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFechaPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMontoPagado;
        private System.Windows.Forms.Button BotonConfirmar;
        private System.Windows.Forms.TextBox textBoxSalida;
    }
}