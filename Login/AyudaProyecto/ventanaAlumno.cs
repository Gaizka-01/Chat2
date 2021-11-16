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
    public partial class ventanaAlumno : Form
    {
        public ventanaAlumno()
        {
            InitializeComponent();
            lblNombreConfig.Text = CapaDatos.Usuario.Nombre + " " + CapaDatos.Usuario.Apellido;
            lblGrupo.Text = CapaDatos.Usuario.Grupo;
            lblNickname.Text = CapaDatos.Usuario.Nickname;
        }

        void OcultarCrear()
        {
            fondoCrear.Visible = false;
            grpCrear.Visible = false;
        }
        void OcularConsulta()
        {
            txtDocente.Visible = false;
            txtTema.Visible = false;
            lblUsuarioContesta.Visible = false;
            txtMensaje.Visible = false;
            btnEnviarMensaje.Visible = false;
            grpTema.Visible = false;
        }
        void Mostrar()
        {
            txtDocente.Visible = true;
            txtMensaje.Visible = true;
            btnEnviarMensaje.Visible = true;
        }

        int posicion;
        int IDsala;
        string mensaje;
        private void btnMostar_Click(object sender, EventArgs e)
        {

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
            chatAlumno nuevo = new chatAlumno();
            nuevo.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            OcularConsulta();
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
            lblUsuarioContesta.Visible = true;
            grpTema.Visible = true;
            txtTema.Visible = true;
            OcultarCrear();
            Mostrar();


        }

        private void btnEnviarMensaje_Click(object sender, EventArgs e)
        {
           
            try { 
            CapaDatos.Consultas.EnviarMensajeA(txtTema.Text, txtMensaje.Text, CapaDatos.Usuario.CI, txtDocente.Text);
            if (CapaDatos.Usuario.Error == false)
            {
                dtgConsulta.DataSource = CapaDatos.Consultas.TablaMensajeA;
                dtgConsulta.Visible = true;
                MessageBox.Show(CapaDatos.Usuario.mensaje);
                txtMensaje.Text = "";
                
            }
            else
            {
                MessageBox.Show(CapaDatos.Usuario.mensaje);
            }
            } catch (Exception eas)
            {
                MessageBox.Show("Ocurrio un error \n" + eas);
            }
        }

        private void btnChats_Click(object sender, EventArgs e)
        {
            chatAlumno nuevo = new chatAlumno();
            nuevo.Show();
            this.Hide();
        }

        private void dgNuevo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       

        }

        private void btnModiNickname_Click(object sender, EventArgs e)
        {
            grpModificarNick.Visible = true;
            txtNuevoNick.Visible = true;
            btnCambiar.Visible = true;
        }

        private void txtNuevoNick_Enter(object sender, EventArgs e)
        {
            if (txtNuevoNick.Text == "Escribir nuevo nickname") txtNuevoNick.Text = "";
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            
            if (txtNuevoNick.Text == "Escribir nuevo nickname" || txtNuevoNick.Text == "" )
            {
                MessageBox.Show("Debe insertar un Nickname valido");
            } else
            {
                try
                {
                    string nuevonick = txtNuevoNick.Text;
                    CapaDatos.Usuario.CambiarNickname(nuevonick, CapaDatos.Usuario.CI);
                    lblNickname.Text = nuevonick;
                    MessageBox.Show("Nickname actualizado");
                } catch (Exception n)
                {
                    MessageBox.Show(CapaDatos.Usuario.mensaje);
                }
                finally
                {
                    grpModificarNick.Visible = false;
                }
                    
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            grpModificar.Visible = true;
            OcularConsulta();
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            grpModificar.Visible = false;
            grpModificarNick.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CapaDatos.Usuario.BajaUsuario(CapaDatos.Usuario.CI);
            if (CapaDatos.Usuario.Error == false)
            {
                MessageBox.Show(CapaDatos.Usuario.mensaje);
                this.Close();
            } else
            {
                MessageBox.Show(CapaDatos.Usuario.mensaje);
            }
        }

        private void btnLegajo_Click(object sender, EventArgs e)
        {
            Legajo nuevo = new Legajo();
            nuevo.Show();
            this.Hide();
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            Agenda nueva = new Agenda();
            nueva.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            chatAlumno nuevo = new chatAlumno();
            nuevo.Show();
            this.Hide();
        }

        private void txtDocente_Enter(object sender, EventArgs e)
        {
            if (txtDocente.Text == "Insertar usuario del docente") txtDocente.Text = "";
        }

        private void txtTema_Enter(object sender, EventArgs e)
        {
            if (txtTema.Text == "Escribir tema de la consulta") txtTema.Text = "";
        }

        private void txtMensaje_Enter(object sender, EventArgs e)
        {
            if (txtMensaje.Text == "Message") txtMensaje.Text = "";
        }
    }
}
