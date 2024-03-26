using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class Circulo : Figura
    {
        public float Radio;

        public override float CalcularArea()
        {
            return (float)(Math.PI * Math.Pow(Radio, 2));
        }
    }
}

