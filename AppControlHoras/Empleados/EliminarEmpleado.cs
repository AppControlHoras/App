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
    public partial class EliminarEmpleado : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source = BATTISTA\\DAVIDSERVER; Initial Catalog = BBDD_HORAS; Integrated Security = True");

        public EliminarEmpleado()
        {
            InitializeComponent();
        }

        // No realiza un delete si no que hace un update y los oculta en la pantalla Empleado 
        // para no perder los datos de los Empleados que se han ido de la empresa
        private void btEliminar_Click(object sender, EventArgs e)
        {
            connection.Open();
            int idEmpleado = Convert.ToInt32(cbIdEmpleado.Text);
            string fechaBaja = dtpFechaBaja.Value.Date.ToString("dd/MM/yyyy");
            string query = "update Empleados set fechaBaja='" + fechaBaja + "' where idEmpleado='" + idEmpleado + "'";
            
            // Habria que hacer un if en el que comparara la fechaBaja con fechaAlta y si es mas antigua de error
            if (idEmpleado <= 0)
            {
                MessageBox.Show("Debes seleccionar un id");
            }
            else
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Empleado eliminado correctamente");
            }
            connection.Close();
        }


        private void EliminarEmpleado_Load(object sender, EventArgs e)
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
    }
}
