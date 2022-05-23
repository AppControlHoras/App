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

namespace AppControlHoras.Tasas
{
    public partial class EliminarTasa : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source = BATTISTA\\DAVIDSERVER; Initial Catalog = BBDD_HORAS; Integrated Security = True");

        public EliminarTasa()
        {
            InitializeComponent();
        }

        private void EliminarTasa_Load(object sender, EventArgs e)
        {
            connection.Open();
            string query = "select idTasa from Tasa";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbTasas.Items.Add(reader["idTasa"].ToString());
            }
            connection.Close();
        }

        private void btAnadir_Click(object sender, EventArgs e)
        {
            connection.Open();
            string idTasa = cbTasas.Text;
            string query = "delete from Tasa where idTasa ='" + idTasa + "'";
            if (string.IsNullOrEmpty(idTasa))
            {
                MessageBox.Show("Debes seleccionar la tasa");
            }
            else
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Tasa " + idTasa + " eliminada correctamente");
            }
            connection.Close();
        }
    }
}
