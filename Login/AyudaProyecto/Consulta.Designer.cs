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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpConsultasAnt = new System.Windows.Forms.GroupBox();
            this.txtBuscarConsulta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMateria = new System.Windows.Forms.TextBox();
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
            this.dtgMensajesA.Location = new System.Drawing.Point(6, 50);
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
            this.dtgMensajeP.Location = new System.Drawing.Point(226, 50);
            this.dtgMensajeP.Name = "dtgMensajeP";
            this.dtgMensajeP.Size = new System.Drawing.Size(229, 334);
            this.dtgMensajeP.TabIndex = 3;
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(6, 385);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(329, 21);
            this.txtMensaje.TabIndex = 4;
            this.txtMensaje.Text = "Escribir mensaje aqui";
            // 
            // btnConsultas
            // 
            this.btnConsultas.Font = new System.Drawing.Font("Century Gothic", 9.75F);
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
            this.btnEnviar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
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
            this.txtConsulta.Location = new System.Drawing.Point(6, 51);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(116, 21);
            this.txtConsulta.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Escriba el tema de la consulta";
            // 
            // grpConsulta
            // 
            this.grpConsulta.Controls.Add(this.txtMateria);
            this.grpConsulta.Controls.Add(this.label4);
            this.grpConsulta.Controls.Add(this.btnAceptar);
            this.grpConsulta.Controls.Add(this.label1);
            this.grpConsulta.Controls.Add(this.txtConsulta);
            this.grpConsulta.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.grpConsulta.ForeColor = System.Drawing.Color.White;
            this.grpConsulta.Location = new System.Drawing.Point(3, 143);
            this.grpConsulta.Name = "grpConsulta";
            this.grpConsulta.Size = new System.Drawing.Size(168, 274);
            this.grpConsulta.TabIndex = 9;
            this.grpConsulta.TabStop = false;
            this.grpConsulta.Text = "Nueva Consulta";
            this.grpConsulta.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(9, 166);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 30);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 123);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione una opcion";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(6, 58);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(116, 20);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Nueva Consulta";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(6, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(139, 20);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Mostrar mis consultas";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // grpNuevaConsulta
            // 
            this.grpNuevaConsulta.BackColor = System.Drawing.Color.DodgerBlue;
            this.grpNuevaConsulta.Controls.Add(this.label3);
            this.grpNuevaConsulta.Controls.Add(this.label2);
            this.grpNuevaConsulta.Controls.Add(this.btnEnviar);
            this.grpNuevaConsulta.Controls.Add(this.txtMensaje);
            this.grpNuevaConsulta.Controls.Add(this.dtgMensajeP);
            this.grpNuevaConsulta.Controls.Add(this.dtgMensajesA);
            this.grpNuevaConsulta.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.grpNuevaConsulta.ForeColor = System.Drawing.Color.White;
            this.grpNuevaConsulta.Location = new System.Drawing.Point(177, 11);
            this.grpNuevaConsulta.Name = "grpNuevaConsulta";
            this.grpNuevaConsulta.Size = new System.Drawing.Size(460, 427);
            this.grpNuevaConsulta.TabIndex = 25;
            this.grpNuevaConsulta.TabStop = false;
            this.grpNuevaConsulta.Text = "Nueva Consulta";
            this.grpNuevaConsulta.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(237, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mensajes Recibidos";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mensajes Enviados";
            // 
            // grpConsultasAnt
            // 
            this.grpConsultasAnt.BackColor = System.Drawing.Color.DodgerBlue;
            this.grpConsultasAnt.Controls.Add(this.txtBuscarConsulta);
            this.grpConsultasAnt.Controls.Add(this.btnConsultas);
            this.grpConsultasAnt.Controls.Add(this.dtgConsultasAnt);
            this.grpConsultasAnt.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.grpConsultasAnt.ForeColor = System.Drawing.Color.White;
            this.grpConsultasAnt.Location = new System.Drawing.Point(646, 12);
            this.grpConsultasAnt.Name = "grpConsultasAnt";
            this.grpConsultasAnt.Size = new System.Drawing.Size(195, 426);
            this.grpConsultasAnt.TabIndex = 26;
            this.grpConsultasAnt.TabStop = false;
            this.grpConsultasAnt.Text = "Consultas anteriores";
            this.grpConsultasAnt.Visible = false;
            // 
            // txtBuscarConsulta
            // 
            this.txtBuscarConsulta.Location = new System.Drawing.Point(21, 363);
            this.txtBuscarConsulta.Name = "txtBuscarConsulta";
            this.txtBuscarConsulta.Size = new System.Drawing.Size(129, 21);
            this.txtBuscarConsulta.TabIndex = 10;
            this.txtBuscarConsulta.Text = "Inserte tema";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label4.Location = new System.Drawing.Point(3, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Escriba nombre de la materia";
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(6, 122);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(116, 21);
            this.txtMateria.TabIndex = 11;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
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
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Label label4;
    }
}