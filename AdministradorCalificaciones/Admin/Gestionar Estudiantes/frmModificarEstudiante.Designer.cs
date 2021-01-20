namespace AdministradorCalificaciones
{
    partial class frmModificarEstudiante
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.seleccionarAreacomboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.seleccionarCarreracomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Estudiante:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(132, 54);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(157, 20);
            this.txtID.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(132, 108);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(157, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // seleccionarAreacomboBox1
            // 
            this.seleccionarAreacomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seleccionarAreacomboBox1.FormattingEnabled = true;
            this.seleccionarAreacomboBox1.Items.AddRange(new object[] {
            "Economia y Negocios",
            "Ciencias Sociales y Humanidades",
            "Ciencias Basicas y Ambientales",
            "Ingenierias"});
            this.seleccionarAreacomboBox1.Location = new System.Drawing.Point(132, 158);
            this.seleccionarAreacomboBox1.Name = "seleccionarAreacomboBox1";
            this.seleccionarAreacomboBox1.Size = new System.Drawing.Size(157, 21);
            this.seleccionarAreacomboBox1.TabIndex = 12;
            this.seleccionarAreacomboBox1.SelectedIndexChanged += new System.EventHandler(this.SeleccionarAreacomboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre:";
            // 
            // seleccionarCarreracomboBox
            // 
            this.seleccionarCarreracomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seleccionarCarreracomboBox.Enabled = false;
            this.seleccionarCarreracomboBox.FormattingEnabled = true;
            this.seleccionarCarreracomboBox.Location = new System.Drawing.Point(132, 213);
            this.seleccionarCarreracomboBox.Name = "seleccionarCarreracomboBox";
            this.seleccionarCarreracomboBox.Size = new System.Drawing.Size(157, 21);
            this.seleccionarCarreracomboBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Area:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Carrera";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(147, 300);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 27);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modiificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // frmModificarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 395);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.seleccionarCarreracomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.seleccionarAreacomboBox1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmModificarEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModificarEstudiante";
            this.Load += new System.EventHandler(this.FrmModificarEstudiante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox seleccionarAreacomboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox seleccionarCarreracomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModificar;
    }
}