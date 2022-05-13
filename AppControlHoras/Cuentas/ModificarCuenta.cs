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
    public partial class ModificarCuenta : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source = BATTISTA\\DAVIDSERVER; Initial Catalog = BBDD_HORAS; Integrated Security = True");

        public ModificarCuenta()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string descripcion = tbCuenta.Text;
            string query = "select idCuenta, descripcion from Cuentas where descripcion='" + descripcion + "'";
            if (string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("Debes introducir el nombre");
            }
            else
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    panelModificar.Visible = true;
                    lbIdCuenta.Text = reader["idCuenta"].ToString();
                    tbNuevoNombre.Text = reader["descripcion"].ToString();
                }
            }
            connection.Close();
        }

        private void btCambiar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string nuevoNombre = tbNuevoNombre.Text;
            int idCuenta = Convert.ToInt32(lbIdCuenta.Text);
            string query = "update Cuentas set descripcion='" + nuevoNombre + "' where idCuenta='" + idCuenta + "'";
            if (string.IsNullOrEmpty(nuevoNombre))
            {
                MessageBox.Show("El campo no puede estar vacio. Introduce un nuevo nombre");
            }
            else
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Cuenta modificada correctamente ");
                panelModificar.Visible = false;
            }
            connection.Close();
        }
    }
}
