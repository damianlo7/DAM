using System;
using System.Collections.Generic;
using System.Text;

namespace ejer9
{
    internal class NegativeRAMException: Exception
    {
        public NegativeRAMException()
        {
            Console.WriteLine("La ram debe ser mayoit o igual a 0");
        }
    }
}
