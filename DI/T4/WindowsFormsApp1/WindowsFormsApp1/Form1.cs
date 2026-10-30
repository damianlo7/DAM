using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1//TODO liberar color botones.
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //Coordenadas raton

            if (sender.GetType() == typeof(Button))
            {
                Button boton = (Button)sender;
                Text = String.Format("x:{0} , y:{1}", e.X + boton.Location.X, e.Y + boton.Location.Y);
            }
            else
            {
                Text = String.Format("x:{0} , y:{1}", e.X, e.Y);
            }
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            Text = "Mouse Tester";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //KeyPreview = true;//Mejor en diseñador
            crearBotones();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                btnDer.BackColor = Color.Purple;
            }
            else if (e.Button == MouseButtons.Left)
            {
                btnIzq.BackColor = Color.CadetBlue;
            }
            else
            {
                btnDer.BackColor = Color.Red;
                btnIzq.BackColor = Color.Red;
            }
            
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                btnDer.BackColor = DefaultBackColor;
            }else if (e.Button == MouseButtons.Left)
            {
                btnIzq.BackColor = DefaultBackColor;
            }
            else
            {
                btnIzq.BackColor = DefaultBackColor;
                btnDer.BackColor = DefaultBackColor;

            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Text = "MouseTest";
            }
            else
            {
                Text = e.KeyCode.ToString();
            }
        }


        private void crearBotones()
        {
            int inicioX = 20;
            int inicioY = 30;
            int ancho = 60;
            int alto = 40;
            int separacion = 10;
            int contador = 1;

            for (int fila = 0; fila < 4; fila++)
            {
                for (int columna = 0; columna < 5; columna++)
                {
                    Button b = new Button();
                    b.Text = contador.ToString();
                    b.Size = new Size(alto, ancho);
                    b.Location = new Point(inicioX + columna * (ancho + separacion), inicioY + fila * (alto + separacion));

                    b.MouseDown += Boton_MouseDown;
                    b.MouseDown += Form1_MouseDown;
                    b.MouseUp += Boton_MouseUp;
                    b.MouseMove += Form1_MouseMove;
                    Controls.Add(b);
                    contador++;
                }
            }


        }
        private void Boton_MouseDown(object sender, MouseEventArgs e)//TODO para ti:  pasarlo a lambda
        {
            ((Button)sender).ForeColor = Color.Red;
           
        }

        private void Boton_MouseUp(object sender, MouseEventArgs e)
        {
            ((Button)sender).ForeColor = Color.Black;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Mi Aplicación",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question)== DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }


    }
}
