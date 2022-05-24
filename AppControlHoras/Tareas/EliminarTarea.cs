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
    public partial class EliminarTarea : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source = BATTISTA\\DAVIDSERVER; Initial Catalog = BBDD_HORAS; Integrated Security = True");

        public EliminarTarea()
        {
            InitializeComponent();
        }

        private void EliminarTarea_Load(object sender, EventArgs e)
        {
            connection.Open();
            string query = "select idTarea from Tareas";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbTarea.Items.Add(reader["idTarea"].ToString());
            }
            connection.Close();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string idTarea = cbTarea.Text;
            string query = "delete from Tareas where idTarea = '" + idTarea + "'";
            if (string.IsNullOrEmpty(idTarea))
            {
                MessageBox.Show("Debes seleccionar la tarea", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                SqlCommand command = new SqlCommand();
                command.ExecuteNonQuery();
                MessageBox.Show("Tarea eliminada correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            connection.Close();
        }
    }
}
