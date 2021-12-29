using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_lab6
{
    class Circle
    {
        Point center;
        double radius;

        public Circle()
        {
        }

        public Point getCenter()
        {
            return center;
        }

        public double getRadius()
        {
            return radius;
        }

        public bool init(Point center, double radius)
        {
            if(radius < 0 || center == null) return false;

            this.radius = radius;
            this.center = center;

            return true;
        }

        public bool input()
        {
            this.center = new Point();
            try
            {
                double radius = Convert.ToDouble(Console.ReadLine());

                Point center = new Point();

                if (center.input())
                {
                    return this.init(center, radius);
                }
                else
                {
                    return false;
                }

            }
            catch (FormatException)
            {
                return false;
            }

        }

        public void output()
        {
            Console.WriteLine("Circle\n----------------------------------------------");

            Console.WriteLine("Center: ");
            this.center.output();

            Console.WriteLine("Radius = {0}, circumference = {1}, area = {2}", this.radius, this.circumference(), this.area());

            Console.WriteLine("----------------------------------------------");

        }

        public double area()
        {
            return Math.PI * this.radius * this.radius;
        }

        public double circumference()
        {
            return 2 * Math.PI * this.radius;
        }
    }
}
