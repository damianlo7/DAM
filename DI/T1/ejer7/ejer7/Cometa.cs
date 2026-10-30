using System;
using System.Collections.Generic;
using System.Text;

namespace ejer7
{
     class Cometa : Astro, ITerraformable
    {
        public Cometa(string nombre, double radio): base(nombre,radio) { }
        public bool esHabitable()
        {
            return false;
        }
    }
}
