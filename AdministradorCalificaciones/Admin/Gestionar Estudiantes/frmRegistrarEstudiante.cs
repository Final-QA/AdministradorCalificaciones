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
using System.Threading;

namespace AdministradorCalificaciones
{
    public partial class frmRegistrarEstudiante : Form
    {
        public int id = 1090000;
        public frmRegistrarEstudiante()
        {
            InitializeComponent();
            string[] lineas = File.ReadAllLines("estudianteslista.txt");
            id +=  lineas.Count();
            if (File.Exists(Environment.CurrentDirectory + "\\Estudiantes\\" + id + ".txt"))
            {
                foreach (var item in lineas)
                {
                    string[] ids = item.Split(':');
                    if (ids[0] == id.ToString())
                    {
                        id++;
                    }

                }

            }
            txtId.Text = id.ToString();
            



        }



        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            string id = txtId.Text;
            string nombre = txtNombre.Text;
            string carrera = seleccionarCarreracomboBox.Text;
            string[] nombrecarrera = carrera.Split('(');

        

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(carrera)  || string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(carrera))
            {
                MessageBox.Show("Por favor, llena todos los campos.");
            }
            else
            {
                if (File.Exists(Environment.CurrentDirectory + "\\Estudiantes\\" + id + ".txt"))
                {
                    MessageBox.Show("El estudiante ya está registrado.");
                }
                else
                {



                    //Guardar txt con id, nombre y carrera

                    string IdNombreCarrera = "" + id + ":" + nombre + ":" + nombrecarrera[0] + Environment.NewLine;
                    File.AppendAllText("estudianteslista.txt", IdNombreCarrera);


                    //Guardar ID con sus calificaciones personales
                    
                    string IdMasCalificaciones = "" + id + ":" + nombre + ":" + nombrecarrera[0];
                    string dirUnico = Environment.CurrentDirectory + "\\Estudiantes\\"+ id + ".txt";
                    File.AppendAllText(dirUnico, IdMasCalificaciones);

                    MessageBox.Show("¡Estudiante registrado!");

                    //Limpiar todo despues de hacer todo
                    seleccionarCarreracomboBox.Text = String.Empty;
                    txtId.Text = String.Empty;
                    txtNombre.Text = String.Empty;
                    this.Close();
                    

                }
                var myarchivo = File.Create(Environment.CurrentDirectory + "\\Materias\\" + id + "materias.txt");
                myarchivo.Close();
            }
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

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
