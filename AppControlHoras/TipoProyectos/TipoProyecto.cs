using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppControlHoras.TipoProyectos
{
    public partial class TipoProyecto : Form
    {
        public TipoProyecto()
        {
            InitializeComponent();
        }

        private void btAnadir_Click(object sender, EventArgs e)
        {
            TipoProyectos.AnadirTipoProyecto proyecto = new TipoProyectos.AnadirTipoProyecto();
            proyecto.Show();
            this.Hide();

            proyecto.FormClosing += new FormClosingEventHandler(Form_FormClosing);
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            TipoProyectos.AnadirTipoProyecto proyecto = new TipoProyectos.AnadirTipoProyecto();
            proyecto.Show();
            this.Hide();

            proyecto.FormClosing += new FormClosingEventHandler(Form_FormClosing);
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            TipoProyectos.AnadirTipoProyecto proyecto = new TipoProyectos.AnadirTipoProyecto();
            proyecto.Show();
            this.Hide();

            proyecto.FormClosing += new FormClosingEventHandler(Form_FormClosing);
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TipoProyecto_Load(object sender, EventArgs e)
        {

        }
    }
}
