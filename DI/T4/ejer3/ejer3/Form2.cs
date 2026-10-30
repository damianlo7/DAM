using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer3
{
    public partial class Form2 : Form
    {

        public Form2(string rutaImagen)
        {
            InitializeComponent();
            string[] partes = rutaImagen.Split('\\');
            try
            {
                pictureBox1.Image = Image.FromFile(rutaImagen);
                this.Size = pictureBox1.Image.Size;
            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine("La imagen no es valida");
                lblError.Text = "No se pudo cargar la imagen correctamente";

            }
            catch (IOException ex)
            {
                Console.WriteLine("Hay un error con la imagen");
                lblError.Text = "No se pudo cargar la imagen correctamente";

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex);
                lblError.Text = "No se pudo cargar la imagen correctamente";

            }


            this.Text = partes[partes.Length - 1];
        //    try
        //    {

        //    }
        ////   catch (NullReferenceException ex)
        //    {
        //        Console.WriteLine("No se pudo cargar la imagen correctamente");
        //        lblError.Text = "No se pudo cargar la imagen correctamente";

        //    }
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Size = this.Size;
        }



        private void Form2_Resize(object sender, EventArgs e)
        {
            pictureBox1.Size = this.Size;
        }

        private void seAjustaPerfectamenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void sinDeformaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

    }
}
