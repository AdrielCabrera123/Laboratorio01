using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Triangulo triangulo = new Triangulo
            {
                X1 = 3,
                Y1 = 2,
                X2 = 3,
                Y2 = 4,
                X3 = 5,
                Y3 = 6
            };

           
            double perimetro = triangulo.CalcularPerimetro();
            double area = triangulo.CalcularArea();

           
            Console.WriteLine($"Perímetro del triángulo: {perimetro}");
            Console.WriteLine($"Área del triángulo: {area}");

            Console.Read();
        }
    }
}
