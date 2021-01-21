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
    public partial class frmStudentView : Form
    {
        public frmStudentView()
        {
            InitializeComponent();

            string pathMaterias = Environment.CurrentDirectory + "\\Materias";
            string pathEstudiantes = Environment.CurrentDirectory + "\\Estudiantes";
            string pathAreas = Environment.CurrentDirectory + "\\Areas";
            string pathCarreras = Environment.CurrentDirectory + "\\Carreras";
            string pathProfesores = Environment.CurrentDirectory + "\\Profesores";
            Directory.CreateDirectory(pathMaterias);
            Directory.CreateDirectory(pathEstudiantes);
            Directory.CreateDirectory(pathAreas);
            Directory.CreateDirectory(pathCarreras);
            Directory.CreateDirectory(pathProfesores);

            if (!File.Exists(Environment.CurrentDirectory + "\\Areas\\" + "Ingenierias.txt"))
            {
                var myfile = File.Create(Environment.CurrentDirectory + "\\Areas\\" + "Ingenierias.txt");
                myfile.Close();
            }
            if (!File.Exists(Environment.CurrentDirectory + "\\Areas\\" + "Economia y Negocios.txt"))
            {
                var myfile = File.Create(Environment.CurrentDirectory + "\\Areas\\" + "Economia y Negocios.txt");
                myfile.Close();
            }
            if (!File.Exists(Environment.CurrentDirectory + "\\Areas\\" + "Ciencias Sociales y Humanidades.txt"))
            {
                var myfile = File.Create(Environment.CurrentDirectory + "\\Areas\\" + "Ciencias Sociales y Humanidades.txt");
                myfile.Close();
            }
            if (!File.Exists(Environment.CurrentDirectory + "\\Areas\\" + "Ciencias Basicas y Ambientales.txt"))
            {
                var myfile = File.Create(Environment.CurrentDirectory + "\\Areas\\" + "Ciencias Basicas y Ambientales.txt");
                myfile.Close();
            }
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
        {
            if (e.KeyValue == (char)Keys.F3)
            {
                Form admin = new frmAdminLogin();
                this.Hide();
                this.Dispose();
                admin.ShowDialog();
            }
            else if (e.KeyValue == (char)Keys.F2)
            {
                Form profesor = new frmLogin();
                this.Hide();
                this.Dispose();
                profesor.ShowDialog();
            }

        }

        private void FrmStudentView_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Dispose();
            Application.Exit();
        }

        private void frmStudentView_Load(object sender, EventArgs e)
        {

        }

        private void txtTituloPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
