namespace AdministradorCalificaciones
{
    partial class frmGestionarEstudiante
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
            this.seleccionarEstComboBox = new System.Windows.Forms.ComboBox();
            this.btnVerCalificaciones = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.btnModificarEstudiante = new System.Windows.Forms.Button();
            this.btnEliminarEstudiante = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione un estudiante:";
            // 
            // seleccionarEstComboBox
            // 
            this.seleccionarEstComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seleccionarEstComboBox.FormattingEnabled = true;
            this.seleccionarEstComboBox.Location = new System.Drawing.Point(162, 40);
            this.seleccionarEstComboBox.Name = "seleccionarEstComboBox";
            this.seleccionarEstComboBox.Size = new System.Drawing.Size(190, 21);
            this.seleccionarEstComboBox.TabIndex = 3;
            this.seleccionarEstComboBox.SelectedIndexChanged += new System.EventHandler(this.SeleccionarEstComboBox_SelectedIndexChanged);
            // 
            // btnVerCalificaciones
            // 
            this.btnVerCalificaciones.Location = new System.Drawing.Point(27, 169);
            this.btnVerCalificaciones.Name = "btnVerCalificaciones";
            this.btnVerCalificaciones.Size = new System.Drawing.Size(115, 23);
            this.btnVerCalificaciones.TabIndex = 4;
            this.btnVerCalificaciones.Text = "Ver Calificaciones";
            this.btnVerCalificaciones.UseVisualStyleBackColor = true;
            this.btnVerCalificaciones.Click += new System.EventHandler(this.BtnVerCalificaciones_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Indice:";
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(69, 110);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.ReadOnly = true;
            this.txtIndice.Size = new System.Drawing.Size(100, 20);
            this.txtIndice.TabIndex = 6;
            // 
            // btnModificarEstudiante
            // 
            this.btnModificarEstudiante.Location = new System.Drawing.Point(45, 220);
            this.btnModificarEstudiante.Name = "btnModificarEstudiante";
            this.btnModificarEstudiante.Size = new System.Drawing.Size(142, 23);
            this.btnModificarEstudiante.TabIndex = 7;
            this.btnModificarEstudiante.Text = "Modificar Estudiante";
            this.btnModificarEstudiante.UseVisualStyleBackColor = true;
            this.btnModificarEstudiante.Click += new System.EventHandler(this.BtnModificarEstudiante_Click);
            // 
            // btnEliminarEstudiante
            // 
            this.btnEliminarEstudiante.Location = new System.Drawing.Point(224, 220);
            this.btnEliminarEstudiante.Name = "btnEliminarEstudiante";
            this.btnEliminarEstudiante.Size = new System.Drawing.Size(142, 23);
            this.btnEliminarEstudiante.TabIndex = 8;
            this.btnEliminarEstudiante.Text = "Eliminar Estudiante";
            this.btnEliminarEstudiante.UseVisualStyleBackColor = true;
            this.btnEliminarEstudiante.Click += new System.EventHandler(this.BtnEliminarEstudiante_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(77, 74);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(150, 20);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // frmGestionarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 283);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEliminarEstudiante);
            this.Controls.Add(this.btnModificarEstudiante);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVerCalificaciones);
            this.Controls.Add(this.seleccionarEstComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGestionarEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Estudiante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox seleccionarEstComboBox;
        private System.Windows.Forms.Button btnVerCalificaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.Button btnModificarEstudiante;
        private System.Windows.Forms.Button btnEliminarEstudiante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
    }
}