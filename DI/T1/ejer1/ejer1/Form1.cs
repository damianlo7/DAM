using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer1
{
    public partial class Form1 : Form
    {

        //string txb1;
        //string txb2;

       


        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //txb1 = textBox1.Text;
            //vlr1 = Convert.ToInt32(txb1);

            //txb2 = textBox2.Text;
            //vlr2 = Convert.ToInt32(txb2);
            int vlr1;
            int vlr2;
            int total;
            bool flag = false;
            try
                {
                    vlr1 = Convert.ToInt32(textBox1.Text);
                    vlr2 = Convert.ToInt32(textBox2.Text);

                    if (vlr1 >= 0 && vlr2 >= 0)
                    {
                        total = vlr1 + vlr2;
                        lblres.Text = "=  " + total;
                    }
                    else
                    {
                        lblres.Text = "=  Esta calculadora no permite numeros negativos";
                    }
                   // flag = false;
                }
                catch (FormatException)
                {
                    flag = true;
                    lblres.Text = "=  Tienes algun valor incorrecto";
                    Console.WriteLine("dato invalido");
                    //return;
                }
            }
            

        }
    }

