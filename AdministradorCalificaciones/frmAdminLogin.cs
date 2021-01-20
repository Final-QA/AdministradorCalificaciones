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
    public partial class frmAdminLogin : Form
    {
        public frmAdminLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
            else
            {
                string[] lineas = File.ReadAllLines("Admin.txt");
                string[] user= lineas[0].Split(':');
                string[] pass = lineas[1].Split(':');

                string usernametxt = user[1];
                string passwordtxt = pass[1];

                if (username.ToLower() == usernametxt.ToLower() && password == passwordtxt)
                {
                    this.Hide();
                    this.Dispose();
                    Form admin = new frmPrincipal();
                    admin.ShowDialog();
                }
                else if (username.ToLower() == usernametxt.ToLower() && password != passwordtxt)
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
                else if (username.ToLower() != usernametxt.ToLower() && password == passwordtxt)
                {
                    MessageBox.Show("Usuario Incorrecto");
                }else
                {
                    MessageBox.Show("Datos incorrectos");
                }

            }

        }

        private void FrmAdminLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Dispose();
            Form studentview = new frmStudentView();
            studentview.ShowDialog();

        }
    }
}
