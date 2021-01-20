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
    public partial class frmCalificacionesDataGrid : Form
    {
        public frmCalificacionesDataGrid()
        {
            InitializeComponent();
        }

        private void FrmCalificacionesDataGrid_Load(object sender, EventArgs e)
        {
            int counter = 0;
            string id = "";
            FormCollection fc = Application.OpenForms;
            foreach (Form item in fc)
            {
                if (item.Name == "frmGestionarEstudiante")
                {
                    id = frmGestionarEstudiante.id;
                }

            }
            if (string.IsNullOrWhiteSpace(id))
            {
                id = frmIDForDataGrid_StudentView.ID;
            }

            string[] lineofcontent = File.ReadAllLines(Environment.CurrentDirectory + "\\Materias\\" + id + "materias.txt");

            foreach (var item in lineofcontent)
            {
                string[] elementos = item.Split(':');

                string asignatura = elementos[0];
                string creditos = elementos[1];
                string profesor = elementos[2];
                try
                {
                    string calificacion = elementos[3];
                    string alpha = elementos[4];
                    string puntos_honor = elementos[5];
                    string print = asignatura + ":" + creditos + ":" + profesor + ":" +  calificacion + ":" + alpha + ":" + puntos_honor;
                    dataGridView1.Rows.Add(print.Split(':'));
                    dataGridView1.Rows[counter].Cells[3].Value = Convert.ToInt32(calificacion);

                }
                catch (Exception)
                {


                }
                counter++;

            }

            dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Descending);


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = (dataGridView1.ClientRectangle.Height - dataGridView1.ColumnHeadersHeight) / dataGridView1.Rows.Count;
            }

        }

    }
}
