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
    public partial class ventanaAlumno : Form
    {
        public ventanaAlumno()
        {
            InitializeComponent();
        }

        private void btnMostar_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server = 127.0.0.2; port = 3306; database = bdsistema; Uid = root; pwd = MalvinyBolso;");
            conectar.Open();
            MySqlCommand comando = new MySqlCommand("Select persona.Nombre, docente.Materia from persona, docente where persona.CI = docente.CI", conectar);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgNuevo.DataSource = tabla;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Consulta nuevo = new Consulta();
            nuevo.Show();
            this.Hide();
        }
    }
}
