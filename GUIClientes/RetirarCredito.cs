using CONECTOR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIClientes
{
    public partial class RetirarCredito : Form
    {
        public RetirarCredito()
        {
            InitializeComponent();
        }

        private void BotonConsultar_Click(object sender, EventArgs e)
        {
            string url = "http://localhost:55421/api/Creditos";
            try
            {
                string jsonResponse = DBapi.Get(url).ToString();
                var clientes = JsonConvert.DeserializeObject<List<dynamic>>(jsonResponse);
                var clienteEncontrado = clientes.FirstOrDefault(c => c.ID_Credito.ToString() == textBoxIDCredito.Text);

                if (clienteEncontrado != null)
                {
                    textBoxIDCliente.Text = clienteEncontrado.ID_Cliente;
                    textBoxMontoTotal.Text = clienteEncontrado.Monto_Total;
                    textBoxSalida.Text = "Se encontró el credito!";
                    EliminarCredito.Enabled = true;
                }
                else
                {
                    textBoxSalida.Text = "No existe el credito con el código especificado.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void EliminarCredito_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxIDCredito.Text))
                {
                    MessageBox.Show("El campo ID_Credito debe estar completo.");
                    return;
                }
                int idCredito = Int32.Parse(textBoxIDCredito.Text);
                string urlApi = "http://localhost:55421/api/Creditos";

                // Verificar si el monto total es 0 antes de eliminar
                string consultaUrl = urlApi + "/" + idCredito;
                string jsonResponse = DBapi.Get(consultaUrl).ToString();
                var credito = JsonConvert.DeserializeObject<Credito>(jsonResponse);

                if (credito == null)
                {
                    MessageBox.Show("El crédito con el ID especificado no existe.");
                    return;
                }

                if (credito.Monto_Total == 0)
                {
                    bool resultado = DBapi.DeleteCredito(urlApi, idCredito);
                    if (resultado)
                    {
                        textBoxSalida.Text = "El crédito ha sido eliminado correctamente.";
                        textBoxIDCredito.Clear();
                    }
                    else
                    {
                        textBoxSalida.Text = "ERROR: No se ha podido eliminar el registro.";
                    }
                }
                else
                {
                    textBoxSalida.Text = "No se puede eliminar el crédito. El Monto Total debe ser 0.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void RetirarCredito_Load(object sender, EventArgs e)
        {

        }
    }
}
