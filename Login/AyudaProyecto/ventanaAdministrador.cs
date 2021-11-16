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

namespace AyudaProyecto
{
    public partial class ventanaAdministrador : Form
    {
        public ventanaAdministrador()
        {
            InitializeComponent();
        }

        private void txtBorrar_Enter(object sender, EventArgs e)
        {
            if (txtBorrar.Text == "Cedula") txtBorrar.Text = "";
        }

        void OcultarBorrar()
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            pnlEliminar.Visible = false;
            btnBorrar.Visible = false;
            radioAlumno.Visible = false;
            radioDocente.Visible = false;
            txtBorrar.Visible = false;
            lbGrupos.Visible = false;

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                int cedula = Convert.ToInt32(txtBorrar.Text);
            
                CapaDatos.Usuario.BajaUsuario(cedula);
                MessageBox.Show(CapaDatos.Usuario.mensaje);
                OcultarBorrar();
            }catch (Exception a)
            {
                MessageBox.Show(CapaDatos.Usuario.mensaje);
            }
            
        }

        private void radioAlumno_CheckedChanged(object sender, EventArgs e)
        {
            lbGrupos.Visible = true;
            label3.Visible = true;
        }

        private void lbGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Visible = true;
            txtBorrar.Visible = true;
            btnBorrar.Visible = true;
            string grupo = lbGrupos.SelectedItem.ToString();
            try
            {
                CapaDatos.Usuario.DevolverGrupo(grupo);
                dgNuevo.DataSource = CapaDatos.Usuario.Integrantes;
                dgNuevo.Visible = true;
            }catch (Exception ea)
            {
                MessageBox.Show(CapaDatos.Usuario.mensaje);
            }
            
        }

        private void radioDocente_CheckedChanged(object sender, EventArgs e)
        {
          try { 
            label4.Visible = true;
            txtBorrar.Visible = true;
            btnBorrar.Visible = true;
            try
            {
                CapaDatos.Usuario.Docentes();
                dgNuevo.DataSource = CapaDatos.Usuario.Integrantes;
            } catch (Exception a)
            {
                MessageBox.Show("" + a);
            }
            } catch (Exception ar)
            {
                MessageBox.Show("oCURRIO un error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgNuevo.Visible = true;
            pnlEliminar.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            radioAlumno.Visible = true;
            radioDocente.Visible = true;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OcultarBorrar();
            dgNuevo.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Registrar nuevo = new Registrar();
            nuevo.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModificarUsuario nuevo = new ModificarUsuario();
            nuevo.Show();
            this.Hide();
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
