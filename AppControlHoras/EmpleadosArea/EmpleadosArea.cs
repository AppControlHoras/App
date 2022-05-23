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
    public partial class EmpleadosArea : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source = TERESA\\SERVERSQL; Initial Catalog = ControlHoras; Integrated Security = True");

        public EmpleadosArea()
        {
            InitializeComponent();
        }

        private void btAnadir_Click(object sender, EventArgs e)
        {
            AnadirEmpleadoArea empleadoArea = new AnadirEmpleadoArea();
            empleadoArea.Show();

            empleadoArea.FormClosing += new FormClosingEventHandler(Form_FormClosing);
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            EliminarEmpleadoArea empleadoArea = new EliminarEmpleadoArea();
            empleadoArea.Show();

            empleadoArea.FormClosing += new FormClosingEventHandler(Form_FormClosing);
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cargar();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            ModificarEmpleadoArea empleadoArea = new ModificarEmpleadoArea();
            empleadoArea.Show();

            empleadoArea.FormClosing += new FormClosingEventHandler(Form_FormClosing);
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cargar()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=TERESA\SERVERSQL;Initial Catalog=ControlHoras;Integrated Security=True"))
            {
                DataTable dt = new DataTable();
                string query = "SELECT ema.ID_EMPLEADO AS 'ID Empleado', ema.ID_AREA AS 'ID Area' " +
                           "FROM Empleados_Area ema " +
                           "INNER JOIN Empleados em ON ema.ID_EMPLEADO=em.ID_EMPLEADO " +
                           "INNER JOIN AreaFuncional ar ON ema.ID_AREA=ar.ID_AREA"; ;
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);

                dgvEmpleadosArea.DataSource = dt;
            }
        }

        private DataTable showInfo()
        {
            string query = "SELECT ema.ID_EMPLEADO AS 'ID Empleado', ema.ID_AREA AS 'ID Area' " +
                           "FROM Empleados_Area ema " +
                           "INNER JOIN Empleados em ON ema.ID_EMPLEADO=em.ID_EMPLEADO " +
                           "INNER JOIN AreaFuncional ar ON ema.ID_AREA=ar.ID_AREA";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        private void EmpleadosArea_Load(object sender, EventArgs e)
        {
            dgvEmpleadosArea.DataSource = showInfo();
        }
    }
}
