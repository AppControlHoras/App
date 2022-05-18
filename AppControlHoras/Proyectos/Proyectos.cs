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
    public partial class Proyectos : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source = TERESA\\SERVERSQL; Initial Catalog = ControlHoras; Integrated Security = True");
        public Proyectos()
        {
            InitializeComponent();
        }

        private void btAnadir_Click(object sender, EventArgs e)
        {
            AnadirProyecto proyecto = new AnadirProyecto();
            proyecto.Show();
            this.Hide();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            EliminarProyecto proyecto = new EliminarProyecto();
            proyecto.Show();
            this.Hide();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            ModificarProyecto proyecto = new ModificarProyecto();
            proyecto.Show();
            this.Hide();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            MenuAdministracion menu = new MenuAdministracion();
            menu.Show();
            this.Close();
        }

        public DataTable showData()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Proyectos", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        private void Proyectos_Load(object sender, EventArgs e)
        {
            dgvProyectos.DataSource = showData();
        }
    }
}
