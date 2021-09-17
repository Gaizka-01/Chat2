namespace AyudaProyecto
{
    partial class consultaProfesor
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
            this.lbGrupos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgAlumnos = new System.Windows.Forms.DataGridView();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtgMensajeA = new System.Windows.Forms.DataGridView();
            this.dtgMensajeP = new System.Windows.Forms.DataGridView();
            this.dtgMostrarConsultas = new System.Windows.Forms.DataGridView();
            this.grpBuscarConsulta = new System.Windows.Forms.GroupBox();
            this.grpMostrarConsultas = new System.Windows.Forms.GroupBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.txtEnviar = new System.Windows.Forms.Button();
            this.grpBuscarConsultas1 = new System.Windows.Forms.GroupBox();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnBuscar1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMensajeA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMensajeP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMostrarConsultas)).BeginInit();
            this.grpBuscarConsulta.SuspendLayout();
            this.grpMostrarConsultas.SuspendLayout();
            this.grpBuscarConsultas1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbGrupos
            // 
            this.lbGrupos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lbGrupos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbGrupos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrupos.ForeColor = System.Drawing.Color.LightGray;
            this.lbGrupos.FormattingEnabled = true;
            this.lbGrupos.ItemHeight = 17;
            this.lbGrupos.Items.AddRange(new object[] {
            "1BA",
            "1BB",
            "2BA",
            "2BB",
            "3BA",
            "3BB"});
            this.lbGrupos.Location = new System.Drawing.Point(10, 55);
            this.lbGrupos.Name = "lbGrupos";
            this.lbGrupos.Size = new System.Drawing.Size(56, 119);
            this.lbGrupos.TabIndex = 10;
            this.lbGrupos.SelectedIndexChanged += new System.EventHandler(this.lbGrupos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Seleccione un grupo";
            // 
            // dtgAlumnos
            // 
            this.dtgAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlumnos.Location = new System.Drawing.Point(72, 55);
            this.dtgAlumnos.Name = "dtgAlumnos";
            this.dtgAlumnos.Size = new System.Drawing.Size(228, 228);
            this.dtgAlumnos.TabIndex = 12;
            // 
            // txtCI
            // 
            this.txtCI.Location = new System.Drawing.Point(10, 303);
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(290, 20);
            this.txtCI.TabIndex = 13;
            this.txtCI.Text = "Ingrese cedula del alumno sin puntos ni guiones";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(10, 341);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 31);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar consultas";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtgMensajeA
            // 
            this.dtgMensajeA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMensajeA.Location = new System.Drawing.Point(249, 48);
            this.dtgMensajeA.Name = "dtgMensajeA";
            this.dtgMensajeA.Size = new System.Drawing.Size(225, 321);
            this.dtgMensajeA.TabIndex = 15;
            // 
            // dtgMensajeP
            // 
            this.dtgMensajeP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMensajeP.Location = new System.Drawing.Point(6, 48);
            this.dtgMensajeP.Name = "dtgMensajeP";
            this.dtgMensajeP.Size = new System.Drawing.Size(237, 321);
            this.dtgMensajeP.TabIndex = 16;
            // 
            // dtgMostrarConsultas
            // 
            this.dtgMostrarConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMostrarConsultas.Location = new System.Drawing.Point(3, 19);
            this.dtgMostrarConsultas.Name = "dtgMostrarConsultas";
            this.dtgMostrarConsultas.Size = new System.Drawing.Size(468, 53);
            this.dtgMostrarConsultas.TabIndex = 17;
            // 
            // grpBuscarConsulta
            // 
            this.grpBuscarConsulta.Controls.Add(this.btnBuscar);
            this.grpBuscarConsulta.Controls.Add(this.txtCI);
            this.grpBuscarConsulta.Controls.Add(this.dtgAlumnos);
            this.grpBuscarConsulta.Controls.Add(this.label1);
            this.grpBuscarConsulta.Controls.Add(this.lbGrupos);
            this.grpBuscarConsulta.Location = new System.Drawing.Point(2, 16);
            this.grpBuscarConsulta.Name = "grpBuscarConsulta";
            this.grpBuscarConsulta.Size = new System.Drawing.Size(307, 399);
            this.grpBuscarConsulta.TabIndex = 18;
            this.grpBuscarConsulta.TabStop = false;
            this.grpBuscarConsulta.Text = "Buscar consultas de alumnos";
            // 
            // grpMostrarConsultas
            // 
            this.grpMostrarConsultas.Controls.Add(this.label3);
            this.grpMostrarConsultas.Controls.Add(this.label2);
            this.grpMostrarConsultas.Controls.Add(this.txtEnviar);
            this.grpMostrarConsultas.Controls.Add(this.txtMensaje);
            this.grpMostrarConsultas.Controls.Add(this.dtgMensajeP);
            this.grpMostrarConsultas.Controls.Add(this.dtgMensajeA);
            this.grpMostrarConsultas.Location = new System.Drawing.Point(315, 135);
            this.grpMostrarConsultas.Name = "grpMostrarConsultas";
            this.grpMostrarConsultas.Size = new System.Drawing.Size(483, 400);
            this.grpMostrarConsultas.TabIndex = 19;
            this.grpMostrarConsultas.TabStop = false;
            this.grpMostrarConsultas.Text = "Consultas";
            this.grpMostrarConsultas.Visible = false;
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(6, 374);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(240, 20);
            this.txtMensaje.TabIndex = 18;
            this.txtMensaje.Text = "Ingrese mensaje a enviar";
            // 
            // txtEnviar
            // 
            this.txtEnviar.Location = new System.Drawing.Point(252, 373);
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.Size = new System.Drawing.Size(65, 20);
            this.txtEnviar.TabIndex = 15;
            this.txtEnviar.Text = "Enviar";
            this.txtEnviar.UseVisualStyleBackColor = true;
            this.txtEnviar.Click += new System.EventHandler(this.txtEnviar_Click);
            // 
            // grpBuscarConsultas1
            // 
            this.grpBuscarConsultas1.Controls.Add(this.btnBuscar1);
            this.grpBuscarConsultas1.Controls.Add(this.txtConsulta);
            this.grpBuscarConsultas1.Controls.Add(this.dtgMostrarConsultas);
            this.grpBuscarConsultas1.Location = new System.Drawing.Point(321, 6);
            this.grpBuscarConsultas1.Name = "grpBuscarConsultas1";
            this.grpBuscarConsultas1.Size = new System.Drawing.Size(476, 111);
            this.grpBuscarConsultas1.TabIndex = 20;
            this.grpBuscarConsultas1.TabStop = false;
            this.grpBuscarConsultas1.Text = "Temas de consultas";
            this.grpBuscarConsultas1.Visible = false;
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(6, 78);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(240, 20);
            this.txtConsulta.TabIndex = 19;
            this.txtConsulta.Text = "Ingrese tema para mostrar la consulta";
            // 
            // btnBuscar1
            // 
            this.btnBuscar1.Location = new System.Drawing.Point(271, 77);
            this.btnBuscar1.Name = "btnBuscar1";
            this.btnBuscar1.Size = new System.Drawing.Size(65, 20);
            this.btnBuscar1.TabIndex = 19;
            this.btnBuscar1.Text = "Buscar";
            this.btnBuscar1.UseVisualStyleBackColor = true;
            this.btnBuscar1.Click += new System.EventHandler(this.btnBuscar1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tu respuestas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mensaje Recibido";
            // 
            // consultaProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.grpBuscarConsultas1);
            this.Controls.Add(this.grpMostrarConsultas);
            this.Controls.Add(this.grpBuscarConsulta);
            this.Name = "consultaProfesor";
            this.Text = "consultaProfesor";
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMensajeA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMensajeP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMostrarConsultas)).EndInit();
            this.grpBuscarConsulta.ResumeLayout(false);
            this.grpBuscarConsulta.PerformLayout();
            this.grpMostrarConsultas.ResumeLayout(false);
            this.grpMostrarConsultas.PerformLayout();
            this.grpBuscarConsultas1.ResumeLayout(false);
            this.grpBuscarConsultas1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbGrupos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgAlumnos;
        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dtgMensajeA;
        private System.Windows.Forms.DataGridView dtgMensajeP;
        private System.Windows.Forms.DataGridView dtgMostrarConsultas;
        private System.Windows.Forms.GroupBox grpBuscarConsulta;
        private System.Windows.Forms.GroupBox grpMostrarConsultas;
        private System.Windows.Forms.Button txtEnviar;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpBuscarConsultas1;
        private System.Windows.Forms.Button btnBuscar1;
        private System.Windows.Forms.TextBox txtConsulta;
    }
}