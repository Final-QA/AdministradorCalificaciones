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
using System.Data.SqlClient;

namespace AdministradorCalificaciones
{
    public partial class frmLogin : Form
    {
        public static string id;
        public static string nombre;
        public static string carrera;
        public static string materia;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            string password = txtPassword.Text;


            if (string.IsNullOrWhiteSpace(ID) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
            else if(ID == "admin")
            {

                string[] lineas = File.ReadAllLines("Admin.txt");
                string[] pass = lineas[1].Split(':');

                string passwordtxt = pass[1];

                if (password == passwordtxt)
                {
                    this.Hide();
                    this.Dispose();
                    Form admin = new frmPrincipal();
                    admin.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Los datos ingresados no son validos");
                }
            }
            else if (!File.Exists(Environment.CurrentDirectory + "\\Profesores\\" + ID + ".txt"))
            {
                MessageBox.Show("Los datos ingresados no son validos");
            }
            else
            {
                string[] profesor = File.ReadAllLines(Environment.CurrentDirectory + "\\Profesores\\" + ID + ".txt");
                foreach (var item in profesor)
                {
                    string[] elementos = item.Split(':');
                    string contraseña = elementos[3];
                    if (contraseña == password)
                    {
                        nombre = elementos[0];
                        carrera = elementos[1];
                        materia = elementos[2];
                        this.Hide();
                        Form profesorview = new frmTeacherView();
                        profesorview.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta");
                    }
                }
            }

        }

        private void FrmProfesorLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Dispose();
            Form studentview = new frmStudentView();
            studentview.ShowDialog();

        }
    }
}
