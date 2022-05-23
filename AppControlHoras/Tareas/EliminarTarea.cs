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
        private SqlConnection connection = new SqlConnection("Data Source = TERESA\\SERVERSQL; Initial Catalog = ControlHoras; Integrated Security = True");

        public EliminarTarea()
        {
            InitializeComponent();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string id = cbTareas.Text;

            try
            {
                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Seleccione una tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Tareas WHERE DESCRIPCION = '"+ id + "'", connection);
                    DialogResult result = MessageBox.Show("¿Estas seguro de que desea eliminar " + id + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Eliminado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbTareas.ResetText();
                        cbTareas.Items.Remove(id);
                    }
                }
            } catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Source, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        private void EliminarTarea_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Tareas", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbTareas.Items.Add(reader["DESCRIPCION"].ToString());
            }
            connection.Close();
        }
    }
}
