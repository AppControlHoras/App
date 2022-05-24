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
    public partial class AñadirTarea : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source = BATTISTA\\DAVIDSERVER; Initial Catalog = BBDD_HORAS; Integrated Security = True");

        public AñadirTarea()
        {
            InitializeComponent();
        }

        private void btAnadir_Click(object sender, EventArgs e)
        {
            connection.Open();
            string idProyecto = cbIdProyecto.Text;
            string descripcion = tbDescripcion.Text;
            string fechaAlta = dtpFechaAlta.Text;

            string query = "insert into Tareas(descripcion, fechaAlta, idProyecto) " +
                            "values('" + descripcion + "', '"+ fechaAlta + "', '" + idProyecto + "')";
            if (string.IsNullOrEmpty(idProyecto) || string.IsNullOrEmpty(descripcion) || string.IsNullOrEmpty(fechaAlta))
            {
                MessageBox.Show("Debes rellenar todos los campos", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Tarea añadida correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            connection.Close();
        }

        private void AñadirTarea_Load(object sender, EventArgs e)
        {
            connection.Open();
            string query = "select idProyecto from Proyectos";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbIdProyecto.Items.Add(reader["idProyecto"].ToString());
            }
            connection.Close();
        }
    }
}
