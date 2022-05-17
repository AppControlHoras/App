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
    public partial class ModificarCliente : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source = BATTISTA\\DAVIDSERVER; Initial Catalog = BBDD_HORAS; Integrated Security = True");

        public ModificarCliente()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string nombreCliente = tbCliente.Text;
            string query = "select idCliente, descripcion " +
                            "from Clientes " +
                            "where descripcion='" + nombreCliente + "'";
            if (string.IsNullOrEmpty(nombreCliente))
            {
                MessageBox.Show("Debes introducir el nombre del cliente");
            }
            else
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    panelModificar.Visible = true;
                    lbIdCliente.Text = reader["idCliente"].ToString();
                    tbNuevoNombre.Text = reader["descripcion"].ToString();
                }
                else
                {
                    MessageBox.Show("El cliente con nombre " + nombreCliente + " no existe. Introduce un nombre correcto");
                }
            }
            connection.Close();
        }

        private void btCambiar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string nuevoNombre = tbNuevoNombre.Text;
            string idCliente = lbIdCliente.Text;
            string query = "update Clientes " +
                            "set descripcion='" + nuevoNombre + "' " +
                            "where idCliente='" + idCliente + "'";

            if (string.IsNullOrEmpty(nuevoNombre))
            {
                MessageBox.Show("Debes introducir un nombre nuevo");
            }
            else
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Cliente modificado correctamente");
            }
            connection.Close();
        }
    }
}
