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


                using (SqlConnection objconexion = new SqlConnection("Data Source=localhost;Initial Catalog=LaQuiebraLTDA;Integrated Security=SSPI;"))
                {

                    objconexion.Open();


                    string consulta = "INSERT INTO Creditos ([ID_Credito], [ID_Cliente], [Monto_Total], [Fecha_Inicio], [Fecha_Vencimiento], [Tasa_Interes], [Estado], [Cuotas]) " +
                                      "VALUES (@ID_Credito,@ID_Cliente, @Monto_Total, @Fecha_Inicio, @Fecha_Vencimiento, @Tasa_Interes, @Estado, @Cuotas)";


                    using (SqlCommand objcomando = new SqlCommand(consulta, objconexion))
                    {
                        objcomando.Parameters.AddWithValue("@ID_Credito", Int32.Parse(textBoxIDCredito.Text));
                        objcomando.Parameters.AddWithValue("@ID_Cliente", Int32.Parse(textBoxIDCliente.Text));
                        objcomando.Parameters.AddWithValue("@Monto_Total", montoTotal);
                        objcomando.Parameters.AddWithValue("@Fecha_Inicio", fechaInicio.ToString("yyyy-MM-dd"));
                        objcomando.Parameters.AddWithValue("@Fecha_Vencimiento", fechaVencimiento.ToString("yyyy-MM-dd"));
                        objcomando.Parameters.AddWithValue("@Tasa_Interes", 10);
                        objcomando.Parameters.AddWithValue("@Estado", textBoxEstado.Text);
                        objcomando.Parameters.AddWithValue("@Cuotas", 10);
                        int cant = objcomando.ExecuteNonQuery();
                        if (cant > 0)
                        {
                            textBoxSalida.Text = ("Nuevo registro agregado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("ERROR: No se ha podido agregar el registro.");
                        }
                    }
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

