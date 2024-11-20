using GUIClientes;
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
            string nombreUsuario = textBoxUsuario.Text;
            string contraseña = textBoxContrasena.Text;
            string rol = comboBoxRol.Text;

            try
            {
                List<Usuario> usuarios = DBAPI.Get(url);
                //si es cliente el browser a ConsultaCredito.aspx
                foreach (Usuario usuario in usuarios)
                {
                    if (nombreUsuario == usuario.Nombre_Usuario && contraseña == usuario.Contrasena && rol == usuario.Rol)
                    {
                        switch(rol){
                            case ("Administrador"):
                                Maestro menu = new Maestro();

                                menu.Show();
                                break;
                            case ("Taquillera"):
                                Maestro menu1 = new Maestro();
                                menu1.ingresarCreditoToolStripMenuItem.Enabled = false;
                                menu1.retirarCreditoToolStripMenuItem.Enabled = false;
                                menu1.cambiarDatosCreditoToolStripMenuItem.Enabled=false;
                                menu1.consultaWebToolStripMenuItem.Enabled=false;
                                menu1.vistaWebToolStripMenuItem.Enabled = false;
                                menu1.Show();
                                break;
                            case ("Cliente"):
                                ConsultaWeb consulta =  new ConsultaWeb();
                                consulta.Show();
                                break;

                        }
                    }
                    
                }
                

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
