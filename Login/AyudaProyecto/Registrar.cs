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
                
                
                  
                
                    CapaLogica.ConexionBD.Conexion();
                CapaLogica.ConexionBD.conectar.Open();
                    MySqlCommand PersonaA = new MySqlCommand("insert into Persona(CI, Nombre, Apellido, Grupo, Contraseña, usuario) values ('"+tbCedula.Text+"','"+tbNombre.Text+"','"+tbApellido.Text+"', '"+lbGrupos.SelectedItem.ToString()+"', '"+tbContra.Text+"', ' "+txtUsuario.Text+"' );", CapaLogica.ConexionBD.conectar);
                    MySqlCommand Alumno = new MySqlCommand("insert into Alumno(CI, Nickname, usuario) values ('"+tbCedula.Text+"', 'NULL', '"+txtUsuario.Text+"');", CapaLogica.ConexionBD.conectar);
                    PersonaA.ExecuteNonQuery();
                    Alumno.ExecuteNonQuery();
                    CapaLogica.ConexionBD.CerrarConexion();
                    this.Close();
                MessageBox.Show("Usuario ingresado correctamente");
                
                
            } else if (cbProfesor.Checked == true)
                {
       
                  
                    CapaLogica.ConexionBD.Conexion();
                    MySqlCommand PersonaP = new MySqlCommand("insert into Persona(CI, Nombre, Apellido, Grupo, Contraseña, usuario) values ('"+tbCedula.Text+"','"+tbNombre.Text+"','"+tbApellido.Text+"', '"+ lbGrupos.SelectedItem.ToString()+"', '"+tbContra.Text+"', ' "+txtUsuario.Text+"' );", CapaLogica.ConexionBD.conectar );
                    MySqlCommand Profesor = new MySqlCommand("insert into Docente(CI, Materia, usuario) values ('" + tbCedula.Text + "','" + lbMateria.SelectedItem.ToString() + "' , '"+txtUsuario.Text+"');", CapaLogica.ConexionBD.conectar);
                    PersonaP.ExecuteNonQuery();
                    Profesor.ExecuteNonQuery();
                    CapaLogica.ConexionBD.CerrarConexion();
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
