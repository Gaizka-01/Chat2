namespace AyudaProyecto.Properties
{
    partial class Form1
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
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.lblIngresa = new System.Windows.Forms.Label();
            this.groupUsuario = new System.Windows.Forms.GroupBox();
            this.chkboxAdministrador = new System.Windows.Forms.CheckBox();
            this.chkboxProfesor = new System.Windows.Forms.CheckBox();
            this.chkboxAlumno = new System.Windows.Forms.CheckBox();
            this.groupUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUsuario
            // 
            this.tbUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.tbUsuario.Location = new System.Drawing.Point(233, 179);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(306, 20);
            this.tbUsuario.TabIndex = 5;
            this.tbUsuario.Text = "Usuario";
            this.tbUsuario.Visible = false;
            // 
            // tbContraseña
            // 
            this.tbContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tbContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.tbContraseña.Location = new System.Drawing.Point(233, 205);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(306, 20);
            this.tbContraseña.TabIndex = 6;
            this.tbContraseña.Text = "Contraseña";
            this.tbContraseña.Visible = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.DimGray;
            this.btnRegistrar.Location = new System.Drawing.Point(12, 375);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 103;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Visible = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.DimGray;
            this.btnVolver.Location = new System.Drawing.Point(559, 330);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(97, 29);
            this.btnVolver.TabIndex = 104;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Visible = false;
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAcceder.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnAcceder.Location = new System.Drawing.Point(662, 330);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(97, 29);
            this.btnAcceder.TabIndex = 105;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = true;
            this.btnAcceder.Visible = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // lblIngresa
            // 
            this.lblIngresa.AutoSize = true;
            this.lblIngresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresa.ForeColor = System.Drawing.Color.White;
            this.lblIngresa.Location = new System.Drawing.Point(255, 105);
            this.lblIngresa.Name = "lblIngresa";
            this.lblIngresa.Size = new System.Drawing.Size(287, 16);
            this.lblIngresa.TabIndex = 106;
            this.lblIngresa.Text = "Ingresa a la aplicacion que te pertenece";
            // 
            // groupUsuario
            // 
            this.groupUsuario.Controls.Add(this.chkboxAdministrador);
            this.groupUsuario.Controls.Add(this.chkboxProfesor);
            this.groupUsuario.Controls.Add(this.chkboxAlumno);
            this.groupUsuario.Location = new System.Drawing.Point(258, 133);
            this.groupUsuario.Name = "groupUsuario";
            this.groupUsuario.Size = new System.Drawing.Size(281, 169);
            this.groupUsuario.TabIndex = 125;
            this.groupUsuario.TabStop = false;
            this.groupUsuario.Text = "Seleccione un usuario";
            // 
            // chkboxAdministrador
            // 
            this.chkboxAdministrador.AutoSize = true;
            this.chkboxAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxAdministrador.ForeColor = System.Drawing.Color.White;
            this.chkboxAdministrador.Location = new System.Drawing.Point(6, 65);
            this.chkboxAdministrador.Name = "chkboxAdministrador";
            this.chkboxAdministrador.Size = new System.Drawing.Size(115, 19);
            this.chkboxAdministrador.TabIndex = 2;
            this.chkboxAdministrador.Text = "Administrador";
            this.chkboxAdministrador.UseVisualStyleBackColor = true;
            this.chkboxAdministrador.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chkboxProfesor
            // 
            this.chkboxProfesor.AutoSize = true;
            this.chkboxProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxProfesor.ForeColor = System.Drawing.Color.White;
            this.chkboxProfesor.Location = new System.Drawing.Point(6, 42);
            this.chkboxProfesor.Name = "chkboxProfesor";
            this.chkboxProfesor.Size = new System.Drawing.Size(80, 19);
            this.chkboxProfesor.TabIndex = 1;
            this.chkboxProfesor.Text = "Profesor";
            this.chkboxProfesor.UseVisualStyleBackColor = true;
            this.chkboxProfesor.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkboxAlumno
            // 
            this.chkboxAlumno.AutoSize = true;
            this.chkboxAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxAlumno.ForeColor = System.Drawing.Color.White;
            this.chkboxAlumno.Location = new System.Drawing.Point(6, 19);
            this.chkboxAlumno.Name = "chkboxAlumno";
            this.chkboxAlumno.Size = new System.Drawing.Size(74, 19);
            this.chkboxAlumno.TabIndex = 0;
            this.chkboxAlumno.Text = "Alumno";
            this.chkboxAlumno.UseVisualStyleBackColor = true;
            this.chkboxAlumno.CheckedChanged += new System.EventHandler(this.chkboxAlumno_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupUsuario);
            this.Controls.Add(this.lblIngresa);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.tbUsuario);
            this.Name = "Form1";
            this.Text = "Login";
            this.groupUsuario.ResumeLayout(false);
            this.groupUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Label lblIngresa;
        private System.Windows.Forms.GroupBox groupUsuario;
        private System.Windows.Forms.CheckBox chkboxAdministrador;
        private System.Windows.Forms.CheckBox chkboxProfesor;
        private System.Windows.Forms.CheckBox chkboxAlumno;
    }
}