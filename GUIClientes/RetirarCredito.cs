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
        string url = "http://localhost:55421/api/Creditos";
        public RetirarCredito()
        {
            InitializeComponent();
        }

        private void BotonConsultar_Click(object sender, EventArgs e)
        {
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
                using (SqlConnection objconexion = new SqlConnection("Data Source=localhost;Initial Catalog=LaQuiebraLTDA;Integrated Security=SSPI;"))
                {
                    objconexion.Open();
                    string consultaMonto = "SELECT [Monto_Total] FROM Creditos WHERE [ID_Credito] = @ID_Credito";
                    using (SqlCommand objComandoMonto = new SqlCommand(consultaMonto, objconexion))
                    {
                        objComandoMonto.Parameters.AddWithValue("@ID_Credito", idCredito);
                        var result = objComandoMonto.ExecuteScalar();
                        if (result == null)
                        {
                            MessageBox.Show("El crédito con el ID especificado no existe.");
                            return;
                        }
                        decimal montoTotal = Convert.ToDecimal(result);
                        if (montoTotal == 0)
                        {
                            string consultaBorrar = "DELETE FROM Creditos WHERE [ID_Credito] = @ID_Credito";
                            using (SqlCommand objComandoBorrar = new SqlCommand(consultaBorrar, objconexion))
                            {
                                objComandoBorrar.Parameters.AddWithValue("@ID_Credito", idCredito);

                                int cant = objComandoBorrar.ExecuteNonQuery();

                                if (cant > 0)
                                {
                                    textBoxSalida.Text = ("El crédito ha sido eliminado correctamente.");
                                    textBoxIDCredito.Clear(); 
                                }
                                else
                                {
                                     textBoxSalida.Text= ("ERROR: No se ha podido eliminar el registro.");
                                }
                            }
                        }
                        else
                        {
                            textBoxSalida.Text = ("No se puede eliminar el crédito. El Monto Total debe ser 0.");
                        }
                    }
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
