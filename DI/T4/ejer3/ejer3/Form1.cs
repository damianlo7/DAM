using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer3
{
    public partial class Form1 : Form //TODO control excepciones. Icono. quitar un pb.
    {
        public int cont = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void btnNuevaImagen_Click(object sender, EventArgs e)
        {
            String rutaImagen = "";
            bool archivo = false;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Seleccion de imagen: ";
                openFileDialog.InitialDirectory = "D:\\2026-27\\zzCarpetaImegenesPrueba";
                openFileDialog.Filter = "imagen (*.jpg)|*.jpg|imagen (*.png)|*.png|Todos los archivos|*.*"; //Nombre que aparece | extension
                openFileDialog.ValidateNames = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rutaImagen = openFileDialog.FileName;
                    archivo = true;
                }

            }

            if (archivo)
            {
                Form2 f2 = new Form2(rutaImagen);
                if (chkModal.Checked)
                {
                    f2.ShowDialog();
                }
                else
                {
                    f2.Show();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Timer t = new Timer();
            //t.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cont++;
            int segundos = cont % 60;
            int minutos = cont / 60;
            this.Text = $"Visor de imagenes {minutos:D2}:{segundos:D2}";

        }

        private void chkModal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkModal.Checked)
            {
                chkModal.ForeColor = Color.Red;
            }
            else
            {
                chkModal.ForeColor = Color.Black;
            }

        }
    }
}
