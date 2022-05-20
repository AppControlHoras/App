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

namespace AppControlHoras.Empleados
{
    public partial class Empleado : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source = BATTISTA\\DAVIDSERVER; Initial Catalog = BBDD_HORAS; Integrated Security = True");

        public Empleado()
        {
            InitializeComponent();
        }

        private DataTable showInfo()
        {
            // Muestra solo los empleados que el campo fechaBaja es null, lo que quiere decir que son actuales
            string query = "select em.idEmpleado as 'ID Empleado', em.nombre as 'Nombre', em.primerApellido as 'Primer Apellido', em.segundoApellido as 'Segundo Apellido', em.email as 'Email', em.fechaAlta as 'Fecha Alta', ta.valor as 'Valor Tasa', ar.descripcion as 'Nombre Departamento' " +
                            "from Empleados em " +
                            "join Tasa ta on em.idTasa=ta.idTasa " +
                            "join AreasFuncionales ar on em.idArea=ar.idArea " +
                            "where em.fechaBaja is null";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        private void Empleado_Load(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = showInfo();
        }

        private void btAnadir_Click(object sender, EventArgs e)
        {
            AnadirEmpleado anadir = new AnadirEmpleado();
            anadir.Show();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            EliminarEmpleado eliminar = new EliminarEmpleado();
            eliminar.Show();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            ModificarEmpleado modificar = new ModificarEmpleado();
            modificar.Show();
            
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Empleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
