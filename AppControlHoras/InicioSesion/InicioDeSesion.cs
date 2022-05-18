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

namespace AppControlHoras
{
    public partial class InicioSesion : Form
    {
        public String conn = @"Data Source = TERESA\SERVERSQL; Initial Catalog = ControlHoras; Integrated Security = True";
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        public InicioSesion()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

        }

        private void BtInicioSesion_Click(object sender, EventArgs e)
        {
            
            if (!String.IsNullOrEmpty(TbUser.Text) && !String.IsNullOrEmpty(TbPswd.Text))
            {
                
                try
                {
                    BaseDeDatos bd = new BaseDeDatos();

                    Boolean result = bd.LogIn(TbUser.Text, TbPswd.Text);

                    if (result)
                    {
                        MenuPrincipal principal = new MenuPrincipal();
                        this.Hide();
                        principal.Show();
                        TbUser.Clear();
                        TbPswd.Clear();

                        principal.FormClosing += new FormClosingEventHandler(Form_FormClosing);
                        

                        
                    }
                    else
                    {
                        MessageBox.Show("Datos Incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Rellene los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }


        private void InicioSesion_Load(object sender, FormClosingEventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'controlHorasDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            // this.empleadosTableAdapter.Fill(this.controlHorasDataSet.Empleados);
            Application.Exit();
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            
            SqlDataReader dReader;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = conn;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select  Usuario from Empleados order by Usuario asc";
            con.Open();
            dReader = cmd.ExecuteReader();
            if (dReader.HasRows == true)
            {
                while (dReader.Read())
                namesCollection.Add(dReader["Usuario"].ToString());
            }
            else
            {
                MessageBox.Show("Data not found");
            }

            dReader.Close();

            TbUser.AutoCompleteMode = AutoCompleteMode.Suggest;
            TbUser.AutoCompleteSource = AutoCompleteSource.CustomSource;
            TbUser.AutoCompleteCustomSource = namesCollection;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            TbPswd.PasswordChar = '\0';
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            TbPswd.PasswordChar = '*';
        }

       

        private void TbPswd_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }
    }
}
