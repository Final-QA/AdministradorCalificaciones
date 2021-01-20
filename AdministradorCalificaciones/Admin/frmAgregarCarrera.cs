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
    public partial class frmAgregarCarrera : Form
    {
        public frmAgregarCarrera()
        {
            InitializeComponent();
        }

        private void BtnAgregarCarrera_Click(object sender, EventArgs e)
        {


            string nombreCarrera = txtNombreCarrera.Text;
            string siglas = txtSiglasCarrera.Text;
            string area = seleccionarAreacomboBox1.Text;
            string print = siglas.ToUpper() + "(" + nombreCarrera.ToLower() + "),";
            bool registrar_si = false;
            if (txtNombreCarrera.Text.Trim() == "" || txtSiglasCarrera.Text.Trim() == "" || seleccionarAreacomboBox1.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, llena todos los campos.");
            }
            else
            {
                string[] verificar = File.ReadAllLines(Environment.CurrentDirectory + "\\Areas\\" + area + ".txt");
                if (new FileInfo(Environment.CurrentDirectory + "\\Areas\\" + area + ".txt").Length == 0)
                {
                    registrar_si = true;
                }
                else
                {
                    foreach (var item in verificar)
                    {
                        string[] elementos = item.Split(new char[] { '(', ')' });
                        string sigla = elementos[0];
                        if (siglas.ToUpper() == elementos[0])
                        {
                            MessageBox.Show("Estas siglas ya estan registradas");
                            txtSiglasCarrera.Text = null;
                        }
                        else if (nombreCarrera.ToLower() == elementos[1])
                        {
                            MessageBox.Show("Esta carrera ya esta registrada");
                            txtNombreCarrera.Text = null;
                        }
                        else
                        {
                            registrar_si = true;
                            break;
                        }
                    }
                }
                if (registrar_si == true)
                {
                    StreamWriter archivo = File.AppendText(Environment.CurrentDirectory + "\\Areas\\" + area + ".txt");
                    archivo.WriteLine(print);
                    archivo.Close();
                    txtNombreCarrera.Text = String.Empty;
                    txtSiglasCarrera.Text = String.Empty;
                    MessageBox.Show("Carrera Registrada!");
                    this.Close();
                }


            }



        }
    }
}
