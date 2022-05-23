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
    public partial class EliminarEmpleadoArea : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source = TERESA\\SERVERSQL; Initial Catalog = ControlHoras; Integrated Security = True");

        public EliminarEmpleadoArea()
        {
            InitializeComponent();
        }



        private void btEliminar_Click(object sender, EventArgs e)
        {
            connection.Open();
            int idEmpleado = Convert.ToInt32(tbEmpleado.Text);
            int idArea = Convert.ToInt32(tbArea.Text);

            if (idArea.Equals("") || idEmpleado.Equals(""))
            {
                MessageBox.Show("Debe rellenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Empleados_Area WHERE ID_EMPLEADO = '" + idEmpleado + "' AND ID_AREA = '" + idArea + "'", connection);
                DialogResult result = MessageBox.Show("¿Estas seguro de que quieres eliminar el registro con IdEmpleado = " + idEmpleado + " e IdArea = " + idArea +"?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(result == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Eliminado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            connection.Close();
            this.Close();
        }
    }
}
