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

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cbAlumno.Checked == true)
            {
                try
                {
                    string usuario = tbNombre.Text.Substring(0, 1) + tbApellido.Text;
                    MessageBox.Show($"Cuenta creada correctamente, tu usuario es {usuario} ");
                    MySqlConnection conectar = new MySqlConnection("server = 127.0.0.2; port = 3306; database = bdsistema; Uid = root; pwd = MalvinyBolso;");
                    conectar.Open();
                    MySqlCommand PersonaA = new MySqlCommand("insert into Persona(CI, Nombre, Apellido, Grupo, Contraseña, usuario) values ('"+tbCedula.Text+"','"+tbNombre.Text+"','"+tbApellido.Text+"', '"+lbGrupos.SelectedItem.ToString()+"', '"+tbContra.Text+"', ' "+usuario+"' );", conectar);
                    MySqlCommand Alumno = new MySqlCommand("insert into Alumno(CI, Nickname) values ('"+tbCedula.Text+"', 'NULL');", conectar);
                    PersonaA.ExecuteNonQuery();
                    Alumno.ExecuteNonQuery();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Ya existe un alumno con la cedula ingresada");
                }
            } else if (cbProfesor.Checked == true)
                {
                    string usuario = tbNombre.Text.Substring(0, 1) + tbApellido.Text;
                    MySqlConnection conectar = new MySqlConnection("server = 127.0.0.2; port = 3306; database = bdsistema; Uid = root; pwd = MalvinyBolso;");
                    conectar.Open();
                    MySqlCommand PersonaP = new MySqlCommand("insert into Persona(CI, Nombre, Apellido, Grupo, Contraseña, usuario) values ('"+tbCedula.Text+"','"+tbNombre.Text+"','"+tbApellido.Text+"', '"+ lbGrupos.SelectedItem.ToString()+"', '"+tbContra.Text+"', ' "+usuario+"' );", conectar);
                    MySqlCommand Profesor = new MySqlCommand("insert into Docente(CI, Materia) values ('" + tbCedula.Text + "','" + lbMateria.SelectedItem.ToString() + "' );", conectar);
                    PersonaP.ExecuteNonQuery();
                    Profesor.ExecuteNonQuery();
                    this.Close();
                }
                else { MessageBox.Show("Por favor seleccione tipo de usuario"); }
            
        }

        private void cbProfesor_CheckedChanged(object sender, EventArgs e)
        {
            lblMateria.Visible = true;
            lbMateria.Visible = true;
        }
    }
}
