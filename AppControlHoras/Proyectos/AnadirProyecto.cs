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

namespace AppControlHoras.Proyectos
{
    public partial class AnadirProyecto : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source = TERESA\\SERVERSQL; Initial Catalog = ControlHoras; Integrated Security = True");
        public AnadirProyecto()
        {
            InitializeComponent();
        }

        private void btAnadir_Click(object sender, EventArgs e)
        {
            connection.Open();
            string proyecto = textBox1.Text;

            if (string.IsNullOrEmpty(proyecto))
            {
                MessageBox.Show("Debes introducir el nombre del proyecto","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Proyectos(DESCRIPCION) VALUES('" + proyecto + "')", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Añadido correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            connection.Close();
        }
    }
}
