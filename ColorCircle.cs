using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_lab6
{
    class ColorCircle : Circle
    {
        private String color;

        public ColorCircle(Point center, float radius, string color) : base(center, radius)
        {
            this.color = color;
        }

        public void output()
        {
            Console.WriteLine("Circle\n----------------------------------------------");

            Console.WriteLine("Center: ");
            this.center.output();

            Console.WriteLine("Radius = {0}, circumference = {1}, area = {2}", this.radius, this.circumference, this.area);
            Console.WriteLine("Color -" + this.color);

            Console.WriteLine("----------------------------------------------");

        }
    }
}
