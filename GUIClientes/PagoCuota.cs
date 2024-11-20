using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIClientes
{
    public partial class PagoCuota : Form
    {
        public PagoCuota()
        {
            InitializeComponent();
        }
        //a

        private void BotonConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxIdCredito.Text) || string.IsNullOrEmpty(textBoxMontoPagado.Text) || string.IsNullOrEmpty(textBoxFechaPago.Text))
                {
                    MessageBox.Show("Todos los campos deben estar completos.");
                    return;
                }
                if (!Decimal.TryParse(textBoxMontoPagado.Text, out decimal montoPago))
                {
                    MessageBox.Show("El monto de pago debe ser un número válido.");
                    return;
                }
                if (!DateTime.TryParse(textBoxFechaPago.Text, out DateTime fechaPago))
                {
                    MessageBox.Show("La fecha de pago debe ser válida.");
                    return;
                }

                using (SqlConnection objconexion = new SqlConnection("Data Source=localhost;Initial Catalog=LaQuiebraLTDA;Integrated Security=SSPI;"))
                {
                    objconexion.Open();
                    string consulta = "INSERT INTO Pagos (ID_Pago, ID_Credito, Fecha_Pago, Monto_Pago, Metodo_Pago) " +
                                      "VALUES (@ID_Pago, @ID_Credito, @Fecha_Pago, @Monto_Pago, @Metodo_Pago)";

                    using (SqlCommand objcomando = new SqlCommand(consulta, objconexion))
                    {
                        objcomando.Parameters.AddWithValue("@ID_Pago", Int32.Parse(textBoxPagoID.Text));
                        objcomando.Parameters.AddWithValue("@ID_Credito", Int32.Parse(textBoxIdCredito.Text));
                        objcomando.Parameters.AddWithValue("@Fecha_Pago", fechaPago.ToString("yyyy-MM-dd"));
                        objcomando.Parameters.AddWithValue("@Monto_Pago", montoPago);
                        objcomando.Parameters.AddWithValue("@Metodo_Pago", "Fisico");

                        int cant = objcomando.ExecuteNonQuery();

                        if (cant > 0)
                        {
                            string consultaUpdate = "UPDATE Creditos " +
                                                    "SET Monto_Total = Monto_Total - @Descuento " +
                                                    "WHERE ID_Credito = @ID_Credito";

                            using (SqlCommand objcomando2 = new SqlCommand(consultaUpdate, objconexion))
                            {
                                decimal interes = montoPago * 0.1m;
                                objcomando2.Parameters.AddWithValue("@Descuento", interes);
                                objcomando2.Parameters.AddWithValue("@ID_Credito", Int32.Parse(textBoxIdCredito.Text));
                                objcomando2.ExecuteNonQuery();
                            }

                            MessageBox.Show("Pago registrado y crédito actualizado correctamente.");
                            textBoxIdCredito.Clear();
                            textBoxMontoPagado.Clear();
                            textBoxFechaPago.Clear();
                            textBoxPagoID.Clear();
                        }
                        else
                        {
                            MessageBox.Show("ERROR: No se ha podido registrar el pago.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}



