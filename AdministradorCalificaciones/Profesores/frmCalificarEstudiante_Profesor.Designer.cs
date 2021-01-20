namespace AdministradorCalificaciones
{
    partial class frmCalificarEstudiante_Profesor
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
            this.seleccionarEstComboBox1 = new System.Windows.Forms.ComboBox();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estudiante a calificar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Calificacion:";
            // 
            // seleccionarEstComboBox1
            // 
            this.seleccionarEstComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seleccionarEstComboBox1.FormattingEnabled = true;
            this.seleccionarEstComboBox1.Location = new System.Drawing.Point(31, 61);
            this.seleccionarEstComboBox1.Name = "seleccionarEstComboBox1";
            this.seleccionarEstComboBox1.Size = new System.Drawing.Size(162, 21);
            this.seleccionarEstComboBox1.TabIndex = 2;
            this.seleccionarEstComboBox1.SelectedIndexChanged += new System.EventHandler(this.SeleccionarEstComboBox1_SelectedIndexChanged);
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Enabled = false;
            this.txtCalificacion.Location = new System.Drawing.Point(98, 114);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(175, 20);
            this.txtCalificacion.TabIndex = 7;
            // 
            // btnCalificar
            // 
            this.btnCalificar.Location = new System.Drawing.Point(98, 194);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(75, 23);
            this.btnCalificar.TabIndex = 8;
            this.btnCalificar.Text = "Calificar";
            this.btnCalificar.UseVisualStyleBackColor = true;
            this.btnCalificar.Click += new System.EventHandler(this.BtnCalificar_Click);
            // 
            // frmCalificarEstudiante_Profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 241);
            this.Controls.Add(this.btnCalificar);
            this.Controls.Add(this.txtCalificacion);
            this.Controls.Add(this.seleccionarEstComboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalificarEstudiante_Profesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calificar Estudiante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox seleccionarEstComboBox1;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.Button btnCalificar;
    }
}