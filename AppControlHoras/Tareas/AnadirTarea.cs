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

namespace AppControlHoras.Tareas
{
    public partial class AnadirTarea : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source = TERESA\\SERVERSQL; Initial Catalog = ControlHoras; Integrated Security = True");
        public AnadirTarea()
        {
            InitializeComponent();
        }

        private void btAnadir_Click(object sender, EventArgs e)
        {
            connection.Open();
            string tarea = tbTarea.Text;

            if (string.IsNullOrEmpty(tarea))
            {
                MessageBox.Show("Debes introducir una tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Tareas(DESCRIPCION) VALUES('" + tarea + "')", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Introducido correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            connection.Close();
        }
    }
}
