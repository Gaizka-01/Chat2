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
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();
            lblNombreConfig.Text = CapaDatos.Usuario.Nombre + " " + CapaDatos.Usuario.Apellido;
            lblGrupo.Text = CapaDatos.Usuario.Grupo;
            try
            {
                CapaDatos.Usuario.MostrarAgenda();
                dtgAgenda.DataSource = CapaDatos.Usuario.Integrantes;
            } catch (Exception e)
            {
                MessageBox.Show(CapaDatos.Usuario.mensaje);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            ventanaAlumno nueva = new ventanaAlumno();
            nueva.Show();
            this.Hide();
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
