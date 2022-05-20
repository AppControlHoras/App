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
    public partial class TipoProyecto : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source = TERESA\\SERVERSQL; Initial Catalog = ControlHoras; Integrated Security = True");
        public TipoProyecto()
        {
            InitializeComponent();
        }

        private void btAnadir_Click(object sender, EventArgs e)
        {
            TipoProyectos.AnadirTipoProyecto proyecto = new TipoProyectos.AnadirTipoProyecto();
            proyecto.Show();


        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            TipoProyectos.AnadirTipoProyecto proyecto = new TipoProyectos.AnadirTipoProyecto();
            proyecto.Show();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            TipoProyectos.AnadirTipoProyecto proyecto = new TipoProyectos.AnadirTipoProyecto();
            proyecto.Show();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DataTable showInfo()
        {
            string query = "SELECT ID_TIPO_PROYECTO, DESCRIPCION FROM Tipo_Proyecto";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;

        }
        private void TipoProyecto_Load(object sender, EventArgs e)
        {
            dgvTipoProyectos.DataSource = showInfo();
        }
    }
}
