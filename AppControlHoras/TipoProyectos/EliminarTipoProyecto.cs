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
    public partial class EliminarTipoProyecto : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source = TERESA\\SERVERSQL; Initial Catalog = BBDD_HORAS; Integrated Security = True");
        public EliminarTipoProyecto()
        {
            InitializeComponent();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string id = cbTipoPoryectos.Text;

            try
            {
                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Selecciona un ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Tipo_Proyecto WHERE ID_TIPO_PROYECTO = '" + id + "'", connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Eliminado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Source, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        private void EliminarTipoProyecto_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Tipo_Proyectos", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbTipoPoryectos.Items.Add(reader["DESCRIPCION"].ToString());
            }
            connection.Close();
        }
    }
}
