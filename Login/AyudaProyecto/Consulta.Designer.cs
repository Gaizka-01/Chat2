namespace AyudaProyecto
{
    partial class Consulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgMensajesA = new System.Windows.Forms.DataGridView();
            this.dtgConsultasAnt = new System.Windows.Forms.DataGridView();
            this.dtgMensajeP = new System.Windows.Forms.DataGridView();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpConsulta = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.grpNuevaConsulta = new System.Windows.Forms.GroupBox();
            this.grpConsultasAnt = new System.Windows.Forms.GroupBox();
            this.txtBuscarConsulta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMensajesA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultasAnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMensajeP)).BeginInit();
            this.grpConsulta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpNuevaConsulta.SuspendLayout();
            this.grpConsultasAnt.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgMensajesA
            // 
            this.dtgMensajesA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMensajesA.Location = new System.Drawing.Point(19, 45);
            this.dtgMensajesA.Name = "dtgMensajesA";
            this.dtgMensajesA.Size = new System.Drawing.Size(214, 334);
            this.dtgMensajesA.TabIndex = 0;
            // 
            // dtgConsultasAnt
            // 
            this.dtgConsultasAnt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultasAnt.Location = new System.Drawing.Point(6, 19);
            this.dtgConsultasAnt.Name = "dtgConsultasAnt";
            this.dtgConsultasAnt.Size = new System.Drawing.Size(161, 323);
            this.dtgConsultasAnt.TabIndex = 2;
            // 
            // dtgMensajeP
            // 
            this.dtgMensajeP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMensajeP.Location = new System.Drawing.Point(242, 42);
            this.dtgMensajeP.Name = "dtgMensajeP";
            this.dtgMensajeP.Size = new System.Drawing.Size(229, 337);
            this.dtgMensajeP.TabIndex = 3;
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(19, 389);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(329, 20);
            this.txtMensaje.TabIndex = 4;
            this.txtMensaje.Text = "Escribir mensaje aqui";
            // 
            // btnConsultas
            // 
            this.btnConsultas.Location = new System.Drawing.Point(21, 389);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(129, 23);
            this.btnConsultas.TabIndex = 5;
            this.btnConsultas.Text = "Mostar Consultas";
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(368, 386);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(17, 77);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(116, 20);
            this.txtConsulta.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Escriba el tema de la consulta";
            // 
            // grpConsulta
            // 
            this.grpConsulta.Controls.Add(this.btnAceptar);
            this.grpConsulta.Controls.Add(this.label1);
            this.grpConsulta.Controls.Add(this.txtConsulta);
            this.grpConsulta.Location = new System.Drawing.Point(3, 225);
            this.grpConsulta.Name = "grpConsulta";
            this.grpConsulta.Size = new System.Drawing.Size(151, 213);
            this.grpConsulta.TabIndex = 9;
            this.grpConsulta.TabStop = false;
            this.grpConsulta.Text = "Nueva Consulta";
            this.grpConsulta.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(17, 112);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 166);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione una opcion";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.Color.Black;
            this.checkBox2.Location = new System.Drawing.Point(6, 71);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(102, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Nueva Consulta";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(6, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Mostrar mis consultas";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // grpNuevaConsulta
            // 
            this.grpNuevaConsulta.Controls.Add(this.label3);
            this.grpNuevaConsulta.Controls.Add(this.label2);
            this.grpNuevaConsulta.Controls.Add(this.btnEnviar);
            this.grpNuevaConsulta.Controls.Add(this.txtMensaje);
            this.grpNuevaConsulta.Controls.Add(this.dtgMensajeP);
            this.grpNuevaConsulta.Controls.Add(this.dtgMensajesA);
            this.grpNuevaConsulta.Location = new System.Drawing.Point(160, 11);
            this.grpNuevaConsulta.Name = "grpNuevaConsulta";
            this.grpNuevaConsulta.Size = new System.Drawing.Size(477, 427);
            this.grpNuevaConsulta.TabIndex = 25;
            this.grpNuevaConsulta.TabStop = false;
            this.grpNuevaConsulta.Text = "Nueva Consulta";
            this.grpNuevaConsulta.Visible = false;
            // 
            // grpConsultasAnt
            // 
            this.grpConsultasAnt.Controls.Add(this.txtBuscarConsulta);
            this.grpConsultasAnt.Controls.Add(this.btnConsultas);
            this.grpConsultasAnt.Controls.Add(this.dtgConsultasAnt);
            this.grpConsultasAnt.Location = new System.Drawing.Point(646, 11);
            this.grpConsultasAnt.Name = "grpConsultasAnt";
            this.grpConsultasAnt.Size = new System.Drawing.Size(185, 427);
            this.grpConsultasAnt.TabIndex = 26;
            this.grpConsultasAnt.TabStop = false;
            this.grpConsultasAnt.Text = "Consultas anteriores";
            this.grpConsultasAnt.Visible = false;
            // 
            // txtBuscarConsulta
            // 
            this.txtBuscarConsulta.Location = new System.Drawing.Point(21, 363);
            this.txtBuscarConsulta.Name = "txtBuscarConsulta";
            this.txtBuscarConsulta.Size = new System.Drawing.Size(129, 20);
            this.txtBuscarConsulta.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mensajes Enviados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mensajes Recibidos";
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 450);
            this.Controls.Add(this.grpConsultasAnt);
            this.Controls.Add(this.grpConsulta);
            this.Controls.Add(this.grpNuevaConsulta);
            this.Controls.Add(this.groupBox1);
            this.Name = "Consulta";
            this.Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.dtgMensajesA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultasAnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMensajeP)).EndInit();
            this.grpConsulta.ResumeLayout(false);
            this.grpConsulta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpNuevaConsulta.ResumeLayout(false);
            this.grpNuevaConsulta.PerformLayout();
            this.grpConsultasAnt.ResumeLayout(false);
            this.grpConsultasAnt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgMensajesA;
        private System.Windows.Forms.DataGridView dtgConsultasAnt;
        private System.Windows.Forms.DataGridView dtgMensajeP;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpConsulta;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox grpNuevaConsulta;
        private System.Windows.Forms.GroupBox grpConsultasAnt;
        private System.Windows.Forms.TextBox txtBuscarConsulta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}