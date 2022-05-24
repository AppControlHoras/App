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

        private void btAnadir_Click(object sender, EventArgs e)
        {
            connection.Open();
            string nombreCliente = tbCliente.Text;
            string query = "insert into Clientes(descripcion) values('" + nombreCliente+"')";

            if (string.IsNullOrEmpty(nombreCliente))
            {
                MessageBox.Show("Debes introducir el nombre del cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Añadido correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            connection.Close();
        }
    }

}
