namespace AdministradorCalificaciones
{
    partial class frmPrincipal
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
            this.txtTituloPrincipal = new System.Windows.Forms.Label();
            this.btnCalificarEstudiante = new System.Windows.Forms.Button();
            this.btnRegistrarEstudiante = new System.Windows.Forms.Button();
            this.btnRegistrarMateria = new System.Windows.Forms.Button();
            this.btnListarCalificaciones = new System.Windows.Forms.Button();
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            this.btnAgregarCarrera = new System.Windows.Forms.Button();
            this.btnAgregarProfesor = new System.Windows.Forms.Button();
            this.btnGestionarEstudiante = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTituloPrincipal
            // 
            this.txtTituloPrincipal.AutoSize = true;
            this.txtTituloPrincipal.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloPrincipal.Location = new System.Drawing.Point(5, 9);
            this.txtTituloPrincipal.Name = "txtTituloPrincipal";
            this.txtTituloPrincipal.Size = new System.Drawing.Size(416, 40);
            this.txtTituloPrincipal.TabIndex = 0;
            this.txtTituloPrincipal.Text = "Manejador de Calificaciones";
            // 
            // btnCalificarEstudiante
            // 
            this.btnCalificarEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalificarEstudiante.Location = new System.Drawing.Point(19, 344);
            this.btnCalificarEstudiante.Name = "btnCalificarEstudiante";
            this.btnCalificarEstudiante.Size = new System.Drawing.Size(155, 45);
            this.btnCalificarEstudiante.TabIndex = 3;
            this.btnCalificarEstudiante.Text = "Calificar Estudiante";
            this.btnCalificarEstudiante.UseVisualStyleBackColor = true;
            this.btnCalificarEstudiante.Click += new System.EventHandler(this.btnCalificarEstudiante_Click);
            // 
            // btnRegistrarEstudiante
            // 
            this.btnRegistrarEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarEstudiante.Location = new System.Drawing.Point(19, 282);
            this.btnRegistrarEstudiante.Name = "btnRegistrarEstudiante";
            this.btnRegistrarEstudiante.Size = new System.Drawing.Size(155, 45);
            this.btnRegistrarEstudiante.TabIndex = 1;
            this.btnRegistrarEstudiante.Text = "Registrar Estudiante";
            this.btnRegistrarEstudiante.UseVisualStyleBackColor = true;
            this.btnRegistrarEstudiante.Click += new System.EventHandler(this.btnRegistrarEstudiante_Click);
            // 
            // btnRegistrarMateria
            // 
            this.btnRegistrarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarMateria.Location = new System.Drawing.Point(12, 108);
            this.btnRegistrarMateria.Name = "btnRegistrarMateria";
            this.btnRegistrarMateria.Size = new System.Drawing.Size(155, 45);
            this.btnRegistrarMateria.TabIndex = 0;
            this.btnRegistrarMateria.Text = "Registrar Materia";
            this.btnRegistrarMateria.UseVisualStyleBackColor = true;
            this.btnRegistrarMateria.Click += new System.EventHandler(this.btnRegistrarMateria_Click);
            // 
            // btnListarCalificaciones
            // 
            this.btnListarCalificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarCalificaciones.Location = new System.Drawing.Point(235, 282);
            this.btnListarCalificaciones.Name = "btnListarCalificaciones";
            this.btnListarCalificaciones.Size = new System.Drawing.Size(155, 45);
            this.btnListarCalificaciones.TabIndex = 4;
            this.btnListarCalificaciones.Text = "Listar Calificaciones";
            this.btnListarCalificaciones.UseVisualStyleBackColor = true;
            this.btnListarCalificaciones.Click += new System.EventHandler(this.btnListarCalificaciones_Click);
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMateria.Location = new System.Drawing.Point(12, 176);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(155, 46);
            this.btnAgregarMateria.TabIndex = 2;
            this.btnAgregarMateria.Text = "Agregar Materia";
            this.btnAgregarMateria.UseVisualStyleBackColor = true;
            this.btnAgregarMateria.Click += new System.EventHandler(this.BtnAgregarMateria_Click);
            // 
            // btnAgregarCarrera
            // 
            this.btnAgregarCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCarrera.Location = new System.Drawing.Point(235, 177);
            this.btnAgregarCarrera.Name = "btnAgregarCarrera";
            this.btnAgregarCarrera.Size = new System.Drawing.Size(155, 45);
            this.btnAgregarCarrera.TabIndex = 5;
            this.btnAgregarCarrera.Text = "Agregar Carrera";
            this.btnAgregarCarrera.UseVisualStyleBackColor = true;
            this.btnAgregarCarrera.Click += new System.EventHandler(this.BtnAgregarCarrera_Click);
            // 
            // btnAgregarProfesor
            // 
            this.btnAgregarProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProfesor.Location = new System.Drawing.Point(235, 108);
            this.btnAgregarProfesor.Name = "btnAgregarProfesor";
            this.btnAgregarProfesor.Size = new System.Drawing.Size(155, 45);
            this.btnAgregarProfesor.TabIndex = 6;
            this.btnAgregarProfesor.Text = "Agregar Profesor";
            this.btnAgregarProfesor.UseVisualStyleBackColor = true;
            this.btnAgregarProfesor.Click += new System.EventHandler(this.BtnAgregarProfesor_Click);
            // 
            // btnGestionarEstudiante
            // 
            this.btnGestionarEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarEstudiante.Location = new System.Drawing.Point(235, 344);
            this.btnGestionarEstudiante.Name = "btnGestionarEstudiante";
            this.btnGestionarEstudiante.Size = new System.Drawing.Size(155, 45);
            this.btnGestionarEstudiante.TabIndex = 7;
            this.btnGestionarEstudiante.Text = "Gestionar Estudiante";
            this.btnGestionarEstudiante.UseVisualStyleBackColor = true;
            this.btnGestionarEstudiante.Click += new System.EventHandler(this.BtnVerificarEstudiantes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "F1(Student View)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "F2(Teacher View)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Actividades Generales";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Actividades de Estudiante";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(426, 452);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGestionarEstudiante);
            this.Controls.Add(this.btnAgregarProfesor);
            this.Controls.Add(this.btnAgregarCarrera);
            this.Controls.Add(this.btnAgregarMateria);
            this.Controls.Add(this.btnListarCalificaciones);
            this.Controls.Add(this.btnRegistrarMateria);
            this.Controls.Add(this.btnRegistrarEstudiante);
            this.Controls.Add(this.btnCalificarEstudiante);
            this.Controls.Add(this.txtTituloPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manejador de Calificaciones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPrincipal_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTituloPrincipal;
        private System.Windows.Forms.Button btnCalificarEstudiante;
        private System.Windows.Forms.Button btnRegistrarEstudiante;
        private System.Windows.Forms.Button btnRegistrarMateria;
        private System.Windows.Forms.Button btnListarCalificaciones;
        private System.Windows.Forms.Button btnAgregarMateria;
        private System.Windows.Forms.Button btnAgregarCarrera;
        private System.Windows.Forms.Button btnAgregarProfesor;
        private System.Windows.Forms.Button btnGestionarEstudiante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

