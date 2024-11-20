using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LaQuiebraWeb
{
    public partial class ConsultaCredito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cadenaSQL"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                c.ID_Credito,
                c.Monto_Total,
                ISNULL(SUM(p.Monto_Pago), 0) AS Pagos_Realizados,
                (c.Monto_Total - ISNULL(SUM(p.Monto_Pago), 0)) AS Monto_Pendiente
            FROM 
                Creditos c
            LEFT JOIN 
                Pagos p ON c.ID_Credito = p.ID_Credito
            INNER JOIN 
                Clientes cl ON c.ID_Cliente = cl.ID_Cliente
            WHERE 
                (@ID_Cliente IS NULL OR cl.ID_Cliente = @ID_Cliente)
                AND (@Nombre IS NULL OR cl.Nombre LIKE '%' + @Nombre + '%')
            GROUP BY 
                c.ID_Credito, c.Monto_Total";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_Cliente", string.IsNullOrEmpty(txtIdCliente.Text) ? (object)DBNull.Value : txtIdCliente.Text);
                command.Parameters.AddWithValue("@Nombre", string.IsNullOrEmpty(txtNombreCliente.Text) ? (object)DBNull.Value : txtNombreCliente.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                gvResultados.DataSource = dt;
                gvResultados.DataBind();
            }
        }

    }
}