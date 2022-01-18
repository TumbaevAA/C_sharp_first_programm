using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Point center = new Point(0, 0), p1 = new Point(0.5f, 0.86602540378f), p2 = new Point(1,0);

            EquilateralTriangle eT = new EquilateralTriangle(center, p1, p2);

            eT.output();

            ColorCircle colorCircle = new ColorCircle(center, 4, "white");
            colorCircle.output();

            Console.ReadLine();
        }
    }
}
