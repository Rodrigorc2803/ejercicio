using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class Rectangulo : Figura
    {
        public float Base;
        public float Altura;

        public override float CalcularArea()
        {
            return Base * Altura;
        }

    }
