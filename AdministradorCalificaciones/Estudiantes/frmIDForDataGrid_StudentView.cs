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
    public partial class frmIDForDataGrid_StudentView : Form
    {
        public static string ID = "";
        public frmIDForDataGrid_StudentView()
        {
            InitializeComponent();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            if (!File.Exists(Environment.CurrentDirectory + "\\Estudiantes\\" + id + ".txt"))
            {
                MessageBox.Show("El ID que ha ingresado no es valido");
            }
            else if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Porfavor ingrese un ID");
            }
            else if(!txtID.Text.All(char.IsDigit))
            {
                MessageBox.Show("Porfavor ingrese un ID valido");
            }
            else
            {
                if (!File.Exists("estudianteslista.txt"))
                {
                    var myfile = File.Create("estudianteslista.txt");
                    myfile.Close();
                }

                string lineOfContents = File.ReadAllText("estudianteslista.txt");
                if (string.IsNullOrWhiteSpace(lineOfContents))
                {
                    MessageBox.Show("No hay estudiantes registrados");
                }
                else
                {

                    ID = txtID.Text;
                    this.Hide();
                    Form calificaiones = new frmCalificacionesDataGrid();
                    calificaiones.ShowDialog();
                    this.Close();
                }
                
            }

        }
    }
}
