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
            this.seleccionarEstComboBox = new System.Windows.Forms.ComboBox();
            this.btnAgregarAsignatura = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.seleccionarMateriacomboBox = new System.Windows.Forms.ComboBox();
            this.ProfesorescheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione un estudiante:";
            // 
            // seleccionarEstComboBox
            // 
            this.seleccionarEstComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seleccionarEstComboBox.FormattingEnabled = true;
            this.seleccionarEstComboBox.Location = new System.Drawing.Point(171, 39);
            this.seleccionarEstComboBox.Name = "seleccionarEstComboBox";
            this.seleccionarEstComboBox.Size = new System.Drawing.Size(190, 21);
            this.seleccionarEstComboBox.TabIndex = 2;
            this.seleccionarEstComboBox.SelectedIndexChanged += new System.EventHandler(this.SeleccionarEstComboBox1_SelectedIndexChanged);
            // 
            // btnAgregarAsignatura
            // 
            this.btnAgregarAsignatura.Location = new System.Drawing.Point(129, 316);
            this.btnAgregarAsignatura.Name = "btnAgregarAsignatura";
            this.btnAgregarAsignatura.Size = new System.Drawing.Size(132, 30);
            this.btnAgregarAsignatura.TabIndex = 6;
            this.btnAgregarAsignatura.Text = "Agregar Asignatura";
            this.btnAgregarAsignatura.UseVisualStyleBackColor = true;
            this.btnAgregarAsignatura.Click += new System.EventHandler(this.BtnAgregarAsignatura_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre:Creditos";
            // 
            // seleccionarMateriacomboBox
            // 
            this.seleccionarMateriacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seleccionarMateriacomboBox.Enabled = false;
            this.seleccionarMateriacomboBox.FormattingEnabled = true;
            this.seleccionarMateriacomboBox.Location = new System.Drawing.Point(171, 87);
            this.seleccionarMateriacomboBox.Name = "seleccionarMateriacomboBox";
            this.seleccionarMateriacomboBox.Size = new System.Drawing.Size(177, 21);
            this.seleccionarMateriacomboBox.TabIndex = 10;
            this.seleccionarMateriacomboBox.SelectedIndexChanged += new System.EventHandler(this.SeleccionarMateriacomboBox_SelectedIndexChanged);
            // 
            // ProfesorescheckedListBox1
            // 
            this.ProfesorescheckedListBox1.CheckOnClick = true;
            this.ProfesorescheckedListBox1.Enabled = false;
            this.ProfesorescheckedListBox1.FormattingEnabled = true;
            this.ProfesorescheckedListBox1.Location = new System.Drawing.Point(42, 126);
            this.ProfesorescheckedListBox1.Name = "ProfesorescheckedListBox1";
            this.ProfesorescheckedListBox1.Size = new System.Drawing.Size(394, 169);
            this.ProfesorescheckedListBox1.TabIndex = 11;
            this.ProfesorescheckedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ProfesorescheckedListBox1_ItemCheck);
            // 
            // frmAgregarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 389);
            this.Controls.Add(this.ProfesorescheckedListBox1);
            this.Controls.Add(this.seleccionarMateriacomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregarAsignatura);
            this.Controls.Add(this.seleccionarEstComboBox);
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
        private System.Windows.Forms.ComboBox seleccionarEstComboBox;
        private System.Windows.Forms.Button btnAgregarAsignatura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox seleccionarMateriacomboBox;
        private System.Windows.Forms.CheckedListBox ProfesorescheckedListBox1;
    }
}