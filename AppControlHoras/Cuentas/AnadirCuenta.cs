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
            int idCliente = Convert.ToInt32(tbIdCliente.Text);
            string query = "insert into Cuentas(idCliente, descripcion) values('" + idCliente + "','" + descripcion + "')";
      
            if (string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("Debes rellenar la descripcion");
            }
            else if (string.IsNullOrEmpty(tbIdCliente.Text))
            {
                MessageBox.Show("Debes introducir el id del cliente");
            }
            else
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Cuenta añadida correctamente");
            }
            connection.Close();
        }
    }
}
