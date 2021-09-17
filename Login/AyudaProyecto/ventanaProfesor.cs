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
    public partial class ventanaProfesor : Form
    {
        public ventanaProfesor()
        {
            InitializeComponent();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            consultaProfesor nueva = new consultaProfesor();
            nueva.Show();
            this.Hide();
        }
    }
}
