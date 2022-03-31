using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_2._0
{
    public class Square : Shape
    {


        
        public Square(double a) :base(a)
        {
            sideA = a;
        }

        public override double Perimiter()
        {

            return  sideA * 4;

        }

        public override double Area()
        {
            return sideA * sideA;
        }

    }

    
}
