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
    public partial class Enviado : UserControl
    {
        public Enviado()
        {
            InitializeComponent();
        }

        public string MensajeE
        {
            get
            {
                return lblMensajeE.Text;
            }
            set
            {
                lblMensajeE.Text = value;
            }
        }
    }
}
