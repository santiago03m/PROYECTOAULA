namespace GUIClientes
{
    partial class ModificarCliente
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
            this.textBoxIDCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.BotonConsultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id cliente: ";
            // 
            // textBoxIDCliente
            // 
            this.textBoxIDCliente.Location = new System.Drawing.Point(156, 31);
            this.textBoxIDCliente.Name = "textBoxIDCliente";
            this.textBoxIDCliente.Size = new System.Drawing.Size(100, 20);
            this.textBoxIDCliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre: ";
            // 
            // textBoxNombreCliente
            // 
            this.textBoxNombreCliente.Location = new System.Drawing.Point(175, 81);
            this.textBoxNombreCliente.Name = "textBoxNombreCliente";
            this.textBoxNombreCliente.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombreCliente.TabIndex = 3;
            // 
            // BotonConsultar
            // 
            this.BotonConsultar.Location = new System.Drawing.Point(559, 51);
            this.BotonConsultar.Name = "BotonConsultar";
            this.BotonConsultar.Size = new System.Drawing.Size(75, 23);
            this.BotonConsultar.TabIndex = 4;
            this.BotonConsultar.Text = "Consultar";
            this.BotonConsultar.UseVisualStyleBackColor = true;
            this.BotonConsultar.Click += new System.EventHandler(this.BotonConsultar_Click);
            // 
            // ModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotonConsultar);
            this.Controls.Add(this.textBoxNombreCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIDCliente);
            this.Controls.Add(this.label1);
            this.Name = "ModificarCliente";
            this.Text = "ModificarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIDCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombreCliente;
        private System.Windows.Forms.Button BotonConsultar;
    }
}