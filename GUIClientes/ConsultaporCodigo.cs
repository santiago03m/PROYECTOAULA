using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;
using System.Security.Policy;

namespace GUIClientes
{
    public partial class ConsultaporCodigo : Form
    {
        string url = "http://localhost:55421/api/Cliente";
        public ConsultaporCodigo()
        {
            InitializeComponent();
        }

        private void Maestro_Load(object sender, EventArgs e)
        {

        }

        private void BotonConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                string jsonResponse = DBapi.Get(url).ToString();
                var clientes = JsonConvert.DeserializeObject<List<dynamic>>(jsonResponse);
                var clienteEncontrado = clientes.FirstOrDefault(c => c.ID_Cliente.ToString() == textBoxCodigo.Text);

                if (clienteEncontrado != null)
                {
                    textBoxNombre.Text = clienteEncontrado.Nombre;
                    textBoxApellido.Text = clienteEncontrado.Apellido;
                    textBoxDireccion.Text = clienteEncontrado.Direccion;
                    textBoxTelefono.Text = clienteEncontrado.Telefono;
                    textBoxCorreo.Text = clienteEncontrado.Correo_Electronico;
                    textBoxFechaRegistro.Text = DateTime.Parse(clienteEncontrado.Fecha_Registro.ToString()).ToString("yyyy-MM-dd");
                    textBoxSalida.Text = "El cliente existe.";
                }
                else
                {
                   textBoxSalida.Text = "No existe el cliente con el código especificado.";
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
