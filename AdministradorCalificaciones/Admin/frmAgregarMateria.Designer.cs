namespace AdministradorCalificaciones
{
    partial class frmAgregarMateria
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarAsignatura = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.seleccionarMateriacomboBox = new System.Windows.Forms.ComboBox();
            this.ProfesorescheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Carrera = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione un estudiante:";
            // 
            // btnAgregarAsignatura
            // 
            this.btnAgregarAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAsignatura.Location = new System.Drawing.Point(129, 316);
            this.btnAgregarAsignatura.Name = "btnAgregarAsignatura";
            this.btnAgregarAsignatura.Size = new System.Drawing.Size(167, 30);
            this.btnAgregarAsignatura.TabIndex = 6;
            this.btnAgregarAsignatura.Text = "Agregar Asignatura";
            this.btnAgregarAsignatura.UseVisualStyleBackColor = true;
            this.btnAgregarAsignatura.Click += new System.EventHandler(this.BtnAgregarAsignatura_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre:Creditos";
            // 
            // seleccionarMateriacomboBox
            // 
            this.seleccionarMateriacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seleccionarMateriacomboBox.Enabled = false;
            this.seleccionarMateriacomboBox.FormattingEnabled = true;
            this.seleccionarMateriacomboBox.Location = new System.Drawing.Point(171, 88);
            this.seleccionarMateriacomboBox.Name = "seleccionarMateriacomboBox";
            this.seleccionarMateriacomboBox.Size = new System.Drawing.Size(164, 21);
            this.seleccionarMateriacomboBox.TabIndex = 10;
            this.seleccionarMateriacomboBox.SelectedIndexChanged += new System.EventHandler(this.SeleccionarMateriacomboBox_SelectedIndexChanged);
            // 
            // ProfesorescheckedListBox1
            // 
            this.ProfesorescheckedListBox1.CheckOnClick = true;
            this.ProfesorescheckedListBox1.Enabled = false;
            this.ProfesorescheckedListBox1.FormattingEnabled = true;
            this.ProfesorescheckedListBox1.Location = new System.Drawing.Point(24, 126);
            this.ProfesorescheckedListBox1.Name = "ProfesorescheckedListBox1";
            this.ProfesorescheckedListBox1.Size = new System.Drawing.Size(377, 169);
            this.ProfesorescheckedListBox1.TabIndex = 11;
            this.ProfesorescheckedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ProfesorescheckedListBox1_ItemCheck);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(171, 52);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(164, 20);
            this.txtID.TabIndex = 12;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(341, 50);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 13;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombre:";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(82, 26);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(35, 13);
            this.lbl_Nombre.TabIndex = 15;
            this.lbl_Nombre.Text = "label5";
            this.lbl_Nombre.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Carrera:";
            // 
            // lbl_Carrera
            // 
            this.lbl_Carrera.AutoSize = true;
            this.lbl_Carrera.Location = new System.Drawing.Point(261, 26);
            this.lbl_Carrera.Name = "lbl_Carrera";
            this.lbl_Carrera.Size = new System.Drawing.Size(35, 13);
            this.lbl_Carrera.TabIndex = 17;
            this.lbl_Carrera.Text = "label5";
            this.lbl_Carrera.Visible = false;
            // 
            // frmAgregarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 374);
            this.Controls.Add(this.lbl_Carrera);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.ProfesorescheckedListBox1);
            this.Controls.Add(this.seleccionarMateriacomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregarAsignatura);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarMateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarMateria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarAsignatura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox seleccionarMateriacomboBox;
        private System.Windows.Forms.CheckedListBox ProfesorescheckedListBox1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Carrera;
    }
}