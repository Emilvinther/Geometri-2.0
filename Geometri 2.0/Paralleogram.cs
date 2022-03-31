using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_2._0
{
    public class Paralleogram : Shape
    {
        private double sideB;
        private double angle;
        public Paralleogram(double a, double b, double v) : base(a)
        {
            sideB = b;
            angle = v;
        }

        public override double Perimiter()
        {
            return (sideA + sideB) * 2;
        }

        public override double Area()
        {
            return sideA * sideB * Math.Sin(angle);
        }
    }

    
}
