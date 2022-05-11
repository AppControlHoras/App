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

namespace AppControlHoras.Clientes
{
    public partial class AnadirCliente : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source = BATTISTA\\DAVIDSERVER; Initial Catalog = BBDD_HORAS; Integrated Security = True");

        public AnadirCliente()
        {
            InitializeComponent();
        }

        private void AnadirCliente_Load(object sender, EventArgs e)
        {
            connection.Open();
            string query = "select descripcion, idCuenta from Cuentas ";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbCuentas.Items.Add(reader["descripcion"].ToString());
                cbCuentas.Items.Add(reader["idCuenta"].ToString());
            }
            connection.Close();
        }

        private void btAnadir_Click(object sender, EventArgs e)
        {
            connection.Open();
            string nombreCliente = tbCliente.Text;
            string cuenta = cbCuentas.Text;
            // Al enviar carga la cuenta como varchar y pide un int de idCuenta
            // Hay que solucionarlo ya que es mas visual que salga el nombre de Cuenta que un numero
            int cuenta2 = Convert.ToInt32(cbCuentas.Text);

            string query = "insert into Clientes(descripcion, idCuenta) values('" + nombreCliente +"', '"+ cuenta2 + "')";

            if (string.IsNullOrEmpty(tbCliente.Text))
            {
                MessageBox.Show("Debes introducir el nombre del cliente");
            }
            else if (string.IsNullOrEmpty(cbCuentas.Text))
            {
                MessageBox.Show("Selecciona una cuenta");
            }
            else
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Añadido correctamente");
            }
            connection.Close();
        }
    }

}
