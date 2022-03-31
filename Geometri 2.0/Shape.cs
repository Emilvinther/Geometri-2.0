using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_2._0
{
    public abstract class Shape
    {

        protected double sideA;


        public Shape(double a)
        {
            sideA = a;
        }

        public abstract double Perimiter();
        

        public abstract double Area();
        
 

    }

}

