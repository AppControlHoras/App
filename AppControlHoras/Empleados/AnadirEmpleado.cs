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

namespace AppControlHoras.Empleados
{
    public partial class AnadirEmpleado : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source = BATTISTA\\DAVIDSERVER; Initial Catalog = BBDD_HORAS; Integrated Security = True");

        public AnadirEmpleado()
        {
            InitializeComponent();
        }

        private void AnadirEmpleado_Load(object sender, EventArgs e)
        {
            connection.Open();
            string queryForTasa = "select idTasa from Tasa";
            SqlCommand commandTasa = new SqlCommand(queryForTasa, connection);
            SqlDataReader readerTasa = commandTasa.ExecuteReader();
            while (readerTasa.Read())
            {
                cbTasa.Items.Add(readerTasa["idTasa"].ToString());
            }
            connection.Close();

            connection.Open();
            string queryForArea = "select idArea from AreasFuncionales";
            SqlCommand commandArea = new SqlCommand(queryForArea, connection);
            SqlDataReader readerArea = commandArea.ExecuteReader();
            while (readerArea.Read())
            {
                cbArea.Items.Add(readerArea["idArea"].ToString());
            }
            connection.Close();
        }

        private void btAnadir_Click(object sender, EventArgs e)
        {
            connection.Open();
            string nombre = tbNombre.Text;
            string primerApellido = tbPrimerApellido.Text;
            string segundoApellido = tbSegundoApellido.Text;
            string email = tbEmail.Text;
            string fechaAlta = dtpFechaAlta.Value.Date.ToString("dd/MM/yyyy");
            string idTasa = cbTasa.Text;
            string idArea = cbArea.Text;

            string query = "insert into Empleados(nombre, primerApellido, segundoApellido, email, fechaAlta, idArea, idTasa) " +
                            "values ('" + nombre + "', '" + primerApellido + "', '" + segundoApellido + "', '" + email + "', '" + fechaAlta + "', '" + idArea + "', '" + idTasa + "')";
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(primerApellido) || string.IsNullOrEmpty(segundoApellido) 
                || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(fechaAlta) || string.IsNullOrEmpty(idTasa) || string.IsNullOrEmpty(idArea))
            {
                MessageBox.Show("Debes rellenar todos los campos", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Empleado creado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            connection.Close();
        }
    }
}
