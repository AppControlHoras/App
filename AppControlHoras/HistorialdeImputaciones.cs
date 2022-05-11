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

namespace AppControlHoras
{
    public partial class HistorialdeImputaciones : Form
    {

        private SqlConnection connection = new SqlConnection("Data Source = TERESA\\SERVERSQL; Initial Catalog = ControlHoras; Integrated Security = True");

        public HistorialdeImputaciones()
        {
            InitializeComponent();
            lblUser.Text = BaseDeDatos.Username;
        }

        public DataTable ShowData()
        {
            string query = "Select * FROM Imputaciones";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;

        }
        private void HistorialdeImputaciones_Load(object sender, EventArgs e)
        {
            dgvHistorial.DataSource = ShowData();
         }

        public DataTable CargarTabla(String query)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            da.Fill(dt);

            return dt;
        }

        private void BorrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
