using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AppControlHoras.Clientes;

namespace AppControlHoras
{
    public partial class Cliente : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source = TERESA\\SERVERSQL; Initial Catalog = ControlHoras; Integrated Security = True");

        public Cliente()
        {
            InitializeComponent();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        public DataTable showData()
        {
            string query = "select ID_CLIENTE, DESCRIPCION from Clientes ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            dgvClient.DataSource = showData();

        }

        private void btAnadir_Click(object sender, EventArgs e)
        {
            AnadirCliente anadirCliente = new AnadirCliente();
            anadirCliente.Show();

        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            EliminarCliente eliminarCliente = new EliminarCliente();
            eliminarCliente.Show();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            ModificarCliente modificarCliente = new ModificarCliente();
            modificarCliente.Show();
        }
    }
}
