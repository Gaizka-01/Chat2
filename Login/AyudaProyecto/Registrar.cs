using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AyudaProyecto.Properties;
using CapaDatos;


namespace AyudaProyecto
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void tbContra_TextChanged(object sender, EventArgs e)
        {
            if (tbContra.Text== "Contraseña")
            {
              
            } else
            {
                tbContra.PasswordChar = '*';
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int CI = Convert.ToInt32(tbCedula.Text);
            string Nombre = tbNombre.Text;
            string Apellido = tbApellido.Text;
            string Contrasenia = tbContra.Text;
            string Verif_Contrasenia = tbContra2.Text;
            string usuario = txtUsuario.Text;
            string Grupo = lbGrupos.SelectedItem.ToString();
            try { 
            
            if (tbContra.Text != tbContra2.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }

            else if (cbAlumno.Checked == true)
            {

                try
                { 
                    CapaDatos.Usuario.Persona(CI, Nombre, Apellido, Grupo, Contrasenia, usuario);
                    CapaDatos.Usuario.Alumno(CI);
                    MessageBox.Show(CapaDatos.Usuario.mensaje);
                    this.Close();
                }
                catch (Exception E)
                {
                    MessageBox.Show(CapaDatos.Usuario.mensaje + E);

                }
            }
            else if (cbProfesor.Checked == true)
            {
                string Materia = lbMateria.SelectedItem.ToString();                
                try
                {
                    CapaDatos.Usuario.Persona(CI, Nombre, Apellido, Grupo, Contrasenia, usuario);
                    CapaDatos.Usuario.Profesor(CI, Materia);
                    MessageBox.Show(CapaDatos.Usuario.mensaje);
                    this.Close();
                }  
                catch (Exception E)
                {
                    MessageBox.Show(CapaDatos.Usuario.mensaje + E);

                }
            }
            else { MessageBox.Show("Por favor seleccione tipo de usuario"); }
            } catch (Exception ea)
            {
                MessageBox.Show("A ocurrido un error, debes completar todos los campos \n" + ea);
            }


        }


        private void lbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Registrar_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 nuevo = new Form1();
            nuevo.Show();
            this.Close();
            
        }

        private void tbNombre_Enter(object sender, EventArgs e)
        {
            if (tbNombre.Text == "Nombre") tbNombre.Text = "";
        }

        private void tbApellido_Enter(object sender, EventArgs e)
        {
            if (tbApellido.Text == "Apellido") tbApellido.Text = "";
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Nombre de usuario") txtUsuario.Text = "";
        }

        private void tbCedula_Enter(object sender, EventArgs e)
        {
            if (tbCedula.Text == "Cedula") tbCedula.Text = "";
        }

        private void tbContra_Enter(object sender, EventArgs e)
        {
            if (tbContra.Text == "Contraseña") tbContra.Text = "";
        }

        private void tbContra2_TextChanged(object sender, EventArgs e)
        {
            if (tbContra2.Text== "Repetir Contraseña")
            {

            } else
            {
                tbContra2.PasswordChar = '*';
            }
        }

        private void tbContra2_Enter(object sender, EventArgs e)
        {
            if (tbContra2.Text == "Repetir Contraseña") tbContra2.Text = "";
        }

        private void cbProfesor_CheckedChanged(object sender, EventArgs e)
        {
            if (cbProfesor.Checked)
            {
                lblMateria.Visible = true;
                lbMateria.Visible = true;
            } else
            {
                lblMateria.Visible = false;
                lbMateria.Visible = false;
            }
            
        }

        private void cbProfesor_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
