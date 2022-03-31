using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_2._0
{
    public class Trapez : Shape
    {

        private double sideB;
        private double sideC;
        private double sideD;

        public Trapez(double a, double b, double c, double d) : base(a)
        {
            if (a < c)
            {
                sideC = a;
                sideA = c;
            }
            else { sideC = c; }
            sideB = b; 
            sideD = d;
        }

        public override double Perimiter()
        {
            return sideA + sideB + sideC + sideD;
        }

        public override double Area()
        {
            return  0.5 * (sideA + sideC) * HCal(SCal());
        }

        public double SCal()
        {
            double s = (sideA + sideB - sideC + sideD) / 2;

            return s;
        }

        public double HCal(double s)
        {
           double h = ((sideA - sideC)/2) * Math.Sqrt(s * (s - sideA + sideC) * (s - sideB) * (s - sideD));

            return h;
        }



    }
}
