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
    public partial class Tasa : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source = BATTISTA\\DAVIDSERVER; Initial Catalog = BBDD_HORAS; Integrated Security = True");

        public Tasa()
        {
            InitializeComponent();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAnadir_Click(object sender, EventArgs e)
        {
            AnadirTasa anadirTasa = new AnadirTasa();
            anadirTasa.Show();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            EliminarTasa eliminar = new EliminarTasa();
            eliminar.Show();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            ModificarTasa modificar = new ModificarTasa();
            modificar.Show();
        }

        private DataTable showInfo()
        {
            string query = "select idTasa as 'ID Tasa', valor as 'Valor' from Tasa";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;

        }
        private void Tasa_Load(object sender, EventArgs e)
        {
            dgvTasas.DataSource = showInfo();
        }
    }
}
