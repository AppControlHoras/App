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

namespace AppControlHoras.Proyectos
{
    public partial class ModificarProyecto : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source = TERESA\\SERVERSQL; Initial Catalog = BBDD_HORAS; Integrated Security = True");
        public ModificarProyecto()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string proyecto = tbNombre.Text;

            if (string.IsNullOrEmpty(proyecto))
            {
                MessageBox.Show("El proyecto " + proyecto + " no existe. Introduce un nombre correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Proyectos WHERE DESCRIPCION = '" + proyecto + "'", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    panel2.Visible = true;
                    lblIDProyecto.Text = reader["ID_PROYECTO"].ToString();
                    tbNuevoNombre.Text = reader["DESCRIPCION"].ToString();
                }
            }
            
            connection.Close();
        }

        private void btCambiar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string nombre = tbNuevoNombre.Text;
            string idProyecto = lblIDProyecto.Text;

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Debes introducir un nombre nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("UPDATE Proyectos SET DESCRIPCION = '"+ nombre +"' WHERE ID_PROYECTO = '"+ idProyecto +"'", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Proyecto modificado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            connection.Close();
        }

        private void ModificarProyecto_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}
