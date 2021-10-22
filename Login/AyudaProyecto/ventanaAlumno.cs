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


namespace AyudaProyecto
{
    public partial class ventanaAlumno : Form
    {
        public ventanaAlumno()
        {
            InitializeComponent();
            lblNombreConfig.Text = CapaLogica.DatoUsu.Nombre + " "+ CapaLogica.DatoUsu.Apellido;
            lblGrupo.Text = CapaLogica.DatoUsu.Grupo;
           
        }

        void OcultarCrear()
        {
            fondoCrear.Visible = false;
            grpCrear.Visible = false;
        }

        void Mostrar()
        {
            txtDocente.Visible = true;
            txtMensaje.Visible = true;
            btnEnviarMensaje.Visible = true;
            btnEnviarFoto.Visible = true;
        }

        private void btnMostar_Click(object sender, EventArgs e)
        {
            CapaLogica.ConexionBD.Conexion();
            CapaLogica.ConexionBD.conectar.Open();
            MySqlCommand comando = new MySqlCommand("Select persona.Nombre, docente.Materia from persona, docente where persona.CI = docente.CI", CapaLogica.ConexionBD.conectar);
            CapaLogica.ConexionBD.conectar.Close();
            CapaLogica.ConexionBD.CerrarConexion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

      

        private void lblNombreConfig_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearChat_Click(object sender, EventArgs e)
        {
            Consulta nuevo = new Consulta();
            nuevo.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            fondoCrear.Visible = true;
            grpCrear.Visible = true;
        }

        private void btnCancelarCrear_Click(object sender, EventArgs e)
        {
            fondoCrear.Visible = false;
            grpCrear.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            Consulta nuevo = new Consulta();
            nuevo.Show();
            this.Hide();

        }

        private void btnNuevaConsulta_Click(object sender, EventArgs e)
        {
            
            grpTema.Visible = true;
            txtTema.Visible = true;
            OcultarCrear();
            Mostrar();


        }

        private void btnEnviarMensaje_Click(object sender, EventArgs e)
        {
            if (txtMensaje.Text == "Message" || txtMensaje.Text == "")
            {
                MessageBox.Show("Debes escribir un mensaje valido");
            }
            else if (txtDocente.Text == "Insertar usuario del docente" || txtMensaje.Text == "")
            {
                MessageBox.Show("Debes escribir el usuario del docente");
            }
            else if (txtTema.Text == "Escribir tema de la consulta" || txtTema.Text == "")
            {
                MessageBox.Show("Debes escribir el tema de la consulta");
            }
            else
            {

                CapaLogica.ConexionBD.conectar.Close();
                CapaLogica.ConexionBD.Conexion();
                MySqlCommand buscarDocente = new MySqlCommand("Select usuario from persona where usuario = '"+txtDocente.Text+"'", CapaLogica.ConexionBD.conectar);
                CapaLogica.ConexionBD.conectar.Open();
                MySqlDataReader verificar = buscarDocente.ExecuteReader();
                

                    if (verificar.Read())
                    {
                    CapaLogica.ConexionBD.conectar.Close();
                    CapaLogica.ConexionBD.CerrarConexion();
                    //Crear consulta
                    CapaLogica.ConexionBD.conectar.Open();
                        MySqlCommand consulta = new MySqlCommand("insert into consulta (tema, mensaje, usuarioA, usuarioP, CI) values ('"+txtTema.Text+"', '"+txtMensaje.Text+"', '"+CapaLogica.DatoUsu.NombreUsu+"', '"+txtDocente.Text+"', '"+CapaLogica.DatoUsu.CIUsu+"');", CapaLogica.ConexionBD.conectar);
                        consulta.ExecuteNonQuery();
                        MySqlCommand mostrarConsulta = new MySqlCommand("Select mensaje From consulta where tema = '"+txtTema.Text+"' and usuarioA = '"+CapaLogica.DatoUsu.NombreUsu+"' and usuarioP = '"+txtDocente.Text+"' and CI = '"+CapaLogica.DatoUsu.CIUsu+"' ", CapaLogica.ConexionBD.conectar);
                        mostrarConsulta.ExecuteNonQuery();
                        MySqlDataAdapter adaptadorConsulta = new MySqlDataAdapter();
                        adaptadorConsulta.SelectCommand = mostrarConsulta;
                        DataTable tablaConsulta = new DataTable();
                        adaptadorConsulta.Fill(tablaConsulta);
                        dtgConsulta.DataSource = tablaConsulta;
                        dtgConsulta.Visible = true;
                        CapaLogica.ConexionBD.CerrarConexion();
                    }

               
            }
        }
    }
}
