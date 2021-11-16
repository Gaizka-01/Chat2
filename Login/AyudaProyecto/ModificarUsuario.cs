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
    public partial class ModificarUsuario : Form
    {
        public ModificarUsuario()
        {
            InitializeComponent();
        }

        string grupo;
        string Nombre;
        string Apellido;
        string Dif;
        int CI;
        int posicion;
        
        void Mostrar()
        {
            lblNombre.Visible = true;
            txtNom.Visible = true;
            lblApellido.Visible = true;
            txtApe.Visible = true;
            lblGrupo.Visible = true;
            txtGrupo.Visible = true;
            txtDif.Visible = true;
        }
        private void txtDif_Enter(object sender, EventArgs e)
        {
            if (txtDif.Text == "Inserte nuevo valor") txtDif.Text = "";
        }

        private void txtGrupo_Enter(object sender, EventArgs e)
        {
            if (txtGrupo.Text == "Inserte nuevo valor") txtGrupo.Text = "";

        }

        private void txtApe_Enter(object sender, EventArgs e)
        {
            if (txtApe.Text == "Inserte nuevo valor") txtApe.Text = "";
        }

        private void txtNom_Enter(object sender, EventArgs e)
        {
            if (txtNom.Text == "Inserte nuevo valor") txtNom.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ventanaAdministrador nuevo = new ventanaAdministrador();
            nuevo.Show();
            this.Hide();
        }

        private void lbGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            grupo = lbGrupos.SelectedItem.ToString();
            try
            {
                CapaDatos.Usuario.MostrarCambiarDatosA(grupo);
                dgNuevo.DataSource = CapaDatos.Usuario.Integrantes;
                dgNuevo.Visible = true;
            }
            catch (Exception ea)
            {
                MessageBox.Show(CapaDatos.Usuario.mensaje);
            }
        }

        private void radioAlumno_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = true;
            lbGrupos.Visible = true;
            lblNick.Visible = true;
        }

        private void radioDocente_CheckedChanged(object sender, EventArgs e)
        {
            lblMateria.Visible = true;
            try
            {
                CapaDatos.Usuario.MostrarCambiarDatosP();
                dgNuevo.DataSource = CapaDatos.Usuario.Integrantes;
            }
            catch (Exception a)
            {
                MessageBox.Show("" + a);
            }
        }

        private void dgNuevo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Mostrar();
            posicion = e.RowIndex;
            DataGridViewRow linea = dgNuevo.Rows[posicion];
            Nombre = linea.Cells[0].Value.ToString();
            Apellido = linea.Cells[1].Value.ToString();
            Dif = linea.Cells[2].Value.ToString();
            grupo = linea.Cells[3].Value.ToString();
            CI = Convert.ToInt32(linea.Cells[4].Value);

            txtNom.Text = Nombre;
            txtApe.Text = Apellido;
            txtDif.Text = Dif;
            txtGrupo.Text = grupo;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string Nombren = txtNom.Text;
            string Apen = txtApe.Text;
            string Difn = txtDif.Text;

            if (radioAlumno.Checked)
            {
                try
                {
                    
                    CapaDatos.Usuario.CambiarDatosA(CI, Nombren, Apen, Difn);
                    MessageBox.Show("Usuario modificado");
                    CapaDatos.Usuario.MostrarCambiarDatosA(grupo);
                    dgNuevo.DataSource = CapaDatos.Usuario.Integrantes;

                } catch (Exception er)
                {
                    MessageBox.Show(CapaDatos.Usuario.mensaje + "" + er);
                }
            } else if (radioDocente.Checked)
            {
                try
                {
                    
                    CapaDatos.Usuario.CambiarDatosP(CI, Nombren, Apen, Difn);
                    MessageBox.Show("Usuario modificado");
                    CapaDatos.Usuario.MostrarCambiarDatosP();
                    dgNuevo.DataSource = CapaDatos.Usuario.Integrantes;

                }
                catch (Exception er)
                {
                    MessageBox.Show(CapaDatos.Usuario.mensaje + "" + er);
                }
            } else
            {
                MessageBox.Show("Debes seleccionar el tipo de usuario");
            }
        }
    }
}
