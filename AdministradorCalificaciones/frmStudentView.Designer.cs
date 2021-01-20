namespace AdministradorCalificaciones
{
    partial class frmStudentView
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
            this.btnListarCalificaciones = new System.Windows.Forms.Button();
            this.btnVerCalificaciones = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTituloPrincipal
            // 
            this.txtTituloPrincipal.AutoSize = true;
            this.txtTituloPrincipal.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloPrincipal.Location = new System.Drawing.Point(12, 21);
            this.txtTituloPrincipal.Name = "txtTituloPrincipal";
            this.txtTituloPrincipal.Size = new System.Drawing.Size(562, 55);
            this.txtTituloPrincipal.TabIndex = 1;
            this.txtTituloPrincipal.Text = "Manejador de Calificaciones";
            // 
            // btnListarCalificaciones
            // 
            this.btnListarCalificaciones.Location = new System.Drawing.Point(206, 208);
            this.btnListarCalificaciones.Name = "btnListarCalificaciones";
            this.btnListarCalificaciones.Size = new System.Drawing.Size(141, 45);
            this.btnListarCalificaciones.TabIndex = 5;
            this.btnListarCalificaciones.Text = "Ver Ranking";
            this.btnListarCalificaciones.UseVisualStyleBackColor = true;
            this.btnListarCalificaciones.Click += new System.EventHandler(this.BtnListarCalificaciones_Click);
            // 
            // btnVerCalificaciones
            // 
            this.btnVerCalificaciones.Location = new System.Drawing.Point(206, 124);
            this.btnVerCalificaciones.Name = "btnVerCalificaciones";
            this.btnVerCalificaciones.Size = new System.Drawing.Size(141, 45);
            this.btnVerCalificaciones.TabIndex = 6;
            this.btnVerCalificaciones.Text = "Ver Materias";
            this.btnVerCalificaciones.UseVisualStyleBackColor = true;
            this.btnVerCalificaciones.Click += new System.EventHandler(this.BtnVerCalificaciones_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "F3(Administrador)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "F2(Profesor)";
            // 
            // frmStudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 312);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerCalificaciones);
            this.Controls.Add(this.btnListarCalificaciones);
            this.Controls.Add(this.txtTituloPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudentView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Calificaciones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmStudentView_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmStudentView_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTituloPrincipal;
        private System.Windows.Forms.Button btnListarCalificaciones;
        private System.Windows.Forms.Button btnVerCalificaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}