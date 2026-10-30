using System;
using System.Collections.Generic;
using System.Text;

namespace ejer1
{
    internal class Planeta : Astro, ITerraformable
    {
        //private bool gaseoso;
        private int numSat;
        public bool Gaseoso { set; get; }


        public int NumSat
        {
            set
            {
                if (value < 0)
                {
                    numSat = 0;
                }
                else
                {
                    numSat = value;
                }
            }
            get
            {
                return numSat;
            }
        }

        //Inicializa lo que se pueda llamando al constructor de Astro
        public Planeta(bool gas, int nSat, string nombre, double radio) : base(nombre, radio)
        {
            this.Gaseoso = gas;
            NumSat = nSat;
        }
        public Planeta() : this(false, 0, "", 1)
        {

        }



        //hacer pruebas para revisar que funcione simplificado
        public bool esHabitable()
        {
            return !Gaseoso && Radio >= 2000 && Radio <= 8000;
        }

        public override string ToString()
        {
            return string.Format("Nombre: {0,10}su numero de satelites es: {1,4} y tiene radio:{2,5:F2}", Nombre, numSat, Radio);
        }


        public static Planeta operator ++(Planeta m1)
        {
            m1.numSat++;
            return m1;
        }


        public static Planeta operator --(Planeta r2)
        {
            if (r2.numSat > 0)
            {
                r2.numSat--;
            }
            else
            {
                Console.WriteLine("Hay 0 satelites, no se pueden restar mas");
            }

            return r2;
        }
    }
}
