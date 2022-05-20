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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            lblUser.Text = BaseDeDatos.Username;

            //if (BaseDeDatos.Username.Equals("alvaro.benito")){
             //   BtAdmin.Visible = true;
             //   BtAusencias.Visible = true;
             //   BtExportar.Visible = true;
             //   BtImputacion.Visible = true;
           // }
           // else
           // {
            //    BtExportar.Visible = true;
             //   BtImputacion.Visible = true;
           // }
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtAdmin_Click(object sender, EventArgs e)
        {
            MenuAdministracion menuAdministracion = new MenuAdministracion();
            this.Hide();
            menuAdministracion.Show();

            menuAdministracion.FormClosing += new FormClosingEventHandler(Form_FormClosing);
        }

        private void BtImputacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Imputacion", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Show();
        }

        private void BtExportar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exportar", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Show();
        }

        private void BtAusencias_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ausencias", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
