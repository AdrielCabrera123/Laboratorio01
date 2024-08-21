using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio01
{
    public class Triangulo
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }
        public double X3 { get; set; }
        public double Y3 { get; set; }

        private double CalcularDistancia(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public double CalcularPerimetro()
        {
            double a = CalcularDistancia(X1, Y1, X2, Y2);
            double b = CalcularDistancia(X2, Y2, X3, Y3);
            double c = CalcularDistancia(X3, Y3, X1, Y1);

            return a + b + c;
        }

        public double CalcularArea()
        {
            double a = CalcularDistancia(X1, Y1, X2, Y2);
            double b = CalcularDistancia(X2, Y2, X3, Y3);
            double c = CalcularDistancia(X3, Y3, X1, Y1);

            double s = (a + b + c) / 2;

            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }
    }
}