using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer2
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quieres salir?", "ejer2", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cambioColor()

        {
            //int r = int.Parse(txbR.Text);
            //int g = int.Parse(txbG.Text);
            //int b = int.Parse(txbB.Text);
            if (int.TryParse(txbR.Text, out int r) && int.TryParse(txbG.Text, out int g) && int.TryParse(txbB.Text, out int b))
            {
                if (r <= 255 && r >= 0 && g <= 255 && g >= 0 && b <= 255 && b >= 0)
                {
                    this.BackColor = Color.FromArgb(r, g, b);
                    lblError.Text = "";

                }
                else
                {
                    lblError.Text = "Algun numero no esta dentro del rango";
                    Console.WriteLine("Algun numero no esta dentro del rango");
                }
            }
            else
            {
                lblError.Text = "Algun numero no esta dentro del rango";
                Console.WriteLine("Debes introducir un numero");
            }



        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            cambioColor();
        }


        private void btnImagen_Click(object sender, EventArgs e)
        {
            //pictureBox.ImageLocation = tbRutaImagen.Text;

            if (tbRutaImagen.Text == null || tbRutaImagen.Text.Trim() == "")
            {
                lblError.Text = "La ruta no puede estar vacia";
            }
            else 
            {
                try
                {
                    pictureBox.Image = new Bitmap(tbRutaImagen.Text);
                    lblError.Text = "";
                }
                catch (ArgumentException error)
                {
                    Console.WriteLine("Hay un argumento no valido: " + error);
                    lblError.Text = "La imagen o la ruta no es valida";
                }
                catch (FileNotFoundException error)
                {
                    Console.WriteLine("No se encontro la imagen: " + error);
                    lblError.Text = "No se encontro la imagen";
                }


            }
        }

        private void colores_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnColor;
        }
        private void imagen_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnImagen;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    if (item.Tag.ToString() == "color")
                    {
                        item.Text = "0";
                    }
                    else if (item.Tag.ToString() == "imagen")
                    {
                        item.Text = "";
                        pictureBox.Image = null;
                    }


                }
                else if (item.GetType() == typeof(Label))
                {
                    if ((string)item.Tag == "lblError")
                    {
                        item.Text = "";
                    }
                }

            }
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Button))
            {
                Button b = (Button)sender;

                b.BackColor = Color.Red;



            }
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {

            if (sender.GetType() == typeof(Button))
            {

                Button b = (Button)sender;
                if (b.Tag.ToString() == "salir")
                {
                    b.BackColor = Color.Red;

                }
                else if (b.Tag.ToString() == "reset")// Con el uso del Tag se simplifica
                {
                    b.BackColor = Color.FromArgb(255, 128, 0);

                }
                else
                {
                    b.BackColor = Color.FromArgb(128, 255, 128);

                }
            }
        }
    }
}
// D:\2026-27\DI\Recursos\DLP_small.ico