using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppControlHoras
{
    public partial class MenuAdministracion : Form
    {
        public MenuAdministracion()
        {
            InitializeComponent();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btCuentas_Click(object sender, EventArgs e)
        {
            Cuenta accounts = new Cuenta();
            accounts.Show();
            this.Hide();

            accounts.FormClosing += new FormClosingEventHandler(Form_FormClosing);
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Close();

        }

        private void btClientes_Click(object sender, EventArgs e)
        {
            Cliente clientes = new Cliente();
            clientes.Show();
            this.Hide();

            clientes.FormClosing += new FormClosingEventHandler(Form_FormClosing);
        }

        private void btEmpleados_Click(object sender, EventArgs e)
        {
            Empleados.Empleado empleado = new Empleados.Empleado();
            empleado.Show();
            this.Hide();

            empleado.FormClosing += new FormClosingEventHandler(Form_FormClosing);
        }

        private void btTasas_Click(object sender, EventArgs e)
        {
            Tasas.Tasa tasa = new Tasas.Tasa();
            tasa.Show();
            this.Hide();

            tasa.FormClosing += new FormClosingEventHandler(Form_FormClosing);
        }

        private void btAreaFuncional_Click_1(object sender, EventArgs e)
        {
            AreasFuncionales.Area areaFuncional = new AreasFuncionales.Area();
            areaFuncional.Show();
            this.Hide();

            areaFuncional.FormClosing += new FormClosingEventHandler(Form_FormClosing);
        }

        private void btProyectos_Click(object sender, EventArgs e)
        {
            Proyectos.Proyectos proyecto = new Proyectos.Proyectos();
            proyecto.Show();
            this.Hide();

            proyecto.FormClosing += new FormClosingEventHandler(Form_FormClosing);
        }

        private void btTipoProyectos_Click(object sender, EventArgs e)
        {
            TipoProyectos.TipoProyecto proyecto = new TipoProyectos.TipoProyecto();
            proyecto.Show();
            this.Hide();

            proyecto.FormClosing += new FormClosingEventHandler(Form_FormClosing);
        }

        private void MenuAdministracion_Load(object sender, EventArgs e)
        {

        }

        private void btTareas_Click(object sender, EventArgs e)
        {
            Tareas.Tarea tarea = new Tareas.Tarea();
            tarea.Show();
            this.Hide();

            tarea.FormClosing += new FormClosingEventHandler(Form_FormClosing);
        }

        private void btTareas_Click_1(object sender, EventArgs e)
        {
            Tareas.Tarea tarea = new Tareas.Tarea();
            tarea.Show();
            this.Hide();
        }

        private void btEmpleadosArea_Click(object sender, EventArgs e)
        {
            EmpleadosArea.EmpleadosArea area = new EmpleadosArea.EmpleadosArea();
            area.Show();
            this.Hide();

            area.FormClosing += new FormClosingEventHandler(Form_FormClosing);
        }
    }
}
