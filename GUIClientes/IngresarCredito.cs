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
    public partial class IngresarCredito : Form
    {
        public IngresarCredito()
        {
            InitializeComponent();
        }

        private void BotonIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxIDCliente.Text) || string.IsNullOrEmpty(textBoxMontoTotal.Text) ||
                    string.IsNullOrEmpty(textBoxFechaInicio.Text) || string.IsNullOrEmpty(textBoxFechaVencimiento.Text) ||
                    string.IsNullOrEmpty(textBoxEstado.Text))
                {
                    MessageBox.Show("Todos los campos deben estar completos.");
                    return;
                }

                int montoTotal = 0;
                if (!Int32.TryParse(textBoxMontoTotal.Text, out montoTotal))
                {
                    MessageBox.Show("Monto Total debe ser un número válido.");
                    return;
                }

                DateTime fechaInicio, fechaVencimiento;
                if (!DateTime.TryParse(textBoxFechaInicio.Text, out fechaInicio) ||
                    !DateTime.TryParse(textBoxFechaVencimiento.Text, out fechaVencimiento))
                {
                    MessageBox.Show("Las fechas deben ser válidas.");
                    return;
                }

                Credito nuevoCredito = new Credito
                {
                    ID_Credito = Int32.Parse(textBoxIDCredito.Text),
                    ID_Cliente = Int32.Parse(textBoxIDCliente.Text),
                    Monto_Total = montoTotal,
                    Fecha_Inicio = fechaInicio,
                    Fecha_Vencimiento = fechaVencimiento,
                    Tasa_Interes = 10,
                    Estado = "Activo",
                    Cuotas = 10
                };

                string urlApi = "http://localhost:55421/api/Creditos/credito_nuevo";
                bool resultado = DBapi.CreateCredito(urlApi, nuevoCredito);

                if (resultado)
                {
                    textBoxSalida.Text = "Nuevo registro agregado correctamente.";
                }
                else
                {
                    MessageBox.Show("ERROR: No se ha podido agregar el registro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void IngresarCredito_Load(object sender, EventArgs e)
        {

        }
    }
}

