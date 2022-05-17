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

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dgvHistorial.Columns)
            {
                if (column.HeaderText.Equals("FECHA_IMPUTACION"))
                {
                    string valor = GetValorCelda(dgvHistorial, 0);
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Imputaciones WHERE FECHA_IMPUTACION = @valor", connection);
                    cmd.Parameters.AddWithValue("@valor", valor);

                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                else if (column.HeaderText.Equals("HORAS"))
                {
                    int valor = Convert.ToInt32(GetValorCelda(dgvHistorial, 1));
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Imputaciones WHERE HORAS = @valor", connection);
                    cmd.Parameters.AddWithValue("@valor", valor);

                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                else if (column.HeaderText.Equals("ID_TAREA"))
                {

                    int valor = Convert.ToInt32(GetValorCelda(dgvHistorial, 2));
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Imputaciones WHERE ID_TAREA = @valor", connection);
                    cmd.Parameters.AddWithValue("@valor", valor);

                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                else if (column.HeaderText.Equals("ID_EMPLEADO"))
                {
                    int valor = Convert.ToInt32(GetValorCelda(dgvHistorial, 3));
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Imputaciones WHERE ID_EMPLEADO = @valor", connection);
                    cmd.Parameters.AddWithValue("@valor", valor);

                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            Cargar();
        }
        public static string GetValorCelda(DataGridView dgv, int num)
        {
            string valor = "";

            valor = dgv.Rows[dgv.CurrentRow.Index].Cells[num].Value.ToString();

            return valor;
        }

        private void Cargar()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=TERESA\SERVERSQL;Initial Catalog=ControlHoras;Integrated Security=True"))
            {
                DataTable dt = new DataTable();
                string query = "SELECT * FROM Imputaciones";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);

                dgvHistorial.DataSource = dt;
            }
        }

    }
}
