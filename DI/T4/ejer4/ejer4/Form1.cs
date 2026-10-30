using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ejer4 
{
    public partial class ejer4 : Form
    {
        int cont = 0;
        String titulo;
        int letras;
        public ejer4()
        {
            InitializeComponent();
            lb2.Items.Add("cadena de prueba");
            actualizarTooltip();

        }
        private void btnAnhadir_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if (tbx.Text.Trim() == "")
            {
                return;
            }
            foreach (var item in lb1.Items)
            {
                if (item.ToString() == tbx.Text)
                {
                    flag = true;
                }
            }
            if (!flag)
            {
                lb1.Items.Add(tbx.Text);
                lblElementos.Text = lb1.Items.Count.ToString();
            }

        }


        private void rbL_CheckedChanged(object sender, EventArgs e)
        {
            if (rbL1.Checked)
            {
                btnEliminar.Text = "Eliminar de 1";
            }
            else if (rbL2.Checked)
            {
                btnEliminar.Text = "Eliminar de 2";
            }
        }
        private void rbT_CheckedChanged(object sender, EventArgs e) 
        {
            RadioButton rb = (RadioButton)sender;
            btnTranspasar.Text = rb.Text;
            //if (rbT12.Checked)
            //{
            //    btnTranspasar.Text = "Transpaso 1->2";
            //}
            //else if (rbT21.Checked)
            //{
            //    btnTranspasar.Text = "Transpaso 2->1";
            //}

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (rbL1.Checked)
            {
                eliminar();
            }
            else if (rbL2.Checked)
            {
                int seleccionado = lb2.SelectedIndex;
                if (seleccionado < 0)
                {
                    Console.WriteLine("No hay ningun elemento seleccionado");
                }
                else
                {
                    lb2.Items.RemoveAt(seleccionado);
                    actualizarTooltip();
                }

                //if (lb2.SelectedIndex >= 0)
                //{
                //    lb2.Items.RemoveAt(lb2.SelectedIndex);
                //}
                //for (int i = lb2.Items.Count - 1; i >= 0; i--)//T 
                //{
                //    if (lb2.GetSelected(i))
                //    {
                //        lb2.Items.RemoveAt(i);
                //    }
                //}


            }
            lblElementos.Text = lb1.Items.Count.ToString();

        }



        private void btnTranspasar_Click(object sender, EventArgs e)
        {
            bool flag = false;
            //

            //foreach (var item in lb1.Items)
            //{
            //    if (item.ToString() == tbx.Text)
            //    {
            //        flag = true;
            //    }
            //}
            //if (!flag)
            //{
            //    lb1.Items.Add(tbx.Text);
            //    lblElementos.Text = lb1.Items.Count.ToString();
            //}

            //

            if (rbT12.Checked)
            {
                try
                {
                    for (int i = 0; i < lb1.SelectedItems.Count; i++)
                    {
                        lb2.Items.Add(lb1.SelectedItems[i]);
                    }


                    //for (int i = lb1.Items.Count - 1; i >= 0; i--)  
                    //{
                    //    if (lb1.GetSelected(i))
                    //    {
                    //        lb1.Items.RemoveAt(i);
                    //    }
                    //}
                    eliminar();
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine("No se puede enviar un campo vacio");
                }
                lblElementos.Text = lb1.Items.Count.ToString();
                actualizarTooltip();

            }
            else if (rbT21.Checked)
            {
                try
                {
                    for (int i = 0; i < lb2.SelectedItems.Count; i++)
                    {
                        if (!lb1.Items.Contains(lb2.SelectedItems[i]))
                        {
                            lb1.Items.Add(lb2.SelectedItems[i]);
                        }
                    }

                    for (int i = lb2.Items.Count - 1; i >= 0; i--)
                    {
                        if (lb2.GetSelected(i))
                        {
                            lb2.Items.RemoveAt(i);
                        }
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine("No se puede enviar un campom vacio");
                }
                lblElementos.Text = lb1.Items.Count.ToString();
                actualizarTooltip();
            }
        }


        private void lb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> seleccionado = new List<int>();
            string aux = "";

            //lblIndices.Text = $"Indices seleccionados {seleccionado[0]}";

            foreach (int item in lb1.SelectedIndices)
            {
                seleccionado.Add(item);
            }
            for (int i = 0; i < seleccionado.Count; i++)
            {
                aux += seleccionado[i];
                if (i < seleccionado.Count - 1)
                {
                    aux += ", ";
                }
            }
            lblIndices.Text = $"Indices seleccionados: {aux}";

            //lblIndices.Text = $"Indices seleccionados {lb1.SelectedIndex.ToString()}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                this.Icon = Properties.Resources.DLP_small;
                cont++;
            }
            else if (cont == 1)
            {
                this.Icon = Properties.Resources.DLP_morado;
                cont--;
            }

            letras++;

            if (letras > titulo.Length)
            {
                letras = 1;
            }
            this.Text = titulo.Substring(titulo.Length - letras);

        }

        private void ejer4_Load(object sender, EventArgs e)
        {
            titulo = this.Text;
            letras = 0;
        }

        //private void lb2_MouseEnter(object sender, EventArgs e) 
        //{
        //    toolTip1.SetToolTip(lb2, $"Elementos en la lista: {lb2.Items.Count}");
        //}

        public void eliminar()
        {
            for (int i = lb1.Items.Count - 1; i >= 0; i--)
            {
                if (lb1.GetSelected(i))
                {
                    lb1.Items.RemoveAt(i);
                }
            }
        }
        public void actualizarTooltip()
        {
            toolTip1.SetToolTip(lb2, $"Elementos en la lista: {lb2.Items.Count}");
        }

    }
}

//TODOS JUNTOS: 

//separar groupboxes V
// linea con sender v 
// sin bucle v
// no repetir codigo de eliminacion v
//Tooltip final 
