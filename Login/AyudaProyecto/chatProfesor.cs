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
    public partial class chatProfesor : Form
    {
        public chatProfesor()
        {
            InitializeComponent();
            lblNombreConfig.Text = CapaDatos.Usuario.NombreP + " " + CapaDatos.Usuario.ApellidoP;
            dgNuevoP.Visible = true;
            try
            {
                CapaDatos.Chats.MostrarSalasP(CapaDatos.Usuario.usuario);
                dgNuevoP.DataSource = CapaDatos.Chats.TablaC;
            }
            catch (Exception ea)
            {
                MessageBox.Show("No se pudo mostrar las salas de chat");
            }
        }

        int posicion;
        int IDsala;
        string mensaje;
        string GrupoSala;

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


        private void dgNuevoP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
            posicion = e.RowIndex;
            DataGridViewRow linea = dgNuevoP.Rows[posicion];
            IDsala = Convert.ToInt32(linea.Cells[2].Value);
            GrupoSala = linea.Cells[1].Value.ToString();
            CapaDatos.Chats nuevo = new CapaDatos.Chats();
            nuevo.BuscarSala(IDsala);
            if (CapaDatos.Usuario.Error == false)
            {
                btnEnviarFoto.Visible = true;
                txtM.Visible = true;
                btnEnviarMensaje.Visible = true;
                AgregarMensajeR(CapaDatos.Chats.ResumenChat, "Mensajes hasta ahora:");
                lblTituloChat.Text = CapaDatos.Chats.TituloChat + " Materia: " + CapaDatos.Chats.MateriaChat;
            }
            else
            {
                MessageBox.Show(CapaDatos.Usuario.mensaje);
            }
            } catch (Exception a)
            {
                MessageBox.Show("Ocurrio un error");
            }
        }


        private void txtM_Enter(object sender, EventArgs e)
        {
            if (txtM.Text == "Message") txtM.Text = "";
        }

        private void btnEnviarFoto_Click(object sender, EventArgs e)
        {
            grpIntegrantes.Visible = true;
            fondoIntegrantes.Visible = true;
            try
            {
                CapaDatos.Chats.BuscarConectados(IDsala);
                CapaDatos.Usuario.DevolverGrupo(GrupoSala);

            }
            catch (Exception ea)
            {
                MessageBox.Show(CapaDatos.Usuario.mensaje);
            }
            dtgConectados.DataSource = CapaDatos.Chats.Conectados;
            dtgIntegrantes.DataSource = CapaDatos.Usuario.Integrantes;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            grpIntegrantes.Visible = false;
            fondoIntegrantes.Visible = false;
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            ventanaProfesor nuevo = new ventanaProfesor();
            nuevo.Show();
            this.Hide();
        }

        private void btnEnviarMensaje_Click_1(object sender, EventArgs e)
        {
            try
            {
                mensaje = txtM.Text;
                CapaDatos.Chats nuevo = new CapaDatos.Chats();
                nuevo.InsertarMensajeP(mensaje, IDsala, CapaDatos.Usuario.usuario);
                if (CapaDatos.Usuario.Error == false)
                {
                    AgregarMensajeE(mensaje);
                    txtM.Text = "";
                }
                else
                {
                    MessageBox.Show(CapaDatos.Usuario.mensaje);
                }
            }
            catch (Exception ar)
            {
                MessageBox.Show("A ocurrido un error");
            }
        }
    }
}
