using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Calcular área de un Rectángulo");
            Console.WriteLine("2. Calcular área de un Triángulo");
            Console.WriteLine("3. Calcular área de un Círculo");

            int opcion = int.Parse(Console.ReadLine());

            Figura figura;

            switch (opcion)
            {
                case 1:
                    figura = new Rectangulo();
                    Console.Write("Ingrese la base del rectángulo: ");
                    ((Rectangulo)figura).Base = float.Parse(Console.ReadLine());
                    Console.Write("Ingrese la altura del rectángulo: ");
                    ((Rectangulo)figura).Altura = float.Parse(Console.ReadLine());
                    break;
                case 2:
                    figura = new Triangulo();
                    Console.Write("Ingrese la base del triángulo: ");
                    ((Triangulo)figura).Base = float.Parse(Console.ReadLine());
                    Console.Write("Ingrese la altura del triángulo: ");
                    ((Triangulo)figura).Altura = float.Parse(Console.ReadLine());
                    break;
                case 3:
                    figura = new Circulo();
                    Console.Write("Ingrese el radio del círculo: ");
                    ((Circulo)figura).Radio = float.Parse(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    return;
            }

            float area = figura.CalcularArea();
            Console.WriteLine($"El área de la figura es: {area}");
        }

    }
}
