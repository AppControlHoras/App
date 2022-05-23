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

namespace AppControlHoras.EmpleadosArea
{
    public partial class AnadirEmpleadoArea : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source = TERESA\\SERVERSQL; Initial Catalog = ControlHoras; Integrated Security = True");
        public AnadirEmpleadoArea()
        {
            InitializeComponent();
        }

        private void btAnadir_Click(object sender, EventArgs e)
        {
            connection.Open();
            int idEmpleado = Convert.ToInt32(tbEmpleado.Text);
            int idArea = Convert.ToInt32(tbArea.Text);

            if(idArea.Equals("") || idEmpleado.Equals(""))
            {
                MessageBox.Show("Debe rellenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Empleados_Area(ID_EMPLEADO, ID_AREA) VALUES('" + idEmpleado + "', '" + idArea + "')", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Añadido correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            connection.Close();
            this.Close();
        }
    }
}
