using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //string nTitulo = textBox1.Text;

            DialogResult a;
            a = MessageBox.Show("Deseas ponerlo como titulo del formulario","aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (a == DialogResult.Yes)
            {
                this.Text = textBox1.Text;
            }
        }
    }
}
