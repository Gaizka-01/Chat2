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
using MySql.Data.MySqlClient;

namespace AyudaProyecto
{
    public partial class ventanaProfesor : Form
    {
        public ventanaProfesor()
        {
            InitializeComponent();
            lblNombreConfig.Text = CapaDatos.Usuario.NombreP + " " + CapaDatos.Usuario.ApellidoP;
            lbMateria.Text = CapaDatos.Usuario.materiaP;
        }
        int posicion;
        string consultaTema;
        int consultaID;
        int CIA;
        
        void MostrarConsulta()
        {
            txtM.Visible = true;
            btnEnviarMensaje.Visible = true;
            lblUsuarioContesta.Visible = true;
        }
        private void btnConsultas_Click(object sender, EventArgs e)
        {
            try {  
            CapaDatos.Consultas.MostrarConsultasP(CapaDatos.Usuario.CI);
            dgNuevoP.DataSource = CapaDatos.Consultas.Tabla;
            } catch (Exception n)
            {
                MessageBox.Show(CapaDatos.Usuario.mensaje);
            }
        }

        

        private void btnEnviarMensaje_Click(object sender, EventArgs e)
        {
            try { 
            string MensajeP = txtM.Text;
            CapaDatos.Consultas.EnviarMensajeP(consultaID, MensajeP);
            if (CapaDatos.Usuario.Error == false)
            {
                MessageBox.Show(CapaDatos.Usuario.mensaje);
                CapaDatos.Consultas.MostrarMensajeConsultaP(consultaID);
                dtgConsultaE.DataSource = CapaDatos.Consultas.TablaMensajeP;
                dtgConsultaE.Visible = true;
                txtM.Text = "";
            }
            else
            {
                MessageBox.Show(CapaDatos.Usuario.mensaje);
            }
            } catch (Exception ee)
            {
                MessageBox.Show("Ocurrio un error" + ee);
            }
        }

        private void dgNuevoP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = e.RowIndex;
            DataGridViewRow linea = dgNuevoP.Rows[posicion];
            consultaTema = linea.Cells[0].Value.ToString();
            consultaID = Convert.ToInt32(linea.Cells[3].Value);
            CIA = Convert.ToInt32(linea.Cells[1].Value);
            try
            {
                MostrarConsulta();
                CapaDatos.Usuario.DevolverAlumno(CIA);
                lblUsuarioContesta.Text = "De: " + CapaDatos.Usuario.Nombre + " " + CapaDatos.Usuario.Apellido + "\n Titulo: " + consultaTema;
                CapaDatos.Consultas.MostrarMensajeConsultaA(consultaID);
                dtgConsultaR.DataSource = CapaDatos.Consultas.TablaMensajeA;
                dtgConsultaR.Visible = true;
            } catch (Exception ea) {
                MessageBox.Show("Ocurrio un error \n " +ea);
            }
        }
        private void btnChats_Click(object sender, EventArgs e)
        {
            chatProfesor nuevo = new chatProfesor();
            nuevo.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            grpModificar.Visible = true;
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            grpModificarNick.Visible = true;
            string nuevo = lbMateria.SelectedItem.ToString();

            try
            {
                CapaDatos.Usuario.CambiarMateriaP(CapaDatos.Usuario.CIP, nuevo);
                MessageBox.Show(CapaDatos.Usuario.mensaje);
                lblMateria.Text = nuevo;
            }catch (Exception eas)
            {
                MessageBox.Show(CapaDatos.Usuario.mensaje);
            } finally
            {
                grpModificar.Visible = false;
                grpModificarNick.Visible = false;
                lbMateria.Visible = false;
                btnCambiar.Visible = false;
            }
        }

        private void btnModiMateria_Click(object sender, EventArgs e)
        {
            grpModificarNick.Visible = true;
            lbMateria.Visible = true;
            btnCambiar.Visible = true;
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            grpAgenda.Visible = true;
            btnConfirmar.Visible = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string dias = listaDias.SelectedItem.ToString();
            try
            {
                CapaDatos.Usuario.RellenarAgenda(CapaDatos.Usuario.CIP, dias);
                MessageBox.Show(CapaDatos.Usuario.mensaje);
            }catch (Exception ea)
            {
                MessageBox.Show(CapaDatos.Usuario.mensaje);
            }
            finally
            {
                grpAgenda.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grpModificar.Visible = false;
            grpModificarNick.Visible = false;
            grpAgenda.Visible = false;
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtM_Enter(object sender, EventArgs e)
        {
            if (txtM.Text == "Message") txtM.Text = "";
        }
    }
}
