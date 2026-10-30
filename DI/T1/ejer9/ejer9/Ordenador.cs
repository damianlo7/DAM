using System;
using System.Collections.Generic;
using System.Text;

namespace ejer9
{
    internal class Ordenador
    {

        //private string nombre;
        private int ram;

        public string Nombre { set; get; }
        //{
        //    set
        //    {
        //        this.nombre = value;
        //    }
        //    get
        //    {
        //        return this.nombre;
        //    }
        //}
        public int Ram
        {
            set
            {
                if (value >= 0)
                {
                    this.ram = value;

                }
                else
                {
                    throw new NegativeRAMException();
                }
            }
            get
            {
                return this.ram;
            }


        }

        public static bool compruebaIP(string cadenaIP)
        {

            string[] partes;

            if (cadenaIP == null || cadenaIP == "")
            {
                return false;
            }
            else
            {
                partes = cadenaIP.Split('.');

                if (partes.Length != 4)
                {
                    return false;

                }
            }

            //comprobar que estan entre 0 y 255
            foreach (string parte in partes)
            {
                if (!int.TryParse(parte.Trim(), out int parteN))
                {
                    return false;
                }

                if (parteN < 0 || parteN > 255)
                {
                    return false;
                }

                //return parteN <= 255 && parteN >= 0; //NO SE PUEDE HACER DENTRO DEL BUCLE, ROMPE EN LA PRIMERA VUELTA
            }
            return true;
        }
    }



}