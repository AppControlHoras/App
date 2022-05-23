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

namespace AppControlHoras.Tareas
{
    public partial class ModificarTarea : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source = TERESA\\SERVERSQL; Initial Catalog = ControlHoras; Integrated Security = True");
        public ModificarTarea()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string id = tbTarea.Text;

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("La tarea " + id + " no existe, introduzca una tarea existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    panel2.Visible = true;
                    lblIDTarea.Text = reader["ID_TAREA"].ToString();
                    tbNuevoNombre.Text = reader["DESCRIPCION"].ToString();
                }
            }
            connection.Close();
        }

        private void btCambiar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string tarea = tbNuevoNombre.Text;
            string idTarea = lblIDTarea.Text;

            if (string.IsNullOrEmpty(tarea))
            {
                MessageBox.Show("Debes introducir un nombre nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("UPDATE Tareas SET DESCRIPCION = '" + tarea + "' WHERE ID_PROYECTO = '" + idTarea + "'", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tarea modificada correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            connection.Close();
        }
    }
}
