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
            lblNombreConfig.Text = "" + CapaLogica.DatoUsu.Nombre + "" + CapaLogica.DatoUsu.Apellido;
            lblGrupo.Text = CapaLogica.DatoUsu.Grupo;
            CapaLogica.ConexionBD.Conexion();
            MySqlCommand comando = new MySqlCommand("Select tema, usuarioP, CI From consulta where usuarioA = '"+CapaLogica.DatoUsu.NombreUsu+"' group by tema;", CapaLogica.ConexionBD.conectar);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgNuevo.DataSource = tabla;
            CapaLogica.ConexionBD.CerrarConexion();
        }
        string temaNuevo;
        string temaBuscar;
        int posicion;
        string consultaDocente;
        int CIdocente;
        string consultaTema;

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
            dtgConsultaP.DataSource = tabla;
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
            dtgConsultaP.DataSource = tabla;
            MySqlCommand mostrarMensajeP = new MySqlCommand("Select mensaje From consulta where tema = '" + temaBuscar + "' and CI = '1234567'", conectar);
            MySqlDataAdapter adaptadorP = new MySqlDataAdapter();
            adaptador.SelectCommand = mostrarMensajeP;
            DataTable tablaP = new DataTable();
            adaptador.Fill(tablaP);
            dtgConsultaE.DataSource = tablaP;
            grpNuevaConsulta.Visible = true;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CapaLogica.ConexionBD.Conexion();
            MySqlCommand comando = new MySqlCommand("Select tema From consulta where CI = '"+CapaLogica.DatoUsu.CIUsu+"' group by tema;", CapaLogica.ConexionBD.conectar);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgNuevo.DataSource = tabla;
            CapaLogica.ConexionBD.CerrarConexion();

           

        }

        private void dgNuevo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = e.RowIndex;
            DataGridViewRow linea = dgNuevo.Rows[posicion];
            consultaTema = linea.Cells[0].Value.ToString();
            consultaDocente = linea.Cells[1].Value.ToString();
            CapaLogica.ConexionBD.Conexion();
            MySqlCommand mostrar = new MySqlCommand("Select mensaje From consulta where tema = '"+consultaTema+"' and usuarioA = '"+CapaLogica.DatoUsu.NombreUsu+"' and usuarioP = '"+consultaDocente+"' and CI = '"+CapaLogica.DatoUsu.CIUsu+"' ", CapaLogica.ConexionBD.conectar);
            CapaLogica.ConexionBD.conectar.Open();
            mostrar.ExecuteNonQuery();
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = mostrar;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dtgConsultaE.DataSource = tabla;
            dtgConsultaE.Visible = true;
            CapaLogica.ConexionBD.CerrarConexion();

            CapaLogica.ConexionBD.Conexion();
            MySqlCommand guardarP = new MySqlCommand("Select CI From docente where usuario = '"+consultaDocente+"'", CapaLogica.ConexionBD.conectar);
            CIdocente = Convert.ToInt32(guardarP.ExecuteScalar());
            MySqlCommand mostrarP = new MySqlCommand("Select mensaje From consulta where tema = '"+consultaTema+"' and usuarioA = '"+CapaLogica.DatoUsu.NombreUsu+"' and usuarioP = '"+consultaDocente+"' and CI = '"+CIdocente+"' ", CapaLogica.ConexionBD.conectar);
            mostrarP.ExecuteNonQuery();
            MySqlDataAdapter adaptadorP = new MySqlDataAdapter();
            adaptadorP.SelectCommand = mostrarP;
            DataTable tablaP = new DataTable();
            adaptadorP.Fill(tablaP);
            dtgConsultaP.DataSource = tablaP;
            dtgConsultaP.Visible = true;
            CapaLogica.ConexionBD.CerrarConexion();

            lblUsuarioContesta.Text = "Para: "+consultaDocente;

        }

        private void dtgConsultaE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEnviarMensaje_Click(object sender, EventArgs e)
        {
            CapaLogica.ConexionBD.Conexion();
            MySqlCommand insertar = new MySqlCommand("update consulta set mensaje = '"+txtM.Text+ "' where CI = '"+CapaLogica.DatoUsu.CIUsu+ "' and tema = '"+consultaTema+"' ", CapaLogica.ConexionBD.conectar);
            insertar.ExecuteNonQuery();
            MySqlCommand mostrar = new MySqlCommand("Select mensaje From consulta where tema = '" + consultaTema + "' and usuarioA = '" + CapaLogica.DatoUsu.NombreUsu + "' and usuarioP = '" + consultaDocente + "' and CI = '" + CapaLogica.DatoUsu.CIUsu + "' ", CapaLogica.ConexionBD.conectar);
            mostrar.ExecuteNonQuery();
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = mostrar;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dtgConsultaE.DataSource = tabla;
            CapaLogica.ConexionBD.CerrarConexion();
            txtM.Text = "Message";
        }
    }
}
 