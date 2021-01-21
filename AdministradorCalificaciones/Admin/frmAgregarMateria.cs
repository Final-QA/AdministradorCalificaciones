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

    public partial class frmAgregarMateria : Form
    {
        public string Id;
        public string carreras = "";
        public string materia = "";

        public frmAgregarMateria()
        {
            InitializeComponent();

        }



        private void BtnAgregarAsignatura_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(Id))
            {
                MessageBox.Show("Debe de seleccionar a un estudiante");
            }
            else if (string.IsNullOrWhiteSpace(seleccionarMateriacomboBox.Text))
            {
                MessageBox.Show("Debe de seleccionar una asignatura");
            }
            else if (ProfesorescheckedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Debe de seleccionar a un profesor");
            }
            else
            {

                string estudiante = Id;
                string profesor = ProfesorescheckedListBox1.Text;


                string est = File.ReadAllText(Environment.CurrentDirectory + "\\Estudiantes\\" + estudiante + ".txt");
                string[] carrera = est.Split(':');

                string[] materias = File.ReadAllLines(Environment.CurrentDirectory + "\\Carreras\\" + carrera[2] + "Materias.txt");

                foreach (var item in materias)
                {
                    string[] elemento = item.Split(':');

                        
                    string[] materiasest = File.ReadAllLines(Environment.CurrentDirectory + "\\Materias\\" + estudiante + "materias.txt");

                    if (seleccionarMateriacomboBox.SelectedItem.Equals(item))
                    {
                        if (!File.ReadAllText(Environment.CurrentDirectory + "\\Materias\\" + estudiante + "materias.txt").Contains(item.ToString()))
                        {
                            StreamWriter archivo = File.AppendText(Environment.CurrentDirectory + "\\Materias\\" + estudiante + "materias.txt");
                            archivo.Write(seleccionarMateriacomboBox.Items[seleccionarMateriacomboBox.Items.IndexOf(item.ToString())] + ":" + profesor + Environment.NewLine);
                            archivo.Close();

                            MessageBox.Show("Se ha añadido la materia: " + elemento[0]);
                            break;
                        }
                    }
                      
                }
                this.Close();

            }
            
        }



        private void SeleccionarMateriacomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string[] print = seleccionarMateriacomboBox.Text.Split(':');
            string estudiante = Id;
            string asignatura = seleccionarMateriacomboBox.Text;
            materia = print[0];
            foreach (var file in Directory.EnumerateFiles(Environment.CurrentDirectory + "\\Profesores\\", "*.txt"))
            {
                string contents = File.ReadAllText(file);
                string[] elementos = contents.Split(':');
                string nombre = elementos[0];
                string carrera = elementos[1];
                string materias = elementos[2];


                if (carrera == carreras && materias == materia )
                {
                    ProfesorescheckedListBox1.Items.Add(nombre);
                }

                
            }
            if (File.ReadAllText(Environment.CurrentDirectory + "\\Materias\\" + estudiante + "materias.txt").Contains(asignatura))
            {
                MessageBox.Show("El estudiante ya posee esta asignatura");
                ProfesorescheckedListBox1.Items.Clear();
            }
            else if (ProfesorescheckedListBox1.Items.Count == 0)
            {
                MessageBox.Show("No hay profesores registrados para esta materia");
            }else
            {
                ProfesorescheckedListBox1.Enabled = true;
            }
        }


        private void ProfesorescheckedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < ProfesorescheckedListBox1.Items.Count; ++i)
                if (i != e.Index) ProfesorescheckedListBox1.SetItemChecked(i, false);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            lbl_Nombre.Visible = false;
            lbl_Carrera.Visible = false;
            seleccionarMateriacomboBox.Enabled = false;
            seleccionarMateriacomboBox.Items.Clear();
            Id = null;

            string estudiante = txtID.Text;

            string est = File.ReadAllText(Environment.CurrentDirectory + "\\Estudiantes\\" + estudiante + ".txt");
            string[] carrera = est.Split(':');
            string siglas = carrera[2];
            carreras = carrera[2];
            if (!File.Exists(Environment.CurrentDirectory + "\\Carreras\\" + siglas + "Materias.txt"))
            {
                var myarchivo = File.Create(Environment.CurrentDirectory + "\\Carreras\\" + siglas + "Materias.txt");
                myarchivo.Close();
                MessageBox.Show("La carrera " + siglas + " no tiene materias registradas", siglas);
                this.Close();
            }
            else if (new FileInfo(Environment.CurrentDirectory + "\\Carreras\\" + siglas + "Materias.txt").Length == 0)
            {
                MessageBox.Show("La carrera " + siglas + " no tiene materias registradas");
                this.Close();

            }
            else
            {
                string nombre = est.Split(':')[1];
                lbl_Nombre.Text = nombre;
                lbl_Carrera.Text = carreras;
                Id = estudiante;
                lbl_Nombre.Visible = true;
                lbl_Carrera.Visible = true;

                string[] materias = File.ReadAllLines(Environment.CurrentDirectory + "\\Carreras\\" + siglas + "Materias.txt");
                foreach (var item in materias)
                {
                    string[] elemento = item.Split(':');
                    string asignatura = elemento[0] + ":" + elemento[1];

                    seleccionarMateriacomboBox.Items.Add(asignatura);

                }




                if (!File.Exists(Environment.CurrentDirectory + "\\Materias\\" + estudiante + "materias.txt"))
                {
                    var myfile = File.Create(Environment.CurrentDirectory + "\\Materias\\" + estudiante + "materias.txt");
                    myfile.Close();

                }



                seleccionarMateriacomboBox.Enabled = true;

            }



        }
    }
    
}
