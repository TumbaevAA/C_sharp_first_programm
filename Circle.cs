using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_lab6
{

    [Serializable]
    class Circle : IOInterface, ICloneable
    {
        protected Point center;
        protected double radius;

        public Point Center { get => center;}

        public Circle()
        {
        }

       public Circle(Point center, double radius)
        {
            if (center == null) throw new ArgumentNullException();
            this.center = center;
            this.radius = radius;
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
                    this.center = center;
                    this.radius = radius;
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (FormatException)
            {

                Console.WriteLine("Invalid input");
                return false;
            }
        }

        public virtual void output()
        {
            Console.WriteLine("Circle\n----------------------------------------------");

            Console.WriteLine("Center: ");
            this.center.output();

            Console.WriteLine("Radius = {0}, circumference = {1}, area = {2}", this.radius, this.circumference, this.area);

            Console.WriteLine("----------------------------------------------");

        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public double area => Math.PI * this.radius * this.radius;

        public double circumference => 2 * Math.PI * this.radius;

        public void setCenter(float x, float y)
        {
            this.center.X = x;
            this.center.Y = y;
        }
    }
}
