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
    public partial class frmCalificarEstudiante : Form
    {

        public string Id;
        public frmCalificarEstudiante()
        {
            InitializeComponent();

            //Buscar los estudiantes de la lista
        }


    

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            double indice = 0;
            double puntos_honor = 0;
            string calificacion = txtCalificacion.Text.ToUpper(); ;//Los datos del la calificacion
            int nota = 0;

            if (calificacion.All(char.IsDigit))
            {
                nota = Convert.ToInt32(calificacion);
            }
                         


            if (string.IsNullOrEmpty(calificacion))
            {
                MessageBox.Show("Debe de ingresar una calificacion");

            }
            else if (nota < 0 || nota > 100)
            {
                MessageBox.Show("Debe de ingresar una calificacion del 0-100");
            }
            else
            {

                //Calcular las notas
                string estudiante = Id;
                string[] Asignaturas = File.ReadAllLines(Environment.CurrentDirectory + "\\Materias\\" + estudiante + "materias.txt");

                bool escribir = true;
                int counter = 0;

                foreach (var item in Asignaturas)
                {

                    string[] elemento = item.Split(':');
                    string print = elemento[0] + ":" + elemento[1] + ":" + elemento[2];

                    if (elemento.Length > 3 && elemento[0] == seleccionarAsigComboBox.Text)
                    {
                        DialogResult opcion = MessageBox.Show("Esta materia ya tiene una calificacion, desea reemplazarla?", "Alerta", MessageBoxButtons.YesNo);
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
                    }
                   
                    

                        double cred = Convert.ToDouble(elemento[1]);

                    if (nota >= 90 && nota  <= 100)
                    {
                        calificacion = "A";
                        puntos_honor = 4.00 * cred;
                        indice = 4.00;
                    }
                    else if (nota >= 85 && nota <= 89)
                    {
                        calificacion = "B+";
                        puntos_honor = 3.50 * cred;
                        indice = 3.50;
                    }
                    else if (nota >= 80 && nota <= 84)
                    {
                        calificacion = "B";
                        puntos_honor = 3.00 * cred;
                        indice = 3.00;
                    }
                    else if (nota >= 75 && nota <= 79) 
                    {
                        calificacion = "C+";
                        puntos_honor = 2.50 * cred;
                        indice = 2.50;
                    }
                    else if (nota >=70 && nota <=74)
                    {
                        calificacion = "C";
                        puntos_honor = 2.00 * cred;
                        indice = 2.00;
                    }
                    else if (nota >=0 && nota <= 69)
                    {
                        if (calificacion == "R")
                        {
                            
                        }
                        else
                        {
                            calificacion = "F";
                            puntos_honor = 0;
                            indice = 0;
                        }
                    }                       

                        string text = ":" + nota + ":" + calificacion +":" + indice + ":" + puntos_honor;



                        if (elemento[0] == seleccionarAsigComboBox.Text)
                        {
                            if (calificacion == "R")
                            {
                                Asignaturas[counter] = string.Format(print + "::R");
                            }
                            else
                            {
                                Asignaturas[counter] = string.Format(print + text);
                            }
                        }

                        counter++;

                    
                }

                if (escribir == true)
                {
                    FileInfo myarchivo = new FileInfo(Environment.CurrentDirectory + "\\Materias\\" + estudiante + "materias.txt");
                    myarchivo.Delete();

                    File.WriteAllLines(Environment.CurrentDirectory + "\\Materias\\" + estudiante + "materias.txt", Asignaturas);



                    MessageBox.Show("¡Estudiante calificado!");
                    this.Close();
                }

            }
        }


        private void SeleccionarAsigComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(seleccionarAsigComboBox.Text))
            {
               
                txtCalificacion.Enabled = true;
            }
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            string id = txtID.Text;
            if (!File.Exists(Environment.CurrentDirectory + "\\Estudiantes\\" + id + ".txt"))
            {
                lbl_Nombre.Visible = false;
                lbl_Carrera.Visible = false;
                seleccionarAsigComboBox.Enabled = false;
                seleccionarAsigComboBox.Items.Clear();
                Id = null;

                MessageBox.Show("El ID que ha ingresado no es valido");
                
            }
            else if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Porfavor ingrese un ID");
            }
            else if (!txtID.Text.All(char.IsDigit))
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
                    string[] estudiante = File.ReadAllLines(Environment.CurrentDirectory + "\\Estudiantes\\" + id + ".txt");
                    string[] Asignaturas = File.ReadAllLines(Environment.CurrentDirectory + "\\Materias\\" + id + "materias.txt");


                    string nombre = estudiante[0].Split(':')[1];
                    string carrera = estudiante[0].Split(':')[2];


                    lbl_Carrera.Text = carrera;
                    lbl_Nombre.Text = nombre;

                    lbl_Nombre.Visible = true;
                    lbl_Carrera.Visible = true;

                    foreach (var item in Asignaturas)
                    {
                        string[] elemento = item.Split(':');
                        string asignatura = elemento[0];
                        if (!seleccionarAsigComboBox.Items.Contains(asignatura))
                        {
                            seleccionarAsigComboBox.Items.Add(asignatura);
                        }
                    }

                    Id = id;

                    seleccionarAsigComboBox.Enabled = true;

                }


            }

        }
    }
}
