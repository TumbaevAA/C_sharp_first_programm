using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_lab6
{
    class Point
    {
        private double x;
        private double y;

        public Point()
        {
        }

        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public double getX()
        {
            return x;
        }

        public double getY()
        {
            return x;
        }

        public bool input()
        {
            try
            { 
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());

                this.x = x;
                this.y = y;
                return true;
            }
            catch (FormatException)
            {
                return false;
            }   
        }
        public void output()
        {
            Console.WriteLine("x = {0}, y = {1}", x, y);
        }
        public double distance(Point end)
        {
            if (end == null) return - 1;

            double d1 = end.x - this.x, d2 = end.y - this.y;
            return Math.Sqrt(d1 * d1 + d2 * d2);
        }
    }
}
