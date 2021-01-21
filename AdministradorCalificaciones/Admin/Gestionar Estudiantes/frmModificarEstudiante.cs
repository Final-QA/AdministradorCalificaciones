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
    public partial class frmModificarEstudiante : Form
    {
        public frmModificarEstudiante()
        {
            InitializeComponent();
            txtID.Text = frmGestionarEstudiante.Id;

            string[] lineas2 = File.ReadAllLines(Environment.CurrentDirectory + "\\Estudiantes\\" + frmGestionarEstudiante.Id + ".txt");
            foreach (var item in lineas2)
            {
                string[] elementos3 = item.Split(':');
                string nombre = elementos3[1];
                txtNombre.Text = nombre;
            }
        }

        private void FrmModificarEstudiante_Load(object sender, EventArgs e)
        {

        }

        private void SeleccionarAreacomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string area = seleccionarAreacomboBox1.Text;
            string[] Areas;
            if (seleccionarAreacomboBox1.Items != null)
            {
                seleccionarCarreracomboBox.Items.Clear();
            }

            switch (area)
            {
                case "Ingenierias":

                    if (new FileInfo(Environment.CurrentDirectory + "\\Areas\\" + "Ingenierias.txt").Length == 0)
                    {
                        MessageBox.Show("Esta area no tiene carrearas registradas");
                        seleccionarAreacomboBox1.Text = null;

                    }
                    else
                    {
                        Areas = File.ReadAllLines(Environment.CurrentDirectory + "\\Areas\\" + "Ingenierias.txt");

                        foreach (var item in Areas)
                        {
                            string[] carrera = item.Split(',');
                            seleccionarCarreracomboBox.Items.Add(carrera[0]);
                        }
                        seleccionarCarreracomboBox.Enabled = true;


                    }
                    break;
                case "Economia y Negocios":

                    if (new FileInfo(Environment.CurrentDirectory + "\\Areas\\" + "Economia y Negocios.txt").Length == 0)
                    {

                        MessageBox.Show("Esta area no tiene carrearas registradas");
                        seleccionarAreacomboBox1.Text = null;

                    }
                    else
                    {
                        Areas = File.ReadAllLines(Environment.CurrentDirectory + "\\Areas\\" + "Economia y Negocios.txt");

                        foreach (var item in Areas)
                        {
                            string[] carrera = item.Split(',');
                            seleccionarCarreracomboBox.Items.Add(carrera[0]);
                        }
                        seleccionarCarreracomboBox.Enabled = true;
                    }
                    break;

                case "Ciencias Sociales y Humanidades":
                    if (new FileInfo(Environment.CurrentDirectory + "\\Areas\\" + "Ciencias Sociales y Humanidades.txt").Length == 0)
                    {

                        MessageBox.Show("Esta area no tiene carrearas registradas");
                        seleccionarAreacomboBox1.Text = null;
                    }
                    else
                    {
                        Areas = File.ReadAllLines(Environment.CurrentDirectory + "\\Areas\\" + "Ciencias Sociales y Humanidades.txt");

                        foreach (var item in Areas)
                        {
                            string[] carrera = item.Split(',');
                            seleccionarCarreracomboBox.Items.Add(carrera[0]);
                        }
                        seleccionarCarreracomboBox.Enabled = true;
                    }
                    break;

                case "Ciencias Basicas y Ambientales":
                    if (new FileInfo(Environment.CurrentDirectory + "\\Areas\\" + "Ciencias Basicas y Ambientales.txt").Length == 0)
                    {

                        MessageBox.Show("Esta area no tiene carrearas registradas");
                        seleccionarAreacomboBox1.Text = null;

                    }
                    else
                    {
                        Areas = File.ReadAllLines(Environment.CurrentDirectory + "\\Areas\\" + "Ciencias Basicas y Ambientales.txt");

                        foreach (var item in Areas)
                        {
                            string[] carrera = item.Split(',');
                            seleccionarCarreracomboBox.Items.Add(carrera[0]);
                        }
                        seleccionarCarreracomboBox.Enabled = true;
                    }
                    break;

                default:
                    break;
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

            string id = txtID.Text;
            bool escribir = true;
            int counter = 0;
            string nombre = txtNombre.Text;
            string[] siglas = seleccionarCarreracomboBox.Text.Split('(');
            string carrera = siglas[0];

            DialogResult opcion = MessageBox.Show("Desea modififcar este?", "Alerta", MessageBoxButtons.YesNo);
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
            if (escribir == true)
            {
                //string[] estudiante = File.ReadAllLines(Environment.CurrentDirectory + "\\Estudiantes\\" + id + ".txt");
                string estudiante = File.ReadAllText(Environment.CurrentDirectory + "\\Estudiantes\\" + id + ".txt");
                string[] carreraverificar = estudiante.Split(':');
                if (carreraverificar[2] != carrera)
                {
                    FileInfo myarchivo2 = new FileInfo(Environment.CurrentDirectory + "\\Materias\\" + id + "materias.txt");
                    myarchivo2.Delete();
                    var archivos = File.Create(Environment.CurrentDirectory + "\\Materias\\" + id + "materias.txt");
                    archivos.Close();
                }

                estudiante = string.Format(id + ":" + nombre + ":" + carrera);

                FileInfo myarchivo = new FileInfo(Environment.CurrentDirectory + "\\Estudiantes\\" + id + ".txt");
                myarchivo.Delete();

                File.WriteAllText(Environment.CurrentDirectory + "\\Estudiantes\\" + id + ".txt", estudiante);

                string[] estudiantes = File.ReadAllLines("estudianteslista.txt");
                foreach (var item in estudiantes)
                {
                    string[] elementos = item.Split(':');

                    if (elementos[0] == id)
                    {
                        estudiantes[counter] = string.Format(id + ":" + nombre + ":" + carrera);

                    }
                    else
                    {
                        estudiantes[counter] = string.Format(elementos[0] + ":" + elementos[1] + ":" + elementos[2]);
                    }

                    counter++;
                }
                File.WriteAllLines("estudianteslista.txt", estudiantes);
                MessageBox.Show("El estudiante ha sido modificado!");
                this.Close();
            }
            else
            {
                this.Close();
            }

        }
    }
}
