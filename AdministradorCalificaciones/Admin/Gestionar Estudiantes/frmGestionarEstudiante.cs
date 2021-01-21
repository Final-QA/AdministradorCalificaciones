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
    public partial class frmGestionarEstudiante : Form
    {
        public static string Id;
        public frmGestionarEstudiante()
        {
            InitializeComponent();
        }

        private void BtnVerCalificaciones_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Debe de seleccionar un estudiante");
            }
            else
            {
                Form verificarcalificaciones = new frmCalificacionesDataGrid();
                verificarcalificaciones.ShowDialog();
            }
        }

       
        private void BtnEliminarEstudiante_Click(object sender, EventArgs e)
        {

            bool escribir = true;
            string id = txtID.Text;
            int counter = 0;
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Debe de seleccionar un estudiante");
            }
            else
            {
                DialogResult opcion = MessageBox.Show("Desea eliminar este estudiantes?", "Alerta", MessageBoxButtons.YesNo);
                switch (opcion)
                {
                    case DialogResult.Yes:

                        DialogResult seguro = MessageBox.Show("Esta seguro?", "Alerta", MessageBoxButtons.YesNo);

                        switch (seguro)
                        {

                            case DialogResult.Yes:

                                break;
                            case DialogResult.No:
                                escribir = false;
                                this.Close();
                                break;

                        }

                        break;
                    case DialogResult.No:
                        escribir = false;
                        this.Close();
                        break;

                }
                string[] estudiantes = File.ReadAllLines("estudianteslista.txt");
                string[] lineas = new string[estudiantes.Length - 1];
                if (escribir == true)
                {


                    foreach (var item in estudiantes)
                    {

                        string[] elementos = item.Split(':');
                        string ID = elementos[0];
                        string Nombre = elementos[1];
                        string Carrera = elementos[2];

                        string print = ID + ":" + Nombre + ":" + Carrera;

                        if (elementos[0] == txtID.Text)
                        {
                            counter--;
                        }
                        else
                        {
                            estudiantes[counter] = string.Format(print);
                            lineas[counter] = estudiantes[counter];
                        }

                        counter++;

                        if (counter == lineas.Length)
                        {
                            break;
                        }

                    }
                }
                if (escribir == true)
                {

                    FileInfo myarchivo = new FileInfo(Environment.CurrentDirectory + "\\Materias\\" + id + "materias.txt");
                    myarchivo.Delete();

                    FileInfo myarchivo2 = new FileInfo("estudianteslista.txt");
                    myarchivo2.Delete();

                    FileInfo myarchivo3 = new FileInfo(Environment.CurrentDirectory + "\\Estudiantes\\" + id + ".txt");
                    myarchivo3.Delete();

                    File.WriteAllLines("estudianteslista.txt", lineas);




                    MessageBox.Show("El estudiante ha sido eliminado con exito!");
                    this.Close();
                }
            }
        }

        private void BtnModificarEstudiante_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Debe de seleccionar un estudiante");
            }
            else
            {
                Id = txtID.Text;
                Form modificarest = new frmModificarEstudiante();
                modificarest.ShowDialog();
                
            }

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            txtNombre.Text = null;
            txtIndice.Text = null;
            if (!File.Exists(Environment.CurrentDirectory + "\\Estudiantes\\" + id + ".txt"))
            {
                MessageBox.Show("El ID que ha ingresado no es valido");
            }
            else if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Porfavor ingrese un ID");
            }
            else
            {
                Id = txtID.Text;
                double puntos_honor = 0;
                double creditos = 0;
                if (!File.Exists(Environment.CurrentDirectory + "\\Materias\\" + id + "materias.txt"))
                {
                    var myfile = File.Create(Environment.CurrentDirectory + "\\Materias\\" + id + "materias.txt");
                    myfile.Close();

                }
                string[] lineas3 = File.ReadAllLines(Environment.CurrentDirectory + "\\Materias\\" + id + "materias.txt");


                foreach (var item in lineas3)
                {
                    string[] elementos2 = item.Split(':');
                    try
                    {
                        puntos_honor += Convert.ToDouble(elementos2[6]);

                    }
                    catch (Exception)
                    {
                        puntos_honor += 0;
                        creditos -= Convert.ToDouble(elementos2[1]);

                    }
                    creditos += Convert.ToDouble(elementos2[1]);
                }

                double indice = Math.Round(puntos_honor / creditos, 2);
                txtIndice.Text = indice.ToString();

                string[] lineas2 = File.ReadAllLines(Environment.CurrentDirectory + "\\Estudiantes\\" + id + ".txt");
                foreach (var item in lineas2)
                {
                    string[] elementos3 = item.Split(':');
                    string nombre = elementos3[1];
                    txtNombre.Text = nombre;
                }
            }

        }
    }
}
