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
            Point center1 = new Point(0, 0);
            Circle c = new Circle(center1, 3);

            Circle cClone = (Circle)c.Clone();
            c.output();

            cClone.output();
            cClone.setCenter(1, 1);
            c.output();

            Point point1 = new Point(0, 0), point2 = new Point(0, 1), point3 = new Point(1, 1), point4 = new Point(1, 0);

            Square s = new Square(point1, point2, point3, point4, "new square");
            s.output();
            Console.WriteLine(s.getDescription() + "\n\n");
            
            Point center = new Point(0, 0), p1 = new Point(0.5f, 0.86602540378f), p2 = new Point(1,0);

            EquilateralTriangle eT = new EquilateralTriangle(center, p1, p2);

            eT.output();

            ColorCircle colorCircle = new ColorCircle(center, 4, "white");
            colorCircle.output();

            Console.ReadLine();
        }
    }
}
