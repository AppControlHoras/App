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

namespace AppControlHoras.Empleados
{
    public partial class ModificarEmpleado : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source = BATTISTA\\DAVIDSERVER; Initial Catalog = BBDD_HORAS; Integrated Security = True");

        public ModificarEmpleado()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string idEmpleado = cbIdEmpleado.Text;
            string query = "select nombre, primerApellido, segundoApellido, email, fechaAlta, idArea, idTasa " +
                            "from Empleados " +
                            "where idEmpleado='" + idEmpleado + "'";
            if (string.IsNullOrEmpty(idEmpleado))
            {
                MessageBox.Show("Debes seleccionar el id del empleado");
            }
            else
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    plInfoEmpleado.Visible = true;
                    tbNombre.Text = reader["nombre"].ToString();
                    tbPrimerApellido.Text = reader["primerApellido"].ToString();
                    tbSegundoApellido.Text = reader["segundoApellido"].ToString();
                    tbEmail.Text = reader["email"].ToString();
                    dtpFechaAlta.Text = reader["fechaAlta"].ToString();
                    cbArea.Text = reader["idArea"].ToString();
                    cbTasa.Text = reader["idTasa"].ToString();
                }
            }
            connection.Close();
        }

        private void ModificarEmpleado_Load(object sender, EventArgs e)
        {
            connection.Open();
            string query = "select idEmpleado from Empleados";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbIdEmpleado.Items.Add(reader["idEmpleado"].ToString());
            }

            connection.Close();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string idEmpleado = cbIdEmpleado.Text;
            string nombre = tbNombre.Text;
            string primerApellido = tbPrimerApellido.Text;
            string segundoApellido = tbSegundoApellido.Text;
            string email = tbEmail.Text;
            string fechaAlta = dtpFechaAlta.Text;
            string tasa = cbTasa.Text;
            string area = cbArea.Text;
            string query = "update Empleados set nombre='" + nombre + "', " +
                                                "primerApellido='" + primerApellido + "', " +
                                                "segundoApellido='" + segundoApellido + "', " +
                                                "email='" + email + "', " +
                                                "fechaAlta='" + fechaAlta + "', " +
                                                "idArea='" + area + "', " +
                                                "idTasa='" + tasa + "' " +
                           "where idEmpleado='" + idEmpleado + "'";

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(primerApellido) || string.IsNullOrEmpty(segundoApellido) 
                || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(tasa) || string.IsNullOrEmpty(area))
            {
                MessageBox.Show("Todos los campos deben rellenarse");
            }
            else
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Empleado modificado correctamente");
            }
            connection.Close();
        }
    }
}
