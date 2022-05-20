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

namespace AppControlHoras.TipoProyectos
{
    public partial class ModificarTipoProyecto : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source = TERESA\\SERVERSQL; Initial Catalog = BBDD_HORAS; Integrated Security = True");
        public ModificarTipoProyecto()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string tipo = tbTipoProyecto.Text;

            if (string.IsNullOrEmpty(tipo))
            {
                MessageBox.Show("El tipo de proyecto " + tipo + " no existe. Introduce un tipo de proyecto correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Tipo_Proyectos WHERE DESCRIPCION = '" + tipo + "'", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    panel2.Visible = true;
                    lblIDProyecto.Text = reader["ID_TIPO_PROYECTO"].ToString();
                    tbNuevoTipo.Text = reader["DESCRIPCION"].ToString();
                }
            }
                connection.Close();
        }

        private void btCambiar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string tipo = tbNuevoTipo.Text;
            string idTipoProyecto = lblIDProyecto.Text;

            if (string.IsNullOrEmpty(tipo))
            {
                MessageBox.Show("Debes introducir un tipo de proyecto nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("UPDATE Tipo_P^ROYECTO SET DESCRIPCION = '" + tipo + "' WHERE ID_PROYECTO = '" + idTipoProyecto + "'", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tipo de proyecto modificado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            connection.Close();
        }
    }
}
