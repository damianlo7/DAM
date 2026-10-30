using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ejer7 //Falta sobreescribir equals
{
    abstract class Astro
    {
        private string nombre;
        private double radio;


        public string Nombre
        {
            get
            {
                return $"\"{nombre}\"";
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
                    throw new ArgumentException();
                }

            }
        }

        protected Astro(string name, double radio)
        {
            Nombre = name;
            Radio = radio;
        }
        // sobrecarga
        protected Astro() : this("Tierra", 6378)
        {

        }

        //falta : Sobreescribe equals de forma que se considera que dos astros son iguales si
        //son iguales sus nombres.Además si el parámetro es String y coincide con el
        //nombnre también devolverá true


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

        //public override bool Equals(object? obj)
        //{
        //    return base.Equals(obj);
        //}


    }
}
