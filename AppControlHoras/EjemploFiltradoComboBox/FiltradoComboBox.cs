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

namespace AppControlHoras.EjemploFiltradoComboBox
{
    public partial class FiltradoComboBox : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = TERESA\\SERVERSQL; Initial Catalog = ControlHoras; Integrated Security = True");
        public FiltradoComboBox()
        {
            InitializeComponent();
            CargarDatos();
        }

        public void CargarDatos()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID_PROYECTO, DESCRIPCION FROM Proyectos", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            DataRow row = dt.NewRow();
            row["Descripcion"] = "Seleccione un proyecto";
            dt.Rows.InsertAt(row, 0);

            comboBox1.ValueMember = "ID_PROYECTO";
            comboBox1.DisplayMember = "DESCRIPCION";
            comboBox1.DataSource = dt;
        }

        public void CargaTarea(string idProyecto)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID_TAREA, DESCRIPCION FROM Tareas WHERE ID_PROYECTO = @idProyecto", conn);
            cmd.Parameters.AddWithValue("idProyecto", idProyecto);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            DataRow row = dt.NewRow();
            row["Descripcion"] = "Selecciona una tarea";
            dt.Rows.InsertAt(row, 0);

            comboBox2.ValueMember = "ID_TAREA";
            comboBox2.DisplayMember = "Descripcion";
            comboBox2.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() != null)
            {
                string idProyecto = comboBox1.SelectedValue.ToString();
                CargaTarea(idProyecto);
            }
        }
    }
}
