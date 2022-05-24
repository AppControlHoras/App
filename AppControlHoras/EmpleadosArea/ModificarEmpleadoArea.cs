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

namespace AppControlHoras.EmpleadosArea
{
    public partial class ModificarEmpleadoArea : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source = TERESA\\SERVERSQL; Initial Catalog = ControlHoras; Integrated Security = True");
        public ModificarEmpleadoArea()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            connection.Open();
            int idEmpleado = Convert.ToInt32(tbIdEmpleado.Text);
            int idArea = Convert.ToInt32(tbIdArea.Text);

            if(tbIdEmpleado.Equals("") || tbIdArea.Equals(""))
            {
                MessageBox.Show("Rellene los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Empleados_Area WHERE ID_EMPLEADO = '" + idEmpleado + "' AND ID_AREA = '"+ idArea +"'", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    panel2.Visible = true;
                    lblIdEmpleado2.Text = reader["ID_EMPLEADO"].ToString();
                    lblIdArea2.Text = reader["ID_AREA"].ToString();
                    tbIdEmpleadoNuevo.Text = reader["ID_EMPLEADO"].ToString();
                    tbIdAreaNuevo.Text = reader["ID_AREA"].ToString();
                }
            }
            connection.Close();
        }

        private void btCambiar_Click(object sender, EventArgs e)
        {
            connection.Open();
            int idEmpleadoNuevo = Convert.ToInt32(tbIdEmpleadoNuevo.Text);
            int idAreaNuevo = Convert.ToInt32(tbIdAreaNuevo.Text);
            int idEmpleado = Convert.ToInt32(lblIdEmpleado2.Text);
            int idArea = Convert.ToInt32(lblIdArea2.Text);

            if (idAreaNuevo.Equals("") || idEmpleadoNuevo.Equals(""))
            {
                MessageBox.Show("Debes rellenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("UPDATE Empleados_Area SET ID_EMPLEADO = '" + idEmpleadoNuevo + "', ID_AREA = '"+ idAreaNuevo +"' WHERE ID_EMPLEADO = '" + idEmpleado + "' AND ID_AREA = '"+ idArea +"'", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Empleado-Area modificado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            connection.Close();
            this.Close();
        }
    }
}
