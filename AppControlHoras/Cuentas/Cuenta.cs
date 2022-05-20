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
using AppControlHoras.Cuentas;

namespace AppControlHoras
{
    public partial class Cuenta : Form
    {
        private SqlConnection connection = new SqlConnection( "Data Source = BATTISTA\\DAVIDSERVER; Initial Catalog = BBDD_HORAS; Integrated Security = True");


        public Cuenta()
        {
            InitializeComponent();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void dgvCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public DataTable showData()
        {
            string query = "select cu.idCuenta as 'ID Cuenta', cu.descripcion as 'Nombre Cuenta', cl.idCliente as 'ID Cliente', cl.descripcion as 'Nombre Cliente' " +
                            "from Cuentas cu " +
                            "join Clientes cl on cu.idCliente=cl.idCliente";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;

        }

        private void Cuentas_Load(object sender, EventArgs e)
        {
            dgvCuentas.DataSource = showData();

        }

        private void btAnadir_Click(object sender, EventArgs e)
        {
            AnadirCuenta anadirCuenta = new AnadirCuenta();
            anadirCuenta.Show();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            EliminarCuenta eliminarCuenta = new EliminarCuenta();
            eliminarCuenta.Show();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            ModificarCuenta modificarCuenta = new ModificarCuenta();
            modificarCuenta.Show();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
