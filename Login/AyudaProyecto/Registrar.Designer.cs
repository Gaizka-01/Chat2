namespace AyudaProyecto
{
    partial class Registrar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAlumno = new System.Windows.Forms.CheckBox();
            this.cbProfesor = new System.Windows.Forms.CheckBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbCedula = new System.Windows.Forms.TextBox();
            this.tbContra = new System.Windows.Forms.TextBox();
            this.tbContra2 = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lbGrupos = new System.Windows.Forms.ListBox();
            this.lbMateria = new System.Windows.Forms.ListBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 102;
            this.label1.Text = "Log-In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(279, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 17);
            this.label2.TabIndex = 103;
            this.label2.Text = "Seleccione Tipo de Usuario:";
            // 
            // cbAlumno
            // 
            this.cbAlumno.AutoSize = true;
            this.cbAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAlumno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlumno.ForeColor = System.Drawing.Color.DimGray;
            this.cbAlumno.Location = new System.Drawing.Point(467, 85);
            this.cbAlumno.Name = "cbAlumno";
            this.cbAlumno.Size = new System.Drawing.Size(74, 21);
            this.cbAlumno.TabIndex = 104;
            this.cbAlumno.Text = "Alumno";
            this.cbAlumno.UseVisualStyleBackColor = true;
            // 
            // cbProfesor
            // 
            this.cbProfesor.AutoSize = true;
            this.cbProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProfesor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProfesor.ForeColor = System.Drawing.Color.DimGray;
            this.cbProfesor.Location = new System.Drawing.Point(547, 85);
            this.cbProfesor.Name = "cbProfesor";
            this.cbProfesor.Size = new System.Drawing.Size(75, 21);
            this.cbProfesor.TabIndex = 105;
            this.cbProfesor.Text = "Profesor";
            this.cbProfesor.UseVisualStyleBackColor = true;
            this.cbProfesor.CheckedChanged += new System.EventHandler(this.cbProfesor_CheckedChanged);
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tbNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.ForeColor = System.Drawing.Color.DimGray;
            this.tbNombre.Location = new System.Drawing.Point(282, 112);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(422, 20);
            this.tbNombre.TabIndex = 106;
            this.tbNombre.Text = "Nombre";
            // 
            // tbApellido
            // 
            this.tbApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tbApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellido.ForeColor = System.Drawing.Color.DimGray;
            this.tbApellido.Location = new System.Drawing.Point(282, 138);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(422, 20);
            this.tbApellido.TabIndex = 107;
            this.tbApellido.Text = "Apellido";
            // 
            // tbCedula
            // 
            this.tbCedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tbCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCedula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCedula.ForeColor = System.Drawing.Color.DimGray;
            this.tbCedula.Location = new System.Drawing.Point(282, 190);
            this.tbCedula.Name = "tbCedula";
            this.tbCedula.Size = new System.Drawing.Size(422, 20);
            this.tbCedula.TabIndex = 108;
            this.tbCedula.Text = "Cedula";
            // 
            // tbContra
            // 
            this.tbContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tbContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbContra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContra.ForeColor = System.Drawing.Color.DimGray;
            this.tbContra.Location = new System.Drawing.Point(282, 213);
            this.tbContra.Name = "tbContra";
            this.tbContra.Size = new System.Drawing.Size(422, 20);
            this.tbContra.TabIndex = 109;
            this.tbContra.Text = "Contraseña";
            this.tbContra.TextChanged += new System.EventHandler(this.tbContra_TextChanged);
            // 
            // tbContra2
            // 
            this.tbContra2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tbContra2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbContra2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContra2.ForeColor = System.Drawing.Color.DimGray;
            this.tbContra2.Location = new System.Drawing.Point(282, 241);
            this.tbContra2.Name = "tbContra2";
            this.tbContra2.Size = new System.Drawing.Size(422, 20);
            this.tbContra2.TabIndex = 110;
            this.tbContra2.Text = "Repetir Contraseña";
            // 
            // btnVolver
            // 
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.DimGray;
            this.btnVolver.Location = new System.Drawing.Point(602, 316);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(66, 34);
            this.btnVolver.TabIndex = 123;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnRegistrar.Location = new System.Drawing.Point(674, 316);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(90, 34);
            this.btnRegistrar.TabIndex = 124;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(279, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 125;
            this.label3.Text = "Grupo:";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.ForeColor = System.Drawing.Color.DimGray;
            this.lblMateria.Location = new System.Drawing.Point(364, 299);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(61, 17);
            this.lblMateria.TabIndex = 126;
            this.lblMateria.Text = "Materia:";
            this.lblMateria.Visible = false;
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
            this.lbGrupos.Location = new System.Drawing.Point(282, 319);
            this.lbGrupos.Name = "lbGrupos";
            this.lbGrupos.Size = new System.Drawing.Size(63, 85);
            this.lbGrupos.TabIndex = 127;
            // 
            // lbMateria
            // 
            this.lbMateria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lbMateria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbMateria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMateria.ForeColor = System.Drawing.Color.LightGray;
            this.lbMateria.FormattingEnabled = true;
            this.lbMateria.ItemHeight = 17;
            this.lbMateria.Items.AddRange(new object[] {
            "Matematicas",
            "Geometria",
            "Programacion"});
            this.lbMateria.Location = new System.Drawing.Point(367, 319);
            this.lbMateria.Name = "lbMateria";
            this.lbMateria.Size = new System.Drawing.Size(94, 85);
            this.lbMateria.TabIndex = 128;
            this.lbMateria.Visible = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsuario.Location = new System.Drawing.Point(282, 164);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(422, 20);
            this.txtUsuario.TabIndex = 129;
            this.txtUsuario.Text = "Nombre de usuario";
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lbMateria);
            this.Controls.Add(this.lbGrupos);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.tbContra2);
            this.Controls.Add(this.tbContra);
            this.Controls.Add(this.tbCedula);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.cbProfesor);
            this.Controls.Add(this.cbAlumno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registrar";
            this.Text = "Registrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbAlumno;
        private System.Windows.Forms.CheckBox cbProfesor;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbCedula;
        private System.Windows.Forms.TextBox tbContra;
        private System.Windows.Forms.TextBox tbContra2;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.ListBox lbGrupos;
        private System.Windows.Forms.ListBox lbMateria;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}