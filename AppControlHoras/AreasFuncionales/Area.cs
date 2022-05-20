using AppControlHoras.AreaFuncional;
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

namespace AppControlHoras.AreasFuncionales
{
    public partial class Area : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source = TERESA\\SERVERSQL; Initial Catalog = ControlHoras; Integrated Security = True");

        public Area()
        {
            InitializeComponent();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }


        public DataTable showData()
        {
            string query = "SELECT ID_AREA as 'ID Area', DESCRIPCION as 'Nombre' FROM AreaFuncional";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        private void AreaFuncional_Load(object sender, EventArgs e)
        {
            dgvClient.DataSource = showData();
        }

        private void btAnadir_Click(object sender, EventArgs e)
        {
            AñadirArea area = new AñadirArea();
            area.Show();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            EliminarArea area = new EliminarArea();
            area.Show();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            ModificarArea area = new ModificarArea();
            area.Show();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            MenuAdministracion menu = new MenuAdministracion();
            menu.Show();
            this.Close();
        }
    }
}
