using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AyudaProyecto.Properties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }

        private void chkboxAlumno_CheckedChanged(object sender, EventArgs e)
        {
            tbUsuario.Visible = true;
            tbContraseña.Visible = true;
            btnAcceder.Visible = true;
            btnRegistrar.Visible = true;
            btnVolver.Visible = true;
            groupUsuario.Visible = false;
            lblIngresa.Visible = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            tbUsuario.Visible = true;
            tbContraseña.Visible = true;
            btnAcceder.Visible = true;
            btnRegistrar.Visible = true;
            btnVolver.Visible = true;
            groupUsuario.Visible = false;
            lblIngresa.Visible = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            tbUsuario.Visible = true;
            tbContraseña.Visible = true;
            btnAcceder.Visible = true;
            btnRegistrar.Visible = true;
            btnVolver.Visible = true;
            groupUsuario.Visible = false;
            lblIngresa.Visible = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registrar nueva = new Registrar();
            this.Hide();
            nueva.Show();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server = 127.0.0.2; port = 3306; database = bdsistema; Uid = root; pwd = MalvinyBolso;");
            conectar.Open();
            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conectar;
            codigo.CommandText = ("Select usuario, Contraseña from Persona where usuario = '" + tbUsuario.Text + "' and Contraseña = '" + tbContraseña.Text + "'");
            MySqlDataReader leer = codigo.ExecuteReader();
            
            if (chkboxAlumno.Checked == true && leer.Read()) { 
            ventanaAlumno nueva = new ventanaAlumno();
            nueva.Show();
            this.Hide();
            } else if (chkboxProfesor.Checked == true && leer.Read())
            {
                ventanaProfesor nuevaP = new ventanaProfesor();
                nuevaP.Show();
                this.Hide();
            }
        }
    }
}
