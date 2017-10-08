using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise45
{
    class Square
    {

        private double lengthofside;

        //property
        public double SideLength

        {
            set { lengthofside = value; }
            get { return lengthofside; }
        }

        //methods
        public double GetArea()
        {
            double area = lengthofside * lengthofside;
            return area;
        }
        

        public double GetPerimeter()
        {
            double perimeter;
            perimeter = 2 * (lengthofside + lengthofside);
            return perimeter;
            }
        }
    }

