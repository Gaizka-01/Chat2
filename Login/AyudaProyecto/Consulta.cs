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
            MySqlCommand insertar = new MySqlCommand("update consulta set mensaje = '"+txtM.Text+ "' where CI = '"+CapaLogica.DatoUsu.CIUsu+ "' and tema = '"+consultaTema+"' and usuarioP = '"+ consultaDocente + "' ", CapaLogica.ConexionBD.conectar);
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
 