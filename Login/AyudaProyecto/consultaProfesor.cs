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
using AyudaProyecto.Properties;

namespace AyudaProyecto
{
    public partial class consultaProfesor : Form
    {
        public consultaProfesor()
        {
            InitializeComponent();
        }

        class consultaPorefsor : AyudaProyecto.Properties.Form1
        {
            
        }
        string tema;


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server = 127.0.0.2; port = 3306; database = bdsistema; Uid = root; pwd = MalvinyBolso;");
            conectar.Open();
            MySqlCommand MostrarConsultas = new MySqlCommand("Select tema From consulta where CI = '"+ txtCI.Text +"' group by tema;", conectar);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = MostrarConsultas;
            DataTable tablaConsultas = new DataTable();
            adaptador.Fill(tablaConsultas);
            dtgMostrarConsultas.DataSource = tablaConsultas;
            grpBuscarConsultas1.Visible = true;

        }

        private void lbGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server = 127.0.0.2; port = 3306; database = bdsistema; Uid = root; pwd = MalvinyBolso;");
            conectar.Open();
            MySqlCommand MostrarAlumnos = new MySqlCommand("Select CI, Nombre, Apellido From persona where Grupo = '" + lbGrupos.SelectedItem.ToString() + "';", conectar);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = MostrarAlumnos;
            DataTable tablaAlumnos = new DataTable();
            adaptador.Fill(tablaAlumnos);
            dtgAlumnos.DataSource = tablaAlumnos;
        }

        private void btnBuscar1_Click(object sender, EventArgs e)
        {
            tema = txtConsulta.Text;
            MySqlConnection conectar = new MySqlConnection("server = 127.0.0.2; port = 3306; database = bdsistema; Uid = root; pwd = MalvinyBolso;");
            conectar.Open();
            MySqlCommand MostrarConsulta = new MySqlCommand("Select mensaje From consulta where tema = '" + txtConsulta.Text + "';", conectar);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = MostrarConsulta;
            DataTable tablaMensajes = new DataTable();
            adaptador.Fill(tablaMensajes);
            dtgMensajeA.DataSource = tablaMensajes;
            grpMostrarConsultas.Visible = true;
        }

        private void txtEnviar_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server = 127.0.0.2; port = 3306; database = bdsistema; Uid = root; pwd = MalvinyBolso;");
            conectar.Open();
            MySqlCommand EnviarMensaje = new MySqlCommand("insert into consulta(CI, tema, mensaje) values('1234567','" + tema + "', '" + txtMensaje.Text + "' ); ", conectar);
            EnviarMensaje.ExecuteNonQuery();
            MySqlCommand insertar = new MySqlCommand("Select mensaje From consulta where tema = '" + txtConsulta.Text + "' and CI = '1234567';", conectar);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = insertar;
            DataTable tablaMensajesP = new DataTable();
            adaptador.Fill(tablaMensajesP);
            dtgMensajeP.DataSource = tablaMensajesP;
        }

        private void dtgMensajeP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
