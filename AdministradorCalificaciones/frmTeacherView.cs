using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AdministradorCalificaciones
{
    public partial class frmTeacherView : Form
    {
        public frmTeacherView()
        {
            InitializeComponent();
            txtNombre.Text = frmLogin.nombre;
            txtMateria.Text = frmLogin.materia;
        }

        private void BtnListarCalificaciones_Click(object sender, EventArgs e)
        {
            if (!File.Exists("estudianteslista.txt"))
            {
                var miarchivo = File.Create("estudianteslista.txt");
                miarchivo.Close();
            }

            string lineOfContents = File.ReadAllText("estudianteslista.txt");
            if (string.IsNullOrWhiteSpace(lineOfContents))
            {

                MessageBox.Show("No hay estudiantes registrados, antes de listar registre a algun estudiante");
            }
            if (!Directory.EnumerateFileSystemEntries(Environment.CurrentDirectory + "\\Materias").Any())
            {
                MessageBox.Show("No hay materias registradas, antes de listar regitre alguna materia");
            }
            else
            {
                Form listarCalificaciones = new frmListarCalificaciones();
                listarCalificaciones.ShowDialog();
            }

        }

        private void BtnVerCalificaciones_Click(object sender, EventArgs e)
        {
            Form id = new frmIDForDataGrid_StudentView();
            id.ShowDialog();
        }

        private void FrmStudentView_KeyDown(object sender, KeyEventArgs e)
        {if (e.KeyValue == (char)Keys.F2)
            {
                Form profesor = new frmLogin();
                this.Hide();
                this.Dispose();
                profesor.ShowDialog();
            }
        }

        private void BtnVerCalificaciones_Click_1(object sender, EventArgs e)
        {
            Form id = new frmIDForDataGrid_StudentView();
            id.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            Form verCalificaciones = new frmVerCalificacionesDataGrid_Profesor();
            verCalificaciones.ShowDialog();
            
        }

        private void BtnCalificarEstudiante_Click(object sender, EventArgs e)
        {
            Form calificarEstudiante = new frmCalificarEstudiante_Profesor();
            calificarEstudiante.ShowDialog();
        }

        private void FrmTeacherView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F1)
            {
                Form student = new frmStudentView();
                this.Hide();
                this.Dispose();
                student.ShowDialog();
            }

        }

        private void FrmTeacherView_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Dispose();
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
