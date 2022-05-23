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

namespace AppControlHoras.TipoProyectos
{
    public partial class AnadirTipoProyecto : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source = TERESA\\SERVERSQL; Initial Catalog = ControlHoras; Integrated Security = True");
        public AnadirTipoProyecto()
        {
            InitializeComponent();
        }

        private void btAnadir_Click(object sender, EventArgs e)
        {
            connection.Open();
            string tipo = tbTipoProyecto.Text;

            if (string.IsNullOrEmpty(tipo))
            {
                MessageBox.Show("Debes introducir el tipo de proyecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Tipo_Proyecto(DESCRIPCION) VALUES('"+ tipo + "')", connection );
                cmd.ExecuteNonQuery();
                MessageBox.Show("Añadido correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            connection.Close();
        }
    }
}
