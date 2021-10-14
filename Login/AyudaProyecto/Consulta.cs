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
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }
        string temaNuevo;
        string temaBuscar;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtConsulta.Text == "")
            {
                MessageBox.Show("Debes ingresar un tema para poder crear una nueva consulta");
            } else
            {
                grpConsulta.Visible = false;
                grpNuevaConsulta.Visible = true;
                temaNuevo = txtConsulta.Text;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            grpConsultasAnt.Visible = true;
            MySqlConnection conectar = new MySqlConnection("server = 127.0.0.2; port = 3306; database = bdsistema; Uid = root; pwd = MalvinyBolso;");
            conectar.Open();
            MySqlCommand comando = new MySqlCommand("Select tema From consulta where CI = '3333' group by tema;", conectar);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dtgConsultasAnt.DataSource = tabla;
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            grpConsulta.Visible = true;
            
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server = 127.0.0.2; port = 3306; database = bdsistema; Uid = root; pwd = MalvinyBolso;");
            conectar.Open();
            MySqlCommand insertar = new MySqlCommand("insert into consulta(CI, tema, mensaje) values('3333','"+ temaNuevo +"', '"+ txtMensaje.Text +"' ); ", conectar);
            insertar.ExecuteNonQuery();
            MySqlCommand mostrar = new MySqlCommand("Select mensaje From consulta where tema = '"+ temaNuevo +"'", conectar);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = mostrar;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dtgMensajesA.DataSource = tabla;
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            temaBuscar = txtBuscarConsulta.Text;
            MySqlConnection conectar = new MySqlConnection("server = 127.0.0.2; port = 3306; database = bdsistema; Uid = root; pwd = MalvinyBolso;");
            conectar.Open();
            MySqlCommand mostrarMensajeA = new MySqlCommand("Select mensaje From consulta where tema = '" + temaBuscar + "' and CI = '3333'", conectar);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = mostrarMensajeA;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dtgMensajesA.DataSource = tabla;
            MySqlCommand mostrarMensajeP = new MySqlCommand("Select mensaje From consulta where tema = '" + temaBuscar + "' and CI = '1234567'", conectar);
            MySqlDataAdapter adaptadorP = new MySqlDataAdapter();
            adaptador.SelectCommand = mostrarMensajeP;
            DataTable tablaP = new DataTable();
            adaptador.Fill(tablaP);
            dtgMensajeP.DataSource = tablaP;
            grpNuevaConsulta.Visible = true;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
