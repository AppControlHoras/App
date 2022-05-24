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

namespace AppControlHoras.Cuentas
{
    public partial class AnadirCuenta : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source = BATTISTA\\DAVIDSERVER; Initial Catalog = BBDD_HORAS; Integrated Security = True");

        public AnadirCuenta()
        {
            InitializeComponent();
        }

        private void btAnadir_Click(object sender, EventArgs e)
        {
            connection.Open();
            string descripcion = tbDescripcion.Text;
            string idCliente = tbIdCliente.Text;
            string query = "insert into Cuentas(idCliente, descripcion) values('" + idCliente + "','" + descripcion + "')";
      
            if (string.IsNullOrEmpty(descripcion) || string.IsNullOrEmpty(idCliente))
            {
                MessageBox.Show("Debes introducir todos los datos", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Cuenta añadida correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            connection.Close();
        }
    }
}
