using System;
using System.Collections.Generic;
using System.Text;

namespace ejer10
{
    internal class MatrizException : Exception
    {
        public MatrizException()
        {
            Console.WriteLine("Hay un error");
        }
    }
}
