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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

        }

        private void btnCalificarEstudiante_Click(object sender, EventArgs e)
        {

            if (!File.Exists("estudianteslista.txt"))
            {
                var miarchivo = File.Create("estudianteslista.txt");
                miarchivo.Close();
            }



                string lineOfContents = File.ReadAllText("estudianteslista.txt");

                if (string.IsNullOrWhiteSpace(lineOfContents))
                {

                    MessageBox.Show("No hay estudiantes registrados, antes de calificar registre a algun estudiante");
                }
                else
                {
                    Form calificarEstudiante = new frmCalificarEstudiante();
                    calificarEstudiante.ShowDialog();
                }
            

         
        }

        private void btnRegistrarMateria_Click(object sender, EventArgs e)
        {
            Form registrarMateria = new frmRegMateria();
            registrarMateria.ShowDialog();
        }

        private void btnRegistrarEstudiante_Click(object sender, EventArgs e)
        {
            Form registrarEstudiante = new frmRegistrarEstudiante();
            registrarEstudiante.ShowDialog();
        }

        private void btnListarCalificaciones_Click(object sender, EventArgs e)
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

        private void BtnAgregarMateria_Click(object sender, EventArgs e)
        {
            if (!File.Exists("estudianteslista.txt"))
            {
                var myfile = File.Create("estudianteslista.txt");
                myfile.Close();
            }

                string lineOfContents = File.ReadAllText("estudianteslista.txt");
                if (string.IsNullOrWhiteSpace(lineOfContents))
                {

                    MessageBox.Show("No hay estudiantes registrados, antes de calificar registre a algun estudiante");
                }
                else
                {
                    Form agregarmateria = new frmAgregarMateria();
                    agregarmateria.ShowDialog();
                }                      
        }


        private void BtnAgregarCarrera_Click(object sender, EventArgs e)
        {
            Form agregarcarrera = new frmAgregarCarrera();
            agregarcarrera.ShowDialog();
        }

        private void BtnAgregarProfesor_Click(object sender, EventArgs e)
        {
            Form agregarprofesor = new frmAgregarProfesor();
            agregarprofesor.ShowDialog();
        }

        private void BtnVerificarEstudiantes_Click(object sender, EventArgs e)
        {
            if (!File.Exists("estudianteslista.txt"))
            {
                var myfile = File.Create("estudianteslista.txt");
                myfile.Close();
            }

            string lineOfContents = File.ReadAllText("estudianteslista.txt");
            if (string.IsNullOrWhiteSpace(lineOfContents))
            {

                MessageBox.Show("No hay estudiantes registrados, antes de gestionar registre a algun estudiante");
            }
            else
            {
                Form gestionarestudiante = new frmGestionarEstudiante();
                gestionarestudiante.ShowDialog();
            }
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Dispose();
            Application.Exit();
        }

        private void FrmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F1)
            {
                Form student= new frmStudentView();
                this.Hide();
                this.Dispose();
                student.ShowDialog();
            }
            else if (e.KeyValue == (char)Keys.F2)
            {
                Form profesor = new frmLogin();
                this.Hide();
                this.Dispose();
                profesor.ShowDialog();
            }
        }

    }
}
