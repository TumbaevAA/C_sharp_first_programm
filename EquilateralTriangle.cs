using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_lab6
{
    class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(Point first, Point second, Point third) : base(first, second, third)
        {
        }

        public double lineLength()
        {
            return firstPoint.distance(this.secondPoint);
        }

        public void output()
        {
            Console.WriteLine("Triangle\n----------------------------------------------");

            Console.WriteLine("Points");
            Console.WriteLine("first: ");
            this.firstPoint.output();
            Console.WriteLine("second: ");
            this.secondPoint.output();
            Console.WriteLine("third: ");
            this.thirdPoint.output();

            Console.WriteLine("\nLine length = {0}", lineLength());

            Console.WriteLine("Perimeter = {0}, area = {1}", this.perimeter, this.area);

            Console.WriteLine("----------------------------------------------");

        }
    }
}
