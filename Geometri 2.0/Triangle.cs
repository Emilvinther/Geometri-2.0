using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_2._0
{
    public class Triangle : Shape
    {

        private double sideB;

        public Triangle(double a, double b) : base(a)
        {
            sideB = b;
        }

        public override double Perimiter()
        {
            return sideA + sideB + CCal();
        }

        public override double Area()
        {
            return 0.5 * sideA * sideB;
        }

        public double CCal()
        {
            double c = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
            return c;
        }
    }
}
