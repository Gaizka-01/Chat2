using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyudaProyecto.ChatItems
{
    public partial class Recibido : UserControl
    {
        public Recibido()
        {
            InitializeComponent();
        }
        public string MensajeR
        {
            get
            {
                return lblMensajeR.Text;
            }
            set
            {
                lblMensajeR.Text = value;
            }
        }

        public string UsuarioR
        {
            get
            {
                return lblUsuarioR.Text;
            }
            set
            {
                lblUsuarioR.Text = value;
            }
        }

        private void Recibido_Load(object sender, EventArgs e)
        {

        }
    }
}


