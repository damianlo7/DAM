using System;
using System.Collections.Generic;
using System.Text;

namespace ejer1
{
    internal abstract class Astro
    {
        private string nombre;
        private double radio;


        public string Nombre
        {
            get
            {
                return String.Format($"\"{nombre}\"");
            }
            set
            {
                nombre = value.ToUpper();
            }
        }

        public double Radio
        {
            get
            {
                return radio;
            }
            set
            {
                if (value > 0)
                {
                    radio = value;
                }
                else
                {
                    throw new ArgumentException("hay un valor no numerico");
                }

            }
        }

        protected Astro(string name, double r)
        {
            Nombre = name;
            Radio = r;
        }
        // sobrecarga
        protected Astro() : this("Tierra", 6378)
        {

        }

        public override bool Equals(object obj)
        {
            if (obj is Astro)
            {
                Astro a = (Astro)obj;
                return this.nombre == a.nombre;
            }
            if (obj is string)
            {
                string s = (string)obj;
                return this.nombre == s.ToUpper();
            }
            return false;
        }




    }
}
