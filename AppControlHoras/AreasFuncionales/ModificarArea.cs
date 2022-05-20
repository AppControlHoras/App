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

namespace AppControlHoras.AreaFuncional
{
    public partial class ModificarArea : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source = TERESA\\SERVERSQL; Initial Catalog = ControlHoras; Integrated Security = True");

        public ModificarArea()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string nombreArea = tbArea.Text;
            string query = "SELECT *" +
                            "FROM AreaFuncional " +
                            "WHERE DESCRIPCION='" + nombreArea + "'";
            if (string.IsNullOrEmpty(nombreArea))
            {
                MessageBox.Show("Debes introducir el area");
            }
            else
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    panelModificar.Visible = true;
                    lbIdArea.Text = reader["ID_AREA"].ToString();
                    tbNuevoNombre.Text = reader["DESCRIPCION"].ToString();
                }
                else
                {
                    MessageBox.Show("El area " + nombreArea + " no existe. Introduce un nombre correcto","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            connection.Close();
        }

        private void btCambiar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string nuevoNombre = tbNuevoNombre.Text;
            string idArea = lbIdArea.Text;
            string query = "UPDATE AreaFuncional " +
                            "SET DESCRIPCION ='" + nuevoNombre + "' " +
                            "WHERE ID_AREA='" + idArea + "'";

            if (string.IsNullOrEmpty(nuevoNombre))
            {
                MessageBox.Show("Debes introducir un nombre nuevo");
            }
            else
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Area modificada correctamente");
            }
            connection.Close();
        }

        private void ModificarArea_Load(object sender, EventArgs e)
        {

        }
    }
}
