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
    public partial class Tarea : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source = TERESA\\SERVERSQL; Initial Catalog = ControlHoras; Integrated Security = True");
        public Tarea()
        {
            InitializeComponent();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btAnadir_Click(object sender, EventArgs e)
        {
            AnadirTarea tarea = new AnadirTarea();
            tarea.Show();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            EliminarTarea tarea = new EliminarTarea();
            tarea.Show();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            ModificarTarea tarea = new ModificarTarea();
            tarea.Show();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DataTable showInfo()
        {
            string query = "SELECT ID_TAREA AS 'ID Tarea', DESCRIPCION AS 'Nombre' FROM Tareas";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;

        }

        private void Tarea_Load(object sender, EventArgs e)
        {
            dgvTareas.DataSource = showInfo();
        }
    }
}
