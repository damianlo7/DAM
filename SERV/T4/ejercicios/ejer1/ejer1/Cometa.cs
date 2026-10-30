using System;
using System.Collections.Generic;
using System.Text;

namespace ejer1
{
    internal class Cometa : Astro, ITerraformable
    {
        public Cometa(string nombre, double radio) : base(nombre, radio) { }
        bool ITerraformable.esHabitable()
        {
            return false;
        }
    }
}
