namespace AyudaProyecto
{
    partial class chatProfesor
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
            this.FondoChat = new System.Windows.Forms.GroupBox();
            this.lblTituloChat = new System.Windows.Forms.Label();
            this.pNuevo = new System.Windows.Forms.Panel();
            this.btnEnviarMensaje = new System.Windows.Forms.PictureBox();
            this.btnEnviarFoto = new System.Windows.Forms.PictureBox();
            this.pnlMensajes = new System.Windows.Forms.Panel();
            this.txtM = new System.Windows.Forms.TextBox();
            this.pOpicones = new System.Windows.Forms.Panel();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnChats = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombreConfig = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgNuevoP = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.grpIntegrantes = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fondoIntegrantes = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgIntegrantes = new System.Windows.Forms.DataGridView();
            this.dtgConectados = new System.Windows.Forms.DataGridView();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.FondoChat.SuspendLayout();
            this.pNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnviarMensaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnviarFoto)).BeginInit();
            this.pOpicones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNuevoP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.grpIntegrantes.SuspendLayout();
            this.fondoIntegrantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIntegrantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConectados)).BeginInit();
            this.SuspendLayout();
            // 
            // FondoChat
            // 
            this.FondoChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.FondoChat.Controls.Add(this.lblTituloChat);
            this.FondoChat.Location = new System.Drawing.Point(0, -6);
            this.FondoChat.Name = "FondoChat";
            this.FondoChat.Size = new System.Drawing.Size(521, 65);
            this.FondoChat.TabIndex = 25;
            this.FondoChat.TabStop = false;
            // 
            // lblTituloChat
            // 
            this.lblTituloChat.AutoSize = true;
            this.lblTituloChat.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloChat.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloChat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.lblTituloChat.Location = new System.Drawing.Point(17, 28);
            this.lblTituloChat.Name = "lblTituloChat";
            this.lblTituloChat.Size = new System.Drawing.Size(0, 16);
            this.lblTituloChat.TabIndex = 12;
            // 
            // pNuevo
            // 
            this.pNuevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pNuevo.Controls.Add(this.btnEnviarMensaje);
            this.pNuevo.Controls.Add(this.btnEnviarFoto);
            this.pNuevo.Controls.Add(this.pnlMensajes);
            this.pNuevo.Controls.Add(this.FondoChat);
            this.pNuevo.Controls.Add(this.txtM);
            this.pNuevo.Location = new System.Drawing.Point(267, 22);
            this.pNuevo.Name = "pNuevo";
            this.pNuevo.Size = new System.Drawing.Size(522, 416);
            this.pNuevo.TabIndex = 31;
            // 
            // btnEnviarMensaje
            // 
            this.btnEnviarMensaje.BackColor = System.Drawing.Color.Transparent;
            this.btnEnviarMensaje.Image = global::AyudaProyecto.Properties.Resources.Boton_Enviar_Mjs;
            this.btnEnviarMensaje.Location = new System.Drawing.Point(483, 384);
            this.btnEnviarMensaje.Name = "btnEnviarMensaje";
            this.btnEnviarMensaje.Size = new System.Drawing.Size(30, 23);
            this.btnEnviarMensaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEnviarMensaje.TabIndex = 24;
            this.btnEnviarMensaje.TabStop = false;
            this.btnEnviarMensaje.Visible = false;
            this.btnEnviarMensaje.Click += new System.EventHandler(this.btnEnviarMensaje_Click_1);
            // 
            // btnEnviarFoto
            // 
            this.btnEnviarFoto.BackColor = System.Drawing.Color.Transparent;
            this.btnEnviarFoto.Image = global::AyudaProyecto.Properties.Resources.Boton_adjuntar;
            this.btnEnviarFoto.Location = new System.Drawing.Point(485, 15);
            this.btnEnviarFoto.Name = "btnEnviarFoto";
            this.btnEnviarFoto.Size = new System.Drawing.Size(28, 23);
            this.btnEnviarFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEnviarFoto.TabIndex = 23;
            this.btnEnviarFoto.TabStop = false;
            this.btnEnviarFoto.Visible = false;
            this.btnEnviarFoto.Click += new System.EventHandler(this.btnEnviarFoto_Click);
            // 
            // pnlMensajes
            // 
            this.pnlMensajes.Location = new System.Drawing.Point(8, 68);
            this.pnlMensajes.Name = "pnlMensajes";
            this.pnlMensajes.Size = new System.Drawing.Size(501, 302);
            this.pnlMensajes.TabIndex = 26;
            // 
            // txtM
            // 
            this.txtM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.txtM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.txtM.Location = new System.Drawing.Point(56, 384);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(417, 23);
            this.txtM.TabIndex = 21;
            this.txtM.Text = "Message";
            this.txtM.Visible = false;
            this.txtM.Enter += new System.EventHandler(this.txtM_Enter);
            // 
            // pOpicones
            // 
            this.pOpicones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.pOpicones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pOpicones.Controls.Add(this.btnConsultas);
            this.pOpicones.Controls.Add(this.btnChats);
            this.pOpicones.Controls.Add(this.panel1);
            this.pOpicones.Controls.Add(this.lblNombreConfig);
            this.pOpicones.Controls.Add(this.pictureBox2);
            this.pOpicones.Controls.Add(this.dgNuevoP);
            this.pOpicones.Controls.Add(this.textBox1);
            this.pOpicones.Controls.Add(this.pictureBox5);
            this.pOpicones.Location = new System.Drawing.Point(11, 24);
            this.pOpicones.Name = "pOpicones";
            this.pOpicones.Size = new System.Drawing.Size(250, 414);
            this.pOpicones.TabIndex = 30;
            // 
            // btnConsultas
            // 
            this.btnConsultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.btnConsultas.FlatAppearance.BorderSize = 0;
            this.btnConsultas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnConsultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.ForeColor = System.Drawing.Color.White;
            this.btnConsultas.Location = new System.Drawing.Point(11, 379);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(83, 26);
            this.btnConsultas.TabIndex = 26;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.UseVisualStyleBackColor = false;
            // 
            // btnChats
            // 
            this.btnChats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.btnChats.FlatAppearance.BorderSize = 0;
            this.btnChats.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnChats.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChats.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChats.ForeColor = System.Drawing.Color.White;
            this.btnChats.Location = new System.Drawing.Point(154, 379);
            this.btnChats.Name = "btnChats";
            this.btnChats.Size = new System.Drawing.Size(83, 26);
            this.btnChats.TabIndex = 26;
            this.btnChats.Text = "Chats";
            this.btnChats.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(11, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 1);
            this.panel1.TabIndex = 13;
            // 
            // lblNombreConfig
            // 
            this.lblNombreConfig.AutoSize = true;
            this.lblNombreConfig.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreConfig.ForeColor = System.Drawing.Color.LightGray;
            this.lblNombreConfig.Location = new System.Drawing.Point(84, 22);
            this.lblNombreConfig.Name = "lblNombreConfig";
            this.lblNombreConfig.Size = new System.Drawing.Size(135, 18);
            this.lblNombreConfig.TabIndex = 11;
            this.lblNombreConfig.Text = "Nombre Apellido";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AyudaProyecto.Properties.Resources.usuario1;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // dgNuevoP
            // 
            this.dgNuevoP.AllowUserToAddRows = false;
            this.dgNuevoP.AllowUserToDeleteRows = false;
            this.dgNuevoP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.dgNuevoP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNuevoP.Location = new System.Drawing.Point(3, 104);
            this.dgNuevoP.Name = "dgNuevoP";
            this.dgNuevoP.ReadOnly = true;
            this.dgNuevoP.Size = new System.Drawing.Size(242, 257);
            this.dgNuevoP.TabIndex = 19;
            this.dgNuevoP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNuevoP_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "Buscar";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::AyudaProyecto.Properties.Resources.Link;
            this.pictureBox5.Location = new System.Drawing.Point(222, 78);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(23, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // grpIntegrantes
            // 
            this.grpIntegrantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.grpIntegrantes.Controls.Add(this.label4);
            this.grpIntegrantes.Controls.Add(this.fondoIntegrantes);
            this.grpIntegrantes.Controls.Add(this.label3);
            this.grpIntegrantes.Controls.Add(this.dtgIntegrantes);
            this.grpIntegrantes.Controls.Add(this.dtgConectados);
            this.grpIntegrantes.Location = new System.Drawing.Point(288, 24);
            this.grpIntegrantes.Name = "grpIntegrantes";
            this.grpIntegrantes.Size = new System.Drawing.Size(460, 342);
            this.grpIntegrantes.TabIndex = 32;
            this.grpIntegrantes.TabStop = false;
            this.grpIntegrantes.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(237, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 17);
            this.label4.TabIndex = 137;
            this.label4.Text = "Integrantes del grupo";
            // 
            // fondoIntegrantes
            // 
            this.fondoIntegrantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.fondoIntegrantes.Controls.Add(this.button1);
            this.fondoIntegrantes.Controls.Add(this.label2);
            this.fondoIntegrantes.Location = new System.Drawing.Point(0, -2);
            this.fondoIntegrantes.Name = "fondoIntegrantes";
            this.fondoIntegrantes.Size = new System.Drawing.Size(460, 65);
            this.fondoIntegrantes.TabIndex = 25;
            this.fondoIntegrantes.TabStop = false;
            this.fondoIntegrantes.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(382, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 25;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(142, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Lista de integrantes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(11, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 136;
            this.label3.Text = "Conectados";
            // 
            // dtgIntegrantes
            // 
            this.dtgIntegrantes.AllowUserToAddRows = false;
            this.dtgIntegrantes.AllowUserToDeleteRows = false;
            this.dtgIntegrantes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.dtgIntegrantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIntegrantes.Location = new System.Drawing.Point(235, 94);
            this.dtgIntegrantes.Name = "dtgIntegrantes";
            this.dtgIntegrantes.ReadOnly = true;
            this.dtgIntegrantes.Size = new System.Drawing.Size(211, 229);
            this.dtgIntegrantes.TabIndex = 28;
            // 
            // dtgConectados
            // 
            this.dtgConectados.AllowUserToAddRows = false;
            this.dtgConectados.AllowUserToDeleteRows = false;
            this.dtgConectados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.dtgConectados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConectados.Location = new System.Drawing.Point(12, 94);
            this.dtgConectados.Name = "dtgConectados";
            this.dtgConectados.ReadOnly = true;
            this.dtgConectados.Size = new System.Drawing.Size(209, 229);
            this.dtgConectados.TabIndex = 27;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.LightGray;
            this.lblBack.Location = new System.Drawing.Point(711, 2);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(44, 18);
            this.lblBack.TabIndex = 35;
            this.lblBack.Text = "Atras";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.ForeColor = System.Drawing.Color.LightGray;
            this.lblX.Location = new System.Drawing.Point(763, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(23, 23);
            this.lblX.TabIndex = 34;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // chatProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.grpIntegrantes);
            this.Controls.Add(this.pNuevo);
            this.Controls.Add(this.pOpicones);
            this.Name = "chatProfesor";
            this.Text = "chatProfesor";
            this.FondoChat.ResumeLayout(false);
            this.FondoChat.PerformLayout();
            this.pNuevo.ResumeLayout(false);
            this.pNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnviarMensaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnviarFoto)).EndInit();
            this.pOpicones.ResumeLayout(false);
            this.pOpicones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNuevoP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.grpIntegrantes.ResumeLayout(false);
            this.grpIntegrantes.PerformLayout();
            this.fondoIntegrantes.ResumeLayout(false);
            this.fondoIntegrantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIntegrantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConectados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox FondoChat;
        private System.Windows.Forms.Panel pNuevo;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Panel pOpicones;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnChats;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombreConfig;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgNuevoP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblTituloChat;
        private System.Windows.Forms.Panel pnlMensajes;
        private System.Windows.Forms.PictureBox btnEnviarMensaje;
        private System.Windows.Forms.PictureBox btnEnviarFoto;
        private System.Windows.Forms.GroupBox grpIntegrantes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox fondoIntegrantes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgIntegrantes;
        private System.Windows.Forms.DataGridView dtgConectados;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblX;
    }
}