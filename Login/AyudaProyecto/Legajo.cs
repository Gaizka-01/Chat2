using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyudaProyecto
{
    public partial class Legajo : Form
    {
        public Legajo()
        {
            InitializeComponent();
            lblNombreConfig.Text = CapaDatos.Usuario.Nombre + " " + CapaDatos.Usuario.Apellido;
            lblGrupo.Text = CapaDatos.Usuario.Grupo;
            lblNickname.Text = CapaDatos.Usuario.Nickname;
            try
            {
                CapaDatos.Usuario.MensajesLegajo(CapaDatos.Usuario.CI);
                AgregarMensajeR(CapaDatos.Usuario.MensajeL);
            } catch (Exception E)
            {
                MessageBox.Show(CapaDatos.Usuario.mensaje);
            }
        }

        void AgregarMensajeR(string mensaje)
        {
            var burbuja = new ChatItems.Recibido();
            pnlMensajes.Controls.Add(burbuja);
            burbuja.Dock = DockStyle.Top;
            burbuja.MensajeR = mensaje;
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            Consulta nuevo = new Consulta();
            nuevo.Show();
            this.Hide();
        }

        private void btnChats_Click(object sender, EventArgs e)
        {
            chatAlumno nuevo = new chatAlumno();
            nuevo.Show();
            this.Hide();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            ventanaAlumno nuevo = new ventanaAlumno();
            nuevo.Show();
            this.Close();
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
