using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            String[] teclado = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "*", "0", "#" };

            int cont = 0;
            for (int filas = 0; filas < 4; filas++)
            {
                for (int columnas = 0; columnas < 3; columnas++)
                {
                    Button b = new Button();

                    for (int i = 0; i < teclado.Length; i++)
                    {
                        b.SetBounds(60 + columnas * 5 * 10, (45 + filas * 40 + 10), 40, 40);
                        b.Text = teclado[cont].ToString();
                        this.Controls.Add(b);


                    }
                    cont++;


                    b.MouseLeave += salirDelBoton;
                    b.MouseEnter += pasarPorBoton;

                    b.Click += pulsarBoton;
                }
            }

            Button reset = new Button();
            reset.SetBounds(60,240,40,20);
            reset.Text = "reset";
            reset.BackColor = Color.Azure;
            this.Controls.Add (reset);
            reset.Click += resetT;

        }

        private void pulsarBoton(object sender, EventArgs e)
        {
            Button b = new Button();
            b = (Button)sender;

            b.BackColor = Color.Orange;
            tb.Text += b.Text;

        }

        private void pasarPorBoton(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.BackColor != Color.Orange)
            {
                b.BackColor = Color.Green;
            }

        }
        private void salirDelBoton(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.BackColor != Color.Orange)
            {
                b.BackColor = DefaultBackColor;
            }
        }

        private void resetT(object sender, EventArgs e)
        {
            tb.Text = "";
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(Button))
                {
                    if (c.BackColor == Color.Orange)
                    {
                        c.BackColor = DefaultBackColor;
                    }
                }

            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta es una aplicacion para DI \nAutor: Damián López", "Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}


