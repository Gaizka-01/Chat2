using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

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

        string condicion;
        string usuario;
        int CI;
        string Contrasenia;
        

        

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registrar nueva = new Registrar();
            this.Hide();
            nueva.Show();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                usuario = tbUsuario.Text;
            CI = Convert.ToInt32(txtCI.Text);
            Contrasenia = tbContraseña.Text;
            

            
            CapaDatos.Usuario.BuscarUsuario(usuario, CI, Contrasenia, condicion);

            if (CapaDatos.Usuario.Error == false && condicion == "Alumno")
            {
                MessageBox.Show(CapaDatos.Usuario.mensaje);
                
                CapaDatos.Usuario.DevolverAlumno(CI);
                ventanaAlumno nuevaA = new ventanaAlumno();
                nuevaA.Show();
                this.Hide();


            } else if (CapaDatos.Usuario.Error == false && condicion == "Docente")
            {
                MessageBox.Show(CapaDatos.Usuario.mensaje);
                
                CapaDatos.Usuario.DevolverProfesor(CI);
                ventanaProfesor nuevaA = new ventanaProfesor();
                nuevaA.Show();
                this.Hide();


            } else
            {
                MessageBox.Show(CapaDatos.Usuario.mensaje);
            }
             } catch (Exception eS)
            {
                MessageBox.Show("A ocurrido un error, Vuelve a intentarlo" + eS);
            }
        }

     

     
     

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tbUsuario.Visible = true;
            tbContraseña.Visible = true;
            btnAcceder.Visible = false;
            btnAccederAdmin.Visible = true;
            btnRegistrar.Visible = true;
            btnVolver.Visible = true;
            groupUsuario.Visible = false;
            Logo.Visible = true;
            lblMenssages.Visible = true;
            txtCI.Visible = false;
            condicion = "admin";
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
            condicion = "Docente";
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
            condicion = "Alumno";
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
            btnAccederAdmin.Visible = false;
            tbUsuario.Text = "Usuario";
            txtCI.Text = "Cedula";
            tbContraseña.Text = "Contraseña";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbUsuario_Enter(object sender, EventArgs e)
        {
            if (tbUsuario.Text == "Usuario") tbUsuario.Text = "";
        }

        private void txtCI_Enter(object sender, EventArgs e)
        {
            if (txtCI.Text == "Cedula") txtCI.Text = "";
        }

        private void tbContraseña_Enter(object sender, EventArgs e)
        {
            if (tbContraseña.Text == "Contraseña") tbContraseña.Text = "";

        }

        private void btnAccederAdmin_Click(object sender, EventArgs e)
        {
            usuario = tbUsuario.Text;
            Contrasenia = tbContraseña.Text;
            if (usuario == "admin" && Contrasenia == "123")
            {
                ventanaAdministrador nueva = new ventanaAdministrador();
                nueva.Show();
                this.Hide();
            }
        }

        private void tbContraseña_TextChanged(object sender, EventArgs e)
        {
            if (tbContraseña.Text=="Contraseña")
            {

            } else
            {
                tbContraseña.PasswordChar = '*';
            }
        }
    }
}
