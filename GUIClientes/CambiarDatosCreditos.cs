using CONECTOR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace GUIClientes
{
    public partial class CambiarDatosCreditos : Form
    {
        string url = "http://localhost:55421/api/Creditos";

        public CambiarDatosCreditos()
        {
            InitializeComponent();
        }
        SqlConnection objconexion = new SqlConnection("Data Source=localhost;Initial Catalog = LaQuiebraLTDA ; Integrated Security = SSPI; ");
       

        private void BotonConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                string jsonResponse = DBapi.Get(url).ToString();
                var clientes = JsonConvert.DeserializeObject<List<dynamic>>(jsonResponse);
                var clienteEncontrado = clientes.FirstOrDefault(c => c.ID_Cliente.ToString() == textBoxCodigoCredito.Text);

                if (clienteEncontrado != null)
                {
                    textBoxCodigoCliente.Text = clienteEncontrado.ID_Cliente;
                    textBoxMontoTotal.Text = clienteEncontrado.Monto_Total;
                    textBoxFechaInicio.Text = clienteEncontrado.Fecha_Inicio;
                    textBoxFechaVencimiento.Text = clienteEncontrado.Fecha_Vencimiento;
                    textBoxEstado.Text = clienteEncontrado.Estado;
                    textBoxSalida.Text = "El cliente existe.";
                    BotonModificar.Enabled = true;
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

        private void BotonModificar_Click(object sender, EventArgs e)
        {

         
        
            try
            {
                // Validar datos de entrada
                if (string.IsNullOrEmpty(textBoxCodigoCliente.Text) || string.IsNullOrEmpty(textBoxMontoTotal.Text) ||
                    string.IsNullOrEmpty(textBoxFechaInicio.Text) || string.IsNullOrEmpty(textBoxFechaVencimiento.Text))
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

                objconexion.Open();
                string consulta = "UPDATE Creditos SET [ID_Cliente] = @ID_Cliente, [Monto_Total] = @Monto_Total, [Fecha_Inicio] = @Fecha_Inicio, " +
                                 "[Fecha_Vencimiento] = @Fecha_Vencimiento, [Tasa_Interes] = @Tasa_Interes, [Estado] = @Estado, [Cuotas] = @Cuotas " +
                                 "WHERE [ID_Credito] = @ID_Credito";

                SqlCommand objcomando = new SqlCommand(consulta, objconexion);
                objcomando.Parameters.AddWithValue("@ID_Cliente", Int32.Parse(textBoxCodigoCliente.Text));
                objcomando.Parameters.AddWithValue("@Monto_Total", montoTotal);
                objcomando.Parameters.AddWithValue("@Fecha_Inicio", fechaInicio.ToString("yyyy-MM-dd"));
                objcomando.Parameters.AddWithValue("@Fecha_Vencimiento", fechaVencimiento.ToString("yyyy-MM-dd"));
                objcomando.Parameters.AddWithValue("@Tasa_Interes", 10); // Ejemplo estático
                objcomando.Parameters.AddWithValue("@Estado", textBoxEstado.Text);
                objcomando.Parameters.AddWithValue("@Cuotas", 10); // Ejemplo estático
                objcomando.Parameters.AddWithValue("@ID_Credito", Int32.Parse(textBoxCodigoCredito.Text));

                int cant = objcomando.ExecuteNonQuery();

                if (cant > 0)
                {
                    MessageBox.Show($"{cant} datos actualizados correctamente");
                }
                else
                {
                    MessageBox.Show("ERROR: No se han podido actualizar los datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                objconexion.Close();
            }
        }

    }
}