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
    public partial class EliminarArea : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source = TERESA\\SERVERSQL; Initial Catalog = BBDD_HORAS; Integrated Security = True");

        public EliminarArea()
        {
            InitializeComponent();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string id = cbAreas.Text;
            string query = "DELETE FROM AreaFuncional WHERE DESCRIPCION = '" + id + "'";
            try
            {
                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Selecciona un id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Eliminado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Source);
            }

            connection.Close();
        }

        private void EliminarArea_Load(object sender, EventArgs e)
        {
            connection.Open();
            string query = "SELECT ID_AREA, DESCRIPCION FROM AreaFuncional";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbAreas.Items.Add(reader["DESCRIPCION"].ToString());
            }
            connection.Close();
        }
    }
}
