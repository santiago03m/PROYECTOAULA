using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string url = "http://localhost:55421/api/Acceso";
        private void btIniciarSesion_Click(object sender, EventArgs e)
        {
            string nombreUsuario = textBox1.Text;
            string contraseña = textBox2.Text;
            string rol = comboBox1.Text;

            try
            {
                List<Usuario> usuarios = DBAPI.Get(url);
                //si es cliente el browser a ConsultaCredito.aspx
                foreach (var usuario in usuarios)
                {
                    if (nombreUsuario == usuario.Nombre_Usuario && contraseña == usuario.Contrasena && rol == usuario.Rol)
                    {

                    }
                }
                MessageBox.Show("El usuario no existe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
