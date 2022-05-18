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
    public partial class AnadirTasa : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source = BATTISTA\\DAVIDSERVER; Initial Catalog = BBDD_HORAS; Integrated Security = True");

        public AnadirTasa()
        {
            InitializeComponent();
        }

        private void btAnadir_Click(object sender, EventArgs e)
        {
            connection.Open();
            var tasa = nudTasa.Value;
            string query = "insert into Tasa(valor) values ('" + tasa + "')";
            if (tasa.Equals(0))
            {
                MessageBox.Show("El valor no puede ser 0");
            }
            else
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Tasa introducida correctamente");
            }
            connection.Close();
        }

        private void nudTasa_ValueChanged(object sender, EventArgs e)
        {
            nudTasa.DecimalPlaces = 2;
        }
    }
}
