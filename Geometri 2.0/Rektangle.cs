using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometri_2;

namespace Geometri_2._0
{
    public class Rektangle : Shape
    {

        private double sideB;

        

        public Rektangle(double sideA, double b) : base(sideA)
        {
            sideB = b;
        }


        public override double Perimiter()
        {
            return 2 * (sideA + sideB);
        }

        public override double Area()
        {
            return sideA * sideB;
        }

    }

    
}
