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
namespace AyudaProyecto
{
    public partial class chatAlumno : Form
    {
        public chatAlumno()
        {
            InitializeComponent();
            lblNombreConfig.Text = CapaDatos.Usuario.Nombre + " " + CapaDatos.Usuario.Apellido;
            lblGrupo.Text = CapaDatos.Usuario.Grupo;
            lblNickname.Text = CapaDatos.Usuario.Nickname;
            CapaDatos.Chats.MostrarSalasA(CapaDatos.Usuario.Grupo);
            dgNuevo.DataSource = CapaDatos.Chats.TablaC;
            
        }

        int posicion;
        int IDsala;
        string mensaje;

        void OcultarChat()
        {
            txtMensaje.Visible = false;
            btnEnviarFoto.Visible = false;
            btnEnviarMensaje.Visible = false;
            btnFinalizar.Visible = false;
            lblTituloChat.Visible = false;
            pnlMensajes.Visible = false;
        }

        void AgregarMensajeE(string mensaje)
        {
            var burbuja = new ChatItems.Enviado();
            pnlMensajes.Controls.Add(burbuja);
            burbuja.Dock = DockStyle.Top;
            burbuja.MensajeE = mensaje;
        }

        void AgregarMensajeR(string mensaje, string usuarioAMR)
        {
            var burbuja = new ChatItems.Recibido();
            pnlMensajes.Controls.Add(burbuja);
            burbuja.Dock = DockStyle.Top;
            burbuja.MensajeR = mensaje;
            burbuja.UsuarioR = usuarioAMR;
        }

        private void txtTituloChat_Enter(object sender, EventArgs e)
        {
            if (txtTituloChat.Text == "Titulo del chat") txtTituloChat.Text = "";
            lblTitulo.Visible = true;
        }

        private void txtUsuarioP_Enter(object sender, EventArgs e)
        {
            if (txtUsuarioP.Text == "Inserte usuario profesor") txtUsuarioP.Text = "";
            lblUsu.Visible = true;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try { 
            if (txtUsuarioP.Text == "" && txtTituloChat.Text == "") MessageBox.Show("Debes completar todos los campos");
            string usuarioP = txtUsuarioP.Text;
            string titulo = txtTituloChat.Text;
            CapaDatos.Chats.CrearSalaChat(Usuario.Grupo, usuarioP, titulo);
            if (CapaDatos.Usuario.Error == false)
            {  
                MessageBox.Show(CapaDatos.Usuario.mensaje);
                CapaDatos.Chats.MostrarSalasA(CapaDatos.Usuario.Grupo);
                dgNuevo.DataSource = CapaDatos.Chats.TablaC;
                dgNuevo.Visible = true;
                grpCrear.Visible = false;
                fondoCrear.Visible = false;
            } else
            {
                MessageBox.Show(CapaDatos.Usuario.mensaje);
            }
            } catch (Exception esas)
            {
                MessageBox.Show("A ocurrido un error \n" + esas);
            }
        }

        private void btnChats_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviarMensaje_Click(object sender, EventArgs e)
        {
            mensaje = txtMensaje.Text;
           CapaDatos.Chats nuevo = new CapaDatos.Chats();
            nuevo.InsertarMensaje(mensaje, IDsala, CapaDatos.Usuario.usuario);
            if (CapaDatos.Usuario.Error == false) {
                AgregarMensajeE(mensaje);
                txtMensaje.Text = "";
            } else
            {
                MessageBox.Show(CapaDatos.Usuario.mensaje);
            }
        }

        private void dgNuevo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = e.RowIndex;
            DataGridViewRow linea = dgNuevo.Rows[posicion];
            IDsala = Convert.ToInt32(linea.Cells[3].Value);
            CapaDatos.Chats nuevo = new CapaDatos.Chats();
            nuevo.BuscarSala(IDsala);
            CapaDatos.Chats.BuscarEstatus(CapaDatos.Usuario.CI, IDsala);
            if (CapaDatos.Usuario.Error == false)
            {
                txtMensaje.Visible = true;
                btnEnviarMensaje.Visible = true;
                btnEnviarFoto.Visible = true;
                btnFinalizar.Visible = true;
                AgregarMensajeR(CapaDatos.Chats.ResumenChat, "Mensajes hasta ahora:");
                lblTituloChat.Text = CapaDatos.Chats.TituloChat + " Materia: " + CapaDatos.Chats.MateriaChat;
            }
            else
            {
                MessageBox.Show(CapaDatos.Usuario.mensaje);
            }

        }

        private void btnCancelarCrear_Click(object sender, EventArgs e)
        {
            grpCrear.Visible = false;
            fondoCrear.Visible = false;
        }

        private void btnEnviarFoto_Click(object sender, EventArgs e)
        {
            grpIntegrantes.Visible = true;
            try
            {
                CapaDatos.Chats.BuscarConectados(IDsala);
                CapaDatos.Usuario.DevolverGrupo(CapaDatos.Usuario.Grupo);
               
            } catch (Exception ea)
            {
                MessageBox.Show(CapaDatos.Usuario.mensaje);
            }
            dtgConectados.DataSource = CapaDatos.Chats.Conectados;
            dtgIntegrantes.DataSource = CapaDatos.Usuario.Integrantes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grpIntegrantes.Visible = false;
        }

        private void txtMensaje_Enter(object sender, EventArgs e)
        {
            if (txtMensaje.Text == "Message") txtMensaje.Text = "";
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                CapaDatos.Chats.CerrarChat(IDsala);
                MessageBox.Show(CapaDatos.Usuario.mensaje);
                OcultarChat();
                CapaDatos.Chats.MostrarSalasA(CapaDatos.Usuario.Grupo);
                dgNuevo.DataSource = CapaDatos.Chats.TablaC;
            }
            catch (Exception esa)
            {
                MessageBox.Show(CapaDatos.Usuario.mensaje);
            }
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            ventanaAlumno nuevo = new ventanaAlumno();
            nuevo.Show();
            this.Close();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            Consulta nuevo = new Consulta();
            nuevo.Show();
            this.Hide();
        }
    }
}
