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
        }

      
        private void btnMostar_Click(object sender, EventArgs e)
        {
            CapaLogica.ConexionBD.Conexion();
            CapaLogica.ConexionBD.conectar.Open();
            MySqlCommand comando = new MySqlCommand("Select persona.Nombre, docente.Materia from persona, docente where persona.CI = docente.CI", CapaLogica.ConexionBD.conectar);
        
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
    }
}
