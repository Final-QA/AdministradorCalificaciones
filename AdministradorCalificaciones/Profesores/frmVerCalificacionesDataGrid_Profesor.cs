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
    public partial class frmVerCalificacionesDataGrid_Profesor : Form
    {
        public frmVerCalificacionesDataGrid_Profesor()
        {
            InitializeComponent();
            int counter = 0;
            string nombreProfesor = frmLogin.nombre;
            string materia = frmLogin.materia;

            string[] allFiles = Directory.GetFiles(Environment.CurrentDirectory + "\\Materias\\", "*.txt");
            foreach (var file in allFiles)
            {
                string nombre_archivo = Path.GetFileName(file);
                string[] archivo = nombre_archivo.Split('m');
                string ID = archivo[0];

                string[] estudiante = File.ReadAllLines(file);

                foreach(var line in estudiante)
                {
                    string[] elementos = line.Split(':');
                    if (nombreProfesor == elementos[2] && materia == elementos[0])
                    {

                        string Archivo_est = File.ReadAllText(Environment.CurrentDirectory + "\\Estudiantes\\" + ID + ".txt");
                        string[] elementos_est = Archivo_est.Split(':');
                        string nombre_est = elementos_est[1];
                        try
                        {
                            int calificacion = Convert.ToInt32(elementos[3]);
                            string cal_alpha = elementos[4];
                            string print = ID + ":" + nombre_est + ":" + calificacion + ":" + cal_alpha;
                            dataGridView1.Rows.Add(print.Split(':'));
                            dataGridView1.Rows[counter].Cells[2].Value = Convert.ToInt32(calificacion);
                        }
                        catch (Exception)
                        {


                        }
                    }

                }
                


            }
            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Descending);

        }
    }
}
