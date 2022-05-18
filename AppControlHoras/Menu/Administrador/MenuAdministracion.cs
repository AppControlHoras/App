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

        private void btCuentas_Click(object sender, EventArgs e)
        {
            Cuenta accounts = new Cuenta();
            accounts.Show();
            this.Hide();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }

        private void btClientes_Click(object sender, EventArgs e)
        {
            Cliente clientes = new Cliente();
            clientes.Show();
            this.Hide();
        }

        private void btEmpleados_Click(object sender, EventArgs e)
        {
            Empleados.Empleado empleado = new Empleados.Empleado();
            empleado.Show();
            this.Hide();
        }

        private void btTasas_Click(object sender, EventArgs e)
        {
            Tasas.Tasa tasa = new Tasas.Tasa();
            tasa.Show();
            this.Hide();
        }

        private void btAreaFuncional_Click(object sender, EventArgs e)
        {
            AreasFuncionales.Area areaFuncional = new AreasFuncionales.Area();
            areaFuncional.Show();
            this.Hide();
        }

        private void btProyectos_Click(object sender, EventArgs e)
        {
            Proyectos.Proyectos proyecto = new Proyectos.Proyectos();
            proyecto.Show();
            this.Hide();
        }
    }
}
