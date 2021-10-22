using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using MySql.Data.MySqlClient;

namespace AyudaProyecto
{
    public partial class ventanaProfesor : Form
    {
        public ventanaProfesor()
        {
            InitializeComponent();
            lblNombreConfig.Text = CapaLogica.DatoUsu.Nombre + " " + CapaLogica.DatoUsu.Apellido;

        }
        int posicion;
        string consultaTema;
        string consultaAlumno;
        
        private void btnConsultas_Click(object sender, EventArgs e)
        {

            CapaLogica.ConexionBD.Conexion();
            MySqlCommand MostrarConsultas = new MySqlCommand("Select consulta.tema, consulta.usuarioA, persona.Grupo From consulta, persona where consulta.usuarioP = '"+CapaLogica.DatoUsu.NombreUsu+"' and consulta.CI = persona.CI;", CapaLogica.ConexionBD.conectar);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = MostrarConsultas;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgNuevo.DataSource = tabla;
             
            CapaLogica.ConexionBD.CerrarConexion();
        }

        private void dgNuevo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagrid Consulta alumno
            posicion = e.RowIndex;
            DataGridViewRow linea = dgNuevo.Rows[posicion];
            consultaTema = linea.Cells[0].Value.ToString();
            consultaAlumno = linea.Cells[1].Value.ToString();
            CapaLogica.ConexionBD.Conexion();
            MySqlCommand mostrarConsulta = new MySqlCommand("Select mensaje From consulta where tema = '"+consultaTema+"' and usuarioP = '"+CapaLogica.DatoUsu.NombreUsu+"' and usuarioA = '"+consultaAlumno+"'", CapaLogica.ConexionBD.conectar);
            mostrarConsulta.ExecuteNonQuery();
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = mostrarConsulta;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dtgConsultaR.DataSource = tabla;
            dtgConsultaR.Visible = true;

            //Recuperar datos del alumno

            MySqlCommand Nombre = new MySqlCommand("Select Nombre From persona where usuario = '"+consultaAlumno+"'", CapaLogica.ConexionBD.conectar);
            MySqlCommand Apellido = new MySqlCommand("Select Apellido From persona where usuario = '"+consultaAlumno+"'", CapaLogica.ConexionBD.conectar);
            MySqlCommand Grupo = new MySqlCommand("Select Grupo From persona where usuario = '"+consultaAlumno+"'", CapaLogica.ConexionBD.conectar);
            MySqlCommand CI = new MySqlCommand("Select CI From persona where usuario = '"+consultaAlumno+"'", CapaLogica.ConexionBD.conectar);

            Nombre.ExecuteNonQuery();
            Apellido.ExecuteNonQuery();
            Grupo.ExecuteNonQuery();
            string NombreA;
            string ApellidoA;
            string GrupoA;
            string CIA;
            NombreA = Nombre.ExecuteScalar().ToString();
            ApellidoA = Apellido.ExecuteScalar().ToString();
            GrupoA = Grupo.ExecuteScalar().ToString();
            CIA = CI.ExecuteScalar().ToString();
         
            lblUsuarioContesta.Text = "Para: " + NombreA + " / " + ApellidoA + " / " + CIA + " / " + GrupoA;
            CapaLogica.ConexionBD.CerrarConexion();


        }

        private void btnEnviarMensaje_Click(object sender, EventArgs e)
        {
            CapaLogica.ConexionBD.Conexion();
            MySqlCommand enviarRespuesta = new MySqlCommand("insert into consulta (tema, mensaje, usuarioA, usuarioP, CI) values ('"+consultaTema+"', '"+txtM.Text+"', '"+consultaAlumno+"', '"+CapaLogica.DatoUsu.NombreUsu+"', '"+CapaLogica.DatoUsu.CIUsu+"')", CapaLogica.ConexionBD.conectar);
            enviarRespuesta.ExecuteNonQuery();
            MySqlCommand mostrarR = new MySqlCommand("Select mensaje From consulta where tema = '"+consultaTema+"' and usuarioP = '"+CapaLogica.DatoUsu.NombreUsu+"' and usuarioA = '"+consultaAlumno+"' and CI = '"+CapaLogica.DatoUsu.CIUsu+"' ", CapaLogica.ConexionBD.conectar);
            mostrarR.ExecuteNonQuery();
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = mostrarR;
            DataTable tablaR = new DataTable();
            adaptador.Fill(tablaR);
            dtgConsultaE.DataSource = tablaR;
            dtgConsultaE.Visible = true;
            CapaLogica.ConexionBD.CerrarConexion();
            txtM.Text = "Message";
        }
    }
}
