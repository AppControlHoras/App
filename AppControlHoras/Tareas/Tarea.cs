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
        private SqlConnection connection = new SqlConnection("Data Source = BATTISTA\\DAVIDSERVER; Initial Catalog = BBDD_HORAS; Integrated Security = True");

        public Tarea()
        {
            InitializeComponent();
        }

        private DataTable showInfo()
        {
            string query = "select pr.idProyecto as 'ID Proyecto', pr.descripcion as 'Nombre Proyecto', ta.idTarea as 'ID Tarea', ta.descripcion as 'Nombre Tarea', ta.fechaAlta as 'Fecha Alta', ta.fechaBaja as 'Fecha Baja' " +
                            "from Tareas ta " +
                            "join Proyectos pr on ta.idTarea=pr.idTarea";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        private void Tarea_Load(object sender, EventArgs e)
        {
            dgvTareas.DataSource = showInfo();
        }
    }
}
