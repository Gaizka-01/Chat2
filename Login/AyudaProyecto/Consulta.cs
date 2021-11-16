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
using CapaDatos;
namespace AyudaProyecto
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
            lblNombreConfig.Text = CapaDatos.Usuario.Nombre + "" + CapaDatos.Usuario.Apellido;
            lblGrupo.Text = CapaDatos.Usuario.Grupo;
            lblNickname.Text = CapaDatos.Usuario.Nickname;
            CapaDatos.Consultas.MostrarConsultasA(CapaDatos.Usuario.CI);
            dgNuevo.DataSource = CapaDatos.Consultas.Tabla;

        }
        string temaNuevo;
        string temaBuscar;
        int posicion;
        string consultaDocente;
        int consultaID;
        string consultaTema;
        string usuarioD;

    

    



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

           

        }

        private void dgNuevo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = e.RowIndex;
            DataGridViewRow linea = dgNuevo.Rows[posicion];
            consultaID = Convert.ToInt32(linea.Cells[2].Value);
            usuarioD = linea.Cells[1].Value.ToString();
           try { 
            CapaDatos.Usuario.DevolverPersona(usuarioD);
            CapaDatos.Usuario.DevolverProfesor(CapaDatos.Usuario.CIP);
            lblUsuarioContesta.Text = "Para: " + CapaDatos.Usuario.NombreP + " " + CapaDatos.Usuario.ApellidoP + " Materia: " + CapaDatos.Usuario.materiaP;
            CapaDatos.Consultas.MostrarMensajeConsultaA(consultaID);
            dtgConsultaE.DataSource = CapaDatos.Consultas.TablaMensajeA;
            CapaDatos.Consultas.MostrarMensajeConsultaP(consultaID);
            dtgConsultaP.DataSource = CapaDatos.Consultas.TablaMensajeP;
            dtgConsultaE.Visible = true;
            dtgConsultaP.Visible = true;
            } catch (Exception ea)
            {
                MessageBox.Show(CapaDatos.Usuario.mensaje);
            }
        }

        private void dtgConsultaE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEnviarMensaje_Click(object sender, EventArgs e)
        {
            
        }

        private void btnChats_Click(object sender, EventArgs e)
        {
            chatAlumno nuevo = new chatAlumno();
            nuevo.Show();
            this.Hide();
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            ventanaAlumno nuevo = new ventanaAlumno();
            nuevo.Show();
            this.Hide();
        }
    }
}
 