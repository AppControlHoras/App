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
    public partial class ModificarTasa : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source = BATTISTA\\DAVIDSERVER; Initial Catalog = BBDD_HORAS; Integrated Security = True");

        public ModificarTasa()
        {
            InitializeComponent();
        }

        private void ModificarTasa_Load(object sender, EventArgs e)
        {
            connection.Open();
            string query = "select idTasa from Tasa";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbIdTasas.Items.Add(reader["idTasa"].ToString());
            }

            connection.Close();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string idTasa = cbIdTasas.Text;

            string query = "select valor from Tasa where idTasa='" + idTasa + "'";
            if (string.IsNullOrEmpty(idTasa))
            {
                MessageBox.Show("Debes seleccionar un id");
            }
            else
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    panelModificar.Visible = true;
                    lbValorAntiguo.Text = reader["valor"].ToString();
                }
            }
            connection.Close();
        }

        private void btCambiar_Click(object sender, EventArgs e)
        {
            connection.Open();
            int nuevoValor = Convert.ToInt32(nudNuevoValor.Text);
            int idTasa = Convert.ToInt32(cbIdTasas.Text);
            string query = "update Tasa set valor='" + nuevoValor + "' where idTasa='" + idTasa + "'";
            if (nuevoValor <= 0)
            {
                MessageBox.Show("El valor de la tasa no puede ser 0 o negativo");
            }
            else
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Valor de tasa modificado correctamente");
            }
            connection.Close();
        }

        private void nudNuevoValor_ValueChanged(object sender, EventArgs e)
        {
            nudNuevoValor.DecimalPlaces = 2;
        }
    }
}
