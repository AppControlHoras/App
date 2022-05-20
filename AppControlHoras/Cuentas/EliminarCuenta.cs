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

    public partial class EliminarCuenta : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source = BATTISTA\\DAVIDSERVER; Initial Catalog = BBDD_HORAS; Integrated Security = True");

        public EliminarCuenta()
        {
            InitializeComponent();
        }



        private void btEliminar_Click(object sender, EventArgs e)
        {
            connection.Open();
            int idCuenta = Convert.ToInt32(tbIdCuenta.Text);
            string query = "delete from Cuentas where idCuenta='" + idCuenta + "'";
            if (string.IsNullOrEmpty(tbIdCuenta.Text))
            {
                MessageBox.Show("Introduce el id de la cuenta");
            }
            else
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                MessageBox.Show("Cuenta eliminada correctamente");
            }
            connection.Close();
        }
    }
}