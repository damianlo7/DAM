//#define PRUEBA
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer3
{
    public partial class Form1 : Form
    {
        int credito;
        Random random = new Random();


        public Form1()
        {
            InitializeComponent();
            lblCredito.Text = "50";
            credito = Convert.ToInt32(lblCredito.Text);


        }


        private void btnJugar_Click(object sender, EventArgs e)
        {

            //Prueba generando randoms sin la funcion de la tupla
            //Random random = new Random();
            //txb1.Text = Convert.ToString(random.Next(1, 8));
            //txb2.Text = Convert.ToString(random.Next(1, 8));
            //txb3.Text = Convert.ToString(random.Next(1, 8));

            lblRes.Text = ""; //resetear el texto de cuando ganas en cada tirada

            //   lblCredito.Text =    credito.ToString();




            if (credito < 2)
            {
                lblRes.Text = "No tienes suficientes creditos para jugar";
            }
            else
            {
                credito -= 2;
                //Generar numeros aleatorios mediante la tupla, el resultado lo guardamos en la variable y luego se elige el valor mediante Item*

                var resultados = genAleatorios(1, 8);
                txb1.Text = resultados.Item1.ToString();
                txb2.Text = Convert.ToString(resultados.Item2); //TODO: se hace igual que al de arriba, esta forma no es correcta
                txb3.Text = Convert.ToString(resultados.Item3);
                if (txb1.Text == txb2.Text && txb2.Text == txb3.Text)
                {
                    credito += 20;
                    //  lblCredito.Text = credito.ToString();
                    lblRes.Text = "!Premio, ganaste 20 creditos";
                }
                else if (txb1.Text == txb2.Text || txb1.Text == txb3.Text || txb2.Text == txb3.Text)
                {
#if PRUEBA
                    lblRes.Text = "TOCA RESTAR";
                    credito -= 5;
                   // lblCredito.Text = credito.ToString();
#else
                    {
                        credito += 5;
                        lblRes.Text = "!Premio, ganaste 5 creditos";
                    }
#endif
                }
                else
                {
                    lblRes.Text = "No hay premio!";
                }
                lblCredito.Text = credito.ToString();


            }
        }

        private void btnAnhadirC_Click(object sender, EventArgs e)
        {
            credito += 10;
            lblCredito.Text = credito.ToString();
        }



        //Funcion con tupla para generar numeros aleatorios
        private (int, int, int) genAleatorios(int min, int max)
        {

            return (random.Next(min, max), random.Next(min, max), random.Next(min, max));
        }
    }
}
