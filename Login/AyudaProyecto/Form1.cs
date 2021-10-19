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
using CapaLogica;

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

        string tipoUsu;
        

        

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registrar nueva = new Registrar();
            this.Hide();
            nueva.Show();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            CapaLogica.ConexionBD.Conexion();
            CapaLogica.ConexionBD.conectar.Open();
            MySqlCommand comando = new MySqlCommand("Select usuario, Contraseña from Persona where usuario = ' "+ tbUsuario.Text +" ' and Contraseña = '"+ tbContraseña.Text +"'", CapaLogica.ConexionBD.conectar);
            MySqlDataReader verificar = comando.ExecuteReader();

            if (tipoUsu == "alumno" && verificar.Read()) {
                CapaLogica.DatoUsu.CIUsu = int.Parse(txtCI.Text);
                CapaLogica.DatoUsu.NombreUsu = tbUsuario.Text;
               
                ventanaAlumno nueva = new ventanaAlumno();
            nueva.Show();
            this.Hide();
                CapaLogica.ConexionBD.conectar.Close();
            } else if (tipoUsu == "docente" && verificar.Read())
            {
                CapaLogica.DatoUsu.CIUsu = int.Parse(txtCI.Text);
                CapaLogica.DatoUsu.NombreUsu = tbUsuario.Text;
                ventanaProfesor nuevaP = new ventanaProfesor();
                nuevaP.Show();
                this.Hide();
                CapaLogica.ConexionBD.conectar.Close();

            }
            else
            {
                MessageBox.Show("No se encontro ningun usuario");
            }
        }

     

     
     

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tbUsuario.Visible = true;
            tbContraseña.Visible = true;
            btnAcceder.Visible = true;
            btnRegistrar.Visible = true;
            btnVolver.Visible = true;
            groupUsuario.Visible = false;
            Logo.Visible = true;
            lblMenssages.Visible = true;
            txtCI.Visible = true;
            tipoUsu = "admin";
        }

        private void picDocente_Click(object sender, EventArgs e)
        {
            tbUsuario.Visible = true;
            tbContraseña.Visible = true;
            btnAcceder.Visible = true;
            btnRegistrar.Visible = true;
            btnVolver.Visible = true;
            groupUsuario.Visible = false;
            Logo.Visible = true;
            lblMenssages.Visible = true;
            txtCI.Visible = true;
            tipoUsu = "docente";
        }

        private void picAlumno_Click(object sender, EventArgs e)
        {
            tbUsuario.Visible = true;
            tbContraseña.Visible = true;
            btnAcceder.Visible = true;
            btnRegistrar.Visible = true;
            btnVolver.Visible = true;
            groupUsuario.Visible = false;
            Logo.Visible = true;
            lblMenssages.Visible = true;
            txtCI.Visible = true;
            tipoUsu = "alumno";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            tbUsuario.Visible = false;
            tbContraseña.Visible = false;
            btnAcceder.Visible = false;
            btnRegistrar.Visible = false;
            btnVolver.Visible = false;
            groupUsuario.Visible = true;
            Logo.Visible = false;
            lblMenssages.Visible = false;
            txtCI.Visible = false;

        }

       
    }
}
