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

namespace AppControlHoras
{
    public partial class Cuentas : Form
    {
        private SqlConnection connection = new SqlConnection( "Data Source = BATTISTA\\DAVIDSERVER; Initial Catalog = BBDD_HORAS; Integrated Security = True");


        public Cuentas()
        {
            InitializeComponent();
        }

        private void dgvCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public DataTable showData()
        {
            string query = "select * from Cuentas";
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
            connection.Open();

            string descripcion = tbElemento.Text;
            string query = "insert into Cuentas(descripcion) values('" + descripcion + "')";

            if (string.IsNullOrEmpty(tbElemento.Text))
            {
                MessageBox.Show("Debes introducir el nombre");
            }
            else
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Añadido correctamente");
            }

            connection.Close();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string descripcion = tbElemento.Text;
            string query = "delete from Cuentas " +
                            "where descripcion='"+ descripcion +"'";

            if (string.IsNullOrEmpty(tbElemento.Text))
            {
                MessageBox.Show("Debes introducir el nombre");
            }
            else
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Eliminado correctamente");
            }
            connection.Close();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbElemento.Text))
            {
                MessageBox.Show("Debes introducir el nombre");
            } else
            {
                panel1.Visible = true;
            }
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string oldName = tbElemento.Text;
            string newName = tbNuevo.Text;
            string query = "update Cuentas " +
                            "set descripcion='"+ newName + "'" +
                            "where descripcion='" + oldName + "'";
            if (string.IsNullOrEmpty(tbNuevo.Text))
            {
                MessageBox.Show("Debes introducir el nombre nuevo");
            }
            else
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Cuenta modificada correctamente");
            }
            connection.Close();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            MenuAdministracion menuAdministracion = new MenuAdministracion();
            menuAdministracion.Show();
            this.Hide();

        }

        private void btAnadir_MouseHover(object sender, EventArgs e)
        {
            btAnadir.BackColor = Color.Red;
        }
    }
}
